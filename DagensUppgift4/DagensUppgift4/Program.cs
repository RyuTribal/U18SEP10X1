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
                        Console.WriteLine("Write a sentence: ");
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
                        Console.WriteLine("Write a sentence: ");
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
                        Console.WriteLine("Write a sentence: ");
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
                    case 4:
                        Console.WriteLine("Write a sentence: ");
                        string sentenceFour = Console.ReadLine();
                        string [] wordsFour = sentenceFour.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        char[] characters = string.Join(string.Empty,wordsFour).ToCharArray();
                        var character_query = (from char word in characters orderby word select word).Distinct();
                        int ammountThree = character_query.Count();
                        char[] resultTwo = character_query.ToArray();
                        foreach (char ch in resultTwo)
                        {
                            int count = sentenceFour.Count(f => f == ch);
                            Console.WriteLine(ch + "(" + count + ")");
                            
                        }

                        switching = 1;
                        break;
                    case 5:
                        string sentenceFive = "";
                        string user_input = "";
                        while (true)
                        {
                   
                            while (true)
                            {
                                Console.WriteLine("Write a word or type END to finalize the sentance");
                                user_input = Console.ReadLine();
                                if (user_input == "")
                                {
                                    Console.WriteLine("All you had to do was type a word CJ!");
                                }
                                else
                                {
                                    break;
                                }


                            }
                            if (user_input.ToLower() == "end")
                            {
                                break;
                            }
                            sentenceFive += " " + user_input;

                        }
                        Console.WriteLine("Your sentence is:" + sentenceFive);
                        switching = 1;
                        break;
                    case 6:
                        Random random = new Random();
                        int randomNum = random.Next(1, 21);
                        while (true)
                        {
                            Console.WriteLine("Guess a number from 1-21:");
                            int userNumber = Convert.ToInt32(Console.ReadLine());
                            if (userNumber == randomNum)
                            {
                                Console.WriteLine("Good Job you just wasted time on this program guessing a number that will never ever make your life any better\n...but congrats nonetheless");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Wrong!");
                            }
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
