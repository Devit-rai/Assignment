using System;

class Program
{
    static void Main(string[] args)
    {
        //Task 1
        Student s1 = new Student("David", 20, "Computing");
        Student s2 = new Student("John", 22, "Networking");

        Console.WriteLine("Student 1:");
        Console.WriteLine(s1.name);
        Console.WriteLine(s1.age);
        Console.WriteLine(s1.course);

        Console.WriteLine();

        Console.WriteLine("Student 2:");
        Console.WriteLine(s2.name);
        Console.WriteLine(s2.age);
        Console.WriteLine(s2.course);

        Console.WriteLine();

        Console.WriteLine("College: " + Student.collegeName);

        // Task 2
        Calculator calc = new Calculator();

        // Calling methods
        calc.PrintWelcome();

        int sum = calc.Add(10, 20);
        int product1 = calc.Multiply(5, 4);  // Both parameters
        int product2 = calc.Multiply(7);     // Uses default value of num2 = 1

        // Printing results
        Console.WriteLine("Addition: " + sum);
        Console.WriteLine("Multiplication (5 * 4): " + product1);
        Console.WriteLine("Multiplication with default (7 * 1): " + product2);
    }
}
