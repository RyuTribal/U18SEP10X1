using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int switching = 0;

            do
            {
                Console.WriteLine("Choose an assigment (1-7) or press 0 to quit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Write a sentance: ");
                        string sentenceOne =  Console.ReadLine() ;
                        int ammount = sentenceOne.Split(' ').Count();
                        string[] words = sentenceOne.Split(' ');
                        Console.WriteLine("This sentance has " + ammount + "of words in it.");
                        int[] letters = new int[words.Count()];
                        for(int i=0; i < words.Length; i++)
                        {
                            letters[i] = words[i].Count();
                            Console.WriteLine(words[i] + " " + letters[i]);
                        }
                        Console.ReadLine();
                        switching = 1;
                        break;

                    case 2:
                        Console.WriteLine("Write a sentance: ");
                        string sentenceTwo = Console.ReadLine();
                        string[] wordsTwo = sentenceTwo.Split(' ');
                        int[] wordLength = new int[wordsTwo.Count()];
                        Array.Sort(wordsTwo, (x,y) => x.Length.CompareTo(y.Length));
                        for(int i = 0; i < wordsTwo.Length; i++)
                        {
                            Console.WriteLine(wordsTwo[i]);

                        }
                        Array.Reverse(wordsTwo);
                        for (int i = 0; i < wordsTwo.Length; i++)
                        {
                            Console.WriteLine(wordsTwo[i]);

                        }
                        Console.ReadLine();
                        switching = 1;
                        break;

                    case 3:
                        Console.WriteLine("Write a sentance: ");
                        string sentenceThree = Console.ReadLine();
                        string[] wordsThree = sentenceThree.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        var word_query = (from string word in wordsThree orderby word select word).Distinct();
                        int ammountTwo = word_query.Count();
                        string[] result = word_query.ToArray();
                        int[] wordCount = new int[ammountTwo];
                        for (int i = 0; i < ammountTwo; i++)
                        {
                            int word_Count = TextTool.CountStringOccurrences(sentenceThree, result[i]);
                            wordCount[i] = word_Count;
                        }
                        Array.Sort(wordCount, result);
                        Array.Reverse(result);
                        for (int i = 0; i < ammountTwo; i++)
                        {
                            int word_Count = TextTool.CountStringOccurrences(sentenceThree, result[i]);
                            Console.WriteLine(result[i] + "(" + word_Count + ")");
                        }
                        switching = 1;
                        break;
                }
            } while (switching != 0);
        }
    }

    public static class TextTool
    {
        public static int CountStringOccurrences(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }
    }
}
