using FifoAnimalShelter;
using FifoAnimalShelter.classes;
using System;
using Xunit;

namespace AnimalShelterTests
{
    public class UnitTest1
    {

        /// <summary>
        /// Check to make sure animals are being added to inbound stack when enqueued.
        /// </summary>
        [Fact]
        public void EnqueueAnimals()
        {
            Animal catOne = new Animal("cat");
            catOne.Name = "fluffy";
            Animal catTwo = new Animal("cat");
            catTwo.Name = "mike";

            AnimalShelter myShelter = new AnimalShelter();
            myShelter.Enqueue(catOne);
            myShelter.Enqueue(catTwo);

            Assert.Equal(2, myShelter.InBoundStack.Count);

        }

        /// <summary>
        /// Checks that the correct first cat is returned
        /// checks to make sure inbound stack is now empty
        /// checkst to make sure something still inside bound stack
        /// </summary>
        [Fact]
        public void CheckAnimalsMoveToOutboundStack()
        {
            Animal catOne = new Animal("cat");
            catOne.Name = "fluffy";
            Animal catTwo = new Animal("cat");
            catTwo.Name = "mike";

            AnimalShelter myShelter = new AnimalShelter();
            myShelter.Enqueue(catOne);
            myShelter.Enqueue(catTwo);

            Assert.Equal("fluffy", myShelter.Dequeue("cat").Name);
            Assert.Empty(myShelter.InBoundStack);
            Assert.Single(myShelter.OutBoundStack);
        }

        /// <summary>
        /// Checks to make sure that if an animal is not the value wanted will move it to temp stack
        /// and once the animal it wants is returned will keep it there till next dequeue is called.
        /// </summary>
        [Fact]
        public void ChecktempStack()
        {
            Animal dogOne = new Animal("dog");
            dogOne.Name = "ron";
            Animal catOne = new Animal("cat");
            catOne.Name = "fluffy";
            Animal catTwo = new Animal("cat");
            catTwo.Name = "mike";

            AnimalShelter myShelter = new AnimalShelter();
            myShelter.Enqueue(dogOne);
            myShelter.Enqueue(catOne);
            myShelter.Enqueue(catTwo);

            myShelter.Dequeue("cat");
            Assert.Single(myShelter.OutBoundStack);
            Assert.Single(myShelter.TempHoldStack);

        }

        /// <summary>
        /// make sure the temp stack is getting emptied back into outbound stack by filling it with two items then returning an item
        /// at top of the outbound stack so it will not get filled till needed.
        /// </summary>
        [Fact]
        public void CheckTempGetReset()
        {

            Animal dogOne = new Animal("dog");
            dogOne.Name = "ron";
            Animal dogTwo = new Animal("dog");
            dogTwo.Name = "demi";
            Animal dogThree = new Animal("dog");
            dogThree.Name = "sparky";
            Animal catOne = new Animal("cat");
            catOne.Name = "fluffy";
            Animal catTwo = new Animal("cat");
            catTwo.Name = "mike";

            AnimalShelter myShelter = new AnimalShelter();
            myShelter.Enqueue(dogOne);
            myShelter.Enqueue(dogTwo);
            myShelter.Enqueue(catOne);
            myShelter.Enqueue(catTwo);
            myShelter.Enqueue(dogThree);

            myShelter.Dequeue("cat");
            Assert.Equal(2, myShelter.TempHoldStack.Count);//make sure the two first items(dogs) are added to temp stack
            Assert.Equal("ron", myShelter.Dequeue("dog").Name);//make sure the first dog ron is returned
            Assert.Empty(myShelter.TempHoldStack);//make sure temp stack is empty becuase it empties into outbound stack when dequeue is called.

            
        }
    }
}
