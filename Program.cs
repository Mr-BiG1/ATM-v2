using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Atm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] example_Account_Number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9 };
            int[] exapmle_Acount_Password = { 2, 2, 4, 4 };
            int[] user_Entered_Card_Number = new int[10];
            int[] user_Entered_Password = new int[4];
            int account_Balance = 1000;
            int user_Money_Need;
            bool exit_program = false;
            int user_Selected_Option;
            // ATM 
            do
            {
                try
                {
                    Console.WriteLine("Welcome to ATM");
                    Console.WriteLine();
                    Console.WriteLine("1. Withdraw Money");
                    Console.WriteLine();
                    Console.WriteLine("2. Balance Enquary");
                    Console.WriteLine();
                    Console.WriteLine("3. Change Password");
                    Console.WriteLine();
                    Console.WriteLine("4. Change Mobile Number");
                    Console.WriteLine();
                    Console.WriteLine("5. Exit");
                    Console.WriteLine();
                    user_Selected_Option = Convert.ToInt32(Console.ReadLine());
                    switch (user_Selected_Option)
                    {
                        // withdraw money from the account.
                        case 1:
                            Atm_Card_Number(user_Entered_Card_Number);
                            // if is used to make sure user have entered a valied card number.
                            if (user_Entered_Card_Number.Length != 0)
                            {
                                Passsword_Checker(user_Entered_Password);
                            }
                            else
                            {
                                Console.WriteLine("Card Number is not entered");
                                Atm_Card_Number(user_Entered_Card_Number);
                            }
                            Password_Compair(user_Entered_Card_Number, user_Entered_Password);
                            Console.WriteLine("Enter the amount to withdraw");
                            user_Money_Need = Convert.ToInt32(Console.ReadLine());
                            account_Balance = account_Balance - user_Money_Need;
                            Console.WriteLine("Processing");
                            Thread.Sleep(200);
                            Console.WriteLine("Collect Money");
                            Console.WriteLine($"FInal Balance: ${account_Balance}");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Not FIxed");
                            break;
                        case 3:
                            Console.WriteLine("Not FIxed");
                            break;
                        case 4:
                            Console.WriteLine("Not FIxed");
                            break;
                        case 5:
                            exit_program = true;
                            break;
                    }
                }catch (Exception Error)
                {
                    Console.WriteLine(Error.Message);
                }
            } while (exit_program == false);
            {
                Console.WriteLine("thank You");
                Console.ReadKey();
            }
        }

        // Function is for get card data from the user to conform the account
        static void Atm_Card_Number(int[] get_Card_Number)
        {
            Console.WriteLine();
            try
            {
                Console.WriteLine("Enter The ATM Number");
                for (int i = 0; i < get_Card_Number.Length; i++)
                {
                    get_Card_Number[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();
            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.Message);
            }
        }

        // function to check and get password.
        static void Passsword_Checker(int[] password_Checker)
        {
            try
            {
                Console.WriteLine("Enter your Four digit pin code");
                for (int i = 0;i < password_Checker.Length; i++)
                {
                    password_Checker[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                Console.Clear();
            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.Message);
            }
        }
        //to check the password and accound number are same 
        static void Password_Compair(int[] account_Number_Compair, int[] pasword_Compair)
        {
            for (int i = 0; i < account_Number_Compair.Length ; i++)
            {
                if (account_Number_Compair[i] != pasword_Compair[i])
                {
                    Console.WriteLine("Hellow ");
                }
            }
        }
    }
}
