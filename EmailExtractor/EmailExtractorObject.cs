using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using CsvHelper;
using EntityFramework.BulkInsert.Extensions;

namespace EmailExtractor
{
    public class EmailExtractorObject
    {
        private void UpdateRichTextBox(string message)
        {
            RichText.AppendText(message);
        }
        public RichTextBox RichText { get; set; }
        public  List<string> GetEmailFromCsvFiles(string path)
        {
            var textReader = new StreamReader(path);
            var csv = new CsvReader(textReader);
            csv.Configuration.RegisterClassMap<EmailMap>();
            var emails = new List<string>();
            var emailContext = new EmailContext();
            var massContacts = new List<MassPromotionContact>();
            while (csv.Read())
            {
                try
                {
                    if (csv.GetField("email") != null || csv.GetField("EMAIL") != null)
                    {
                        if (!String.IsNullOrEmpty(csv.GetRecord<Email>().email))
                        {
                            massContacts.Add(new MassPromotionContact{email =csv.GetRecord<Email>().email.ToLower() });
                            RichText.AppendText(csv.GetRecord<Email>().email.ToLower() + "\n");                                                   
                        }
                    }
                    emailContext.SaveChanges();

                }
                catch (CsvMissingFieldException e)
                {
                    break;
                }

            }
             emailContext.BulkInsert(massContacts);
            return emails;
        }

        // Process all files in the directory passed in, recurse on any directories  
        // that are found, and process the files they contain. 
        public  void ProcessDirectory(string targetDirectory)
        {
            // Process the list of files found in the directory. 
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                if (fileName.Contains("csv"))
                {
                    GetEmailFromCsvFiles(fileName);
             
                }
            }

            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);

        }

        // Insert logic for processing found files here. 
        public static void ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", path);
        }
    }

}