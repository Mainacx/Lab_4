
using System.Collections.Generic;
using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
namespace Logic_Lib
{
    public class Logic
    {
        static Dictionary<int, string> Text_Dict = new Dictionary<int, string>();
        public static string[] Load_Dict()
        {
            string path1 = "1.txt";
            string path2 = "2.txt";
            string path3 = "3.txt";
            string path4 = "4.txt";

            var search_Encoding = Encoding.GetEncoding("UTF-8");

            string[] paths = { path1, path2, path3, path4 };

            for (int i = 0; i < paths.Length; i++)
            {
                using (StreamReader reader = new StreamReader(paths[i], encoding: search_Encoding))
                {
                    Text_Dict[i + 1] = reader.ReadToEnd();
                }
            }

            string[] text_arr = new string[Text_Dict.Count];
            for (int i = 0; i < Text_Dict.Count; i++)
            {
                text_arr[i] = Text_Dict[i + 1];
            }
            return text_arr;
        }

        public static void Upload_Dict(int dict_num, string txt_to_add)
        {
            string path = dict_num.ToString() + ".txt";
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.WriteAllText(path, txt_to_add);
            }
        }

        public static string Generate_Text(int sentence_num, int reg, bool rand_select)
        {
            string text = "";

            if (rand_select)
            {
                Random r = new Random();
                for (int i = 0; i < sentence_num; i++)
                {
                    int randomIndex = r.Next(0, 4);
                    text += Text_Dict[randomIndex] + ". ";
                }
            }
            else
            {
                for (int i = 0; i < sentence_num; i++)
                {
                    int textIndex = i % 4;
                    text += Text_Dict[textIndex + 1] + ". ";
                }
            }

            text += " ";


            switch (reg)
            {
                case 0:
                    text = text.ToLower();
                    break;
                case 1:
                    text = text.ToUpper();
                    break;
                case 2:
                    text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
                    break;
                default:
                    break;
            }

            if (string.IsNullOrWhiteSpace(text.Replace(".", "").Replace(" ", "")))
            {
                text = " ";
            }

            return text;

        }
        public static List<string> Get_txt_data(string text)
        {
            List<string> data = new List<string>();

            // Количество символов в тексте
            int charCount = text.Length;
            data.Add(charCount.ToString());

            // Количество слов в тексте
            int wordCount = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            data.Add(wordCount.ToString());

            // Количество уникальных слов в тексте
            var uniqueWords = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
            int uniqueWordCount = uniqueWords.Count;
            data.Add(uniqueWordCount.ToString());

            return data;
        }


        public static List<string> Chart_Names(string text)
        {
            // Разбить текст на слова
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Подсчитать частоту встречаемости каждого слова и сразу добавить в список
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (word != ".")
                {
                    if (wordFrequency.ContainsKey(word))
                        wordFrequency[word]++;
                    else
                        wordFrequency[word] = 1;
                }
            }

            // Отсортировать слова по частоте встречаемости в убывающем порядке
            var sortedWords = wordFrequency.OrderByDescending(pair => pair.Value).Select(pair => pair.Key).ToList();

            return sortedWords;
        }

        public static List<int> Chart_Nums(string text)
        {
            // Разбить текст на слова
            string[] wordsArray = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Подсчитать частоту встречаемости каждого слова
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
            foreach (string word in wordsArray)
            {
                if (word != ".")
                {
                    if (wordFrequency.ContainsKey(word))
                        wordFrequency[word]++;
                    else
                        wordFrequency[word] = 1;
                }
            }

            // Отсортировать слова по частоте встречаемости в убывающем порядке
            var sortedWords = wordFrequency.OrderByDescending(pair => pair.Value).Take(5);

            List<int> wordsNums = new List<int>();

            foreach (var pair in sortedWords)
            {
                wordsNums.Add(pair.Value);
            }

            return wordsNums;
        }

    }
}