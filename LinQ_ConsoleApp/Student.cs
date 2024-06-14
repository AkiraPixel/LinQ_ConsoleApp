namespace LinQ_ConsoleApp;

public class Student
{
    public Student(string name, double averageGrade)
    {
        Name = name;
        AverageGrade = averageGrade;
    }
    public string Name { get; set; }
    public double AverageGrade { get; set; }

    public static List<Student> GetStudents()
    {
        return new List<Student>()
        {
            new Student("Vasyu",3.4),
            new Student("Freia",4.6),
            new Student("Mikhail",4.4),
            new Student("Vera",5.4),
            new Student("Ispan",4.1),
        };

    }

    public override string ToString()
    {
        return $"{Name} -- averageGrade: {AverageGrade}";
    }
}