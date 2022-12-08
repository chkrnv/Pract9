using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pract9
{
    internal struct Salary
    {
        public string EmployeeName {get; set;}      
        public string Gender { get; set;}
        public string Post {get; set;}
        public int WorkExperience { get; set; }
        public int Wages { get; set; }

        public Salary (string employeeName, string gender, string post, int workExperience, int wages)
        {
            EmployeeName = employeeName;
            Gender = gender;
            Post = post;
            WorkExperience = workExperience;
            Wages = wages;
        }      

    }
}
