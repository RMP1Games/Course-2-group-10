using System;
using System.Collections.Generic;
using System.Runtime.Loader;

namespace SimpleBD
{     
    class Student
    {
        public string Name { get; set; }
        public Dictionary<string, int> Grades { get; set; }
        public List<string> Attendance { get; set; }

        public Student(string name)
        {
            Name = name;
            Grades = new Dictionary<string, int>();
            Attendance = new List<string>();
        }

        public void AddGrade(string subject, int grade)
        {
            Grades[subject] = grade;
        }

        public void AddAttendance(string date)
        {
            Attendance.Add(date);
        }
    }

    class SimpleDB
    {
        private Dictionary<string, Student> students = new Dictionary<string, Student>();

        public void AddStudent(Student student)
        {
            students[student.Name] = student;
        }

        public void RemoveStudent(string name)
        {
            students.Remove(name);
        }

        public void ShowStudentInfo(string name)
        {
            if (students.ContainsKey(name))
            {
                var student = students[name];
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine("Grades:");
                foreach (var grade in student.Grades)
                {
                    Console.WriteLine($"{grade.Key}: {grade.Value}");
                }
                Console.WriteLine("Attendance:");
                foreach (var date in student.Attendance)
                {
                    Console.WriteLine(date);
                }
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }

        class Person
    {
        public string name;
        public int age;
        public void Introduce()
        {
            Console.WriteLine("Hello, my name is " + name);
        }
        // public void AgeChecker(int Age)
        // {
        //     if (Age < 0)
        //     Console.WriteLine("Your age can't be smaller than 0.");
        //     else
        //     age = Age;
        // }
        public Person (string Name, int Age)
        {
            name = Name;
            if (Age < 0)
            Console.WriteLine("Age < 0. Write real age.");
            else
            age = Age;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello world!");

            Console.WriteLine("=====================");

            Person person1 = new Person("Alex", 16);
            person1.Introduce();

            Console.WriteLine("=====================");

            Person name1 = new Person("Sasha", 16);
            Person name2 = new Person("Max", 15);
            Person name3 = new Person("Anna", 16);
            Person name4 = new Person("Artem", 14);
            Person[] names = {name1, name2, name3, name4};

            foreach (Person name in names)
            {
                name.Introduce();
            }
            
            Console.WriteLine("=====================");

            Person person2 = new Person("Misha", -2);
        }
    }
}