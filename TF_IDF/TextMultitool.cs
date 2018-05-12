using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TF_IDF
{
    /// <summary>
    ///     Класс для работы с текстовыми данными, преобразования, нормализации и получения результирующего набора слов
    /// </summary>
    class TextMultitool
    {
        /// <summary>
        ///     "Словарь", который мы используем - набор символов(пробел)/букв которые нам нужны для обработки
        /// </summary>
        private readonly string Dict = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя ";

        /// <summary>
        ///     Убрать лишние табуляции, переводы каретки и новую строку, пробелы вначале и конце, перевести в нижний регистр
        /// </summary>
        /// <param name="input">входной текст</param>
        /// <returns></returns>
        private string NRT_Remove(string input) => input
            .Replace("\n", " ").Replace("\r", " ").Replace("\t", " ").Trim().ToLower();

        /// <summary>
        ///     "Нормализация текста" - только Кириллица и пробелы, с маленьких букв
        /// </summary>
        /// <param name="input">входной текст</param>
        /// <returns></returns>
        private string Normalizer(string input) =>
            NRT_Remove(input)
            .Where(ch => Dict.Contains(ch))
            .Aggregate(string.Empty, (cur, ch) => cur + ch);

        /// <summary>
        ///     Получение результирующего набора слов из текста
        /// </summary>
        /// <param name="input">входной текст</param>
        /// <returns></returns>
        public List<string> GetNormalized(string input) => 
            Normalizer(Regex.Replace(input, "[ ]+", " ")).Split(' ').ToList();
    }
}
