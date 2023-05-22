using StudentList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danh_sach_hoc_sinh
{
    internal class Teacher : Person
    {
       
        public string Subj { get; set; }

        public Teacher(int id, string firstName, string lastName, int birthYear, string subj) 
        {
            this.Id = id;
            this.Firstname = firstName;
            this.Lastname = lastName;
            this.Birthyear = birthYear;
            this.Subj = subj;
        }


    }
}
