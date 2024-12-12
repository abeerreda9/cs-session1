using System;

class Program
{
    static void Main()
    {//1
        #region Write a program that allows the user to enter a number then print it.

        Console.WriteLine(" Enter and Print a Number");
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        Console.WriteLine($"You entered: {input}");
        #endregion
        // 2
        #region Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
        Console.WriteLine(" Value Type Assignment");
        int firstNumber = 10;
        int secondNumber = firstNumber;
        Console.WriteLine($"Initial Value of firstNumber: {firstNumber}");
        Console.WriteLine($"Initial Value of secondNumber: {secondNumber}");
        firstNumber = 20;
        Console.WriteLine("After modifying firstNumber:");
        Console.WriteLine($"Value of firstNumber: {firstNumber}");
        Console.WriteLine($"Value of secondNumber: {secondNumber}");
        #endregion
        // 3
        #region Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

        Console.WriteLine(" Reference Type Assignment");
        Person person1 = new Person { Name = "Abeer" };
        Person person2 = person1;

        Console.WriteLine($"Initial Value of person1.Name: {person1.Name}");
        Console.WriteLine($"Initial Value of person2.Name: {person2.Name}");

        person1.Name = "reda";
        Console.WriteLine($"Value of person1.Name: {person1.Name}");
        Console.WriteLine($"Value of person2.Name: {person2.Name}");
    }
}class Person
{
    public string Name { get; set; }
}
#endregion