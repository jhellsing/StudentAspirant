using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using numberone1;

namespace numberone1
{
    internal class Student
    {
        string firstName, lastName, group;
        double averageMark;

        public Student(string firstName, string lastName, string group, double averageMark)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.group = group;
            this.averageMark = averageMark;
        }


        public int getScholarship()
        {
            if (averageMark == 5)
            {
                return 10000;
            }
            else
            {
                return 8000;
            }
            Console.WriteLine(getScholarship);
        }
        public void PrintStudent()
        {
            Console.WriteLine("имя студента: " + firstName + " "+ "фамилия студента: " + lastName
            + " "+ "группа: "+ group + " "+ "средняя оценка: " +averageMark);

        }
    }
}
