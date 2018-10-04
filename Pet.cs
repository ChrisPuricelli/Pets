using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pet
    {
        public string type;
        public string name;
        public string owner;
        public double weight;

        public Pet(string petType, string petName, string ownerName, double petWeight)
        {
            type = petType;
            name = petName;
            owner = ownerName;
            weight = petWeight;
        }

        public string getTag()
        {
            string tag = "If lost, call " + owner;
            return tag;
        }
    }
}
