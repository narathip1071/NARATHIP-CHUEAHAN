using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_2
{
    class DataUser
    {
    
        public string Name;
        public string Gender;
        public int Age;
        public string Education;
        public string Faculty;
        public string Address;
        public string Email;

        public DataUser(string name, string gender, int age, string eucation, string faculty, string address, string email)
        {
            Name = name;
            Gender = gender;
            Age = age;
            Education = eucation;
            Faculty = faculty;
            Address = address;
            Email = email;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            PrintHeader1();
            ShowNumberForType();
            InputNumberForcheckType();
            Console.Clear();

            PrintHeader2();
            InputManuActivity();
           
        }
        static void PrintHeader1()
        {
            Console.WriteLine("Wellcom to Activity Log");
            Console.WriteLine("-------------------------");
        }
        static void ShowNumberForType()//แสดงประเภทของผู้ใช้
        {
            Console.WriteLine("1.Student");
            Console.WriteLine("2.Teacher");
        }
        static void InputNumberForcheckType()//เลือกประเภทผู้ใช้
        {
            Console.Write("In put number for choose type : ");
            int inputnumber = int.Parse(Console.ReadLine());
            checkinputnumber(inputnumber);
        }
        static void PrintHeader2()//แสดงประกิจกรรม
        {
            Console.WriteLine("activity log");
            Console.WriteLine("-------------");
            Console.WriteLine("1.Open House");
            Console.WriteLine("2.University Hazing");
            Console.WriteLine("3.Newion student Orientat");
        }
    
        static void InputManuActivity()//รับค่าเพื่อเลือกกิจกรรม
        {
            Console.Write("In put number for choose Activity : ");
            int inputManu = int.Parse(Console.ReadLine());
            Console.WriteLine();
            CheckManu(inputManu);
            ContinueActivtyLog(inputManu);
        }
        static void CheckManu(int inputManu)
        {

            if (inputManu != 1 &&inputManu!=2&& inputManu!=3)
            {
                Console.WriteLine("Menu Incorrect please enter again.");
                InputManuActivity();
            }
            
            
        }
        static void checkinputnumber(int inputnumber)//เชคประเภทผู้ใช้
        {

            if (inputnumber == 1)
            {
                Console.Clear();
                Console.Write("Student ID : ");
                string Username = Console.ReadLine();
                Console.Write("Password : ");
                string Password = Console.ReadLine();
            }
            else if (inputnumber == 2)
            {
                Console.Clear();
                Console.Write("Username : ");
                string Username = Console.ReadLine();
                Console.Write("Password : ");
                string Password = Console.ReadLine();
            }
            else
            {
                ShowNumberForType();
                Console.WriteLine("Enter 1 or 2 only, please enter again.");
                InputNumberForcheckType();
            }
        }
        static void ContinueActivtyLog(int inputManu)//แสดงกิจกรรมที่เลือก รับข้อมูลผูใช้ แสดงข้อมูผู้ใช้
        {
            if (inputManu == 1)
            {
                Console.WriteLine("Open House");
            }

            else if (inputManu == 2)
            {
                Console.WriteLine("University Hazing");
            }
            else if (inputManu == 3)
            {
                Console.WriteLine("Newion student Orientat");
            }
            Console.WriteLine("----------------------------");
            Console.Write("Name : ");
            string Name = Console.ReadLine();
            Console.Write("Gender : ");
            string Gender = Console.ReadLine();
            Console.Write("Age : ");
            int Age = int.Parse(Console.ReadLine());
            Console.Write("Education : ");
            string Education = Console.ReadLine();
            Console.Write("Faculty : ");
            string Faculty = Console.ReadLine();
            Console.Write("Address : ");
            string Address = Console.ReadLine();
            Console.Write("Email : ");
            string Email = Console.ReadLine();

            Console.Clear();
            int x = 0;
            while (x == 0)
            {
                Console.Write("Enter next or back only : ");
                string nextorback = Console.ReadLine();
                if (nextorback == "next")
                {
                    DataUser data = new DataUser(Name, Gender, Age, Education, Faculty, Address, Email);
                    Console.WriteLine("---------------------------");
                    Console.WriteLine(data.Name);
                    Console.WriteLine(data.Gender);
                    Console.WriteLine(data.Age);
                    Console.WriteLine(data.Education);
                    Console.WriteLine(data.Faculty);
                    Console.WriteLine(data.Address);
                    Console.WriteLine(data.Email);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Your information has been saved");
                }
                else if (nextorback == "back")
                {
                    PrintHeader1();
                    ShowNumberForType();
                    InputNumberForcheckType();
                    Console.Clear();
                    PrintHeader2();
                    InputManuActivity();
                    

                }

            }


        }

    }
}
    










