using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Week_2_Challenges
{
    [TestClass]
    public class Greeter
    {
        public string Jello(string name)
        {
            string hello = "Hello" + name;
            return hello;
        }

        public string Gbye(string name)
        {
            string goodbye = "Goodbye" + name;
            return goodbye;
        }

        public string Greeting(int now)
        {
            if (now >= 0 && now < 1200)
            {
                return "Good Morning";
            }
            else if (now >= 1200 && now < 1700)
            {
                return "Good Afternoon";
            }
            else if (now >= 1700 && now < 2000)
            {
                return "Good Evening";
            }
            else
            {
                return "Good Night";
            }

        }

        [TestMethod]
        public void MyTestMethod()
        {

        }

    }
}
