using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson5
{
    public class Task3 : IRunnable
    {

        const int NumberWordsInPage = 5;
        const int NumberLetersInWord = 4;

        private string GenerateString(int length)
        {
            Random random = new Random();
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }

        public void DisplayPage(int number, List<string> words, ILog logger)
        {
            foreach (string word in words.GetRange((number - 1) * NumberWordsInPage, NumberWordsInPage))
            {
                logger.Write(word + "\n");
            }
        }

        public void Run(ILog logger)
        {
            logger.Write("Input words number: ");
            int amountOfElement = Convert.ToInt32(logger.Read());
            List<string> words = new List<string>();
            for (var i = 0; i < amountOfElement; i++)
            {
                words.Add(GenerateString(NumberLetersInWord));
            }

            logger.Write($"Start number of elements: {words.Count}\n");
            words.RemoveAll(i => i[0] == 'Z');
            words.Sort(new Comparison<string>((i1, i2) => i2.CompareTo(i1)));
            logger.Write($"Number of elements after delete: {words.Count}\n");

            logger.Write("Input page number: ");
            if (int.TryParse(logger.Read(), out int amountofPages))
            {
                DisplayPage(amountofPages, words, logger);
            }
        }
    }
}
