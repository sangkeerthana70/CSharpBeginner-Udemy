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

            if (sentence.Length < maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                //summarize the sentence using substring method()
                //sentence.Substring(0, maxLength);//this might omit some words from sentence

                //split sentence into words using space as a delimiter
                var words = sentence.Split(' ');//creates a string array of words
                var totalCharacters = 0;
                var summaryWords = new List<string>();//stores words dynamically as the summary is created

                foreach(var word in words)//loop over the words
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;//get the length of each word and add it to the totalCharacter variable. +1 indicates the space after each word.
                    
                    if (totalCharacters > maxLength)
                        break;//break out of loop if totalCharacters exceeds 20.
                }
                var summary = String.Join(" ", summaryWords) + "...";//join with space as a delimiter
                Console.WriteLine(summary);

            }
        }
    }
}
