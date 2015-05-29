using System;

namespace ConsoleProject.Creational
{
    public class AbstractFactory<T> where T : ButtonFactory, new()
    {
        private readonly T _factory;

        public AbstractFactory()
        {
            _factory = new T();
        }

        public Button GetButton()
        {
            return _factory.CreateButton();
        }
    }

    public abstract class Button
    {
        public virtual void Click()
        {
            Console.Write("I`m a button ");
        }
    }

    public class OSxButton : Button
    {
        public override void Click()
        {
            base.Click();
            Console.WriteLine("of type OSx");
        }
    }

    public class WindowsButton : Button
    {
        public override void Click()
        {
            base.Click();
            Console.WriteLine("of type Windows");
        }
    }

    public abstract class ButtonFactory
    {
        public abstract Button CreateButton();
    }

    public class WindowsButtonFactory : ButtonFactory
    {
        public override Button CreateButton()
        {
            return new WindowsButton();
        }
    }

    public class OSxButtonFactory : ButtonFactory
    {
        public override Button CreateButton()
        {
            return new OSxButton();
        }
    }
}
