using System;
using System.Collections.Generic;


public interface IStudent
{
    void Update(string message);
}


public class Gunjan: IStudent
{
    public void Update(string message)
    {
        Console.WriteLine("Gunjan received: " + message);
    }
}

public class Pranita : IStudent
{
    public void Update(string message)
    {
        Console.WriteLine("Pranita received: " + message);
    }
}


public interface ITeacher
{
    void AddStudent(IStudent student);
    void RemoveStudent(IStudent student);
    void NotifyStudents(string message);
}


public class MathTeacher : ITeacher
{
    private List<IStudent> students = new List<IStudent>();

    public void AddStudent(IStudent student)
    {
        students.Add(student);
    }

    public void RemoveStudent(IStudent student)
    {
        students.Remove(student);
    }

    public void NotifyStudents(string message)
    {
        foreach (var student in students)
        {
            student.Update(message);
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        MathTeacher teacher = new MathTeacher();

        IStudent Gunjan = new Gunjan();
        IStudent Pranita = new Pranita();

        teacher.AddStudent(Gunjan);
        teacher.AddStudent(Pranita);

        teacher.NotifyStudents(" Exam on Friday!");
    }
}

