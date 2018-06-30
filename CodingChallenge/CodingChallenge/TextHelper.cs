using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingChallenge
{
    class TextHelper
    {
        public static bool CheckRepeatingChars(List<string> list)
        {
            foreach (string word in list)
            {
                if (word.ToCharArray().Distinct().Count() != 5)
                {
                    return true;
                }
            }
            return false;
        }

        //Works but Unused for now. Almost added in automated error handling for the files.
        public static List<string> RemoveRepeatingChars(List<string> list)
        {
            string newWord = "";
            List<string> newList = new List<string>();
            foreach (string word in list)
            {
                var distinctChars = word.ToArray().Distinct();

                foreach (char item in distinctChars)
                {
                    newWord += item;
                }
                newList.Add(newWord);
                newWord = String.Empty;
            }
            
            return newList;
        }

        public static List<string> ConvertToList(string textContents)
        {
            textContents = Regex.Replace(textContents, @"[^0-9a-zA-Z:,]+", String.Empty).ToUpper();
            return textContents.TrimEnd(',').Split(',').ToList();
        }
        

    }
}
