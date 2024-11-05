using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public Dictionary<string, int> Grades { get; set; }
    public Dictionary<string, bool> Attendance { get; set; }

    public Student(string name)
    {
        Name = name;
        Grades = new Dictionary<string, int>();
        Attendance = new Dictionary<string, bool>();
    }

    public void AddGrade()
    {
        Console.Write("Vvedite predmet: ");
        string subject = Console.ReadLine();

        Console.Write("Vvedite ocenku: ");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            Grades[subject] = grade;
            Console.WriteLine($"Ocenka {grade} po predmetu '{subject}' dobavlena.");
        }
        else
        {
            Console.WriteLine("Nekorrektnyj vvod. Ocenka ne dobavlena.");
        }
    }

    public void AddAttendance()
    {
        Console.WriteLine("Vvedite dannye o posechaemosti (format: 'data=true/false'):");
        string input = Console.ReadLine();
        var parts = input.Split('=');
        if (parts.Length == 2 && DateTime.TryParse(parts[0], out DateTime date))
        {
            bool wasPresent = parts[1].ToLower() == "true";
            Attendance[date.ToLongDateString()] = wasPresent;
            Console.WriteLine("Dannye o posechaemosti dobavleny.");
        }
        else
        {
            Console.WriteLine("Nekorrektnyj vvod. Dannye o posechaemosti ne dobavleny.");
        }
    }
}


public class StudetnFileService
{
    public const string FilePath = "students.txt";
    public Dictionary<string, Student> students = new Dictionary<string, Student>();

    public StudetnFileService(Dictionary<string, Student> data)
    {
        students = data;
    }

    public  void SaveToFile(string filePath=FilePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            foreach (var student in students.Values)
            {
                string grades = string.Join(";", student.Grades.Select(g => $"{g.Key}:{g.Value}"));
                string attendance = string.Join(";", student.Attendance.Select(a => $"{a.Key}:{a.Value}"));
                writer.WriteLine($"{student.Name},{grades},{attendance}");
            }
        }
    }
 public void LoadFromFile(string filePath = FilePath)
{
    if (!File.Exists(filePath))
    {
        Console.WriteLine("Файл не найден.");
        return;
    }

    using (var reader = new StreamReader(filePath))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var parts = line.Split(',');
            if (parts.Length < 3)
            {
                continue; // Переход к следующей строке, если формат неверен
            }

            var studentName = parts[0];
            var student = new Student(studentName);

            // Чтение оценок
            var gradesPart = parts[1].Split(':');
            if (gradesPart.Length == 2 && int.TryParse(gradesPart[1], out int grade))
            {
                student.Grades.Add(gradesPart[0], grade);
            }

            // Чтение данных о посещаемости
            var attendancePart = parts[2].Split(':');
            if (attendancePart.Length == 2 && DateTime.TryParse(attendancePart[0], out DateTime date) && bool.TryParse(attendancePart[1], out bool wasPresent))
            {
                student.Attendance.Add(date.ToLongDateString(), wasPresent);
            }

            students.Add(student.Name, student);
        }
    }
}

     
}

class SimpleDB
{
    private StudetnFileService fileService;
    public SimpleDB()
    {
        fileService = new StudetnFileService(students);
        LoadDB();
    }
    public  Dictionary<string, Student> students = new Dictionary<string, Student>();

    public void SaveDB()
    {
        fileService.SaveToFile();
    }

    public void LoadDB()
    {
        fileService.LoadFromFile();
    }
    public void AddStudent(string name)
    {
        var student = new Student(name);
        students[name] = student;
        Console.WriteLine($"Add a student: {name}.");
    }

    public void RemoveStudent(string name)
    {
        if (students.Remove(name))
            Console.WriteLine($"Student {name} deleted.");
        else
            Console.WriteLine($"Student {name} not found");
    }

    public void ShowStudentInfo(string name)
    {
        if (students.ContainsKey(name))
        {
            var student = students[name];
            Console.WriteLine($"Name: {student.Name}");
            Console.Write("Grades: ");
            foreach (var info in student.Grades)
            {
                Console.WriteLine($"{info.Key}: {info.Value}");
            }
            Console.Write("Info about poseshaemost: ");
            foreach (var info in student.Attendance)
            {
                Console.WriteLine($"{info.Key} - {info.Value}");
            }
        }
        else
        Console.WriteLine($"Student {name} not found.");
    }

    public Student GetStudent(string name)
    {
        if (students.TryGetValue(name, out var student))
        {
            return student;
        }
        else
        {
            Console.WriteLine("Student ne najden.");
            return null;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var db = new SimpleDB(); 
        while (true)
        {
            Console.WriteLine("\n1. Add a student\n2. See info about student\n3. Delete student\n4. Add grade\n5. Add poseshaemost'\n6 Save info to DB\n7 Download info from DB\n0. Vixod");
            Console.Write("Vibor: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Nepravilno. Eshe raz.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();
                    db.AddStudent(name);
                    break;
                case 2:
                    Console.Write("Enter student name (info): ");
                    name = Console.ReadLine();
                    db.ShowStudentInfo(name);
                    break;
                case 3:
                    Console.Write("Enter student name for delete: ");
                    name = Console.ReadLine();
                    db.RemoveStudent(name);
                    break;
                case 4:
                    Console.Write("Enter student name (Grade): ");
                    name = Console.ReadLine();
                    Student student = db.GetStudent(name);
                    student?.AddGrade();
                    break;
                case 5:
                    Console.Write("Enter student name (poseshaemost'): ");
                    name = Console.ReadLine();
                    student = db.GetStudent(name);
                    student?.AddAttendance();
                    break;
                case 6:
                    Console.WriteLine("Saved.");
                    db.SaveDB();
                    break;
                case 7:
                    Console.WriteLine("Downloaded.");
                    db.LoadDB();
                    break;

                case 0:
                    return;
                default:
                    Console.WriteLine("Nepravilno. Eshe raz.");
                    break;
            }
        }
    }
}
