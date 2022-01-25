//Name: Joshua Chamberlain
//Date: 01/24/2022
/*Description: This uses inheritence to allow the user to create different types of animals. Then a menu driven
adding process and printing process allows the user to do certain things. */
using System;
using System.Collections.Generic;

namespace HW_1
{
    class World
    {
        List<Animal> Animals = new List<Animal>();
        static void Main(string[] args)
        {
            World myWorld = new World();
            Console.WriteLine("Please add an animal to the list: ");
            Console.WriteLine("The choices are: Add Cat (C), Add Cassowary (W), Add Dolphin (D), Print Info (P), Make Noise (M), Age Up (A) and Exit (E)");
            string userChoice = Console.ReadLine();
            while (userChoice != "E")
            {
                if (userChoice == "C")
                {
                    Console.WriteLine("Pick a name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Pick an age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    string noise = "Meow";
                    Console.WriteLine("Pick a weight: ");
                    double weight = Convert.ToDouble(Console.ReadLine());
                    myWorld.Animals.Add(new Cat(name, age, noise, weight));
                    Console.WriteLine("The choices are: Add Cat(C), Add Cassowary(W), Add Dolphin(D), Print Info(P), Make Noise(M), Age Up(A) and Exit(E)");
                    userChoice = Console.ReadLine();
                }
                else if (userChoice == "W")
                {
                    Console.WriteLine("Pick a name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Pick an age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    string noise = "Caw Caw";
                    Console.WriteLine("Pick a weight: ");
                    double weight = Convert.ToDouble(Console.ReadLine());
                    myWorld.Animals.Add(new Cassowary(name, age, noise, weight));
                    Console.WriteLine("The choices are: Add Cat(C), Add Cassowary(W), Add Dolphin(D), Print Info(P), Make Noise(M), Age Up(A) and Exit(E)");
                    userChoice = Console.ReadLine();
                }
                else if (userChoice == "D")
                {
                    Console.WriteLine("Pick a name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Pick an age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    string noise = "Blub Blub";
                    Console.WriteLine("Pick a weight: ");
                    double weight = Convert.ToDouble(Console.ReadLine());
                    myWorld.Animals.Add(new Dolphin(name, age, noise, weight));
                    Console.WriteLine("The choices are: Add Cat(C), Add Cassowary(W), Add Dolphin(D), Print Info(P), Make Noise(M), Age Up(A) and Exit(E)");
                    userChoice = Console.ReadLine();
                }
                else if (userChoice == "P")
                {
                    Console.WriteLine("To print all Cat info press C");
                    Console.WriteLine("To print all Cassowarys press W");
                    Console.WriteLine("To print all Dolphins press D");
                    Console.WriteLine("To print a certain animal press F");
                    string userPrintType = Console.ReadLine();
                    if (userPrintType == "C")
                    {
                        foreach (Cat c in myWorld.Animals)
                        {
                            c.PrintInfo();
                        }
                    }
                    else if (userPrintType == "W")
                    {
                        foreach (Cassowary c in myWorld.Animals)
                        {
                            c.PrintInfo();
                        }
                    }
                    else if (userPrintType == "D")
                    {
                        foreach (Dolphin c in myWorld.Animals)
                        {
                            c.PrintInfo();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter index: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        myWorld.Animals[index].PrintInfo();
                    }
                    Console.WriteLine("The choices are: Add Cat(C), Add Cassowary(W), Add Dolphin(D), Print Info(P), Make Noise(M), Age Up(A) and Exit(E)");
                    userChoice = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please pick the index of the animal that has aged up: ");
                    int printIndex = Convert.ToInt32(Console.ReadLine());
                    myWorld.Animals[printIndex].AgeUp();
                    Console.WriteLine("The choices are: Add Cat(C), Add Cassowary(W), Add Dolphin(D), Print Info(P), Make Noise(M), Age Up(A) and Exit(E)");
                    userChoice = Console.ReadLine();
                }
            }
        }
    }
    public abstract class Animal
    {
        private string Name;
        private int Age;
        private string Noise;
        private double Weight;

        //Constructor for an Animal
        public Animal()
        {
            Name = "Steve";
            Age = 3;
            Noise = "Caw Caw";
            Weight = 5.12;
        }
        //Parameterized Constructor for animal.
        //Name is the name of the animal.
        //Age is the age of the animal in years.
        //Noise is the noise that the animal makes.
        //Weight is the weight of the animal in pounds.
        public Animal(string name, int age, string noise, double weight)
        {
            Name = name;
            Age = age;
            Noise = noise;
            Weight = weight;
        }
        //Prints all information about the animal
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Noise: {Noise}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine("");
        }
        //Animal make the noise assigned to it.
        public virtual void MakeNoise()
        {
            Console.WriteLine($"{Noise}");
        }
        //Animals age goes up by 1.
        public virtual int AgeUp()
        {
            Console.Write($"{Name} aged up: ");
            Age++;
            Console.WriteLine($"{Age}");
            return Age;
        }
    }

    public class Cat : Animal
    {

        //Constructor for a cat. Inherits method from the Animal class.
        public Cat(string name, int age, string noise, double weight) : base(name, age, noise, weight)
        {

        }
        //Prints Info about the cat. Inherits method from the Animal class.
        public override void PrintInfo()
        {
            Console.WriteLine("I am a cat.");
            base.PrintInfo();
        }
        
        //Makes a meow noise.
        public override void MakeNoise()
        {
            Console.WriteLine("Meow");
        }
        //Ages up the cat. Inherits method from the Animal class.
        public override int AgeUp()
        {
            return base.AgeUp();
        }
    }

    public class Cassowary : Animal
    {
        //Constructor for a Cassowary. Inherits method from the Animal class.
        public Cassowary(string name, int age, string noise, double weight) : base(name, age, noise, weight)
        {

        }
        //Prints all information about the Cassowary. Inherits method from the Animal class.
        public override void PrintInfo()
        {
            Console.WriteLine("I am a Cassowary.");
            base.PrintInfo();
        }
        //Makes a cassowary noise. Inherits method from the Animal class.
        public override void MakeNoise()
        {
            base.MakeNoise();
        }
        //Ages up Cassowary. Inherits method from the Animal class.
        public override int AgeUp()
        {
            return base.AgeUp();
        }
    }

    public class Dolphin : Animal
    {
        //Constructor for Dolphin. Inherits method from the Animal class.
        public Dolphin(string name, int age, string noise, double weight) : base(name, age, noise, weight)
        {

        }
        //Prints all information about the dolphin. Inherits method from the Animal class.
        public override void PrintInfo()
        {
            Console.WriteLine("I am a Dolphin.");
            base.PrintInfo();
        }
        //Makes a Dolphin noise.
        public override void MakeNoise()
        {
            Console.WriteLine("Blub Blub");
        }
        //Ages up the dolphin. Inherits method from the Animal class.
        public override int AgeUp()
        {
            return base.AgeUp();
        }
    }
}

