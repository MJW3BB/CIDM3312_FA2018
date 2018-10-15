using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.Linq;

namespace Assignment04.Models
{
    public class ReadItems
    {
        public static void ReadTeamALL()
        {
            using(var db = new AppDbContext())
            {
            
                var teams = db.Teams.ToList();

                foreach(Team t in teams)
                {
                    Console.WriteLine(t);
                }
            }
        }
        public static void ReadTeamRecord()
        {
            Console.WriteLine("--NEGATIVE GHOST RIDER--");
        }
        public static void ReadStudentALL()
        {
            using(var db = new AppDbContext())
            {

                var students = db.Students.ToList();

                foreach(Student s in students)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void ReadStudentRecord()
        {
            Console.WriteLine("--NEGATIVE GHOST RIDER--");
        }
        public static void ReadClientALL(){
            using(var db = new AppDbContext())
            {

                var clients = db.Clients.ToList();

                foreach(Client c in clients)
                {
                    Console.WriteLine(c);
                }
            }
        }
        public static void ReadClientRecord()
        {
            Console.WriteLine("--NEGATIVE GHOST RIDER--");
        }
        public static void ReadOrginizationALL()
        {
            using(var db = new AppDbContext())
            {

                var orginizations = db.Orginizations.ToList();

                foreach(Orginization o in orginizations)
                {
                    Console.WriteLine(o);
                }
            }
        }
        public static void ReadOrginizationRecord()
        {
            Console.WriteLine("--NEGATIVE GHOST RIDER--");
        }
    }
}