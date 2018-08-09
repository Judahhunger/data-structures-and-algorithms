using System;
using System.Collections.Generic;
using System.Text;

namespace FifoAnimalShelter.classes
{
    class Animal
    {
        public string Value { get; set; }
        public string Name { get; set; }

        public Animal(string value)
        {
            Value = value;
        }
    }
}
