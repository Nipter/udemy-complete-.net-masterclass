using System.Collections;

namespace _25_HashTables
{
    internal class Program
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public float GPA { get; set; }

            public Student(int id, string name, float GPA)
            {
                this.Id = id;
                this.Name = name;   
                this. GPA = GPA;
            }
        }
        static void Main(string[] args)
        {
            // Key - Value
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            Student storedStudent1 = (Student)studentsTable[1];

            Console.WriteLine("Student 1 Name: " + storedStudent1.Name);

            //foreach (DictionaryEntry entry in studentsTable)
            //{
            //    Student temp = (Student)entry.Value;
            //    Console.WriteLine("Student Id: " + temp.Id);
            //    Console.WriteLine("Student Name: " + temp.Name);
            //    Console.WriteLine("Student GPA: " + temp.GPA);
            //}

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student Id: " + value.Id);
                Console.WriteLine("Student Name: " + value.Name);
                Console.WriteLine("Student GPA: " + value.GPA);
            }
        }
    }
}
