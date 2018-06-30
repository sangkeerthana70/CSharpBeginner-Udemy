using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarising_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really long text";
            const int maxLength = 20;

            if (sentence.Length = maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                //summarize the sentence using substring method()
                sentence.Substring(0, maxLength);//this might omit some words from sentence
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach(var word in words)
                {
                    totalCharacters += word.Length;
                    if (totalCharacters > maxLength)
                        break;
                }

            }
        }
    }
}
