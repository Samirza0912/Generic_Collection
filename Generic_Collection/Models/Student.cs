using System;
namespace Generic_Collection.Models
{
    public class Student
    {
        private static int _id;
        public string Name;
        public string Surname;
        public int Age;
        public int Point;

        public int id { get; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public int point { get; set; }

        public Student(string name, string surname, int age, int point)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;
            _id++;
            id = _id;
        }
        public static bool operator > (Student st1, Student st2, Student st3, Student st4)
        {
            return st1.Point > st2.Point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name} Surname: {surname} Age: {age} Point: {point} ID: {id}");
        }
    }
}
