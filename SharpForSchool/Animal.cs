using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpForSchool
{
    class Animal
    {
        public string kindOfAnimal; // type animal
        public string name;
        public int numberOfLegs;
        public int height;
        public int length;
        public string color;
        public bool hasTail;
        public bool isMammal;
        private bool spellingCorrect; //Check correct write name

        public int NumberOfLegs(string animalName)
        {
            if (animalName == "Elephant")
            {
                return 4;
            }
            else if (animalName == "Turkey")
            {
                return 2;
            }
            else if (animalName == "Oyster")
            {
                return 1;
            }
            else return 0;
        }

        public string GetFoodInto()
        {
            return null;
        }

        private void SpellingCorrect()
        {

        }

        protected bool IsValidAnimalType()
        {
            return true;
        }

    }
}
