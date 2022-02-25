using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOOP
{
    enum Gender { M, F }
    class Student
    {
        public static int nextID=1;
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Major { get; set; }
        public double _asm1Grade
        {
            get
            {
                return Asm1Grade == "N" ? 0 : Asm1Grade == "P" ? 6.5 : Asm1Grade == "M" ? 8 : 10;
            }
                
            
        }
        public double _asm2Grade
        {
            get
            {
                return Asm2Grade == "N" ? 0 : Asm2Grade == "P" ? 6.5 : Asm2Grade == "M" ? 8 : 10;
            }
                          
        }
        public string Asm1Grade { get; set; }
        public string Asm2Grade { get; set; }
        public double AvrGrade
        {
            
            get
            {
                return (_asm1Grade + _asm2Grade) / 2;
            }
        }
        public string Type
        {
            get
            {
                if (Asm1Grade=="N"||Asm2Grade=="N")
                {
                    return "Fail";
                }
                else if (AvrGrade<6.5)
                {
                    return "Fail";

                }
                else if (AvrGrade<8)
                {
                    return "Average";
                }
                else if (AvrGrade<10)
                {
                    return "Good";
                }
                else 
                {
                    return "Excellent";
                }
            }
        }

        public Student()
        {
            Id = nextID;
            nextID++;
        }
        public void EnterInfo()
        {
            Console.WriteLine("Student ID: {0}", Id);
            Console.Write("Enter name: ");
            Name = Console.ReadLine();
            Console.Write("Gender: ");
            Console.WriteLine("1.M 2.F");
            this.Gender = int.Parse(Console.ReadLine()) == 1 ? Gender.M : Gender.F;
            Console.WriteLine("Major: ");
            Major = Console.ReadLine();
        }
        public void EnterGrade()
        {
            Console.WriteLine("Student ID: {0}", Id);
            Console.Write("Assignment 1 grade (N/P/M/D): ");

            Asm1Grade = Console.ReadLine();
            Console.Write("Assignment 2 grade (N/P/M/D): ");

            Asm2Grade = Console.ReadLine();
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Student ID: {0}", Id);
            Console.Write("Name: {0} ", Name);    
            Console.WriteLine("Gender: {0}", this.Gender);                
            Console.WriteLine("Major: {0}", Major);
            Console.WriteLine("Average: {0}", AvrGrade);
            Console.WriteLine("Type: {0}", Type);
        }

    }
}
