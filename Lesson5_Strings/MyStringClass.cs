using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_Strings
{
    internal class MyStringClass
    {
        static char[] chForSplit = { ' ', '!', '.', '!', '?', ',' };

        static Dictionary<int, string> dictionary;
        public MyStringClass() { }

        public static string GetMaxNumDigits(string str)
        {
            var numbersList = new List<int>();
            dictionary = new Dictionary<int, string>();

            var strArray = str.Split(chForSplit);
            for (int i = 0; i < strArray.Length; i++)
            {
                var count = 0;
                var chars = strArray[i].ToCharArray();
                for (int j = 0; j < chars.Length; j++)
                {
                    if (Char.IsDigit(chars[j]))
                    {
                        count++;
                    }
                }
                if (count > 0)
                {

                    if (dictionary.ContainsKey(count))
                    {
                        break;
                    }
                    numbersList.Add(count);
                    dictionary.Add(count, strArray[i]);
                }
            }
            var maxVal = numbersList.Max();

            var isValue = dictionary.TryGetValue(maxVal, out var result);
            if (isValue) { return result; }
            return "null";

        }
        public static string GetLongestWord(string str)
        {
            var numbersList = new List<int>();
            dictionary = new Dictionary<int, string>();
            var strArray = str.Split(chForSplit);
            for (int i = 0; i < strArray.Length; i++)
            {
                var count = 0;
                var chars = strArray[i].ToCharArray();
                for (int j = 0; j < chars.Length; j++)
                {
                    count++;
                }
                numbersList.Add(count);
                dictionary[count] = strArray[i];
            }
            var maxVal = numbersList.Max();
            var isValue = dictionary.TryGetValue(maxVal, out var result);
            if (isValue) { return result; }
            return "null";

        }
        public static int GetNumMeetsWord(string text, string word)
        {
            int count = 0;
            var strArray = text.Split(chForSplit);
            for (int i = 0; i < strArray.Length - 1; i++)
            {
                if (strArray[i] == word)
                {
                    count++;
                }
            }
            return count;
        }
        public static string ChangeDigitWithWord(string text)
        {
            string[] newArray = null;
            var strArray = text.Split(" ");
            for (int i = 0; i < strArray.Length; i++)
            {
                var chars = strArray[i].ToCharArray();
                newArray = new string[strArray[i].Length];
                for (int j = 0; j < chars.Length; j++)
                {
                    if (Char.IsDigit(chars[j]))
                    {
                        newArray[j] = chars[j] switch
                        {
                            '0' => "'ноль'",
                            '1' => "'один'",
                            '2' => "'два'",
                            '3' => "'три'",
                            '4' => "'четыре'",
                            '5' => "'пять'",
                            '6' => "'шесть'",
                            '7' => "'семь'",
                            '8' => "'восемь'",
                            '9' => "'девять'"
                        };
                    }
                    else
                    {
                        newArray[j] = chars[j].ToString();
                    }
                }
                strArray[i] = String.Join("", newArray);
            }
            text = String.Join(" ", strArray);
            return text;
        }
        public static List<string> ShowQuestionSentences(string text)
        {
            var strArray = GetArrayStr(text);
            var newArray = new List<string>();

            for (int i = 0; i < strArray.Count; i++)
            {
                if ((strArray[i].Contains('?')))
                {
                    newArray.Add(strArray[i]);
                }
            }
            if (newArray.Count > 0) { return newArray; };
            newArray.Add("null");

            return newArray;
        }
        public static List<string> ShowPositSentence(string text)
        {
            var strArray = GetArrayStr(text);
            var newArray = new List<string>();

            for (int i = 0; i < strArray.Count; i++)
            {
                if ((strArray[i].Contains('!')))
                {
                    newArray.Add(strArray[i]);
                }
            }
            if (newArray.Count > 0) { return newArray; };
            newArray.Add("null");

            return newArray;
        }
        public static List<string> ShowSentencesWithoutCommas(string text)
        {
            var strArray = GetArrayStr(text);
            var newArray = new List<string>();

            for (int i = 0; i < strArray.Count; i++)
            {
                if (!(strArray[i].Contains(',')))
                {
                    newArray.Add(strArray[i]);
                }
            }
            if (newArray.Count > 0) { return newArray; };
            newArray.Add("null");

            return newArray;
        }
        static List<string> GetArrayStr(string text)
        {
            int result = 0;
            var chars = new char[] { '!', '?', '.' };
            var count = 0;
            var isEnd = false;
            var strArray = new List<string>();
            var lastIndex = text.LastIndexOfAny(chars);
            if (lastIndex > 0)
            {
                while (!isEnd)
                {
                    int index = text.IndexOfAny(chars, count);
                    if (count < lastIndex)
                    {
                        string strOnTime = text.Substring(count, index + 1 - count);
                        strArray.Add(strOnTime);
                        count = ++index;
                    }
                    else
                    {
                        isEnd = true;
                    }

                }
            }
            return strArray;
        }
        public static List<string> GetWordsWithTheSameLetters(string text)
        {
            var textNew = text.ToLower();
            var numbersList = new List<string>();

            var strArray = textNew.Split(chForSplit);
            for (int i = 0; i < strArray.Length; i++)
            {
                var chars = strArray[i].ToCharArray();

                if (chars.Length == 1 || chars.Length == 0)
                {
                    continue;
                }

                if (chars[0] == chars[chars.Length - 1])
                {
                    numbersList.Add(strArray[i]);
                }
            }

            return numbersList;
        }
    }
}
