using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        string sentanceOne =  Console.ReadLine() ;
                        int ammount = sentanceOne.Split(' ').Count();
                        string[] words = sentanceOne.Split(' ');
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
                        string sentanceTwo = Console.ReadLine();
                        string[] wordsTwo = sentanceTwo.Split(' ');
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
                }
            } while (switching != 0);
        }
    }
}
