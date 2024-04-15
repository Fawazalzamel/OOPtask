using System;
public class Student {

    public String Name { get; set; }
    public String major { get; set; }

    public double gpa { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Major {major}, GPA {gpa}";
    }
}

class NewStudent
{

    static void Main(string[] args)
    {
        var student1 = new Student();
        student1.Name = "Fawaz";
        student1.major = "Computer Eng";
        student1.gpa = 3.2;

        Console.WriteLine(student1);

    }
}