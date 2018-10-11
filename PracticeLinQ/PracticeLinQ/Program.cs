using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                try
                {
                    db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                FirstName = "Laith",
                                LastName = "Alfaloujeh",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Freshman"
                                CIDM3350 = "Yes";
                            },
                            new Student()
                            {
                                FirstName = "Mekkala",
                                LastName = "Bourape",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Sophomore"
                                CIDM3350 = "No";
                            },
                            new Student()
                            {
                                FirstName = "Charles",
                                LastName = "Coufal",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Junior"
                                CIDM3350 = "Yes";
                            },
                            new Student()
                            {
                                FirstName = "John",
                                LastName = "Cunningham",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Senior"
                                CIDM3350 = "No";
                            },
                            new Student()
                            {
                                FirstName = "Michael",
                                LastName = "Hayes",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Freshman"
                                CIDM3350 = "Yes";
                            },
                            new Student()
                            {
                                FirstName = "Aaron",
                                LastName = "Hebert",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Senior"
                                CIDM3350 = "No";
                            },
                            new Student()
                            {
                                FirstName = "Yi Fu",
                                LastName = "Ji",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Junior"
                                CIDM3350 = "Yes";
                            },
                            new Student()
                            {
                                FirstName = "Todd",
                                LastName = "Kile",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Senior"
                                CIDM3350 = "No";
                            },
                            new Student()
                            {
                                FirstName = "Mara",
                                LastName = "Kinoff",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Freshman"
                                CIDM3350 = "Yes";
                            },
                            new Student()
                            {
                                FirstName = "Cesareo",
                                LastName = "Lona",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Sophomore"
                                CIDM3350 = "No";
                            },
                            new Student()
                            {
                                FirstName = "Michael",
                                LastName = "Matthews",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Junior"
                                CIDM3350 = "Yes";
                            },
                            new Student()
                            {
                                FirstName = "Mason",
                                LastName = "McCollum",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Senior"
                                CIDM3350 = "No";
                            },
                            new Student()
                            {
                                FirstName = "Alexander",
                                LastName = "McDonald",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Freshman"
                                CIDM3350 = "Yes";
                            },
                            new Student()
                            {
                                FirstName = "Phelps",
                                LastName = "Merrell",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Sophomore"
                                CIDM3350 = "No";
                            },
                            new Student()
                            {
                                FirstName = "Quan",
                                LastName = "Nguyen",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Junior"
                                CIDM3350 = "Yes";
                            },
                            new Student()
                            {
                                FirstName = "Alexander",
                                LastName = "Roder",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Senior"
                                CIDM3350 = "No";
                            },
                            new Student()
                            {
                                FirstName = "Amy",
                                LastName = "Saysourinyosack",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Freshman"
                                CIDM3350 = "Yes";
                            },
                            new Student()
                            {
                                FirstName = "Claudia",
                                LastName = "Silva",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Sophomore"
                                CIDM3350 = "No";
                            },
                            new Student()
                            {
                                FirstName = "Gabriela",
                                LastName = "Valenzuela",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Junior"
                                CIDM3350 = "Yes";
                            },
                            new Student()
                            {
                                FirstName = "Kayla",
                                LastName = "Washington",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Senior"
                                CIDM3350 = "No";
                            },
                            new Student()
                            {
                                FirstName = "Matthew",
                                LastName = "Webb",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Freshman"
                                CIDM3350 = "Yes";
                            },
                            new Student()
                            {
                                FirstName = "Cory",
                                LastName = "Williams",
                                PhoneNumber = "123-456-7890",
                                Email = "test1@test.com",
                                Role = "Sophomore"
                                CIDM3350 = "No";
                            },                                          
                        };
                        db.Students.AddRange(students);  
                        db.SaveChanges();                                              
                        Console.WriteLine("**********DATABASE SEEDED SUCCESSFULLY**********");
                        Console.WriteLine("");
                        Console.WriteLine("--------------LINQ QUERIES--------------");                                            
                    }
                    else
                    {
                    // Show all records in the Students table
                    var students = db.Students.ToList();
                    Console.WriteLine("--------------HERE ARE THE RECORDS WITHIN THE STUDENT TABLE--------------");
                    foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                    Console.WriteLine();

                    // Show records of students who are NOT seniors
                    var studentNotSenior = db.Students.Where(s => s.Role != "Senior");

                    Console.WriteLine("--------------STUDENTS THAT ARE NOT SENIORS--------------");
                    foreach(Student s in studentNotSenior)
                        {
                            Console.WriteLine(s);   
                        }
                    Console.WriteLine("");

                    // show students whose names begin with letters 'M' or lower

                    Console.WriteLine("--------------STUDENTS WHOSE NAMES BEGIN WITH M OR LESSER--------------");
                    
                    var studentFirstLetterM = from s in db.Students
                                                where s.FirstName.StartsWith("M")
                                                select s;
                    foreach(Student s in studentFirstLetterM){
                        Console.WriteLine(s);
                    }

                    // Show students with last names that begin with letters "L" or higher and whose first names are longer than 6 characters
                    Console.WriteLine("------------- LAST NAME STARTS WITH L OR HIGHER + FIRST NAMES LONGER THAN 6 LETTERS--------------");
                    var studentLastLetterL = db.Students.Where(s => s.LastName.StartsWith("L"));
                    var studentLess6 = db.Students.Where(t => t.LastName.Length <= 6);
                    foreach(Student s in studentLastLetterL){
                        foreach(Student t in studentLess6){
                            Console.WriteLine(t);
                        }
                    }
                    Console.WriteLine("");

                    // Show all students who have taken CIDM3350 before

                    Console.WriteLine("--------------STUDENTS PREVIOUSLY ENROLLED IN CIDM3350--------------");

                    var studentCIDM3350 = from t in db.Students
                                            where t.CIDM3350 == "yes"
                                            select t;

                    foreach(Student t in studentCIDM3350){
                        Console.WriteLine(t);
                    }
                    Console.WriteLine("");
                    // FIND

                    // Find a student named "John" and print that record to the screen
                    Console.WriteLine("Student named John:--------> ");
                    var studentJohn = db.Students.Where(s => s.FirstName == "John").FirstOrDefault();
                    Console.WriteLine(studentJohn);
                    Console.WriteLine("");

                    // Find a student named "Alexander" and print that record to the screen
                    Console.WriteLine("Student named Alexander:---------------> ");
                    var studentAlex = db.Students.Where(s => s.FirstName == "Alexander").FirstOrDefault();
                    Console.WriteLine(studentAlex);
                    Console.WriteLine("");

                    // Find a student who has the shortest first name and print that record to the screen
                    Console.WriteLine("Strudent with the shortest First Name:-----------> ");
                    var shortFirst = from t in db.Students  
                                        orderby t.FirstName.FirstOrDefault()
                                        select t;
                    Console.WriteLine(shortFirst);
                    Console.WriteLine("");

                    // Find a student who has the shortest last name and print that record to the screen
                    Console.WriteLine("Student with the shortest first genrally speaking:------------> ");
                    var shortLast = from t in db.Students  
                                        orderby t.LastName.FirstOrDefault()
                                        select t;
                    Console.WriteLine(shortLast);
                    Console.WriteLine("");

                    // Find a student who has the shortest last name but also has the longest first name and print that record to the screen
                    Console.WriteLine("SHORT LAST NAME + LONG FIRST NAME");
                    var lastFirst = db.Students.OrderBy(s => s.LastName.Length).FirstOrDefault();
                    var firstSecond = db.Students.OrderByDescending(t => t.FirstName.Length).FirstOrDefault();
                    Console.WriteLine ($"{firstSecond} {lastFirst}");
                    Console.WriteLine("");

                    // SORT

                    // Sort all students by first name
                    Console.WriteLine("--------------SORTED BY FIRST NAME--------------");
                    var sortFirst = from s in db.Students
                                        orderby s.FirstName
                                        select s;
                    foreach(Student s in sortFirst){
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");

                    // Show all students sorted by last name descending
                    Console.WriteLine("--------------SORTED BY LAST NAME DESCENDING--------------");
                    var sortLast = db.Students.OrderByDescending(s => s.LastName);
                    foreach(Student s in sortLast){
                        Console.WriteLine(s);
                    }

                    // Show all students sorted by rank (Freshman, Sophomore, Junior, Senior, Graduate)
                    Console.WriteLine("--------------SORTED BY RANK--------------");
                    var studentsRank = db.Students.GroupBy(s => s.Role);
                    foreach(var roleGroup in studentsRank){
                            Console.WriteLine($"Rank: {roleGroup.Key}");
                            foreach(Student s in roleGroup){
                                Console.WriteLine(s);
                            }
                        }
                    Console.WriteLine("");

                    // Show students who are Seniors and sorted by last name
                    Console.WriteLine("--------------SORTED SENIORS BY LAST NAME--------------");
                    var seniorLast = db.Students
                                        .Where(s => s.Role == "Senior")
                                        .OrderBy(s => s.LastName);
                    
                    foreach(Student s in seniorLast){
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");

                    // Sort students who are NOT Seniors and sort by first name descending
                    Console.WriteLine("--------------SORTED SENIORS BY FIRST NAME--------------");
                    var notSenior = db.Students 
                                        .Where(s => s.Role != "senior")
                                        .OrderByDescending(s => s.FirstName);
                    foreach(Student s in notSenior){
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");

                    // GROUP

                    // show all students Grouped by class rank
                    Console.WriteLine("--------------GROUP BY RANK--------------");
                    var studentsGroupRank = db.Students.GroupBy(s => s.Role);
                    foreach(var roleGroup in studentsGroupRank){
                            Console.WriteLine($"Rank: {roleGroup.Key}");
                            foreach(Student s in roleGroup){
                                Console.WriteLine(s);
                            }
                        }
                    Console.WriteLine("");

                    // Show all students Grouped by class rank and sorted by last name
                    Console.WriteLine("--------------GROUP BY RANK AND SORTED BY LAST NAME--------------");
                    var groupRankSortLast = db.Students.OrderBy(t => t.LastName).GroupBy(s => s.Role);
                    foreach(Student s in groupRankSortLast){
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");

                    // Show all students Grouped by the first letter of their last name and sorted by first name
                    Console.WriteLine("--------------GROUP BY FIRST LETTER LAST AND SORT BY FIRST NAME"--------------);
                    var firstLetterLast = db.Students
                                            .OrderBy(c => c.FirstName)
                                            .GroupBy(c => string.IsNullOrEmpty(c.LastName) ? ' ' : c.LastName[0]);                  
                    foreach (Student c in firstLetterLast){
                        Console.Write(c);
                    }
                    Console.WriteLine("");                
                    }
                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                    Console.WriteLine("++++++++++++++ HOUSTON WE HAVE A PROBLEM +++++++++++++++");
                }
            }
        }
    }
}