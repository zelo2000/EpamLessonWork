﻿using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson5
{
    public class Task3 : IRunnable
    {

        const int NumberWordsInPage = 5;
        const int NumberLetersInWord = 4;

        public void DisplayPage(int number, List<string> words)
        {
            foreach (string word in words.GetRange((number - 1) * NumberWordsInPage, NumberWordsInPage))
            {
                Logger.Write(word + "\n");
            }
        }

        public void Run()
        {
            Logger.Write("Input words number: ");
            int amountOfElement = Convert.ToInt32(Logger.Read());
            List<string> words = GenerateList(amountOfElement);

            Logger.Write($"Start number of elements: {words.Count}\n");
            for (var i = 0; i < words.Count; i++)
            {
                if (words[i][0] == 'Z')
                {
                    words.Remove(words[i]);
                }
                else
                {
                    for (var j = i + 1; j < words.Count; j++)
                    {
                        if (words[j] == words[i])
                        {
                            words.RemoveAt(j);
                        }
                    }
                }
            }
            words.Sort(new Comparison<string>((i1, i2) => i2.CompareTo(i1)));
            Logger.Write($"Number of elements after delete: {words.Count}\n");

            Logger.Write("Input page number: ");
            if (int.TryParse(Logger.Read(), out int amountofPages))
            {
                DisplayPage(amountofPages, words);
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
                words.Add(ToString());
            }
            return words;
        }
    }
}
