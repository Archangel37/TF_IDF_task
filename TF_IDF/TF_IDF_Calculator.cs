using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TF_IDF
{
    class TF_IDF_Calculator
    {
        /// <summary>
        ///     Разделитель текстовый "\n==================================\n"
        /// </summary>
        private readonly string separator = "\n==================================\n";

        /// <summary>
        ///     Подсчёт количества одного и того же слова из текстового определения
        /// </summary>
        /// <param name="word"></param>
        /// <param name="textDefinition"></param>
        /// <returns></returns>
        private int WordCounter(string word, TextDefinition textDefinition)
            => textDefinition.NormalizedTextFromSource.Where(w => w.Equals(word)).Count();

        /// <summary>
        ///     Получение значения коэффициента TF из текстового определения
        /// </summary>
        /// <param name="word"></param>
        /// <param name="textDefinition"></param>
        /// <returns></returns>
        private double GetTF(string word, TextDefinition textDefinition)
        => (double) WordCounter(word, textDefinition) /
            textDefinition.TotalNumWordsInSource;
        
        /// <summary>
        ///     Получение значения IDF для слова из набора текстовых определений
        /// </summary>
        /// <param name="word"></param>
        /// <param name="listTexts"></param>
        /// <returns></returns>
        private double GetIDF(string word, IEnumerable<TextDefinition> listTexts) => 
            Math.Log(listTexts.Count() / listTexts.Count(td => td.Words.Contains(word)));

        /// <summary>
        ///     Получение общего TF-IDF рейтинга для слова из текстового определения набора текстовых определений
        /// </summary>
        /// <param name="word">слово</param>
        /// <param name="textDefinition">текстовое определение</param>
        /// <param name="listTexts">набор текстовых определений</param>
        /// <returns></returns>
        private double GetTotalRankTfIdf(string word, TextDefinition textDefinition, IEnumerable<TextDefinition> listTexts) =>
            GetTF(word, textDefinition) * GetIDF(word, listTexts);

        /// <summary>
        ///     Получение всех значений TF-IDF для всех слов из источников
        /// </summary>
        /// <param name="listTexts">набор текстовых определений</param>
        /// <returns></returns>
        private string GetAllScores(IEnumerable<TextDefinition> listTexts)
        {
            string result = string.Empty;
            foreach (var file in listTexts)
            {
                foreach (var w in file.Words)
                {
                    result += $"word: {w} >>> (TF-IDF): {GetTotalRankTfIdf(w, file, listTexts)}  >>> form Source: {file.Path} \n";
                }
                result += separator;
            };
            return result;
        }

        /// <summary>
        ///     Получить все значения коэффициентов TF-IDF из слов в файлах *.txt внутри выбранной папки
        /// </summary>
        /// <returns></returns>
        public string GetScoresFromFiles()
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() != DialogResult.OK) return null;
                var filesTxt = Directory.GetFiles(folderDialog.SelectedPath, "*.txt").ToList();
                List<TextDefinition> ListDef = new List<TextDefinition>();

                foreach (var file in filesTxt)
                {
                    ListDef.Add(new TextDefinition { Path = file });
                }

                return GetAllScores(ListDef);
            }
        }
    }
}
