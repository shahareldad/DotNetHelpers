using System;

namespace ConsoleProject.Creational
{
    public class FactoryMethod
    {
        public ICat GetCat(CatType catType)
        {
            ICat cat = null;
            switch (catType)
            {
                case CatType.Lion:
                    cat = new Lion();
                    break;
                case CatType.Puma:
                    cat = new PumaCat();
                    break;
                case CatType.HouseCat:
                    cat = new HouseCat();
                    break;
            }
            return cat;
        }
    }

    public enum CatType
    {
        Lion,
        Puma,
        HouseCat
    }

    public interface ICat
    {
        void PrintSize();
    }

    public class Lion : ICat
    {
        public void PrintSize()
        {
            Console.WriteLine("Large");
        }
    }

    public class PumaCat : ICat
    {
        public void PrintSize()
        {
            Console.WriteLine("Medium");
        }
    }

    public class HouseCat : ICat
    {
        public void PrintSize()
        {
            Console.WriteLine("Small");
        }
    }
}
