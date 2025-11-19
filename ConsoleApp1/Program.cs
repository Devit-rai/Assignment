using System;

class Program
{
    static void Main(string[] args)
    {
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
    }
}
