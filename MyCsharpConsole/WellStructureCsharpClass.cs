using System;

public class Person
{
    // Fields (private variables)
    private string name;

    // Property
    public string Name 
    { 
        get { return name; } 
        set { name = value; } 
    }
    
    public int Age { get; set; } // Auto-implemented property

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method
    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    // Static field and method
    public static int Count = 0;
    public static void ShowClassInfo()
    {
        Console.WriteLine("This is the Person class.");
    }
}