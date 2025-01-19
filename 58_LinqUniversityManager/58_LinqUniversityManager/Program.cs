using System;
using System.Collections.Generic;
using System.Linq;

namespace _58_LinqUniversityManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UniversityManager universityManager = new UniversityManager();

            universityManager.MaleStudents();
            universityManager.FemaleStudents();
            universityManager.SortStudentByAge();
            universityManager.AllStudentsFromBeijingTech();
            universityManager.AllStudentsFromThatUni(1);
            universityManager.StudentAndUniversityNameCollection();

            int[] numbers = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in numbers orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();

            Console.WriteLine("Sorted ints");
            foreach (var item in sortedInts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Reversed sorted ints");
            foreach (var item in reversedInts)
            {
                Console.WriteLine(item);
            }

            reversedInts = from i in numbers orderby i descending select i;
            Console.WriteLine("Reversed sorted ints");
            foreach (var item in reversedInts)
            {
                Console.WriteLine(item);
            }
        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            //Let's add some Universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            //Let's add some Students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "James", Gender = "female", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 6, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;

            Console.WriteLine("Male students");
            foreach (var item in maleStudents)
            {
                item.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "female" select student;

            Console.WriteLine("Female students");
            foreach (var item in maleStudents)
            {
                item.Print();
            }
        }

        public void SortStudentByAge()
        {
            IEnumerable<Student> sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Sorted students by age");
            foreach (var item in sortedStudents)
            {
                item.Print();
            }
        }

        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Student> beijingTechStudents = from student in students
                                                       join university in universities on student.UniversityId equals university.Id
                                                       where university.Name == "Beijing Tech"
                                                       select student;

            Console.WriteLine("Beijing Tech students");
            foreach (var item in beijingTechStudents)
            {
                item.Print();
            }
        }

        public void AllStudentsFromThatUni(int id)
        {
            IEnumerable<Student> myStudents = from student in students where student.UniversityId == id select student;

            Console.WriteLine("Students from uni: " + id);
            foreach (var item in myStudents)
            {
                item.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collection:");
            foreach (var item in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", item.StudentName, item.UniversityName);
            }
        }
    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }    

        public void Print()
        {
            Console.WriteLine("University {0} with id {1}", Name, Id);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with id {1}, UniversityId {2}, Gender {3}, Age {4}", Name, Id, UniversityId, Gender, Age);
        }
    }
}
