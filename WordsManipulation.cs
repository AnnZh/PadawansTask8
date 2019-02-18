using System.Text;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            
            if (text == null) throw new ArgumentNullException();
            if (text == "") throw new ArgumentException();

            var res = Regex.Matches(text, "[a-zA-Z]+");
            List<string> resList = new List<string>();
            int c = 0;

            for (int i = 0; i < res.Count; i++)
            {
                if (res[i].Value == "") continue;
                if (!resList.Contains(res[i].Value))
                    resList.Add(res[i].Value);
                else resList.Add("");
            }


            string str = text;

            for (int i = 0; i < resList.Count; i++)
            {
                str = str.Remove(res[i].Index + c, res[i].Value.Length);
                str = str.Insert(res[i].Index + c, resList[i]);
                c += resList[i].Length - res[i].Value.Length;
            }

            text = str;


        }
    }
}