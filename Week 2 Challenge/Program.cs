using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter Imran = new Greeter();
            Imran.GreetUser("Dave");

            string time = Imran.Greeting();
            Console.WriteLine(time);

            string farewell = Imran.Gbye("Dave");
            Console.WriteLine(farewell);

            Console.ReadLine();
        }
    }
    public class Greeter
    {
        public void GreetUser(string name)
        {
            Console.WriteLine("Hello" + name);
        }

        public string Gbye(string name)
        {
            string goodbye = "Goodbye " + name;
            return goodbye;
        }

        public string Greeting()
        {
            DateTime now = DateTime.Now;

            if (now.Hour >= 0 && now.Hour < 12)
            {
                return "Good Morning";
            }
            else if (now.Hour >= 12 && now.Hour < 17)
            {
                return "Good Afternoon";
            }
            else if (now.Hour >= 17 && now.Hour < 20)
            {
                return "Good Evening";
            }
            else
            {
                return "Good Night";
            }

        }
    }
}
