using System;

namespace InterviewPreperation.DotNetBehindTheScenes
{
    public static class ExtensionMethod
    {
        public static void MyExtensionMethod(this string src)
        {
            Console.WriteLine("Source was: " + src);
        }
    }
}


/*
  
 ============= Extension methods are simply an attribute "ExtensionAttribute" =============
.method public hidebysig static void  MyExtensionMethod(string src) cil managed
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.ExtensionAttribute::.ctor() = ( 01 00 00 00 ) 
  // Code size       19 (0x13)
  .maxstack  8
  IL_0000:  nop
  IL_0001:  ldstr      "Source was: "
  IL_0006:  ldarg.0
  IL_0007:  call       string [mscorlib]System.String::Concat(string,
                                                              string)
  IL_000c:  call       void [mscorlib]System.Console::WriteLine(string)
  IL_0011:  nop
  IL_0012:  ret
} // end of method ExtensionMethod::MyExtensionMethod

 ==================================================================================================================================
 ==================================================================================================================================
 
 Extension methods require an attribute which is normally part of .NET 3.5.
 However, you can define it yourself, at which point you can write and use extension methods to your heart's delight:

namespace System.Runtime.CompilerServices
{
    [AttributeUsageAttribute(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public class ExtensionAttribute : Attribute
    {
    }
}
 
*/