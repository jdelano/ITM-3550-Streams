namespace StreamsDemoPrep2024;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; } = string.Empty;

    public void Display()
    {
        Console.WriteLine($"ID: {StudentId}; Name: {Name}");
    }
}