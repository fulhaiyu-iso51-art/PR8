using System;
using System.Collections.Generic;

public class Course
{
    public string Title { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();

    public Course(string title)
    {
        Title = title;
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void ShowStudents()
    {
        Console.WriteLine($"Курс: {Title}");
        foreach (var s in Students)
            Console.WriteLine("- " + s.Name);
    }
}