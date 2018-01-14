using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaces
{
   public interface IStudent
    {
        /*1.	Создать интерфейс IStudent: 
  ●	string Name { get; set; }
  ●	string FullName { get; set; }
  ●	int[] Grades { get; set; }
  ●	String GetName()
  ●	String GetFullName() 
  ●	Double GetAvgGrade() */
        string Name { get; set; }
  	string FullName { get; set; }
  int[] Grades { get; set; }
        string GetName();
        string GetFullName();
        double GetAvgGrade(int grad);

    }
}
