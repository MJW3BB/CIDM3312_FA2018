using System;

namespace Assignment 04
{
    public class Client
    {
        public int ClientID{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public string PhoneNumber { get; set; }
        public string Email {get; set; }
        public string Role { get; set; }

        public int OrgID {get; set; } // ----------FOREIGN KEY----------
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }