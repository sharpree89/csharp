using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //loops & conditionals
            for(int i = 1; i <= 255; i++){
                Console.WriteLine(i);
            }
            for(int i = 1; i <= 100; i++){
                if(i % 15 == 0){
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 3 == 0 && i % 5 != 0){
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0 && i % 3 != 0){
                    Console.WriteLine("Buzz");
                }
            }

            //creating arrays
            int[] array;
            array = new int[] {0,1,2,3,4,5,6,7,8,9};

            string[] array2;
            array2 = new string[] {"Tim", "Martin", "Nikki", "Sara"};

            bool[] array3;
            array3 = new bool[] {true, false, true, false, true, false, true, false, true, false};

            //creating dictionaries
            Dictionary<string,string> tim = new Dictionary<string,string>();
                tim.Add("Name", "Tim");
                tim.Add("Sport", "Video Games");
                tim.Add("Pets", "2");
                tim.Add("Ice Cream", "true");

            Dictionary<string,string> martin = new Dictionary<string,string>();
                martin.Add("Name", "Martin");
                martin.Add("Sport", "Basketball");
                martin.Add("Pets", "1");
                martin.Add("Ice Cream", "true");
            
            Dictionary<string,string> nikki = new Dictionary<string,string>();
                nikki.Add("Name", "Nikki");
                nikki.Add("Sport", "Ice Hockey");
                nikki.Add("Pets", "0");
                nikki.Add("Ice Cream", "false");

            Dictionary<string,string> sara = new Dictionary<string,string>();
                sara.Add("Name", "Sara");
                sara.Add("Sport", "Chess");
                sara.Add("Pets", "4");
                sara.Add("Ice Cream", "true");

            //creating lists(of dictionaries)
            var profiles = new List<Dictionary<string,string>>();
                profiles.Add(tim);
                profiles.Add(martin);
                profiles.Add(nikki);
                profiles.Add(sara);

            //accessing key value pairs of dictionaries inside a list
            for(int i = 0; i < profiles.Count; i++) {
                foreach (var entry in profiles[i]) {
                    Console.WriteLine(entry.Key + " - " + entry.Value);
                }
            }
        }
    }
}

