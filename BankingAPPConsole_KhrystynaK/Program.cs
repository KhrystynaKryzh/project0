using System;
using System.Collections.Generic;

namespace BankingAPPConsole_KhrystynaK
{
    class Program
    {
        static void Main(string[] args)
        {   
        
            Accounts newAccount0= new Accounts();
        #region Menu
            bool logIN = false;
            while (logIN == false){
            Console.Clear();

            Console.WriteLine("~~~~ Welcome to Banking APP~~~~");
            Console.WriteLine("\n1.Log in to Your Account");
            Console.WriteLine("\n2.Create an Account");
            System.Console.WriteLine("_______________________________\n\n");
 
            int option = Convert.ToInt32(Console.ReadLine());
         #endregion
        
            switch(option){
                 #region Log In 
                case 1: 
                    bool loopLoginPassword = true;
                    while (loopLoginPassword == true){
                        Console.Clear();
                        Console.WriteLine("~~~~ Welcome to Banking APP~~~~");
                        Console.WriteLine("\nPlease enter your User Name:");
                        string userName = Console.ReadLine();
                        Console.WriteLine("Please enter your Password:");
                        string passW = Console.ReadLine();
                        LogIn newLogIn = new LogIn();
                        bool loginSuccess = newLogIn.Login(userName, passW);

                                if (loginSuccess == true)
                                {   loopLoginPassword = false;
                                    logIN = true;
                                    bool newCondition=true;
                                    while(newCondition==true){
                                    Console.Clear();
                                    Console.WriteLine("~~~~ Welcome to Banking APP~~~~");
                                    Console.WriteLine("\n1.Check Balance");
                                    Console.WriteLine("2.Deposit");
                                    Console.WriteLine("3.Withdraw");
                                    Console.WriteLine("4.Send Money");
                                    Console.WriteLine("5.My account information");  
                                    Console.WriteLine("6.Exit\n");
                                    int option2 = Convert.ToInt32(Console.ReadLine());
                                    switch(option2){
                                        case 1: 
                                            Console.Clear();
                                            Console.WriteLine("~~~~ Welcome to Banking APP~~~~");                           
                                            Accounts newAccount5= new Accounts();
                                            newAccount5.userName= userName;
                                            Console.WriteLine("\nYour Current Balance: " + newAccount5.GetBalance(userName));
                                            Console.ReadKey();
                                            break;                                          
                        #region 2. Deposit
                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine("~~~~ Welcome to Banking APP~~~~");   
                                            Console.WriteLine("\nPlease enter an amount that you would like to Deposit: ");
                                            int depositAmount1 = Convert.ToInt32(Console.ReadLine());
                                            Accounts newAccount6= new Accounts();
                                            newAccount6.userName= userName;
                                            newAccount6.depositAmount= depositAmount1;
                                            System.Console.WriteLine(newAccount6.depositMethod(newAccount6));

                                            Console.WriteLine("Your Current Balance: " + newAccount6.GetBalance(userName));
                                            Console.ReadKey();   
                                        break;
                        #endregion
                        #region 3.Withdraw
                                        case 3:
                                            Console.Clear();
                                            Console.WriteLine("~~~~ Welcome to Banking APP~~~~");   
                                            bool withdrawLoop = true;
                                            while (withdrawLoop == true){
                                            Console.WriteLine("\nPlease enter an amount that you would like to Withdraw: ");
                                            int withdrawAmount1 = Convert.ToInt32(Console.ReadLine());
                                            Accounts newAccount9= new Accounts();
                                                newAccount9.accountBalance = newAccount9.GetBalance(userName);
                                                if (withdrawAmount1> newAccount9.accountBalance){
                                                    Console.Clear();
                                                    Console.WriteLine("~~~~ Welcome to Banking APP~~~~");  
                                                    System.Console.WriteLine("\n\n !--The amount you would like to withdraw is greater than your current balance--!\n");
                                                }else if (withdrawAmount1<0){
                                                    Console.Clear();
                                                    Console.WriteLine("~~~~ Welcome to Banking APP~~~~");  
                                                    System.Console.WriteLine("\n\n!--The amount you would like to withdraw cannot be a negative value--!\n");
                                                }else{
                                                    withdrawLoop = false;
                                                    newAccount9.userName= userName;
                                                    newAccount9.withdrawAmount= withdrawAmount1;
                                                    System.Console.WriteLine(newAccount9.withdrawMethod(newAccount9));
                                                    Console.Clear();
                                                    Console.WriteLine("~~~~ Welcome to Banking APP~~~~");  
                                                    Console.WriteLine("\nYour Current Balance: " + newAccount9.GetBalance(userName));
                                                    Console.ReadKey(); 
                                                }
                                            }
                                        break;
                        #endregion
                        #region 4.Send money
                                        case 4:
                                            Console.Clear();
                                            Console.WriteLine("~~~~ Welcome to Banking APP~~~~");  
                                            Console.WriteLine("\nSend money to (Enter User Name): ");
                                            string friendUserName = Console.ReadLine();
                                            bool sendLoop = true;
                                            while (sendLoop==true){
                                                Console.WriteLine("Please enter an amount that you would like to Send: ");
                                                int sendAmount1 = Convert.ToInt32(Console.ReadLine());
                                                Accounts newAccount7= new Accounts();
                                                newAccount7.accountBalance = newAccount7.GetBalance(userName);
                                                    if (sendAmount1> newAccount7.accountBalance){
                                                        Console.Clear();
                                                        Console.WriteLine("~~~~ Welcome to Banking APP~~~~");  
                                                        System.Console.WriteLine("\n!--The amount you would like to send  is greater than your current balance--!\n");
                                                    }else if (sendAmount1<0){
                                                        Console.Clear();
                                                        Console.WriteLine("~~~~ Welcome to Banking APP~~~~");  
                                                        System.Console.WriteLine("\n!--The amount you would like to send cannot be a negative value--!\n");
                                                    }else{
                                                        sendLoop = false;
                                                        newAccount7.userName= userName;
                                                        newAccount7.withdrawAmount= sendAmount1;

                                                        System.Console.WriteLine(newAccount7.withdrawMethod(newAccount7));
                                                        
                                                        Accounts newAccount8= new Accounts();
                                                        newAccount8.userName= friendUserName;
                                                        newAccount8.depositAmount= sendAmount1;
                                                        Console.Clear();
                                                        Console.WriteLine("~~~~ Welcome to Banking APP~~~~");  
                                                        System.Console.WriteLine("\n" + newAccount8.depositMethod(newAccount8));
                                                        Console.ReadKey();
                                                    }
                                            }
                                        break;
                                                
                        #endregion
                        #region 5.Account Information
                                        case 5:
                                           Console.Clear();
                                            Console.WriteLine("~~~~ Welcome to Banking APP~~~~");  
                                            System.Console.WriteLine("\nPlease confirm your User Name: ");
                                            string userN = Console.ReadLine();
                                            List<Accounts> lst =  newAccount0.GetDetails(userN);
                                            foreach (var info in lst)
                                            {   Console.Clear();
                                                Console.WriteLine("~~~~ Welcome to Banking APP~~~~");  
                                                System.Console.WriteLine("\n~Your Account Information~\n");
                                                System.Console.WriteLine(info.accountName);
                                                System.Console.WriteLine("Account Number:  "  + info.accNumber);
                                                System.Console.WriteLine("E-mail:          "  + info.accountEmail);
                                                System.Console.WriteLine("Account Balance: " + info.accountBalance);
                                                Console.ReadKey();
                                            }
                                            break;
                        #endregion                  
                                        case 6:
                                            newCondition=false;
                                            logIN = false;
                                            break;                              
                                        default:
                                            Console.Clear();
                                            Console.WriteLine("~~~~ Welcome to Banking APP~~~~");  
                                            Console.WriteLine("\nPlease try again");
                                            Console.ReadKey();
                                            break;     
                                        }
                                    }
                                } else {
                                    Console.Clear();
                                    Console.WriteLine("~~~~ Welcome to Banking APP~~~~");  
                                    System.Console.WriteLine("\nInvalid Username or Password. Please try again!");
                                    Console.ReadKey();
                                }
                        
                    }
                break;
                #endregion                   
                #region Case 2. Create an Account 
                case 2:
                    Console.Clear();
                    Accounts newAccount1= new Accounts();
                    Console.WriteLine("~~~~ Welcome to Banking APP~~~~");  

                    Console.WriteLine("\nPlease enter your first name:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Please enter your last name:");
                    string lastName = Console.ReadLine();
                    string fullName = firstName + " " + lastName;
                    newAccount1.accountName = fullName;
                    
                    Console.WriteLine("Please enter your email address:");
                    newAccount1.accountEmail =Console.ReadLine();

                    Console.WriteLine("Please create your User Name:");
                    newAccount1.userName = Console.ReadLine();
                    Console.WriteLine("Please create your Password:");
                    newAccount1.passW = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("~~~~ Welcome to Banking APP~~~~");  
                    System.Console.WriteLine("\n"+newAccount1.CreateAccount(newAccount1));
                    Console.ReadKey();
                    break;
                    
                #endregion;

                default:
                Console.Clear();
                Console.WriteLine("~~~~ Welcome to Banking APP~~~~");  
                Console.WriteLine("\nPlease try again");
                Console.ReadKey();
                break;  
            }
        }
        
    }
    
}  
}
