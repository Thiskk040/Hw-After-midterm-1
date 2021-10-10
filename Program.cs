using System;

namespace STudent001
{
    enum Menu
    {
        RegisterNewStudent = 1,
        RegisterNewTeacher = 2,
        GetListPersons = 3,
        Exit=4
    }
    class Program
    {
        static PersonList personList;
        static Student newstudent;
        static Teacher newteacher;

        static void Main(string[] args)
        {
            Program.personList = new PersonList();
            PrintMenuScreen();

        }
        static void PrintMenuScreen()
        {
            Console.Clear();
            Console.WriteLine("Welcome to registration new user school application.");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("1. Register new student.");
            Console.WriteLine("2. Register new Teacher.");
            Console.WriteLine("3. Get List Persons.");
            Console.WriteLine("4. Exit the program");
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);

        }
        static void InputMenuFromKeyboard()
        {
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }

        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.RegisterNewStudent)
            {
                ShowInputRegisterNewStudentScreen();
            }
            else if (menu == Menu.RegisterNewTeacher)
            {
                ShowInputRegisterNewTeacherScreen();
            }
            else if (menu == Menu.GetListPersons)
            {
                ShowGetListPersonScreen();
            }
            else if (menu == Menu.Exit)
            {
                Exitinterace();
            }
            else
            {
                ShowMessageInputMenuIsInCorrect();
            }
        }

        static void ShowInputRegisterNewStudentScreen()
        {
            Console.Clear();
            PrintHeaderRegisterStudent();

            int totalStudent = TotalNewStudents();
            InputNewStudentFromKeyboard(totalStudent);
        }

        static void ShowInputRegisterNewTeacherScreen()
        {
            Console.Clear();
            PrintHeaderRegisterTeacher();

            int totalTeacher = TotalNewTeacher();
            InputNewTeacherFromKeyboard(totalTeacher);
        }

        static void ShowGetListPersonScreen()
        {
            Console.Clear();
            Program.personList.FetchPersonsList();
            InputExitFromKeyboard();
        }

        static void InputExitFromKeyboard()
        {
            string text = "";
            while (text != "exit")
            {
                Console.WriteLine("Input: ");
                text = Console.ReadLine();
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static void InputNewTeacherFromKeyboard(int totalTeacher)
        {
            for (int i = 0; i < totalTeacher; i++)
            {
                Console.Clear();
                PrintHeaderRegisterTeacher();

                Program.newteacher.CreatenewTeacher();
                Program.personList.AddNewPerson(newteacher);
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static void InputNewStudentFromKeyboard(int totalStudent)
        {
            for (int i = 0; i < totalStudent; i++)
            {
                Console.Clear();
                PrintHeaderRegisterStudent();
                Program.newstudent.CreateNewStudent();
                Program.personList.AddNewPerson(newstudent);
            }

            Console.Clear();
            PrintMenuScreen();
        }
       
        /*
        static Student CreateNewStudent()
        {
            return new Student(InputName(),
             InputAddress(),
             InputCitizenID(),
             InputStudentID());
        }

        static Teacher CreateNewTeacher()
        {
            return new Teacher(InputName(),
            InputAddress(),
            InputCitizenID(),
            InputEmployeeID());
        }
        
        
        static string InputName()
        {
            Console.Write("Name: ");

            return Console.ReadLine();
        }

        static string InputStudentID()
        {
            Console.Write("Student ID: ");

            return Console.ReadLine();
        }

        static string InputAddress()
        {
            Console.Write("Address: ");

            return Console.ReadLine();
        }

        static string InputCitizenID()
        {
            Console.Write("Citizen ID: ");

            return Console.ReadLine();
        }

        static string InputEmployeeID()
        {
            Console.Write("Employee ID: ");

            return Console.ReadLine();
        }
        */
        
        static int TotalNewStudents()
        {
            Console.Write("Input Total new Student: ");

            return int.Parse(Console.ReadLine());
        }

        static int TotalNewTeacher()
        {
            Console.Write("Input Total new Teacher: ");

            return int.Parse(Console.ReadLine());
        }
        

        static void PrintHeaderRegisterStudent()
        {
            Console.WriteLine("Register new student.");
            Console.WriteLine("---------------------");
        }

        static void PrintHeaderRegisterTeacher()
        {
            Console.WriteLine("Register new teacher.");
            Console.WriteLine("---------------------");
        }

        static void ShowMessageInputMenuIsInCorrect()
        { 
            Console.WriteLine("Menu Incorrect Please try again.");
            InputMenuFromKeyboard();
        }
        static void Exitinterace()
        {
            long startwait = DateTimeOffset.Now.ToUnixTimeSeconds();
            bool stop = false;
            Console.Write("Program will Exit in...");
            while (true)
            {
                long endWait = DateTimeOffset.Now.ToUnixTimeSeconds();
                long wait = endWait - startwait;
                if (wait == 1 && stop == false) { Console.Write(" 3 "); stop = true; }
                if (wait == 2 && stop == true) { Console.Write(" 2 "); stop = false; }
                if (wait == 3 && stop == false) { Console.Write(" 1 "); stop = true; }
                if (wait == 4 && stop == true) { Console.Write(" 0 "); stop = false; }
                if (wait == 5 && stop == false) { Console.WriteLine("GOOD BYE !!!"); stop = true; break; ; }
                
            }
        }
    }
}
