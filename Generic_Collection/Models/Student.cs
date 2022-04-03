using System;
namespace Generic_Collection.Models
{
    public class Student
    {
        private static int _id;

        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }

        public Student(string name, string surname, int age, int point)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;
            _id++;
            Id = _id;
        }

        public Student()
        {
        }

        public static bool operator >(Student st1, Student st2)
        {
            return st1.Point > st2.Point;
        }
        public static bool operator <(Student st1, Student st2)
        {
            return st1.Point < st2.Point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} Surname: {Surname} Age: {Age} Point: {Point} ID: {Id}");
        }
    }
}
