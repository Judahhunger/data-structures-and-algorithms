using FifoAnimalShelter.classes;
using System;

namespace FifoAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAnimalsFromShelter();
            Console.ReadLine();
        }

        static AnimalShelter MakeAnimalShelter()
        {
            Animal catOne = new Animal("cat");//1st
            catOne.Name = "mike";
            Animal catTwo = new Animal("cat");//2nd
            catTwo.Name = "ron";
            Animal catThree = new Animal("cat");//4th
            catThree.Name = "knight";
            Animal dogOne = new Animal("dog");//3rd
            dogOne.Name = "spot";
            Animal dogTwo = new Animal("dog");//5th
            dogTwo.Name = "demi";
            Animal dogThree = new Animal("dog");//6th
            dogThree.Name = "lassy";

            AnimalShelter myShelter = new AnimalShelter();//make shelter to add too
            //add animals to shelter
            myShelter.Enqueue(catOne);
            myShelter.Enqueue(catTwo);
            myShelter.Enqueue(dogOne);
            myShelter.Enqueue(catThree);
            myShelter.Enqueue(dogTwo);
            myShelter.Enqueue(dogThree);

            return myShelter;
        }

        public static void GetAnimalsFromShelter()
        {
            AnimalShelter myShelter = MakeAnimalShelter();
            Console.WriteLine($"Animal shelter made and last animal added is {myShelter.InBoundStack.Peek().Name}");
            Console.WriteLine($"first cat returned should be mike it is: {myShelter.Dequeue("cat").Name}");
            Console.WriteLine($"first dog returned should be spot it is: {myShelter.Dequeue("dog").Name}");
            Console.WriteLine($"second dog returned should be demi it is: {myShelter.Dequeue("dog").Name}");
            Console.WriteLine($"second cat returned should be ron it is: {myShelter.Dequeue("cat").Name}");
            
        }
    }
}
