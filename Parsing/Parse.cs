using System;
using System.Collections.Generic;
using System.Linq;
//this program ignores input validation
namespace Parsing
{
    public class Parse
    {
        public static void CheckConsecutive()
        {
            Console.WriteLine("Please enter a few numbers seperated by a hyphen (e.g. 2-5-4).");
            var numbers = Console.ReadLine().Split('-').Select(Int32.Parse).ToList();

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] - 1 != numbers[i-1])
                {
                    Console.WriteLine("Not Consecutive");
                    System.Environment.Exit(1);
                }
            }//end for loop

            Console.WriteLine("Consecutive");
        }//end method

        public static void CheckDuplicates()
        {
            Console.WriteLine("Please enter a few number seperated by hyphens (e.g. 5-3-4).");
            var numbers = Console.ReadLine().Split('-').Select(Int32.Parse).ToList();

            for(int i = 0; i < numbers.Count; i++)
            {
                var checker = numbers[1];
                numbers.Remove(numbers[1]);
                if(numbers.Contains(checker))
                    Console.WriteLine("Duplicate");
            }
        }//end method

        public static void ValidTime()
        {
            Console.WriteLine("Please enter a time value in the 24-hour time format (e.g. 19:00).");
            var time = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(time))
                Console.WriteLine("Invalid Time");

            //parse using ':' as delimiter into hours and minutes
            string[] timesplit = time.Split(':');
            var hour = Convert.ToInt32(timesplit[0]);
            var min = Convert.ToInt32(timesplit[1]);

            if (hour <= 23 && hour >= 0 && min <= 59 && min >= 0)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }//end method

        public static void CreatePascal()
        {
            Console.WriteLine("Please enter a few words.");
            var sentence = Console.ReadLine();

            
            //create list of words
            //change each word
            //use ascii values to check undercase or lower add or subtract #

            var pascal = MakePascal(sentence);

           //print each object in list w no space
            foreach (var w in pascal)
            {
                Console.Write(w);
            }
            Console.WriteLine();
        }//end method

        static List<char> MakePascal(string s)
        {
            var stringinput = s.Split(' ');
            var stringreturn = new List<char>();
            int asciiVal = 32;
            foreach (var word in stringinput)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (i == 0)
                    {
                        if (word[i] >= 97)
                            stringreturn.Add((char)(word[i] - asciiVal));
                        else
                        {
                            stringreturn.Add(word[i]);
                        }
                    }
                    else if(i > 0)
                    {
                        if (word[i] <= 90)
                            stringreturn.Add((char)(word[i] + asciiVal));
                        else
                        {
                            stringreturn.Add((word[i]));
                        }
                    }
                }
                
            }

            return stringreturn;
        }

        public static void CountVowels()
        {
            Console.WriteLine("Please enter an English word (no capitalization).");
            var word = Console.ReadLine();

            var vowelCount = 0;
            foreach (var l in word)
            {
                if (l == 'a' || l == 'e' || l == 'o' || l == 'u' || l == 'i')//or can take ascii values
                    vowelCount++;
            }

            Console.WriteLine("{0} has {1} vowel(s).", word, vowelCount);

        }//end method
    }
}
