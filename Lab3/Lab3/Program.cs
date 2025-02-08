using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{


    struct Employee
    {
        private int Ssn, Age;
        private string Fname, Lname, Address;

        public int Ssn1 { get => Ssn; set => Ssn = value; }
        public int Age1 
        
        { get => Age;
          set
            {
                if(value >=23 && value <=45)
                {
                    Age = value; 
                }
                else
                {
                    throw new Exception("Age must be between 23 to 45 ."); 
                }
            }
        }
        public string Fname1 { get => Fname; set => Fname = value; }
        public string Lname1 { get => Lname; set => Lname = value; }
        public string Address1 
        { get => Address;
            set
            {
                if(value.Equals("Alex")||value.Equals("Cairo")||value.Equals("Giza"))
                {
                    this.Address = value; 
                }
                else
                {
                    throw new Exception("Address Must be Cairo or Giza or Alex"); 
                }
            }
        }

        public void PrintOnConsole()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Employee Data "); 
            Console.WriteLine($"\t\tEmployee Ssn : {Ssn1}");
            Console.WriteLine($"\t\tEmployee Age : {Age1}");
            Console.WriteLine($"\t\tEmployee Fname : {Fname1}");
            Console.WriteLine($"\t\tEmployee Lname : {Lname1}");
            Console.WriteLine($"\t\tEmployee Address : {Address1}");
            Console.WriteLine("==================================");
        }

        public string PrintAsString()
        {
            return $"Employe Fname : {Fname1} , Lname : {Lname1} , Ssn : {Ssn1} , Age : {Age1} , Address {Address1}"; 
        }
    }



 


    class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("Press 1. For One Employee. 2.For multiple employees");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Employee emp1 = new Employee();

                    Console.Write("Enter Employee First Name : ");
                    emp1.Fname1 = Console.ReadLine();

                    Console.Write("Enter Employee Last Name : ");
                    emp1.Lname1 = Console.ReadLine();
                    bool addressValidation = false; 
                    while(!addressValidation)
                    {
                        try
                        {
                            Console.Write("Enter Employee Address : ");
                            emp1.Address1 = Console.ReadLine();
                            addressValidation = true; 
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message); 
                        }
                    }
                  
                    bool valid = false;
                    while (!valid)
                    {
                        try
                        {
                            Console.Write("Enter Employee Age : ");
                            emp1.Age1 = int.Parse(Console.ReadLine());
                            valid = true;
                        }
                      

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message); 
                        }
                    }
                  
                  

                    Console.Write("Enter Employee Ssn : ");
                    emp1.Ssn1 = int.Parse(Console.ReadLine()); 
                    emp1.PrintOnConsole(); 
                    break;
                case 2:

                    Console.Write("Enter Number Of Employees : ");
                    int numberOfemployees = int.Parse(Console.ReadLine());
                    Employee[] arrayOfemployees = new Employee[numberOfemployees];

                    Console.WriteLine("Read Employee Data : "); 
                    for(int i = 0; i< numberOfemployees; i++)
                    {
                        Console.Write("Enter Employee First Name : ");
                        arrayOfemployees[i].Fname1 = Console.ReadLine();

                        Console.Write("Enter Employee Last Name : ");
                        arrayOfemployees[i].Lname1 = Console.ReadLine();
                        bool NameVal = false;
                        while (!NameVal)
                        {
                            try
                            {
                                Console.Write("Enter Employee Address : ");
                                arrayOfemployees[i].Address1 = Console.ReadLine();
                                NameVal = true;
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
                        }

                        bool AgeVal = false;
                        while (!AgeVal)
                        {
                            try
                            {
                                Console.Write("Enter Employee Age : ");
                                arrayOfemployees[i].Age1 = int.Parse(Console.ReadLine());
                                AgeVal = true;
                            }


                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }



                        Console.Write("Enter Employee Ssn : ");
                        arrayOfemployees[i].Ssn1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(); 

                    }
                    Console.WriteLine("=============================");

                    Console.WriteLine("Employees Data : ");

                    for(int i =0; i< numberOfemployees; i++)
                    {
                        Console.WriteLine($"Employee {i + 1} First Name : {arrayOfemployees[i].Fname1}");
                        Console.WriteLine($"Employee {i + 1} Last Name : {arrayOfemployees[i].Lname1}");
                        Console.WriteLine($"Employee {i + 1} Address : {arrayOfemployees[i].Address1}");
                        Console.WriteLine($"Employee {i + 1} Age : {arrayOfemployees[i].Age1}");
                        Console.WriteLine($"Employee {i + 1} SSN : {arrayOfemployees[i].Ssn1}");
                        Console.WriteLine("=============================================");
                    }

                    break; 
                default:
                    Console.WriteLine("Invalid Choice."); 
                    break;
            }

        }
    }
}
