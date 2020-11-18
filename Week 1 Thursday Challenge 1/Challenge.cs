using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Week_1_Thursday_Challenge_1
{
    [TestClass]
    public class Challenge
    {
        [TestMethod]
        public void Super()
        {
            string name = "Supercalifragilisticexpialidocious";

            foreach (char letter in name)
            {
                Console.WriteLine(letter);
            }

        }
        [TestMethod]
        public void OnlyTheI()
        {
            string name = "Supercalifragilisticexpialidocious";

            foreach (char letter in name)
            {
                if (letter == 'i')
                    Console.WriteLine(letter);

                else Console.WriteLine("Not an i");
            }
        }

        [TestMethod]
        public void OnlyTheIL()
        {
            string name = "Supercalifragilisticexpialidocious";

            foreach (char letter in name)
            {
                if (letter == 'i')
                    Console.WriteLine(letter);

                if (letter == 'l')
                    Console.WriteLine(letter);

                else Console.WriteLine("Not an i");
            }
        }

        [TestMethod]
        public void Count()
        {
            string name = "Supercalifragilisticexpialidocious";

            Console.WriteLine(name.Length);
        }

        [TestMethod]
        public void FirstLastAge()
        {
            string firstName = "Imran";
            string lastName = "Zaveri";
            int age = 30;

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
        }
        [TestMethod]
        public void Array ()
        {
            string [] myBooks = {"War and Peace", "Harry Potter", "The Brothers Karamazov", "The Old Man and the Sea"};

            foreach (string book in myBooks)
            Console.WriteLine(book);
        }

        [TestMethod]
        public void DT()
        {
            DateTime Today = DateTime.Now;

            List<DateTime> listofDates = new List <DateTime>();
            listofDates.Add(DateTime.Now);
            listofDates.Add(new DateTime(2020,12,25));

            foreach (DateTime date in listofDates)
            Console.WriteLine(date);
        }

        [TestMethod]
        public void Operators()
        {
            int age = 30;
            int var = 7;

            int sum = age + var;
            Console.WriteLine(sum);
            int diff = age - var;
            Console.WriteLine(diff);
            int prod = age * var;
            Console.WriteLine(prod);
            int quot = age / var;
            Console.WriteLine(quot);
            int remainder = age % var;
            Console.WriteLine(remainder);

        }

        [TestMethod]
        public void Sleep()
        {
            Console.WriteLine("How many hours of sleep did you get????");
            int hoursOfSleep = 9;

            if (hoursOfSleep >= 10)
            {
                Console.WriteLine("Wow, that's a lot of sleep!");
            }
            
            else if (hoursOfSleep >= 8 && hoursOfSleep < 10)
            {
                Console.WriteLine("You Should Be Pretty Rested");
            }
            
            else if (hoursOfSleep >= 4 && hoursOfSleep < 8)
            {
                Console.WriteLine("Bummer");
            }

            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }


        }
        [TestMethod]
        public void Switcher()
        {
            int day = 1;

            switch (day)
            {
                case 1:
                    Console.WriteLine(":(");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Bad");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Okay");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Good");
                    break;
                case 10:
                    Console.WriteLine("Great");
                    break;
                default:
                    Console.WriteLine("I am not sure what you are feeling");
                    break;
            }

        }
    }
}
