using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core.Interfaces;
using System.Linq;

namespace TestProject.TaskLibrary.Tasks.Lesson7
{
    public class Task4 : IRunnable
    {

        const int NumberWordsInPage = 5;
        const int NumberLetersInWord = 4;

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
            List<string> words = GenerateList(amountOfElement);

            logger.Write($"Start number of elements: {words.Count}\n");
            words.RemoveAll(x => x.First() == 'Z');
            words = words.Distinct()
                         .OrderByDescending(x => x)
                         .ToList();
            logger.Write($"Number of elements after delete: {words.Count}\n");

            logger.Write("Input page number: ");
            if (int.TryParse(logger.Read(), out int amountofPages))
            {
                DisplayPage(amountofPages, words, logger);
            }
        }

        private List<string> GenerateList(int length)
        {
            Random random = new Random(DateTime.Now.Second);
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            List<string> words = new List<string>();

            for (var i = 0; i < length; i++)
            {
                StringBuilder result = new StringBuilder(length);
                for (int j = 0; j < NumberLetersInWord; j++)
                {
                    result.Append(characters[random.Next(characters.Length)]);
                }
                words.Add(result.ToString());
            }
            return words;
        }
    }
}
