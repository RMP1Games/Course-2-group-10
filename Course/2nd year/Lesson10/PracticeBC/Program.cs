using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic;
//using Newtonsoft.Json;


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }


    public Person(string name, int age)
    {
        Name = name;
        SetAge(age);
    }


    public void Introduce()
    {
        Console.WriteLine("Hello, my name is " + Name);
    }

    public void SetAge(int newAge)
    {
        if (newAge >= 0)
        {
            Age = newAge;
        }
        else
        {
            Console.WriteLine("Age cannot be negative.");
        }
        
    }
    public string InfoChecker()
    {
        string Agee = Age.ToString();
        string info = Name + " " + Agee;
        return info;
    }
}


public class Employee : Person
{
    public string Position { get; set; }


    public Employee(string name, int age, string position) : base(name, age)
    {
        Position = position;
    }
}

public class PersonFileService
{
    static public void FileWriter(string info)
    {
        using (StreamWriter writer = new StreamWriter("People.txt", true))
        {
            writer.WriteLine(info);
        }   
    }

        static public string FileReader()
    {
        using (StreamReader reader = new StreamReader("People.txt"))
        {
            return reader.ReadToEnd();
        }
    }
}


public class Program
{
    public static void Main() // я так и не понял, нужно ли делать практику C
    {
        // List of people to write to and read from the file
        var people = new List<Person>
        {
            new Person("Alice", 28),
            new Person("Bob", 35),
            new Employee("Charlie", 42, "Manager")
        };


        // Writing people to the file
        //PersonFileService.WritePeopleToFile(people);
        foreach (var person in people)
        {
            PersonFileService.FileWriter(person.InfoChecker());
        }
        // Reading people from the file
        //var peopleFromFile = PersonFileService.ReadPeopleFromFile();
        Console.WriteLine(PersonFileService.FileReader());
        
        foreach (var person in people)
        {
            person.Introduce();
        }

    }
}
