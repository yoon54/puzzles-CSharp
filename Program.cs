using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        public static void printSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
        public static double GetAverage(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double avg = sum/numbers.Length;
            Console.WriteLine(avg);
            return avg;
        }
        public static void MinMaxAverage(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            double avg = GetAverage(numbers);
            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }

            }
            Console.WriteLine($"{max}, {min}, {avg}");
        }
        
        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] array = new int[10];
            for(int i = 0; i < array.Length;i++)
            {
                array[i] = rand.Next(5,25);
            }

            return array;
        }
        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin");
            Random rand = new Random();
            int toss = rand.Next(2);
            
            if (toss == 0)
            {
                Console.WriteLine("Heads");
                return "Heads";
            }
            else
            {
                Console.WriteLine("Tails");
                return "Tails";
            }
        }
        public static double TossMultipleCoins(int num)
        {
            double heads = 0, tails = 0;
            for(int i = 0; i < num; i++)
            {
                var result = TossCoin();
                if(result =="Heads")
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            double outcome = heads/tails;
            Console.WriteLine(outcome);
            return outcome;

        }
        public static List<string> Names()
        {
            
            
            List<string> listNames = new List<string>();
            listNames.Add("Todd");
            listNames.Add("Tiffany");
            listNames.Add("Charlie");
            listNames.Add("Geneva");
            listNames.Add("Sydney");
            List<string> newListNames = new List<string>();
            while(listNames.Count > 0)
            {
                Random rand = new Random();
                int person = rand.Next(0, listNames.Count);
                newListNames.Add(listNames[person]);
                listNames.RemoveAt(person);
               
            } 
            
            for (var idx = 0; idx < newListNames.Count; idx++)
                {
                Console.WriteLine(newListNames[idx]);
                }

            for (var idx = 0; idx < newListNames.Count ; idx++)
                {
                if(newListNames[idx].Length < 5)
                {
                    newListNames.RemoveAt(idx);
                }
                }
                
                for (var idx = 0; idx < newListNames.Count; idx++)
                {
                Console.WriteLine(newListNames[idx]);
                }
            return newListNames;
        }
        static void Main(string[] args)
        {
            // var random = RandomArray();
            // Console.WriteLine(random);
            // MinMaxAverage(random);
            // printSum(random);
            // TossCoin();
            // TossMultipleCoins(5);
            Names();
        }

    }
}
