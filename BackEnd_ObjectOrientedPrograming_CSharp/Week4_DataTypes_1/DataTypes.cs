using System;
namespace BackEnd_ObjectOrientedPrograming_CSharp.Week4_DataTypes_1
{
    public class DataTypes
    {
        public DataTypes()
        {
            // Value Type
            int i = 1000;
            Console.WriteLine(i);
            ChangeValueType(i);
            Console.WriteLine(i);

            // Reference Type
            Student newStudent = new Student("Jane", "Austen");
            ChangeReferenceType(newStudent);
            Console.WriteLine(newStudent.FullName);

            // Null
            Student nullStudent = new Student();
            Console.WriteLine(nullStudent.FullName);
            // try it with an int
        }

        void ChangeValueType(int x)
        {
            x = 500;
            Console.WriteLine(x);
        }

        void ChangeReferenceType(Student student)
        {
            student.FullName = "John Doe";
        }

        public class Student
        {
            public string FullName { get; set; }

            public Student() { }
            public Student(string firstName, string lastName)
            {
                FullName = $"{firstName} {lastName}";
            }
        }
    }
}
