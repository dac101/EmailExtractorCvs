using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using CsvHelper;

namespace AlgothrimDevelopment
{
    public class Client
    {     
        public delegate void SortingFunction(IComparable[] arrayComparables);
        static BackgroundWorker bw = new BackgroundWorker();

        static void Main(string[] args)
        {
            #region 

            // SortAlgorithm sortAlgorithm = new SortAlgorithm();
            //string header = String.Format("{0,-12}{1,8}{2,12}{3,14}/n",
            //      "N", "Insertion", "Selection", "Shell Sort");

            //Console.WriteLine(header);
            //GetValue(sortAlgorithm, GenerateParitalySorted);
            //inSortAlgorithm.Show(GenerateParitalySorted(10));
            // sortAlgorithm.Show(NonUniformDistributionsGaussian(10,10));

            #endregion


            #region 

            //string path =
            //    "C:/Users/dacorie/Documents/Visual Studio 2013/Projects/AlgothrimDevelopment/AlgothrimDevelopment/Data/test.csv";
            //var lines = File.ReadAllLines(path).Select(a => a.Split(';'));
            ////EmailExtractor.GetEmailFromCsvFiles(path);
            //EmailExtractor.ProcessDirectory(
            //    "C:/Users/dacorie/Documents/Visual Studio 2013/Projects/AlgothrimDevelopment/AlgothrimDevelopment/Data");
            //Console.ReadLine();

            #endregion

            // BitConversion bitConversion = new BitConversion();
          
            //var turingFunctions = new TuringFunctions();
            //var temp = new List<string>();
            //temp.Add("1");
            //temp.Add("1");// reads it has 110 
            //temp.Add("1");

            

            ////var unaryConversationValue = bitConversion.BinaryToUnary(temp);
            ////var reserveString = bitConversion.ReverseListRegisterFunctionList(temp);
            ////var getlastTwoString = turingFunctions.getLastTwoValue(reserveString);
            ////var getlastTwoStringUnary = bitConversion.BinaryToUnary(getlastTwoString);
            ////var multiplicationbinary = turingFunctions.binaryMultipication(unaryConversationValue, getlastTwoStringUnary);
            ////Console.WriteLine(string.Join("", multiplicationbinary));

            ////Console.WriteLine(bitConversion.BinaryToUnary(temp).Count + " ");
            ////Console.ReadLine();

           
            

        }

     
    }
}
