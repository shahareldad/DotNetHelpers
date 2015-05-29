namespace InterviewPreperation.DotNetBehindTheScenes
{
    public class OperatorOverloading
    {
        public OperatorOverloading()
        {
            var c1 = new Complex(1, 2);
            var c2 = new Complex(1, 2);

            var c3 = c1 + c2;
        }
    }

    public class Complex
    {
        private readonly int _real;
        private readonly int _imaginary;

        public Complex(int real, int imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1._real + c2._real, c1._imaginary + c2._imaginary);
        }
    }
}


/*
  
 ============= The operator overloading simply creates a method named "op_[The name of the operator]" =============
 ============= This is also why you can`t create such a method as the compiler will throw an error =============
 .method public hidebysig specialname static 
        class WpfApplication1.Complex  op_Addition(class WpfApplication1.Complex c1,
                                                   class WpfApplication1.Complex c2) cil managed
{
  // Code size       37 (0x25)
  .maxstack  3
  .locals init ([0] class WpfApplication1.Complex CS$1$0000)
  IL_0000:  nop
  IL_0001:  ldarg.0
  IL_0002:  ldfld      int32 WpfApplication1.Complex::_real
  IL_0007:  ldarg.1
  IL_0008:  ldfld      int32 WpfApplication1.Complex::_real
  IL_000d:  add
  IL_000e:  ldarg.0
  IL_000f:  ldfld      int32 WpfApplication1.Complex::_imaginary
  IL_0014:  ldarg.1
  IL_0015:  ldfld      int32 WpfApplication1.Complex::_imaginary
  IL_001a:  add
  IL_001b:  newobj     instance void WpfApplication1.Complex::.ctor(int32,
                                                                    int32)
  IL_0020:  stloc.0
  IL_0021:  br.s       IL_0023
  IL_0023:  ldloc.0
  IL_0024:  ret
} // end of method Complex::op_Addition

 ==================================================================================================================================
 ==================================================================================================================================
 
 
*/