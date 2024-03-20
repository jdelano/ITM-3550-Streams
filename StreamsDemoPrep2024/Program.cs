namespace StreamsDemoPrep2024;

class Program
{
    static void Main(string[] args)
    {
        // Change the path name below to match your own file system folders
        var path = "/Users/jdelano/test.txt";
        using var writer = new StreamWriter(path);
        writer.WriteLine("Hello world!");
        writer.Close();

        using var reader = new StreamReader(path);
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            Console.WriteLine(line);
        }
        reader.Close();
    }
}

