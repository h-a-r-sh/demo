// //constructor chaining
// class IT
// {
//     public IT()
//     {
//          Console.WriteLine("IT constructor");
//     }
//     public IT(string np)
//     {
//         Console.WriteLine("its base "+" "+np);
//     }
// }

// class Coforge:IT
// {
//      public Coforge()
//     {
//          Console.WriteLine("IT coforge constructor");
//     }
//     public Coforge(string np):base (np)
//     {
//         Console.WriteLine(np);
//     }

// }

// class Controller
// {
//     public static void Main()
//     {
//        Coforge mohit=new Coforge("hello");
//     }
// }

class A{
    virtual public void show()
    {
        Console.WriteLine("Hi");
    }
}
class B:A
{
    override public void show()
    {
        Console.WriteLine("Hello");
    }
    public void display()
    {
        Console.WriteLine("bye");
    }
}
class C
{
    public static void Main(){
        A a=new B();
        a.
        // a.di
        // a.display();
    }
}