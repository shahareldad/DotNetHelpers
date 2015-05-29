using System;

namespace InterviewPreperation.Inheritance
{
    public class Inheritance
    {
        public Inheritance()
        {
            A a = new A();          // ctor A
            a.Write();              // A
            a.WriteVirtualA();      // VirtualA A
            a.WriteVirtualB();      // VirtualB A
                                    
            B b = new B();          // ctor A
                                    // ctor B
            b.Write();              // B
            b.WriteVirtualA();      // VirtualA B
            b.WriteVirtualB();      // VirtualB B

            A ab = new B();         // ctor A
            ab.Write();             // ctor B
            ab.WriteVirtualA();     // A
            ab.WriteVirtualB();     // VirtualA B
                                    // VirtualB A
        }
    }

    public class A
    {
        public A()
        {
            Console.WriteLine("ctor A");
        }

        public void Write()
        {
            Console.WriteLine("A");
        }

        public virtual void WriteVirtualA()
        {
            Console.WriteLine("VirtualA A");
        }

        public virtual void WriteVirtualB()
        {
            Console.WriteLine("VirtualB A");
        }
    }

    public class B : A
    {
        public B()
        {
            Console.WriteLine("ctor B");
        }

        public void Write()
        {
            Console.WriteLine("B");
        }

        public override void WriteVirtualA()
        {
            Console.WriteLine("VirtualA B");
        }

        public void WriteVirtualB()
        {
            Console.WriteLine("VirtualB B");
        }
    }
}
