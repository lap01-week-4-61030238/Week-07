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


            TraineeStudent su = new TraineeStudent("Student Name", "12345678");
            try
            {
                
                su.salary = 350f
                ;
                Console.WriteLine("Student ID   : " + su.ID);
                Console.WriteLine("Student salary : " + su.salary);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
    class TraineeStudent
    {

        private string name;
        private string id;
        private float gpa;

        public Student(string Name, string ID)
        {
            this.name = Name;   // assign auto variable to the field
            this.id = ID;
        }

        public string Name
        {
            get { return name; }
        }

        private string id;
        private float salary;


        public string ID
        {
            get { return id; }
        }
        public float salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 300 && value <= 400)
                    salary  = value;
                else
                    throw (new Exception("Error!!!! invalid GPA"));
            }
        }
    }
}

