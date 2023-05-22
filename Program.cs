
using Danh_sach_hoc_sinh;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;


namespace StudentList
{

    public class Program
    {
        public static void Main()
        {


            StudentList studentList = new StudentList();
            studentList.InitData(10);

            string jsonString1 = JsonSerializer.Serialize(studentList.GetStudents(), new JsonSerializerOptions { WriteIndented = true });
            jsonString1 = jsonString1.Replace("},", "},\n");
            Console.WriteLine(jsonString1);

            //Console.Write("Enter student ID: ");
            //int id = Convert.ToInt32(Console.ReadLine());
            string jsonString2 = JsonSerializer.Serialize(studentList.GetStudentById(5-1));
            Console.WriteLine(jsonString2);
            Console.WriteLine("\n====================================");
            Console.WriteLine("\n====================================");

            //Console.Write("Enter student first name: ");
            //string firstName = Console.ReadLine();
            List<Student> studentsWithFirstName = studentList.GetAllByFirstName("Do");
            string jsonString3 = JsonSerializer.Serialize(studentsWithFirstName, new JsonSerializerOptions { WriteIndented = true });
            jsonString3 = jsonString3.Replace("},", "},\n");
            Console.WriteLine(jsonString3);

            Console.WriteLine("\n====================================");
            Console.WriteLine("\n====================================");

            Console.Write("Top 5 student vippro: ");
            List<Student> top5student = studentList.GetTop5Students();
            string jsonString4 = JsonSerializer.Serialize(top5student, new JsonSerializerOptions { WriteIndented = true });
            jsonString4 = jsonString4.Replace("},", "},\n");
            Console.WriteLine(jsonString4);
            Console.WriteLine("\n====================================");
            Console.WriteLine("\n====================================");

            Console.WriteLine("\nSorting the list by descending order of total score:");
            studentList.QuickSort(studentList.GetStudents(), 0, studentList.GetStudents().Count - 1);
            string jsonString5 = JsonSerializer.Serialize(studentList.GetStudents(), new JsonSerializerOptions { WriteIndented = true });
            jsonString5 = jsonString5.Replace("},", "},\n");
            Console.WriteLine(jsonString5);

            Console.WriteLine("\n====================================");
            Console.WriteLine("\n====================================");

            Console.WriteLine("\nTeacher List: ");
            TeacherList teacherList = new TeacherList();
            teacherList.InitData(10);
            string jsonString6 = JsonSerializer.Serialize(teacherList.Getteacher(), new JsonSerializerOptions { WriteIndented = true });
            jsonString6 = jsonString6.Replace("},", "},\n");
            Console.WriteLine(jsonString6);




            //Console.WriteLine(StudentList.ConvertToJSON(studentList.students));



            //Console.Write("Enter student ID: ");
            //int id = Convert.ToInt32(Console.ReadLine());

            //Student student = studentList.CheckforId(id);
            //if (student == null)
            //{
            //    Console.WriteLine("Student not found");
            //}
            //else
            //{
            //    Console.WriteLine(StudentList.ConvertToJSON(new List<Student>() { student }));

            //    Console.Write("Enter student first name: ");
            //    string firstName = Console.ReadLine();

            //    List<Student> studentsWithFirstName = studentList.FindAllByFirstName(firstName);

            //    Console.WriteLine(StudentList.ConvertToJSON(studentsWithFirstName));
            //}
            //Console.WriteLine("\n====================================");
            //Console.WriteLine("\n====================================");



            //Console.WriteLine("\nTop 5 students with highest average score:");
            //List<Student> top5Students = studentList.GetTop5Students();
            //Console.WriteLine(StudentList.ConvertToJSON(top5Students));
            //Console.WriteLine("\n====================================");
            //Console.WriteLine("\n====================================");

            //Console.WriteLine("\nSorting the list by descending order of total score:");
            //studentList.QuickSort(studentList.students, 0, studentList.students.Count - 1);
            //Console.WriteLine(StudentList.ConvertToJSON(studentList.students));


        }
    }
    }







    
    

