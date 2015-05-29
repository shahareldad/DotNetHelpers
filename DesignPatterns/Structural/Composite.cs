using System;
using System.Collections.Generic;

namespace ConsoleProject.Structural
{
    public interface IAnimal
    {
        void Speak();
    }

    public class CompositeAnimal : IAnimal
    {
        private readonly List<IAnimal> _animalCollection = new List<IAnimal>();

        public void Add(IAnimal animal)
        {
            _animalCollection.Add(animal);
        }

        public void AddCollection(params IAnimal[] animal)
        {
            _animalCollection.AddRange(animal);
        }

        public void Remove(IAnimal animal)
        {
            _animalCollection.Remove(animal);
        }

        public void Speak()
        {
            foreach (var animal in _animalCollection)
            {
                animal.Speak();
            }
        }
    }

    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }
}
