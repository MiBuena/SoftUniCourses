using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    class AnimalFactory
    {

        public static Animal ProduceAnimal(string animalName, string name, int age, string gender)
        {
            switch (animalName)
            {
                case "Cat":
                    return new Cat(name, age, gender);
                    break;
                case "Dog":
                    return new Dog(name, age, gender);
                    break;
                case "Frog":
                    return new Frog(name, age, gender);
                    break;

            }

            return null;
        }

        public static Animal ProduceAnimal(string animalName, string name, int age)
        {
            switch (animalName)
            {
                case "Kitten":
                    return new Kittens(name, age);
                    break;
                case "Tomcat":
                    return new Tomcat(name, age);
                    break;
            }

            return null;
        }
    }
}
