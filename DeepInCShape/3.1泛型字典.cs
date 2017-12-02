using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DeepInCShape
{
    public class 泛型字典
    {
        //public static void Main(string[] args)
        //{
        //    string text = @"Do you like green eggs and ham?
        //                    I do not like them,Sam-I-am.
        //                    I do not like green eggs and ham.";

        //    Dictionary<string, int> dic = CountWords(text);
        //    foreach (KeyValuePair<string,int> entry in dic)
        //    {
        //        string word = entry.Key;
        //        int count = entry.Value;
        //        Console.WriteLine(word + "---" + count);
        //    }
        //    Console.ReadKey();
        //}

        public static Dictionary<string, int> CountWords(string text)
        {
            Dictionary<string,int> frequencies = new Dictionary<string, int>();

            string[] words = Regex.Split(text, @"\W+");//将文本分解成单词

            foreach (var word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }            
            }
            return frequencies;
        } 

    }
}
