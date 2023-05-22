using StudentList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danh_sach_hoc_sinh
{
    internal class TeacherList
    {
        private List<Teacher> teachers;
        internal List<Teacher> Getteacher()
        {
            return this.teachers;
        }

        public TeacherList()
        {
            teachers = new List<Teacher>();
        }

        private void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void ShowInformation()
        {
            foreach (Teacher teacher in teachers)
            {
                Print(teacher);

            }
        }

        private void Print(Teacher teacher)
        {
            Console.WriteLine("ID: " + teacher.Id + ", Name: " + teacher.Firstname + " " + teacher.Lastname + ", Birth Year: " + teacher.Birthyear + "Subj: " +teacher.Subj);
        }

        public void InitData(int numTeacher)
        {
            Random random = new Random();
            string[] firstNames = { "Tran", "Le", "Pham", "Phan", "Nguyen", "Do", "Hoang", "Duong", "Vo", "Dang" };
            string[] lastNames = { "Minh", "Nam", "Phong", "Linh", "Hue", "Quang", "Nhat", "Khanh", "Thao", "Trung" };
            string[] subjects = { "phy", "chem", "math" };
            for (int i = 1; i <= numTeacher; i++)
            {
                string firstName = firstNames[random.Next(firstNames.Length)];
                string lastName = lastNames[random.Next(lastNames.Length)];
                string subject = subjects[random.Next(subjects.Length)];
                int birthYear = random.Next(1970, 1990);
                Teacher teacher = new Teacher(i, firstName, lastName, birthYear, subject);
                teachers.Add(teacher);
            }
        }
    }
}
