using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UBSStringprocessor
{
    class WordCounter
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input the string");

            //We are taking the input from the Console.
            string inputStr = Console.ReadLine();

            if (!String.IsNullOrEmpty(inputStr))
            {
                //convert string into array of words
                string[] source = inputStr.Split(new char[] { '.', ';', ':', ',', '!', ' ','\'' }, StringSplitOptions.RemoveEmptyEntries);

                //count the word using LINQ by grouping them together
                var resultDictionary = from word in source
                                       group word by word.ToLower()
                                           into grp
                                           select new { Word = grp.Key, Count = grp.Count() };

                Console.WriteLine("Output");
                //print each occurence of the word from the sentence
                resultDictionary.ToList().ForEach(x => Console.WriteLine("Word: {0}     Count: {1}", x.Word, x.Count));

                //keep the console window open
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("String is empty or null.");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
               
            }
             
        }
    }
}
