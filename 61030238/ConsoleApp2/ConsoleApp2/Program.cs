using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int StudentID;
            StudentID = int.Parse(Console.ReadLine());



        }
        class TraineeStudent
        {
            private string StudentID;
            private string salary;
            public TraineeStudent (string ID,string SALARY)
            { 
            this.StudentID=ID;
            this.salary=SALARY;
            }
            static void getSalary(add int StudentID)
            {
                return StudentID;
            }
            static void getStudentID()
            {
                Console.WriteLine(salary);
            }

        }

    }
    }


