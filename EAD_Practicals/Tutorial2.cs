using System;

namespace EAD_Practicals
{
    class Tutorial2
    {
        public void OutputInformation(object person)
        {
            /*
            if (person is null)
            {
                Console.WriteLine("Object person is null");
            }
            if (person is Student)
            {
                Student student = (Student)person;
                Console.WriteLine($"Student {student.Name} {student.LastName} is enrolled for courses {String.Join<int>(", ", student.CourseCodes)}");
            }
            if (person is Professor)
            {
                Professor prof = (Professor)person;
                Console.WriteLine($"Professor {prof.Name} {prof.LastName} teaches {String.Join<string>(",", prof.TeachesSubjects)}");
            }*/


            switch (person)
            {
                case Student student when (student.CourseCodes.Contains(203)):
                    Console.WriteLine($"Student {student.Name} {student.LastName} is enrolled for course 203."); 
                    break;
                case Student student: Console.WriteLine($"Student {student.Name} {student.LastName} is enrolled for courses {String.Join<int>(", ", student.CourseCodes)}"); 
                    break;
                case Professor prof: Console.WriteLine($"Professor {prof.Name} {prof.LastName} teaches {String.Join<string>(",", prof.TeachesSubjects)}"); 
                    break;
                case null: Console.WriteLine($"Object {nameof(person)} is null"); 
                    break;
                default: Console.WriteLine("Unknown object detected"); 
                    break;
            }
        }
    }
}
