using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jnit.Training.Business.Managers;
using Jnit.Training.Business.Entities;



namespace Jnit.Training.UI
{
    class Program
    {
        public static StudentManager newStudentManager;
        public static TeacherManager teacherManager;
        //public static void ManagerMethod()
        //    {
        //            newStudentManager = new StudentManager();
        //            teacherManager = new TeacherManager();

        //}
        public  static void Main(string[] args)
        {
            // ManagerMethod();
            teacherManager = new TeacherManager();
            newStudentManager = new StudentManager();
            Teacher teacher1 = new Teacher
            {
                Id = 453,
                Grade = "3",
                Name = "rita"
            };
            Teacher teacher2 = new Teacher
            {
                Id = 452,
                Grade = "1",
                Name = "sonia"
            };
            Teacher teacher3 = new Teacher
            {
                Id = 433,
                Grade = "2",
                Name = "mounica"
            };
                 teacherManager.AddTeacher(teacher1);
                 teacherManager.AddTeacher(teacher2);
                 teacherManager.AddTeacher(teacher3);
           
            MainMenu();
        }
          public static void MainMenu()
        { 
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("\n please enter the selection to perfrom operations:\n'enter 1 to addStudent '\n'enter 2 to removeStudent'\n'enter 3 to updateStudent'\n'enter 4 to getStudent'\n'enter 5 to getOldestStudent'\n'enter 6 to getTeacherByStudentGrade'\n'enter 7 to printTeacher'\n'enter 0 to terminate'");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddMenu();
                         break;
                    case 0:
                        repeat = false;
                        break;
                    case 2:
                        RemStudent();
                        break;
                    case 3:
                        UpdateStud();
                        break;
                    case 4:
                        getStudent();
                        break;
                    case 5:
                        newStudentManager.OldestStudent();
                        break;
                    case 6:Console.WriteLine("enter the grade of the student for the teacher details ");
                        teacherManager.GetTeacherByStudent(Console.ReadLine());
                        break;
                    case 7:
                        teacherManager.PrintTeachers();
                        break;


                }
            }
    
        }
        public static void getStudent()
        {
            
            Console.WriteLine("please pass 'id' of the student you want to get details of ");
            long Id = int.Parse(Console.ReadLine());

            newStudentManager.GetStudentById(Id);
        }
       
        public static void  AddMenu()
        {
           
            Student studentDynamic = new Student();
            Console.WriteLine("please Enter ID:");
            studentDynamic.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("please Enter Name: ");
            studentDynamic.Name = Console.ReadLine();
            Console.WriteLine("please Enter Grade: ");
            studentDynamic.Grade = Console.ReadLine();
            Console.WriteLine("please Enter  the age: ");
            studentDynamic.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the Rollnumber: ");
            studentDynamic.RollNumber = Console.ReadLine();
           
            // CountStudents();
            //       Console.WriteLine("please eneter the Bday mm/dd/yyyy format ");
            //studentDynamic.DateOfBirth = DateTime.Parse(Console.ReadLine());
            studentDynamic.DateOfBirth = DateTime.Parse("10/10/1998");
            newStudentManager.AddStudent(studentDynamic);
            newStudentManager.StudentsCount();
        }
        public static void RemStudent()
        {
            
            Console.WriteLine("please Enter ID:");
            int Id = int.Parse(Console.ReadLine());
            newStudentManager.RemoveStudent(Id);
            newStudentManager.StudentsCount();
            

        }
        public static void UpdateStud()
        {
            Console.WriteLine("please pass 'id' of the student you want to update");
            int Id = int.Parse(Console.ReadLine());
            newStudentManager.UpdateStudent(Id);
        }


    }
}   
