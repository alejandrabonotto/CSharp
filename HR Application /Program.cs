using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alejandra_assignment
{
    internal class Program
    {
        static string[] ids = new string[100];
        static string[] names = new string[100];
        static double[] incomes = new double[100];
        static int employeeCounter = 0;

        static void Main(string[] args)
        {
            bool toContinue = true;

            do
            {
                Console.Clear();
                Console.WriteLine("********** Welcome to the HR Program **********\n\n");
                Console.WriteLine("Choose one of the following options\n\n");

                Console.WriteLine("1 - Add Employee");
                Console.WriteLine("2 - Display Employee");
                Console.WriteLine("3 - Exit");

                Console.Write("\n\nSelection....:\t");
                int selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        AddEmployee();
                        break;

                    case 2:
                        DisplayEmployee();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("\nGood bye!\n");
                        toContinue = false;
                        break;

                    default:
                        Console.WriteLine("Type a valid option");
                        break;
                }

            } while (toContinue);
        }

        static void AddEmployee()
        {
            bool toContinue = true;

            do
            {
                Console.Clear();
                Console.WriteLine("********** Employee Add Section **********\n\n");
                Console.WriteLine("Choose a type of Employee\n\n");

                Console.WriteLine("1 - Comission Employee");
                Console.WriteLine("2 - Salaried Employee");
                Console.WriteLine("3 - Hourly Employee");
                Console.WriteLine("4 - Return to Main Menu");

                Console.Write("\n\nSelection....:\t");
                int selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        AddComissionEmployee();
                        break;

                    case 2:
                        AddSalariedEmployee();
                        break;

                    case 3:
                        AddHourlyEmployee();
                        break;

                    case 4:
                        toContinue = false;
                        break;

                    default:
                        break;
                }

            } while (toContinue);
        }

        static void AddComissionEmployee()
        {
            Console.Clear();
            Console.Write("********** Add Comission Employee **********\n\n");

            Console.Write("Enter employee ID....:\t\t#");
            ids[employeeCounter] = Console.ReadLine();
          


            Console.Write("Enter employee name....:\t#");
            names[employeeCounter] = Console.ReadLine();
            


            Console.Write("Enter total sales value....:\t$");
            double salesValue = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter comission sales....:\t%");
            double salesComission = Convert.ToDouble(Console.ReadLine());
          

            incomes[employeeCounter] = (salesComission * salesValue) / 100 + salesValue;
            
            Console.Write($"\n\nTotal earnings is....:\t\t{incomes[employeeCounter]:C}");
            Console.ReadLine();

            

            employeeCounter++;
            
        }

        static void AddSalariedEmployee()
        {
            Console.Clear();
            Console.Write("********** Add Salaried Employee **********\n\n");

            Console.Write("Enter employee ID....:\t\t#");
            ids[employeeCounter] = Console.ReadLine();

            Console.Write("Enter employee name....:\t#");
            names[employeeCounter] = Console.ReadLine();

            Console.Write("Enter salary....:\t\t$");
            double salary = Convert.ToDouble(Console.ReadLine());
            int firstBonus = 30;
            int secondBonus = 20;
            int thirdBonus = 10;
            

            if (salary <= 50000)
            {
                incomes[employeeCounter] = (salary * firstBonus) / 100 + salary;
                Console.Write($"\n\nTotal earning is........:\t{incomes[employeeCounter]:C}");
                Console.ReadLine();
               
            }

            else if (salary <= 250000)
            {
                incomes[employeeCounter] = (salary * secondBonus) / 100 + salary;
                Console.Write($"\n\nTotal earning is........:\t{incomes[employeeCounter]:C}");
                Console.ReadLine();
                
            }

            else 
            {
                incomes[employeeCounter] = (salary * thirdBonus) / 100 + salary;
                Console.Write($"\n\nTotal earning is........:\t{incomes[employeeCounter]:C}");
                Console.ReadLine();
                
            }
            
            employeeCounter++;
           
        }

        static void AddHourlyEmployee()
        {
            Console.Clear();
            Console.Write("********** Add Hourly Employee **********\n\n");

            Console.Write("Enter employee ID....:\t\t#");
            ids[employeeCounter] = Console.ReadLine();

            Console.Write("Enter employee name....:\t#");
            names[employeeCounter] = Console.ReadLine();

            Console.Write("Enter hourly rate....:\t\t$");
            double hourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter total weekly hours....:\t#");
            double weeklyHours = Convert.ToDouble(Console.ReadLine());

            if (weeklyHours <= 40)
            {
                incomes[employeeCounter] = (hourlyRate * weeklyHours);
                Console.Write($"\n\nTotal earning is .. ..:\t\t{incomes[employeeCounter]:C}");
                Console.ReadLine();
                
            }

            else  
            {
                incomes[employeeCounter] = ((hourlyRate * weeklyHours) * 0.50) + (hourlyRate * weeklyHours);
                Console.Write($"\n\nTotal earning is .. ..:\t\t{incomes[employeeCounter]:C}");
                Console.ReadLine();
            } 

            employeeCounter++;
           
        }

        static void DisplayEmployee()
        {
            Console.Clear();
            Console.WriteLine("********** Display Employee **********\n\n");


            Console.WriteLine("1 - Display information of all employees");
            Console.WriteLine("2 - Display information of one employee");
            Console.WriteLine("3 - Return to Main Menu");

            Console.Write("\n\nSelection....:\t");
            int selection = Convert.ToInt32(Console.ReadLine());


            switch (selection)
            {
                case 1:
                    DisplayAll();
                    return;

                case 2:
                    DisplayOne();
                    return;

                case 3:
                    return;
            }
        }

        static void DisplayAll()
        {
            Console.Clear();
            Console.WriteLine("********** All employees **********\n\n");

            string identity = "ID";
            string name = "Name";

            Console.WriteLine($"{identity,-20}|{name,-20}|Income");

            for (int i = 0; i < employeeCounter; i++)
            {
                Console.WriteLine($"{ids[i],-20}|{names[i],-20}|{incomes[i]}");

            }

            Console.Write("\n\nPress any key to return to the previous menu....");
            Console.ReadLine();
        }

        static void DisplayOne()
        {

            string identity = "ID";
            string name = "Name";

            Console.Clear();
            Console.WriteLine("********** One employees **********\n\n");

            Console.Write("Enter the employee ID....:\t#");
            string id = Console.ReadLine();


            for (int i = 0; i < employeeCounter; i++)
            {
                if (ids[i] == id)
                {
                    Console.WriteLine($"\n\n{identity,-20}|{name,-20}|Income");
                    Console.WriteLine($"{ids[i],-20}|{names[i],-20}|{incomes[i],-20}");
                    break;
                }
            }

            Console.Write("\n\nPress any key to return to the previous menu....");
            Console.ReadLine();
        }
    }
}
