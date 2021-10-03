
using System;
using System.Collections.Generic;
namespace Library
{
    class listbook
    {
        public int Book_ID;
        public string Book_Name;
        public listbook(int ValueBook_ID, string ValueBook_Name)
        {
            Book_ID = ValueBook_ID;
            Book_Name = ValueBook_Name;

        }
    }
}
namespace Library
{
    class Register
    {
        public string Name;
        public string Password;
        public Register(string ValueName, string ValuePassword)
        {
            Name = ValueName;
            Password = ValuePassword;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Digital Library");
        Console.WriteLine("------------------------");
        Console.WriteLine(" 1.Login  ");
        Console.WriteLine(" 2.Register ");
        Console.Write("Select Menu: ");
        Register kittinun = new Register("kittinun", "1234");
        List<Register> listRegister = new List<Register>();//เก็บข้อมูลใน list
        listRegister.Add(new Register("kittinun", "1234"));
        Console.WriteLine("Register new Person");
        Console.WriteLine("------------------------");
        int x = 0;
        while (x == 0)
        {
            int input_menu = int.Parse(Console.ReadLine());
            if (input_menu == 2)
            {
                Console.WriteLine("Register new Person");
                Console.WriteLine("------------------------");
                Console.WriteLine(kittinun.Name);
                Console.WriteLine(kittinun.Password);
                Console.Write(" Input User Type : ");  //เลือก 1 = Student, 2 = Employee
                while (x == 0)
                {
                    choose_type(); break;              //ตรวจสอบ User Type 

                }
            }
            else if (input_menu == 1)
            {
                Login();              //หน้า Login
                choose_type();        //ตรวจสอบ User Type
                break;
            }
        }
    }

    static void choose_type()//1 = Student,2 = Employee
    {
        int User_Type = int.Parse(Console.ReadLine());
        if (User_Type == 1)
        {
            Console.Write("Student ID :");
            string Student_ID = Console.ReadLine();
            Login();
            Console.WriteLine("Student Management");
            Console.WriteLine("------------------------");
            Register kittinun = new Register("kittinun", "1234");
            Console.WriteLine(kittinun.Name);
            Console.Write("Student ID : {0}", Student_ID);
            Console.WriteLine("------------------------");
            Console.WriteLine("1.Borrow Book  ");
            Console.Write("Input Menu: ");
            int input_manu = int.Parse(Console.ReadLine());
            student();

        }

        else if (User_Type == 2)
        {
            Console.Write("Employee ID :");
            string Employee_ID = Console.ReadLine();
            Login();
            Console.WriteLine("Employee Management");
            Console.WriteLine("------------------------");
            Register kittinun = new Register("kittinun", "1234");
            Console.WriteLine(kittinun.Name);
            Console.Write("Employee ID : {0}", Employee_ID);
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Get List Books ");
            Console.Write("Input Menu: ");
            int input_manu = int.Parse(Console.ReadLine());
            Booklist();

        }
    }
    static void Booklist()
    {
        Console.WriteLine("Book list");
        Console.WriteLine("------------------------");
        listbook listbook1 = new listbook(1, "NOW I UNDERSTAND");
        listbook listbook2 = new listbook(2, "REVOLUTIONARY WEALTH");
        listbook listbook3 = new listbook(3, "Six Degrees ");
        listbook listbook4 = new listbook(4, "Les Vacances");
        Console.WriteLine("Book ID : {0}", listbook1.Book_ID);
        Console.WriteLine("Book_Name : {0}", listbook1.Book_Name);
        Console.WriteLine("Book ID : {0}", listbook2.Book_ID);
        Console.WriteLine("Book_Name : {0}", listbook2.Book_Name);
        Console.WriteLine("Book ID : {0}", listbook3.Book_ID);
        Console.WriteLine("Book_Name : {0}", listbook3.Book_Name);
        Console.WriteLine("Book ID : {0}", listbook4.Book_ID);
        Console.WriteLine("BBook_Name : {0}", listbook4.Book_Name);
    }
    static void student()
    {
        Console.WriteLine("Book list");
        Console.WriteLine("------------------------");
        Booklist();
        int y = 0;
        while (y == 0)
        {
            Console.Write("Input book ID: : ");
            string book_ID = Console.ReadLine();
            if (book_ID == "1")
            {
                listbook listbook1 = new listbook(1, "NOW I UNDERSTAND");
                Console.WriteLine("Book ID : {0}", listbook1.Book_ID);
                Console.WriteLine("Book_Name : {0}", listbook1.Book_Name);
            }
            else if (book_ID == "2")
            {
                listbook listbook2 = new listbook(2, "REVOLUTIONARY WEALTH");
                Console.WriteLine("Book ID : {0}", listbook2.Book_ID);
                Console.WriteLine("Book_Name : {0}", listbook2.Book_Name);
            }
            else if (book_ID == "3")
            {
                listbook listbook3 = new listbook(3, "Six Degrees ");
                Console.WriteLine("Book ID : {0}", listbook3.Book_ID);
                Console.WriteLine("Book_Name : {0}", listbook3.Book_Name);

            }
            else if (book_ID == "4")
            {
                listbook listbook4 = new listbook(4, "Les Vacances");
                Console.WriteLine("Book ID : {0}", listbook4.Book_ID);
                Console.WriteLine("BBook_Name : {0}", listbook4.Book_Name);
            }
            else if (book_ID == "exit")
            {
                Console.WriteLine(); break;
            }
        }



    }
    static void Login()
    {
        Console.WriteLine("Login Screen");
        Console.WriteLine("------------------------");
        Console.Write("Input name:");
        string name = Console.ReadLine();
        Console.Write("Input Password:");
        string password = Console.ReadLine();
    }
}
    
}