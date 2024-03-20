using StreamsDemoPrep2024;
namespace StreamsDemoPrep2024Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void TestStudentDisplay()
    {
        using var writer = new StringWriter();
        Console.SetOut(writer);
        var student = new Student { StudentId = 1, Name = "Bob" };
        student.Display();
        Assert.IsTrue(writer.ToString().Contains("ID: 1; Name: Bob"));
    }
}
