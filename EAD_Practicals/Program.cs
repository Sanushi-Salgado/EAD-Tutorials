using System;
using System.Collections.Generic;

namespace EAD_Practicals
{
    public class Program
    {
        public static void Main()
        {
            Person Fred = new Person();
            Console.WriteLine(Person.People());
            Fred.SetAge(25);
            Console.WriteLine($"Fred is {0}", Fred.GetAge());

            Person Jim = new Person();
            Console.WriteLine(Person.People());



            // Tutorial 2
            Tutorial2 t2 = new Tutorial2(); 

            Student student = new Student();
            student.Name = "Dirk"; student.LastName = "Strauss"; 
            student.CourseCodes = new List<int> { 203, 202, 101 }; 
            t2.OutputInformation(student); 

            Professor prof = new Professor(); 
            prof.Name = "Reinhardt";
            prof.LastName = "Botha"; 
            prof.TeachesSubjects = new List<string> { "Mobile Development", "Cryptography" }; 
            t2.OutputInformation(prof);

            Student student2 = null;
            t2.OutputInformation(student2);

        }
    }
}
