namespace InterviewPreperation.DotNetBehindTheScenes
{
    public class EventAndDelegate
    {
        public event MyEventHandler MyEvent;

        public EventAndDelegate()
        {
            
        }
    }

    public delegate void MyEventHandler();
}

/*
 
 ============= inherits from MulticastDelegate =============
 .class public auto ansi sealed WpfApplication1.MyEventHandler
       extends [mscorlib]System.MulticastDelegate
{
} // end of class WpfApplication1.MyEventHandler
 ==================================================================================================================================
 ==================================================================================================================================
 
  
 
 
 
 ============= Adding a subscriber to an event is simply a method add_MyEvent which calls to Combine method from MyEventHandler  =============
 .method public hidebysig specialname instance void 
        add_MyEvent(class WpfApplication1.MyEventHandler 'value') cil managed
{
  // Code size       48 (0x30)
  .maxstack  3
  .locals init (class WpfApplication1.MyEventHandler V_0,
           class WpfApplication1.MyEventHandler V_1,
           class WpfApplication1.MyEventHandler V_2,
           bool V_3)
  IL_0000:  ldarg.0
  IL_0001:  ldfld      class WpfApplication1.MyEventHandler WpfApplication1.EventAndDelegate::MyEvent
  IL_0006:  stloc.0
  IL_0007:  ldloc.0
  IL_0008:  stloc.1
  IL_0009:  ldloc.1
  IL_000a:  ldarg.1
  IL_000b:  call       class [mscorlib]System.Delegate [mscorlib]System.Delegate::Combine(class [mscorlib]System.Delegate,
                                                                                          class [mscorlib]System.Delegate)
  IL_0010:  castclass  WpfApplication1.MyEventHandler
  IL_0015:  stloc.2
  IL_0016:  ldarg.0
  IL_0017:  ldflda     class WpfApplication1.MyEventHandler WpfApplication1.EventAndDelegate::MyEvent
  IL_001c:  ldloc.2
  IL_001d:  ldloc.1
  IL_001e:  call       !!0 [mscorlib]System.Threading.Interlocked::CompareExchange<class WpfApplication1.MyEventHandler>(!!0&,
                                                                                                                         !!0,
                                                                                                                         !!0)
  IL_0023:  stloc.0
  IL_0024:  ldloc.0
  IL_0025:  ldloc.1
  IL_0026:  ceq
  IL_0028:  ldc.i4.0
  IL_0029:  ceq
  IL_002b:  stloc.3
  IL_002c:  ldloc.3
  IL_002d:  brtrue.s   IL_0007
  IL_002f:  ret
} // end of method EventAndDelegate::add_MyEvent


 ==================================================================================================================================
 ==================================================================================================================================
 
  
 
 
 
 ============= Removing a subscriber from an event is simply a method remove_MyEvent which calls to Combine method from MyEventHandler  =============
.method public hidebysig specialname instance void 
        remove_MyEvent(class WpfApplication1.MyEventHandler 'value') cil managed
{
  // Code size       48 (0x30)
  .maxstack  3
  .locals init (class WpfApplication1.MyEventHandler V_0,
           class WpfApplication1.MyEventHandler V_1,
           class WpfApplication1.MyEventHandler V_2,
           bool V_3)
  IL_0000:  ldarg.0
  IL_0001:  ldfld      class WpfApplication1.MyEventHandler WpfApplication1.EventAndDelegate::MyEvent
  IL_0006:  stloc.0
  IL_0007:  ldloc.0
  IL_0008:  stloc.1
  IL_0009:  ldloc.1
  IL_000a:  ldarg.1
  IL_000b:  call       class [mscorlib]System.Delegate [mscorlib]System.Delegate::Remove(class [mscorlib]System.Delegate,
                                                                                         class [mscorlib]System.Delegate)
  IL_0010:  castclass  WpfApplication1.MyEventHandler
  IL_0015:  stloc.2
  IL_0016:  ldarg.0
  IL_0017:  ldflda     class WpfApplication1.MyEventHandler WpfApplication1.EventAndDelegate::MyEvent
  IL_001c:  ldloc.2
  IL_001d:  ldloc.1
  IL_001e:  call       !!0 [mscorlib]System.Threading.Interlocked::CompareExchange<class WpfApplication1.MyEventHandler>(!!0&,
                                                                                                                         !!0,
                                                                                                                         !!0)
  IL_0023:  stloc.0
  IL_0024:  ldloc.0
  IL_0025:  ldloc.1
  IL_0026:  ceq
  IL_0028:  ldc.i4.0
  IL_0029:  ceq
  IL_002b:  stloc.3
  IL_002c:  ldloc.3
  IL_002d:  brtrue.s   IL_0007
  IL_002f:  ret
} // end of method EventAndDelegate::remove_MyEvent

 ==================================================================================================================================
 ==================================================================================================================================
  
  
 
 */