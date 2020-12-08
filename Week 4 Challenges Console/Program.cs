using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Challenges_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var leopard = new Mammal();
            leopard.NumberOfEyes = 2;
            leopard.Name = "leopard";
            leopard.IsSocial = false;
            leopard.EatsMeat = true;

            var snail = new Invertebrate();
            snail.NumberOfEyes = 2;
            snail.Name = "snail";
            snail.EatsMeat = false;
            snail.InvertebrateGroup = "Mollusc";
        }
    }
    abstract class Animal
    {
        public int NumberOfEyes { get; set; }
        public string Name { get; set; }
        public bool EatsMeat { get; set; }

        public Animal() { }

        public Animal(int numberOfEyes, string name, bool eatsMeat)
        {
            NumberOfEyes = numberOfEyes;
            Name = name;
            EatsMeat = eatsMeat;
        }

        public abstract void create();
    }

    class Mammal : Animal
    {
        public Mammal()
        {

        }
        public bool IsSocial { get; set; }

        public Mammal(int numberOfEyes, string name, bool eatsMeat, bool isSocial)
            : base(numberOfEyes, name, eatsMeat)
        {
            NumberOfEyes = numberOfEyes;
            Name = name;
            EatsMeat = eatsMeat;
            IsSocial = isSocial;
        }

        public override void create()
        {
            Console.WriteLine("Your new " + Name + "has been created");
        }

    }

    class Invertebrate : Animal
    {
        public string InvertebrateGroup { get; set; }

        public Invertebrate() { }
        public Invertebrate(int numberOfEyes, string name, bool eatsMeat, string invertebrateGroup) : base(numberOfEyes, name, eatsMeat)
        {
            NumberOfEyes = numberOfEyes;
            Name = name;
            EatsMeat = eatsMeat;
            InvertebrateGroup = invertebrateGroup;
        }

        public override void create()
        {
            Console.WriteLine("Your new " + Name + "has been created");
        }
    }
}
