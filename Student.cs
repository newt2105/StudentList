using Danh_sach_hoc_sinh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
//using System.Text;
//using System.Threading.Tasks;

namespace StudentList
{
    internal class Student : Person
    {


       
        public double Math { get; set; }

        
        public double Phy { get; set; }

       
        public double Chem { get; set; }

        
        public double Total { get; set; }
        public double TotalScore()
        {
            return Phy + Math + Chem;
        }

        public Student(int id, string firstName, string lastName, int birthYear, double math, double phy, double chem, double total)
        {
            this.Id = id;
            this.Firstname= firstName;
            this.Lastname= lastName;
            this.Birthyear= birthYear;
            this.Math = math;
            this.Phy = phy;
            this.Chem = chem;
            this.Total = total;
            
        }

        






        //public static string ConvertToJSON(List<Student> studentList)
        //{
        //    string json = "";
        //    json += "\"studentsList\": \n\n";
        //    foreach (Student student in studentList)
        //    {
        //        json += "{\n";
        //        json += "\"id\": " + student.Id + ",\n";
        //        json += "\"Name\": \"" + student.LastName + " " + student.FirstName + "\",\n";
        //        json += "\"birthYear\": " + student.BirthYear + ",\n";
        //        json += "\"Math\": " + student.Math + ",\n";
        //        json += "\"Phy\": " + student.Phy + ",\n";
        //        json += "\"Chem\": " + student.Chem + ",\n";
        //        json += "\"TotalScore\": " + student.TotalScore();
        //        json += "\n}, \n";
        //        json += "\n";
        //    }
        //    json = json.TrimEnd(',');
        //    json += "}";

        //    return json;
        //}
    }
}

