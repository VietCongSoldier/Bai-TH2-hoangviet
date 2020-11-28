using System;
using System.IO;

namespace Bai_TH_2_Dev_huong_doi_tuong
{
    class Employee
    {
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;
        private double basicSalary;
        private string filename;
        public Employee()
        {
            Id = 1;
            Name = "";
            YearOfBirth = 0;
            SalaryLevel = 0;
            BasicSalary = 0;
        }
        public Employee(int id,string name,int yearOfBirth,double salaryLevel,double basicSalary,string filename)
        {
            this.Id = id;
            this.Name = name;
            this.YearOfBirth = yearOfBirth;
            this.SalaryLevel = salaryLevel;
            this.BasicSalary = basicSalary;
            this.Filename = filename;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int YearOfBirth { get => yearOfBirth; set => yearOfBirth = value; }
        public double SalaryLevel { get => salaryLevel; set => salaryLevel = value; }
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }
        public string Filename { get => filename; set => filename = value; }

        public void Nhap()
        {
            char check;
            do
            {
                Console.Write("Nhap ten :"); name = Console.ReadLine();
                Console.Write("Nhap nam sinh :"); yearOfBirth = int.Parse(Console.ReadLine());
                Console.Write("Nhap bac luong :"); salaryLevel = double.Parse(Console.ReadLine());
                Console.Write("Nhap luong co ban :"); basicSalary = double.Parse(Console.ReadLine());
                Console.Write("Nhap ten tep :"); Filename = Console.ReadLine();
                StreamWriter SR = new StreamWriter(Filename,true);
                SR.WriteLine($"{id}|{name}|{yearOfBirth}|{salaryLevel}|{basicSalary}");
                id++;
                Console.Write("Ban co muon nhap them khong ? (Y/N) :");
                check = Char.Parse(Console.ReadLine());
                if (check == 'N' || check == 'n') break;
            } while (check=='Y'|| check=='y');
        }
        public void getId()
        {
            StreamReader SR = new StreamReader(filename);
            Console.Write("Nhap ten nguoi lao dong can lay ID :");
            string ten = Console.ReadLine();
            string read;
            string[] dulieu;
            string ID;
            do
            {
                read = SR.ReadLine();
                dulieu = read.Split("|");
                if (dulieu[1] == ten) Console.Write(dulieu[0]);

            } while (read!="");
        }
        public string getName()
        {
            return name;
        }
        public int getYearOfBirth()
        {
            return yearOfBirth;
        }
        public double getIncome()
        {
            return salaryLevel * BasicSalary;
        }
        public void display()
        {
            StreamReader SR = new StreamReader(filename);
            string read;
            string[] dulieu;
            do
            {
                read = SR.ReadLine();
                dulieu = read.Split("|");
                Console.WriteLine($"{dulieu[0]}\t{dulieu[1]}\t{dulieu[2]}\t{dulieu[3]}\t{dulieu[4]}");

            } while (read != "");
        }
        public void setSalaryLevel()
        {
            Console.Write("Nhap bac luong cho nguoi lao dong : "); salaryLevel = double.Parse(Console.ReadLine());
        }
        public void setBasicSalary()
        {
            Console.Write("Nhap luong co ban cho nguoi lao dong : "); basicSalary = double.Parse(Console.ReadLine());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.setSalaryLevel();
            e.setBasicSalary();
            e.Nhap();
            e.getId();
            e.getName();
            e.getYearOfBirth();
            e.getIncome();
            e.display();
            Console.ReadKey();
        }
    }
}
