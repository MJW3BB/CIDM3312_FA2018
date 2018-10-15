using System;

namespace Assignment04
{
    public class Student
    {
        public int StudentID{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string PhoneNumber { get; set; }
        public string Email {get; set; }
        public string Role { get; set; }
        public string CIDM3350 {get; set;} 
        public int TeamID {get; set; }
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

    }

}