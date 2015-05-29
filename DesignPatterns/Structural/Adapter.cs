using System;

namespace ConsoleProject.Structural
{
    public class Cat
    {
        private readonly string _catType;

        public Cat(string catType)
        {
            _catType = catType;
        }

        public virtual void GetFullDetails()
        {
            Console.WriteLine(_catType);
        }
    }

    public class WildCat : Cat
    {
        private readonly IVisualAppearnceProvider _visualAppearanceProvider;

        public WildCat(string catType)
            : base(catType)
        {
            _visualAppearanceProvider = new VisualAppearnceProvider(catType);
        }

        public override void GetFullDetails()
        {
            base.GetFullDetails();
            Console.WriteLine(_visualAppearanceProvider.GetVisualAppearance());
        }
    }

    internal interface IVisualAppearnceProvider
    {
        string GetVisualAppearance();
    }

    public class VisualAppearnceProvider : IVisualAppearnceProvider
    {
        private readonly string _catType;

        public VisualAppearnceProvider(string catType)
        {
            _catType = catType;
        }

        public string GetVisualAppearance()
        {
            switch (_catType)
            {
                case "Tiger":
                    return "Large and have stripes all over the body";
                case "Panter":
                    return "Medium and black";
                case "Lion":
                    return "Medium, in one color, and have large afro hair";
            }
            return string.Empty;
        }
    }
}
