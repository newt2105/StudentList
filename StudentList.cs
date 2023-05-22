using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    public class StudentList
    {
        private List<Student> students;
        internal List<Student> GetStudents()
        {
            return this.students;
        }

        public StudentList()
        {
            students = new List<Student>();
        }

        private void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void ShowInformation()
        {
            foreach (Student student in students)
            {
                Print(student);
               
            }
        }
        private void Print(Student student)
        {
            Console.WriteLine("ID: " + student.Id + ", Name: " + student.Firstname + " " + student.Lastname + ", Birth Year: " + student.Birthyear + ", Math: " + student.Math + ", Phy: " + student.Phy + ", Chem: " + student.Chem + ", Total Score: " + student.TotalScore());
        }

        private Student CheckforId(int id)
        {
            return students[id];
        }
        internal Student GetStudentById(int id)
        {
            return CheckforId(id);
        }



        private List<Student> FindAllByFirstName(string firstName)
        {
            return students.Where(s => s.Firstname == firstName).ToList();
        }

        internal List<Student> GetAllByFirstName(string firstName)
        {
            return FindAllByFirstName(firstName);
        }

        private List<Student> FindTop5Students()
        {
            return students.OrderByDescending(s => s.TotalScore()).Take(5).ToList();
        }
        internal List<Student> GetTop5Students()
        {
            return FindTop5Students();
        }

        private int Partition(List<Student> arr, int low, int high)
        {
            Student pivot = arr[high];

            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j].TotalScore() >= pivot.TotalScore())
                {
                    i++;
                    Student temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            Student temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        internal void QuickSort(List<Student> arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }



        public void InitData(int numStudent)
        {
            Random random = new Random();
            string[] firstNames = { "Tran", "Le", "Pham", "Phan", "Nguyen", "Do", "Hoang", "Duong", "Vo", "Dang" };
            string[] lastNames = { "Minh", "Nam", "Phong", "Linh", "Hue", "Quang", "Nhat", "Khanh", "Thao", "Trung" };
            for (int i = 1; i <= numStudent; i++)
            {
                string firstName = firstNames[random.Next(firstNames.Length)];
                string lastName = lastNames[random.Next(lastNames.Length)];
                int birthYear = random.Next(2000, 2010);
                double math = random.Next(1, 11);
                double phy = random.Next(1, 11);
                double chem = random.Next(1, 11);
               double totalscore = math + phy + chem;
                Student student = new Student(i , firstName , lastName , birthYear , math , phy , chem, totalscore);
                students.Add(student);
            }
        }

        //public static string ConvertToJSON(List<Student> studentList)
        //{
        //    string json = "";
            
        //    foreach (Student student in studentList)
        //    {
        //        json += "{\n";
        //        json += "       \"id\": " + student.Id + ",\n";
        //        json += "       \"Name\": \"" + student.LastName +" " +student.FirstName +"\",\n";
        //        json += "       \"birthYear\": " + student.BirthYear + ",\n";
        //        json += "       \"Math\": " + student.Math + ",\n";
        //        json += "       \"Phy\": " + student.Phy + ",\n";
        //        json += "       \"Chem\": " + student.Chem + ",\n";
        //        json += "       \"TotalScore\": " + student.TotalScore();
        //        json += "\n}, \n";
        //        json += "\n";
        //    }
        //    json = json.TrimEnd(',');
        //    json += "}";

        //    return json;
        //}


    }
}