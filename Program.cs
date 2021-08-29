using System;
using SVRMSBusinessLayer;
using SVRMSDataLayer;
namespace StudentViolationRecordManagementSystem
{
    class Program
    {
      
        static void Main(string[] args)
        {

            User.Email = "ejsoriano11@gmail.com";
            User.Password = "thepassword";
            
            int count = 0;
            

            while (count < 4)
            {
                if (count == 3)
                {
                    Console.WriteLine("Maximum attempts exceeded");
                    return;
                }
                else
                {
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("--------Welcome to Student Violation Management System--------");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("\nEnter your email: ");
                    string EmailInput = Console.ReadLine();
                    Console.WriteLine("\nEnter your password: ");
                    string PasswordInput = Console.ReadLine();
                    if (EmailInput.Equals(User.Email) && PasswordInput.Equals(User.Password))
                    {
                        LoginCorrect();
                        SVRMSSQLData.Connect();
                    }
                    else
                    {
                        Console.WriteLine("Wrong email and password");
                        count++;
                    }
                }
            }
        }
        static void LoginCorrect()
        {

        Start:
            Console.WriteLine("=========================================================");
            Console.WriteLine("====+ Welcome to your violation management system! +=====");
            Console.WriteLine("=========================================================");
            var CurrentDate = DateTime.Now;
            Console.WriteLine("====" + CurrentDate + "================================");

            Console.WriteLine("\n====================================================================");
            Console.WriteLine("= A - Record Violation   ===== B - Show Records =====  C - Logout  =");
            Console.WriteLine("====================================================================");
            string option = Console.ReadLine();


            if (option.Equals("A") || option.Equals("a"))
            {
                RecordViolation();
                goto Start;
            }


            else if (option.Equals("B") || option.Equals("b"))
            {
                SVRMSSQLData.ShowData();
                goto Start;
            }
            else if (option.Equals("C") || option.Equals("c"))
            {

                return;
            }
            else
            {
                Console.WriteLine("Wrong Input!");
                goto Start;
            }
        }

        static void RecordViolation()
        {
            Console.WriteLine("Student Number: ");
            string studentnumber = Console.ReadLine();
            Console.WriteLine("Student Name: ");
            string studentname = Console.ReadLine();
            Console.WriteLine("Student Year Level: ");
            int YearLevel = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Section: ");
            string section = Console.ReadLine();
            Console.WriteLine("Adviser: ");
            string adviser = Console.ReadLine();
            Console.WriteLine("Violation: ");
            string violation = Console.ReadLine();
            Console.WriteLine("Grooming\nStudent Identification\nBehavior\nType of Violation: ");
            string stringtypeofviolation = Console.ReadLine();
            WrongInput:
            if (stringtypeofviolation.Equals("Grooming"))
            {

                
                Console.WriteLine("Offenses: \n1st Offense - Warning \n2nd Offense - Conference With Parents" +
                    "\n3rd Offense - Community Service for 1/2 day \n4th Offense - Community Service for 1 day" +
                    "\n5th Offense - Suspension");
                Console.WriteLine("What is the offense? ");
                string offense = Console.ReadLine();

            } 
            else if (stringtypeofviolation.Equals("Student Identification"))
            {
                
                Console.WriteLine("Offenses: \n1st Offense - Warning \n2nd Offense - Conference With Parents" +
                    "\n3rd Offense - Community Service for 1/2 day \n4th Offense - Community Service for 1 day" +
                    "\n5th Offense - Suspension");
                Console.WriteLine("What is the offense? ");
                string offense = Console.ReadLine();
            }
            else if (stringtypeofviolation.Equals("Behaviour"))
            {
                
                Console.WriteLine("Category (1,2,3): ");
                int category = Convert.ToInt32(Console.ReadLine());
                if (category.Equals(1))
                {
                    Console.WriteLine("1st offense - Expulsion");
                    Console.WriteLine("What is the offense? (1st) ");
                    string offense = Console.ReadLine();
                    offense.Equals("Expulsion");
                    SVRMSSQLData.AddInputViolation(studentnumber, studentname, YearLevel, section, adviser, violation, stringtypeofviolation, offense);

                }
                else if (category.Equals(2))
                {
                    secondcategory:
                    Console.WriteLine("1st offense - Ordinary Suspension\n2nd Offense - Preventive Suspension" +
                        "\n3rd offense - Expulsion");
                    Console.WriteLine("What is the offense? (1,2,3,4) ");
                    string offense = Console.ReadLine();
                    if (offense.Equals("1"))
                    {
                        offense.Equals("Ordinary Suspension");
                        SVRMSSQLData.AddInputViolation(studentnumber, studentname, YearLevel, section, adviser, violation, stringtypeofviolation, offense);

                    }
                    else if (offense.Equals("2"))
                    {
                        offense.Equals("Preventive Suspension");
                        SVRMSSQLData.AddInputViolation(studentnumber, studentname, YearLevel, section, adviser, violation, stringtypeofviolation, offense);


                    }
                    else if (offense.Equals("3"))
                    {
                        offense.Equals("Expulsion");
                        SVRMSSQLData.AddInputViolation(studentnumber, studentname, YearLevel, section, adviser, violation, stringtypeofviolation, offense);


                    }
                    else 
                    {
                        Console.WriteLine("Wrong Input");
                        goto secondcategory;
                    }
                }
                else if (category.Equals(3))
                {   
                    thirdcategory:
                    Console.WriteLine("1st offense - Oral Reprimand\n2nd offense - Violaion Report\n" +
                        "3rd offense - Conference with Parents\n4th offense - Ordinary Suspension\n" +
                        "5th offense - Preventive Suspension\n6th offense - Expulsion");
                    Console.WriteLine("What is the offense? (1,2,3,4,5,6) ");
                    string offense = Console.ReadLine();
                    if (offense.Equals("1"))
                    {
                        offense.Equals("Oral Reprimand");
                        SVRMSSQLData.AddInputViolation(studentnumber, studentname, YearLevel, section, adviser, violation, stringtypeofviolation, offense);

                    }
                    else if (offense.Equals("2"))
                    {
                        offense.Equals("Violation Report");
                        SVRMSSQLData.AddInputViolation(studentnumber, studentname, YearLevel, section, adviser, violation, stringtypeofviolation, offense);


                    }
                    else if (offense.Equals("3"))
                    {
                        offense.Equals("Conference with Parents");
                        SVRMSSQLData.AddInputViolation(studentnumber, studentname, YearLevel, section, adviser, violation, stringtypeofviolation, offense);


                    }
                    else if (offense.Equals("4"))
                    {
                        offense.Equals("Ordinary Suspension");
                        SVRMSSQLData.AddInputViolation(studentnumber, studentname, YearLevel, section, adviser, violation, stringtypeofviolation, offense);


                    }
                    else if (offense.Equals("5"))
                    {
                        offense.Equals("Preventive Suspension");
                        SVRMSSQLData.AddInputViolation(studentnumber, studentname, YearLevel, section, adviser, violation, stringtypeofviolation, offense);


                    }
                    else if (offense.Equals("6"))
                    {
                        offense.Equals("Expulsion");
                        SVRMSSQLData.AddInputViolation(studentnumber, studentname, YearLevel, section, adviser, violation, stringtypeofviolation, offense);


                    }
                    else
                    {
                        Console.WriteLine("Wrong Input");
                        goto thirdcategory;
                    }

                }
            }
    
            else
            {
                Console.WriteLine("Wrong Input");
                goto WrongInput;
            }
            
        }
        
    }
    }

