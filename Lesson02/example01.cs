using System;

public class Being
{
    static int count = 0;

    public Being()
    {
        count++;
        Console.WriteLine("Being is created");
    }
    public void GetCount()
    {
        Console.WriteLine("There are {0} Beings", count);
    }
}

public class Human : Being
{
    public Human()
    {
        Console.WriteLine("Human is created");
    }
}
public class Animal : Being
{
    public Animal()
    {
        Console.WriteLine("Animal is created");
    }
}
public class Dog : Animal
{
    public Dog()
    {
        Console.WriteLine("Dog is created");
    }
}
public class Inheritance2
{
    static void Main()
    {
        new Human();
        Dog dog = new Dog();
        dog.GetCount();
    }
}