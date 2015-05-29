using System;
using System.Collections.Generic;

namespace ConsoleProject.Creational
{
    public class LazyInitialization
    {
        readonly Lazy<Fruit> _lazyFruit = new Lazy<Fruit>();

        public Fruit GetFruit()
        {
            Console.WriteLine("IsValueCreated: " + _lazyFruit.IsValueCreated);
            Console.WriteLine("Createing...");
            var returnValue = _lazyFruit.Value;
            Console.WriteLine("IsValueCreated: " + _lazyFruit.IsValueCreated);

            return returnValue;
        }
    }

    public class Fruit
    {
        private static readonly Dictionary<string, Fruit> TypesDictionary = new Dictionary<string, Fruit>();

        public static Fruit GetFruitByTypeName(string type)
        {
            Fruit fruit;

            if (!TypesDictionary.TryGetValue(type, out fruit))
            {
                // Lazy initialization
                fruit = new Fruit();

                TypesDictionary.Add(type, fruit);
            }
            return fruit;
        }

        public static void ShowAll()
        {
            if (TypesDictionary.Count > 0)
            {
                Console.WriteLine("Number of instances made = {0}", TypesDictionary.Count);

                foreach (KeyValuePair<string, Fruit> kvp in TypesDictionary)
                {
                    Console.WriteLine(kvp.Key);
                }

                Console.WriteLine();
            }
        }
    }
}
