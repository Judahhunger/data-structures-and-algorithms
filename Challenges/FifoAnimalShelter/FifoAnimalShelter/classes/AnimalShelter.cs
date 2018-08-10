using FifoAnimalShelter.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifoAnimalShelter
{
    public class AnimalShelter
    {
        public Stack<Animal> InBoundStack { get; set; }
        public Stack<Animal> OutBoundStack { get; set; }
        public Stack<Animal> TempHoldStack { get; set; }

        public AnimalShelter()
        {
            InBoundStack = new Stack<Animal>();
            OutBoundStack = new Stack<Animal>();
            TempHoldStack = new Stack<Animal>();
        }

        public void Enqueue(Animal value)
        {
            InBoundStack.Push(value);
        }


        public Animal Dequeue(string value)
        {
            try
            {
                //empty temp stack into outbound stack first thing
                while (TempHoldStack.Count >= 1)
                {
                    OutBoundStack.Push(TempHoldStack.Pop());
                }

                //if nothing in outbound or temp stack, fill outbound stack with animals from inbound stack
                if (OutBoundStack.Count < 1)
                {
                    while (InBoundStack.Count >= 1)
                    {
                        OutBoundStack.Push(InBoundStack.Pop());
                    }
                }
                //push the animal into temp stack to hold and keep them in order if not value user is looking for
                while (OutBoundStack.Peek().Value != value)
                {

                    TempHoldStack.Push(OutBoundStack.Pop());
                }
                //if animal is the value user is looking for will return the value
                return OutBoundStack.Pop();

            }
            catch (NullReferenceException)
            {

                throw;
            }
            
        }
    }
}
