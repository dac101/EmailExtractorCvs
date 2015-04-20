using System;
using CsvHelper.Configuration;

namespace EmailExtractor
{
    public class Email
    {
        public String email { get; set; }
    
    }

    public class EmailMap : CsvClassMap<Email>
    {
        public override void CreateMap()
        {
            Map(m => m.email);
        }
    }
}
