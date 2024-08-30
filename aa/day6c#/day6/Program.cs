using System;
using System.ComponentModel;


public abstract class Animal
{
    // Abstract method (must be implemented by derived classes)
    public abstract void MakeSound();

    // Non-abstract method (has implementation)
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
    public Animal()
    {
        Console.WriteLine("Parent constructor");
    }
}
public class Dog : Animal
{
    // Implementation of abstract method MakeSound
    public override void MakeSound()
    {
        Console.WriteLine("Bark!");
    }
    public Dog()
    {
        Console.WriteLine("Drived class");
    }

    // Dog class inherits the Eat method from Animal
}
class Controll
{
    public static void Main()
    {
        Dog mydog= new Dog();
        mydog.MakeSound();
    }
}