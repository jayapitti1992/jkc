using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jnit.Training.Business.Entities;

namespace Jnit.Training.Business.Managers
{
    public class StudentManager
    {
        

        private List<Student> _students = new List<Student>();
        public StudentManager()
        {
            _students = new List<Student>();
        }

        //OldestStudent 
        public void OldestStudent()
        {
            int largestAge = 0;
            string stdName = "name";
            foreach (Student value in _students)
            {
              if (largestAge <= value.Age)
                {
                    largestAge = value.Age;
                    stdName = value.Name;
                }
               
            }
           
       Console.WriteLine(stdName + " this is the name of student with the highst age of  :" + largestAge);
           
        }

        //GetStudentsByGrade 
        public void GetStudentById(long localId)
        {
            foreach(Student value in _students)
            {
                if(value.Id == localId)
                {
                    Console.WriteLine(value.Name+ " this is the name of student in garde :"+localId +"with age"+value.Age );
                }
            }
        }

        //UpdateStudent 
        public void UpdateStudent(int id_value)
        {
            foreach (Student Student_value in _students)
            {
                if (Student_value.Id == id_value)
                {
                    Console.WriteLine("please type in the field you would like to update'id',''name','age' ");
                    string switch_value = Console.ReadLine();
                    switch(switch_value)
                    {
                        case "id" : Console.WriteLine("please type in new ID value :");
                            Student_value.Id = int.Parse(Console.ReadLine());
                            break;
                        case "name":
                            Console.WriteLine("please type in new name value :");
                            Student_value.Name = Console.ReadLine();
                            break;
                        case "age":
                            Console.WriteLine("please type in new age value :");
                            Student_value.Age = int.Parse(Console.ReadLine());
                            break;

                    }
                  //  Console.WriteLine(Student_value.Name+"" " this is the name of student in garde :" + localGrade);
                }
            }

        }
            

        //Code to print the Student from the list
        public void PrintStudent(Student student)
        {
            Console.WriteLine("this is the name of student " + student.Name);
        }


        //Code to add the Student to the list
        public void AddStudent(Student student)
        {
            _students.Add(student);
            Console.WriteLine("this is the name of student " + student.Name);
        }

        //Code to count the Student from the list
        public void StudentsCount()
        {

            Console.WriteLine("this is the total number of student in the list "+_students.Count);
            foreach(Student values in _students)
            {

                Console.WriteLine("all names in the student list " + values.Name);
            }

        }
        //Code to remove the Student from the list
        public void RemoveStudent(long value)
        {
            foreach(Student member in _students)
            {
                if (member.Id == value)
                {
                    _students.Remove(member);
                    Console.WriteLine("the student with the id " + member.Id + " has been removed");
                    break;
                }
            }
           
        }
       

    }
}
