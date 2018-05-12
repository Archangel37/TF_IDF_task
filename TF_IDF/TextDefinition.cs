using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TF_IDF
{
    /// <summary>
    ///     Класс для описания источников данных, текстовое определение
    /// </summary>
    class TextDefinition
    {
        /// <summary>
        ///     Путь к файлу, из которого берём текст
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        ///     Нормализованный текст из файла в виде листа слов с маленьких букв и без знаков препинания, Кириллица
        /// </summary>
        public List<string> NormalizedTextFromSource => File.Exists(Path)? GetWordsFromFile(Path) : null;

        /// <summary>
        ///     Уникальные слова в тексте
        /// </summary>
        public List<string> Words => NormalizedTextFromSource.Distinct().ToList();

        /// <summary>
        ///     Общее число слов в источнике
        /// </summary>
        public int TotalNumWordsInSource => NormalizedTextFromSource.Count;

        /// <summary>
        ///     Получение набора слов из файла
        /// </summary>
        /// <param name="path">путь к файлу</param>
        /// <returns></returns>
        private List<string> GetWordsFromFile(string path) => new TextMultitool().GetNormalized(File.ReadAllText(path));
    }
}
