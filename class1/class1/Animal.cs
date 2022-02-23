using System;

namespace class1
{
    public class Animal
    {
        public Animal()
        {
            weight = -1;
            gender = -1;
            name = "Not Defined";
        }
        public int weight;
        public string name;
        public int gender;

        public string GetAnimalProperties()
        {
            return String.Format("Weight: {0} Name:{1} Gender:{2}",weight,name,gender);
        }
    }
}