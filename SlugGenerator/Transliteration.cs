using System.Collections.Generic;
using System.Linq;

//http://usanov.net/748-transliteraciya-rus-2-lat-na-c
namespace SlugGenerator
{
    public static class Transliteration
    {
        private static readonly Dictionary<string, string> Iso = new Dictionary<string, string>();

        public static string Front(string text)
        {
            return Iso.Aggregate(text, (current, key) => current.Replace(key.Key, key.Value));
        }

        static Transliteration()
        {
            Iso.Add("Є", "YE");
            Iso.Add("І", "I");
            Iso.Add("Ѓ", "G");
            Iso.Add("і", "i");
            Iso.Add("№", "#");
            Iso.Add("є", "ye");
            Iso.Add("ѓ", "g");
            Iso.Add("А", "A");
            Iso.Add("Б", "B");
            Iso.Add("В", "V");
            Iso.Add("Г", "G");
            Iso.Add("Д", "D");
            Iso.Add("Е", "E");
            Iso.Add("Ё", "YO");
            Iso.Add("Ж", "ZH");
            Iso.Add("З", "Z");
            Iso.Add("И", "I");
            Iso.Add("Й", "J");
            Iso.Add("К", "K");
            Iso.Add("Л", "L");
            Iso.Add("М", "M");
            Iso.Add("Н", "N");
            Iso.Add("О", "O");
            Iso.Add("П", "P");
            Iso.Add("Р", "R");
            Iso.Add("С", "S");
            Iso.Add("Т", "T");
            Iso.Add("У", "U");
            Iso.Add("Ф", "F");
            Iso.Add("Х", "X");
            Iso.Add("Ц", "C");
            Iso.Add("Ч", "CH");
            Iso.Add("Ш", "SH");
            Iso.Add("Щ", "SHH");
            Iso.Add("Ъ", "'");
            Iso.Add("Ы", "Y");
            Iso.Add("Ь", "");
            Iso.Add("Э", "E");
            Iso.Add("Ю", "YU");
            Iso.Add("Я", "YA");
            Iso.Add("а", "a");
            Iso.Add("б", "b");
            Iso.Add("в", "v");
            Iso.Add("г", "g");
            Iso.Add("д", "d");
            Iso.Add("е", "e");
            Iso.Add("ё", "yo");
            Iso.Add("ж", "zh");
            Iso.Add("з", "z");
            Iso.Add("и", "i");
            Iso.Add("й", "j");
            Iso.Add("к", "k");
            Iso.Add("л", "l");
            Iso.Add("м", "m");
            Iso.Add("н", "n");
            Iso.Add("о", "o");
            Iso.Add("п", "p");
            Iso.Add("р", "r");
            Iso.Add("с", "s");
            Iso.Add("т", "t");
            Iso.Add("у", "u");
            Iso.Add("ф", "f");
            Iso.Add("х", "x");
            Iso.Add("ц", "c");
            Iso.Add("ч", "ch");
            Iso.Add("ш", "sh");
            Iso.Add("щ", "shh");
            Iso.Add("ъ", "");
            Iso.Add("ы", "y");
            Iso.Add("ь", "");
            Iso.Add("э", "e");
            Iso.Add("ю", "yu");
            Iso.Add("я", "ya");
            Iso.Add("«", "");
            Iso.Add("»", "");
            Iso.Add("—", "-");
        }
    }
}
