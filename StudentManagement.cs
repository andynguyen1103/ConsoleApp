using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOOP
{
    class StudentManagement
    {
        List<Student> Students = new List<Student>();
        public StudentManagement()
        {

        }
        public void Menu()
        {
            int choice=1;
            do
            {
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Update info with ID");
                Console.WriteLine("3. Delete info with ID");
                Console.WriteLine("4. Search by name");
                Console.WriteLine("5. Ranking with average");
                Console.WriteLine("6. Ranking with name");
                Console.WriteLine("7. Ranking with ID");
                Console.WriteLine("0. Exit");
                Console.Write("Choose: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        IdUpdate();
                        break;
                    case 3:
                        IdDelete();
                        break;
                    case 4:
                       NameSearch();
                        break;
                    case 5:
                        AvrRank();
                        break;
                    case 6:
                        NameRank();
                        break;
                    case 7:
                        IdRank();
                        break;
                    
                    default:
                        break;
                }
            } while (choice!=0);
        }
        public void AddStudent()
        {
            Student student = new Student();
            student.EnterInfo();
            student.EnterGrade();
            Students.Add(student);
        }
        public void IdUpdate()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Id==id)
                {
                    Students[i].EnterInfo();
                    Students[i].EnterGrade();
                    return;
                }
            }
        }
        public void IdDelete()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Id == id)
                {
                    Students.RemoveAt(i);
                    return;
                }
            }
        }
        public void NameSearch()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Name==name)
                {
                    Students[i].DisplayInfo();
                }
            }
        }
        public void AvrRank()
        {
            var c = Students.OrderByDescending(c => c.AvrGrade);
            foreach (var item in c)
            {
                item.DisplayInfo();
            }
        }
        public void NameRank()
        {
            var c = Students.OrderByDescending(c => c.Name);
            foreach (var item in c)
            {
                item.DisplayInfo();
            }
        }
        public void IdRank()
        {
            var c = Students.OrderByDescending(c => c.Id);
            foreach (var item in c)
            {
                item.DisplayInfo();
            }
        }

    }
}
