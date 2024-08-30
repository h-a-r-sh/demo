delegate void MyDelegate();

//ANONYMOUS METHOD
class Person
{



    public string AccountDetails()
    {
        return "ACCC...ICICI";
    }

}
class Startup
{
    public static void Main()
    {
        Person obj = new Person();
        MyDelegate objdel = delegate ()
        {
            int x = 2;
            Console.WriteLine(x);
        };
        objdel.Invoke();
        objdel.Invoke();

    }
}