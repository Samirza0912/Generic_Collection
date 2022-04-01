using System;
using System.Collections.Generic;

namespace Generic_Collection.Models
{
    public class Group
    {
        private static int No;
        public int no { get; set; }

        public Group(int no)
        {
            No = no;
            No = 101;
            No++;
        }

        public Group()
        {
        }

        List<Student> students = new List<Student>();

        public void AddStudent(Student st)
        {
            students.Add(st);
        }

        public void GetAllStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.id}; {student.Name}; { student.Surname}; { student.Age}; { student.Point}");
            }
        }


        
    }
}
