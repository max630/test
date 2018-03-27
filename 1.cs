using System;
abstract class A
{
public abstract void F();
}
class B: A
{
public override void F() { Console.WriteLine("B.F"); }
}
class Test
{
static void Main() {
B b = new B();
b.F();
A a = b;
a.F();
}
}

