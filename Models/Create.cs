using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace Assignment 04.Models

{
    public class CreateItems
    {
        // ----------------------PULL-----------------------
        public static void CreateTeam(){
            Console.Write("Team ID: ");
            int tID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Team Name: ");
            string tName = Console.ReadLine();
            Console.Write("Team Description: ");
            string tDescription = Console.ReadLine();
           using(var db = new AppDbContext()){
               List<Team> teams = new List<Team>() // ----------ADD COLLECTED INPUTS TO A LIST OBJECT----------
               {
                   new Team()
                   {
                       TeamID = tID,
                       TeamName = tName,
                       TeamDescription = tDescription
                   }
               };
               db.Teams.AddRange(teams);
               db.SaveChanges();
           }
           Console.WriteLine("----------Records Added----------");
        }
        // ----------------------PULL-----------------------
        public static void CreateStudent(){
        Console.Write("First Name: ");
        string StuFName = Console.ReadLine();
        Console.Write("Last Name: ");
        string StuLName = Console.ReadLine();
        Console.Write("Phone Number: ");
        string StuPhone = Console.ReadLine();
        Console.Write("Email: ");
        string StuMail = Console.ReadLine();
        Console.Write("Role: ");
        string StuRole = Console.ReadLine();
        Console.Write("Student Team ID: ");
        int TeamID = Convert.ToInt32(Console.ReadLine());
        // -----------------------INPUT-----------------------
        using(var db = new AppDbContext()){
            List<Student> students = new List<Student>() // -----------ADD COLLECTED INPUTS TO LIST OBJECT-----------
            {
                new Student()
                {
                    FirstName = StuFName,
                    LastName = StuLName,
                    PhoneNumber = StuPhone,
                    Email = StuMail,
                    Role = StuRole,
                    TeamID = TeamID
                }
            };
            db.Students.AddRange(students);
            db.SaveChanges();
            }
            Console.WriteLine("----------Records Added----------");
        }
        // -------------------------COLLECT USER INPUT-------------------------
        public static void CreateOginization(){
        Console.Write("Orginization ID: ");
        int oID = Convert.ToInt32(Console.ReadLine());
        Console.Write("Orginization Name: ");
        string oName = Console.ReadLine();
        Console.Write("Organization Description: ");
        string oDescription = Console.ReadLine();
        // -------------------------ADD IT TO THE DATABASE--------------------------
        using(var db = new AppDbContext()){
            List<Orginization> orginizations = new List<Orginization>() // ----------ADD COLLECTED INPUTS TO A LIST OBJECT-----------
            {
                new Orginization()
                {
                    OrgID = oID,
                    OrgName = oName,
                    OrgDescription = oDescription
                }
            };
            db.Orginizations.AddRange(orginizations);
            db.SaveChanges();
            }
            Console.WriteLine("----------Records Added----------");
        }
        // -------------------------COLLECT MORE USER INPUTS----------------------------
        public static void CreateClient(){
        Console.Write("Client ID: ");
        int cID = Convert.ToInt32(Console.ReadLine());
        Console.Write("First Name: ");
        string cFName = Console.ReadLine();
        Console.Write("Last Name: ");
        string cLName = Console.ReadLine();
        Console.Write("Phone Number: ");
        string cPhone = Console.ReadLine();
        Console.Write("Email: ");
        string cMail = Console.ReadLine();
        Console.Write("Role: ");
        string cRole = Console.ReadLine();
        Console.Write("Orginization ID: ");
        int cOrg = Convert.ToInt32(Console.ReadLine());
        using(var db = new AppDbContext())
            {
            List<Client> clients= new List<Client>() // ----------ADD COLLECTED INPUTS TO A LIST OBJECT-----------
                {
                new Client()
                {
                    ClientID = cID,
                    FirstName= cFName,
                    LastName = cLName,
                    PhoneNumber = cPhone,
                    Email = cMail,
                    Role = cRole,
                    OrgID = cOrg
                }
            };
            db.Clients.AddRange(clients);
            db.SaveChanges();
            }
            Console.WriteLine("----------Records Added----------");
        }
    }
}