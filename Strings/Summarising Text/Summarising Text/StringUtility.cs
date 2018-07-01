using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summarising_Text
{
    //public access modifier
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;

            var words = text.Split(' ');//creates a string array of words
            var totalCharacters = 0;
            var summaryWords = new List<string>();//stores words dynamically as the summary is created

            foreach (var word in words)//loop over the words
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;//get the length of each word and add it to the totalCharacter variable. +1 indicates the space after each word.

                if (totalCharacters > maxLength)
                    break;//break out of loop if totalCharacters exceeds 20.
            }
            return String.Join(" ", summaryWords) + "...";
        }

    }
}
