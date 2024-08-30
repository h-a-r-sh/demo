// // public class MyApp
// // {
// //     static  MyApp()
// //     {

// //     //    MyApp obj=new MyApp();
// //     //    obj.Clean();
// //     }
// //     public static void Main()
// //     {
// //         Employee();
// //     //   MyApp obj=new MyApp();
// //     //   obj.Employee();
// //     }

// //      static void Employee()
// //     {
// //        Console.WriteLine("task for employee");
// //     }
// //      static void Clean()
// //     {
// //         Console.WriteLine("task for sweeper");
// //     }
// // }
// using System.Security.Cryptography.X509Certificates;

// class Person
// {
//         public void Details(out int ID,out string Ename,out int ph)
//         {ID=101;
//         Ename="Harsh";
//         ph=84848484;
//         }
// }
// public class FrontEnd
// {
//     public static void Main()
//     {   int id;
//     string s;
//     int ph;
//         Person Deepak = new Person();
//         Deepak.Details(out id,out s,out ph);
//         Console.WriteLine(id+" "+s+" "+ph);
//     }
// }


public class A{
    public int a=1;
}i9i9i9i9i9i9i9i9i9i9i9i9i9i9i9i9i9i9i9
class B:A
{i09
    public int b=5;
}
class C{
    public static void Main()
    {
        B obj=new B();
        Console.WriteLine(obj.b);
        
        Console.WriteLine(obj.a);
    }
}