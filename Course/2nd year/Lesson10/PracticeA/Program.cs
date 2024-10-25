namespace PracticeA;
class FileOperations
{
    static public void FileWriter(string text)
    {
        using (StreamWriter writer = new StreamWriter("test.txt", true))
        {
            writer.WriteLine(text);
        }   
    }
    static public string FileReader()
    {
        using (StreamReader reader = new StreamReader("test.txt"))
        {
            return reader.ReadToEnd();
        }
    }
    static void Main(string[] args)
    {   
        Console.WriteLine("Type some text to save it in file");
        string text = Console.ReadLine();
        FileWriter(text);
        
        Console.WriteLine("Succesful! Now file have: " + FileReader());
    }
}
