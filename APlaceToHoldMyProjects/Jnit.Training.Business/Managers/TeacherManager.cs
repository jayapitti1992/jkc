using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

using Jnit.Training.Business.Entities;

namespace Jnit.Training.Business.Managers
{
    public class TeacherManager
    { 

        private List<Teacher> _teachers;
        public TeacherManager()
        {
            _teachers = new List<Teacher>();
        }

        //Add Teacher

        public void AddTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void PrintTeachers()
        {
            foreach(Teacher teachers in _teachers)
            {
                Console.WriteLine("name of the teacher :" + teachers.Name + " id of the teacher: " + teachers.Id + " grade of the teacher: " + teachers.Grade);
            }
        }

        public void GetTeacherByStudent(string Localgrade)
        {
            foreach(Teacher teacher in _teachers)
            {
                if(Localgrade == teacher.Grade )
                {
                    Console.WriteLine(teacher.Name + " this is the name of teacher for students  in the garde :" + Localgrade);
                    break;
                }
            }
        }

    }
}
