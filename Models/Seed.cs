using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace Assignment04.Models
{
    public class SeedDatabase
    {
        public static void Seed()
        {
            using(var db = new AppDbContext())
            {
                try
                {
                    db.Database.EnsureCreated();
                    if(!db.Students.Any() && !db.Teams.Any())
                    {
                        List<Team> teams = new List<Team>() // -----LIST OBJECT FOR TEAMS-----
                        {
                            new Team() {TeamID = 1, TeamName = "TEAM 1", TeamDescription = "TEAM 1 ESTABLISHED"},
                            new Team() {TeamID = 2, TeamName = "TEAM 2", TeamDescription = "TEAM 2 ESTABLISHED"},
                            new Team() {TeamID = 3, TeamName = "TEAM 3", TeamDescription = "TEAM 3 ESTABLISHED"}
                        };
                        db.Teams.AddRange(teams);
                        List<Student> students = new List<Student>() // -----LIST OBJECT FOR STUDENTS-----
                        {
                            new Student() {FirstName = "Laith", LastName = "Alfaloujeh", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Freshman", CIDM3350 = "yes", TeamID = 1},
                            new Student() {FirstName = "Mekkala", LastName = "Bourape", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Sophomore", CIDM3350 = "no", TeamID = 2},
                            new Student() {FirstName = "Charles", LastName = "Coufal", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Junior", CIDM3350 = "yes", TeamID = 3},
                            new Student() {FirstName = "John", LastName = "Cunningham", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Senior", CIDM3350 = "no", TeamID = 1},
                            new Student() {FirstName = "Michael", LastName = "Hayes", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Freshman", CIDM3350 = "yes", TeamID = 2},
                            new Student() {FirstName = "Aaron", LastName = "Hebert", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Senior", CIDM3350 = "no", TeamID = 3},
                            new Student() {FirstName = "Yi Fu", LastName = "Ji", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Junior", CIDM3350 = "yes", TeamID = 1},
                            new Student() {FirstName = "Todd", LastName = "Kile", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Senior", CIDM3350 = "no", TeamID = 2},
                            new Student() {FirstName = "Mara", LastName = "Kinoff", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Freshman", CIDM3350 = "yes", TeamID = 3},
                            new Student() {FirstName = "Cesareo", LastName = "Lona", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Sophomore", CIDM3350 = "no", TeamID = 1},
                            new Student() {FirstName = "Michael", LastName = "Matthews", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Junior", CIDM3350 = "yes", TeamID = 2},
                            new Student() {FirstName = "Mason", LastName = "McCollum", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Senior", CIDM3350 = "no", TeamID = 3},
                            new Student() {FirstName = "Alexander", LastName = "McDonald", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Freshman", CIDM3350 = "yes", TeamID = 1},
                            new Student() {FirstName = "Phelps", LastName = "Merrell", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Sophomore", CIDM3350 = "no", TeamID = 2},
                            new Student() {FirstName = "Quan", LastName = "Nguyen", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Junior", CIDM3350 = "yes", TeamID = 3},
                            new Student() {FirstName = "Alexander", LastName = "Roder", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Senior", CIDM3350 = "no", TeamID = 1},
                            new Student() {FirstName = "Amy", LastName = "Saysourinyosack", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Freshman", CIDM3350 = "yes", TeamID = 2},
                            new Student() {FirstName = "Claudia", LastName = "Silva", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Sophomore", CIDM3350 = "no", TeamID = 3},
                            new Student() {FirstName = "Gabriela", LastName = "Valenzuela", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Junior", CIDM3350 = "yes", TeamID = 1},
                            new Student() {FirstName = "Kayla", LastName = "Washington", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Senior", CIDM3350 = "no", TeamID = 2},
                            new Student() {FirstName = "Matthew", LastName = "Webb", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Freshman", CIDM3350 = "yes", TeamID = 3},
                            new Student() {FirstName = "Cory", LastName = "Williams", PhoneNumber = "123-456-7890", Email = "test1@test.com", Role = "Sophomore", CIDM3350 = "no", TeamID = 1},         
                        };
                        db.Students.AddRange(students);  
                        db.SaveChanges();                                      
                    }
                    else
                if (!db.Clients.Any() && !db.Orginizations.Any())
                {
                    List<Orginization> orginizations = new List<Orginization>() // -----LIST OBJECT OF ORGANIZATIONS-----
                    {
                        new Orginization() {OrgID = 1, OrgName = "WTAMU", OrgDescription = "West Texas A&M University"},
                        new Orginization() {OrgID = 2, OrgName = "HSB", OrgDescription = "Happy State Bank"},
                        new Orginization() {OrgID = 3, OrgName = "ANB", OrgDescription = "Amarillo National Bank"},
                        new Orginization() {OrgID = 4, OrgName = "SBDC", OrgDescription = "America's Small Business Development Center"},
                        new Orginization() {OrgID = 5, OrgName = "CSCO", OrgDescription = "Cisco Systems"}
                    };
                    db.Orginizations.AddRange(orginizations);
                    db.SaveChanges();
                    List<Client> clients = new List<Client>() // ------LIST OBJECT OF CLIENTS------
                    {
                        new Client() {FirstName = "Jeffry", LastName = "Babb", PhoneNumber = "123-456-7890", Email = "jbabb@wtamu.edu", Role = "Professor", OrgID = 1},
                        new Client() {FirstName = "James", LastName = "Webb", PhoneNumber = "123-456-7890", Email = "jwebb@wtamu.edu", Role = "CIO", OrgID = 1},
                        new Client() {FirstName = "Pat", LastName = "Hickman", PhoneNumber = "123-456-7890", Email = "somemail@mail.com", Role = "CEO", OrgID = 2},
                        new Client() {FirstName = "Gina", LastName = "Woodward", PhoneNumber = "123-456-7890", Email = "gwoodward@wtsbdc.com", Role = "Consultant", OrgID = 4},
                    };
                    db.Clients.AddRange(clients);
                    db.SaveChanges();
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
            Console.WriteLine("------------------------DATABASE SEEDED--------------------------");
        }
    }
}