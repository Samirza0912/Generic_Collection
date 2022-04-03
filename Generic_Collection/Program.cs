using System;
using Generic_Collection.Models;

namespace Generic_Collection
{
    class Program
    {
        /*1.1 Student class
- Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və
        hər dəfə yeni bir Student obyekt yaradıldıqda avtomatik bir vahid artacaq.
- Name
- Surname
- Age
- Point
- ShowInfo() - student-in bütün məlumatlarını geriyə qaytaracaq.

'>' və '<' operatorları üçün operator overloading yazırsız və Point dəyərlərini müqayisə edir.

ps: Name, surname, point dəyərləri olmadan student obyekti yaratmaq olmaz

1.2 Group class
- No - qıraqdan set etmək olmayacaq yalnız get etmək olacaq hər
dəfə yeni bir Group obyekt yaradıldıqda avtomatik qrup nömrəsinin rəqəm hissəsi bir vahid artacaq
ilk yaradılacaq qrupun qrup nönmrəsi AP101 olacaq
ikinci dəfə qrup yaradan zaman avtomatik AP102 olacaq bu şəkildə
hər dəfə yeni qrup yaradılanda rəqəm hissəsi artacaq.
- Students array - private olacaq, Student obyektilərini özündə saxlayacaq.
- AddStudent() - bu metod studnet type-da studnet qebul edir ve Students array-e elave edir.
- GetAllStudents() - geriyə bütün studentləri qaytaracaq.
- Sort() - parametr olaraq heç nə qəbul etməyəcək,
Students arrayindəki studentləri Point dəyərlərinə görə sort edib
(azdan çoxa sıralamaq) geriyə bir Student tipindən sort olunmuş bir array qaytaracaq

Sort methodundan istifadə edərkən bir başa students array-i üzərində sort əməliyyatını aparmayın
        students arrayinin bir copy-ni yaradın onun üzərində sort əməliyyatı aparın
        və geriyə həmin copy olunmuş arrayi qaytarın.


1.3 Program class
a) 4 dənə student obyekti yaradın qarışıq point dəyərlərində.
b) Group obyekti yaradın və group obyektinə AddStudent methodundan istifadə edərək studentləri əlavə edin.
c) GetAllStudents methodundan istifadə edərək bütün studentləri ekrana çıxardın.
d) Sort methodundan istifadə edərək sort olunmuş studentləri ekrana çıxardın.
e) İkinci bir Group obyketi yaradın və qrup nömrəsinin avtomatik artmağını yoxlayın.
         */
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please write the student's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please write the student's surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Please write the student's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write the student's point: ");
            int point = int.Parse(Console.ReadLine());

            Student student = new Student(name,surname,age,point);
            student.Name = name;
            student.Surname = surname;
            student.Age = age;
            student.Point = point;

            student.ShowInfo();

            Student student1 = new Student("Bukayo", "Saka", 20, 81);
            Student student2 = new Student("Emil", "Smith-Rowe", 21, 77);
            Student student3 = new Student("Martin", "Odegaard", 22, 83);
            Student student4 = new Student("Gabriel", "Martinelli", 20, 76);


            Group group = new Group();
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.AddStudent(student4);

            Console.WriteLine(student3 > student4);

            group.GetAllStudents();

            Group.Sort();

            Console.WriteLine(group);

            
        }
    }
}
