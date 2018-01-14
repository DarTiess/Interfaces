using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFaces;

namespace InterFaces
{
   public class Student : IStudent
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int[] Grades { get; set; }

       public Student(string Name, string FullName, int[] Grades)
        {
            this.Name = Name;
            this.FullName = FullName;
           
            
           
        }
       public string GetName()
        {
            return Name;
        }
       public string GetFullName()
        {
            return FullName;

        }
      public double GetAvgGrade(int grad)
        {
            double avg;
            
            avg =grad / 10.0;
            return avg;
           }
      

    
    }

}