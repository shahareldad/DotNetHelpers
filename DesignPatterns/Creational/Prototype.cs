namespace ConsoleProject.Creational
{
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class PrototypeImpl2 : Prototype
    {
        public override Prototype Clone()
        {
            return (Prototype) MemberwiseClone();
        }
    }

    public class PrototypeImpl1 : Prototype
    {
        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}
