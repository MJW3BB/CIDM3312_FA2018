using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Assignment04.Models
{
    public class MenuMethods
    {
        public static void CreateNewRecord()
        {
            bool exitCreation = false;
            while (exitCreation == false)
            {
                Console.WriteLine("--------WHICH DATABASE WOULD YOU LIKE TO USE------------");
                Console.WriteLine("\t1. Students\n\t2. Teams\n\t3. Clients\n\t4. Orginizations\n\t5. Exit");
                Console.Write("COMMAND: ");
                int command = Convert.ToInt32(Console.ReadLine());
                switch(command)
                {
                    case 1:
                        // Create a Student Record
                        CreateItems.CreateStudent();
                        break;
                    case 2:
                        // Create a Team Record
                        CreateItems.CreateTeam();
                        break;
                    case 3:
                        // Create a Client Record
                        CreateItems.CreateClient();
                        break;
                    case 4:
                        // Create an Orginization Record
                        CreateItems.CreateOginization();
                        break;
                    case 5:
                        // Exit Menu
                        exitCreation = true;
                        break;
                    default:
                        // Default statement / Exception handling
                        Console.WriteLine("--ERROR: TASK FAILED SUCESSFULLY--");
                        break;
                }
            }
        }
        public static void ReadARecord(){
            bool exitRead = false;
            while (exitRead == false){
                Console.WriteLine("--------WHICH DATABASE WOULD YOU LIKE TO USE------------");
                Console.WriteLine("\t1. Students\n\t2. Teams\n\t3. Clients\n\t4. Orginizations\n\t5. Exit");
                Console.Write("COMMAND: ");
                int command = Convert.ToInt32(Console.ReadLine());
                switch(command){
                    case 1:
                        // Read a Student Record
                        Console.WriteLine("1. All Records\n2. Single Record");
                        int command2 = Convert.ToInt32(Console.ReadLine());
                        switch(command2){
                            case 1:
                                ReadItems.ReadStudentALL();
                                break;
                            case 2:
                                ReadItems.ReadStudentRecord();
                                break;
                            default:
                                Console.WriteLine("--ERROR: TASK FAILED SUCESSFULLY--");
                                break;
                        }
                        break;
                    case 2:
                        // Read a Team Record
                        Console.WriteLine("1. All Records\n2. Single Record");
                        int command3 = Convert.ToInt32(Console.ReadLine());
                        switch(command3){
                            case 1:
                                ReadItems.ReadTeamALL();
                                break;
                            case 2:
                                ReadItems.ReadTeamRecord();
                                break;
                            default:
                                Console.WriteLine("--ERROR: TASK FAILED SUCESSFULLY--");
                                break;
                        }
                        break;
                    case 3:
                        // Read a Client Record
                        Console.WriteLine("1. All Records\n2. Single Record");
                        int command4 = Convert.ToInt32(Console.ReadLine());
                        switch(command4){
                            case 1:
                                ReadItems.ReadClientALL();
                                break;
                            case 2:
                                ReadItems.ReadClientRecord();
                                break;
                            default:
                                Console.WriteLine("--ERROR: TASK FAILED SUCESSFULLY--");
                                break;
                        }
                        break;
                    case 4:
                        // Read an Orginization Record
                        Console.WriteLine("1. All Records\n2. Single Record");
                        int command5 = Convert.ToInt32(Console.ReadLine());
                        switch(command5){
                            case 1:
                                ReadItems.ReadOrginizationALL();
                                break;
                            case 2:
                                ReadItems.ReadOrginizationRecord();
                                break;
                            default:
                                Console.WriteLine("--ERROR: TASK FAILED SUCESSFULLY--");
                                break;
                        }
                        break;
                    case 5:
                        // Exit Menu
                        exitRead = true;
                        break;
                    default:
                        // Default statement / Exception handling
                        Console.WriteLine("Please enter a valid command.");
                        break;
                }
            }
        }
        public static void UpdateARecord(){
            bool exitUpdate = false;
            while (exitUpdate == false){
                Console.WriteLine("--------WHICH DATABASE WOULD YOU LIKE TO USE------------");
                Console.WriteLine("\t1. Students\n\t2. Teams\n\t3. Clients\n\t4. Orginizations\n\t5. Exit");
                Console.Write("COMMAND: ");
                int command = Convert.ToInt32(Console.ReadLine());
                switch(command){
                    case 1:
                        // Update a Student Record
                        break;
                    case 2:
                        // Update a Team Record
                        break;
                    case 3:
                        // Update a Client Record
                        break;
                    case 4:
                        // Update an Orginization Record
                        break;
                    case 5:
                        // Exit Menu
                        exitUpdate = true;
                        break;
                    default:
                        // Default statement / Exception handling
                        Console.WriteLine("--ERROR: TASK FAILED SUCESSFULLY--");
                        break;
                }
            }
        }
        public static void DeleteARecord(){
            bool exitDelete = false;
            while (exitDelete == false){
                Console.WriteLine("--------WHICH DATABASE WOULD YOU LIKE TO USE------------");
                Console.WriteLine("\t1. Students\n\t2. Teams\n\t3. Clients\n\t4. Orginizations\n\t5. Exit");
                Console.Write("COMMAND: ");
                int command = Convert.ToInt32(Console.ReadLine());
                switch(command){
                    case 1:
                        // Delete a Student Record
                        break;
                    case 2:
                        // Delete a Team Record
                        break;
                    case 3:
                        // Delete a Client Record
                        break;
                    case 4:
                        // Delete an Orginization Record
                        break;
                    case 5:
                        // Exit Menu
                        exitDelete = true;
                        break;
                    default:
                        // Default statement / Exception handling
                        Console.WriteLine("--ERROR: TASK FAILED SUCESSFULLY--");
                        break;
                }
            }
        }
    }
}