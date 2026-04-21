using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Асоціація
        var course = new Course("C#");
        course.AddStudent(new Student("Іван"));
        course.AddStudent(new Student("Оля"));
        course.ShowStudents();

        Console.WriteLine();

        // Композиція
        var car = new Car("BMW", "V8");
        car.Drive();

        Console.WriteLine();

        // Агрегація
        var library = new Library(new List<Book>
        {
            new Book("C# Basics"),
            new Book("OOP Guide")
        });

        var book = library.Find("C# Basics");
        Console.WriteLine(book != null ? "Знайдено: " + book.Title : "Не знайдено");

        Console.WriteLine();

        // Абстракція
        Animal dog = new Dog();
        Animal cat = new Cat();

        dog.MakeSound();
        cat.MakeSound();
    }
}