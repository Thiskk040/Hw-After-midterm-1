using System;
namespace STudent001
{
    class Student: Person
    {
        private string studentID;

        public Student(string name, string address, string citizenID, string studentID)
        : base(name, address, citizenID)
        {
            this.studentID = studentID;
        }
        public void CreateNewStudent()
        {
            new Student(InputName(),
             InputAddress(),
             InputCitizenID(),
             InputStudentID()); 
        }
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
        public string InputStudentID()
        {
            Console.Write("Student ID: ");

            return Console.ReadLine();
        }
    }
}
