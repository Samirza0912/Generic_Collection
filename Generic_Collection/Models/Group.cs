using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic_Collection.Models
{
    public class Group
    {
        private static int No;
        public int no { get; set; }

        public Group(int no)
        {
            string a = "AP101";

            No = no;
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
                Console.WriteLine($"{student.Id}; {student.Name}; { student.Surname}; { student.Age}; { student.Point}");
            }
        }
        public static void Sort()
        {
            Student student = new Student();
            Student[] student1 = { };
            
            for (int i = 0; i < student1.Length - 1; i++)
            {
                for (int j = i + 1; j < student1.Length; j++)
                {
                    if (student1[i] > student1[j])
                    {
                        student = student1[i];
                        student1[i] = student1[j];
                        student1[j] = student;
                    }
                }
            }
            Console.WriteLine(student);
        }


        
    }
}
