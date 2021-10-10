using System;
namespace STudent001
{
    class Teacher:Person
    {
        private string employeeID;

        public Teacher(string name, string address, string citizenID, string employeeID) : base(name, address, citizenID)
        {
            this.employeeID = employeeID;
        }
        public Teacher CreatenewTeacher() => new Teacher(InputName(),
            InputAddress(),
            InputCitizenID(),
            InputEmployeeID());
        public string InputName()
        {
            Console.Write("Name: ");

            return Console.ReadLine();
        }
        public string InputAddress()
        {
            Console.Write("Address: ");

            return Console.ReadLine();
        }
        public string InputCitizenID()
        {
            Console.Write("Citizen ID: ");

            return Console.ReadLine();
        }
        public string InputEmployeeID()
        {
            Console.Write("Employee ID: ");

            return Console.ReadLine();
        }
    }
}
