using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Encryption
{
    public class Caesar
    {
        /// <summary>
        /// Получает указанный алфавита.
        /// </summary>
        /// <param name="Language">Алфавит.</param>
        /// <returns></returns>
        public static List<Char> GetAlphabet(Alphabet Alphabet)
        {
            switch (Alphabet)
            {
                case Alphabet.Latin:
                    return new List<Char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

                case Alphabet.Cyrillic:
                    return new List<Char>() { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я' };

                default:
                    throw new Exception("Данный алфавит отсутствует");
            }
        }

        /// <summary>
        /// Шифрование текста.
        /// </summary>
        /// <param name="Text">Данные, требуемые шифровки.</param>
        /// <param name="Key">Ключ</param>
        /// <returns></returns>
        public static String Encrypt(String Text, Int32 Key)
        {
            String Result = "", Letter = "";
            List<Char> Alphabet = Caesar.GetAlphabet(Text.GetAlphabet());

            for (int i = 0; i < Text.Length; i++)
            {
                if (Regex.IsMatch(Text[i].ToString(), "[А-Яа-я]|[A-Za-z]"))
                {
                    for (int j = 0; j < Alphabet.Count; j++)
                    {
                        if (Text[i].ToString().ToUpper() == Alphabet[j].ToString())
                        {
                            Letter = ((j + Key) >= Alphabet.Count)
                                ? Alphabet[(j + Key) - Alphabet.Count].ToString()
                                : Alphabet[j + Key].ToString();
                        }
                    }
                }
                else { Letter = Text[i].ToString(); }
                Result += Letter;
            }

            return Result;
        }

        /// <summary>
        /// Дешифрование текста.
        /// </summary>
        /// <param name="Text">Данные, требуемые дешифровки.</param>
        /// <param name="Key">Ключ</param>
        /// <returns></returns>
        public static String Decrypt(String Text, Int32 Key)
        {
            return Caesar.Encrypt(Text, -Key);
        }
    }
}
