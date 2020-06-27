using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Encryption
{
    public static class StringExpansion
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static Boolean IsCirillic(this String Text)
        {
            if (Regex.IsMatch(Text, "[^a-zA-Z]+") && !Regex.IsMatch(Text, "[a-zA-Z]+"))
                return true;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static Boolean IsLatin(this String Text)
        {
            if (Regex.IsMatch(Text, "[^а-яА-Я|ё]+") && !Regex.IsMatch(Text, "[а-яА-Я|ё]+"))
                return true;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static Alphabet GetAlphabet(this String Text)
        {
            if (Text.IsLatin())
                return Alphabet.Latin;

            if (Text.IsCirillic())
                return Alphabet.Cyrillic;

            else return Alphabet.Any;
        }
    }
}