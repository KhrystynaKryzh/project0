using System;

namespace BankingAPPConsole_KhrystynaK
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts account1= new Accounts{ accountNumber = 1, 
            accountName = "Mike Park", 
            accountType = "debit", 
            accountBalance = 500,
            accountIsActive = true,
            accountEmail= "youremail@gmail.com"

            };
            #region Menu
            bool cond = true;
            while (cond == true){
            Console.WriteLine("\n1.Create an Account");
            Console.WriteLine("2.Check Balance");
            Console.WriteLine("3.Withdraw");
            Console.WriteLine("4.Deposit");
            Console.WriteLine("5.My account information");  
            Console.WriteLine("6.Exit\n");
            int option = Convert.ToInt32(Console.ReadLine());
            #endregion
            #region Loop
            switch(option){
                #region Create an Account 
                case 1:
                    Console.WriteLine("Please enter your first name:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Please enter your last name:");
                    string lastName = Console.ReadLine();
                    string fullName = firstName + " " + lastName;
                    account1.accountName = fullName; 
                    Console.WriteLine("Please enter your email address:");
                    string newEmail =Console.ReadLine();
                    account1.accountEmail= newEmail;
                    Console.WriteLine("\nThank You. Your account was successfully created!");
                    break;
                #endregion
                #region Check Balance
                case 2:
                    Console.WriteLine("Your current balance is : " + account1.accountBalance);
                    break;
                #endregion
                #region Withdraw
                case 3:
                    Console.WriteLine("\nCurrent Account Balance: " + account1.accountBalance);            
                    Console.WriteLine("\nEnter the amount you'd like to withdraw:");
                    int withdraw_amount = Convert.ToInt32(Console.ReadLine());
                    account1.withdraw(withdraw_amount);
                    Console.WriteLine("\nCurrent Account Balance: " + account1.accountBalance);
                    break;
                #endregion
                #region Deposit
                case 4:
                    Console.WriteLine("\nCurrent Account Balance: " + account1.accountBalance);            
                    Console.WriteLine("\nEnter the amount you'd like to deposit:");
                    int deposit_amount = Convert.ToInt32(Console.ReadLine());
                    account1.deposit(deposit_amount);
                    Console.WriteLine("\nCurrent Account Balance: " + account1.accountBalance);
                    break;
                #endregion
                #region Account details
                case 5:
                    account1.getAccountDetails();
                    break;
                #endregion
                #region Exit
                case 6:
                    cond = false;
                    break;
                #endregion
                #region Default
                default:
                    Console.WriteLine("\nPlease try again");
                    break;     
                #endregion   
            } 
            #endregion

            }
        }
    }
}
