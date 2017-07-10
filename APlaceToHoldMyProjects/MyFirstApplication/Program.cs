using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    class Program
    {
        //constructor
        //Something to hold Data : Variables /Properties
        //function /methods
        //

        static void Main(string[] args)
        {
            double > grades = new Dictionary<string, double>();

            Student studentNo1 = new Student
            {

               Id = 1234,
               Name = "abrham",
               Age = 25,
                Dictionary < string,
               
            Grades = ["science",9.0],

               //Grades["science"] = 4.0,

                Grades.Add("science",4.0),

          //    studentNo1.Age = 21,
          //  studentNo1.Name = "Abrham",
          //  studentNo1.Id = 1234,
          ////  Dictionary<string, double> grades = new Dictionary<string, double>();
          //  grades.Add("Science", 4.0)
          //  grades.Add("Math", 3.5)
          //  grades.Add("CS", 3.0)
          //  studentNo1.Grades = grades

        };
            Student studentNo2 = new Student();
            Student studentNo3 = new Student();


           


            List<Student> students = new List<Student>();
            students.Add(studentNo1);
            students.Add(studentNo2);
            students.Add(studentNo3);

            StudentManager studentManger = new StudentManager();
            int ageOfEldestStudent = studentManger.EldestStudent(students);

            Console.WriteLine(ageOfEldestStudent);
            
            Console.ReadLine();





            //try
            //catch
            //finally

            ////DataType variableName;
            //string name;
            //int age;

            //Console.WriteLine("Enter Name");
            //name = Console.ReadLine();
            //Console.WriteLine("My Name is" + name);

            
            //Console.WriteLine("Enter Age");

            //age = int.Parse(Console.ReadLine());


            ////conditional statements

            //Console.WriteLine(CanIDrive(age));

            //PrintGrades();

            //Console.ReadLine();

            //List<int> grades = new List<int>();


        }
        
        private static string CanIDrive(int age)
        {
            if (age > 16)
            {
                return "I can drive";
            }
            else
            {
                return "I cannot drive";
            }
        }


        private static void PrintGrades()
        {
            //Array
            string[] names = { "A", "B", "C" };
            int[] grades = { 3, 4, 5 };

            //List
            List<string> namesInList = new List<string> { "A", "B", "C" };
            

            //Dictionary

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            foreach (string name in namesInList)
            {
                Console.WriteLine("Hello " + name);
            }

        }

        private void Student()
        {
            long studentId = 123;
            string studentName = "John";
            byte age = 25;
        }


    }


}
