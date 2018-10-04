using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Dog : Pet
    {
        public Dog(string petName, string ownerName, double petWeight) : base("Dog",petName,ownerName,petWeight)
        {
            name = petName;
            owner = ownerName;
            weight = petWeight;
        }

        public string bark(int count)
        {
            string talk = null;
            int i;
            for (i = 0; i < count; i++)
                talk += "bark!";
            return talk;
        }
    }
}
