using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace BankingAPPConsole_KhrystynaK{
    class Accounts
    {   
        #region Properties
        public string userName { get; set; }
        public string passW { get; set; }
        public string accountName{ get; set; }
        public string accountEmail { get; set; }
        public int accNumber { get; set; }
        public int accountBalance { get; set; }
        public bool accountIsActive { get; set; }
        public int withdrawAmount { get; set; }
        public int depositAmount { get; set; }

        #endregion 


        #region Create an Account 
        SqlConnection con = new SqlConnection(@"server=DESKTOP-OO7BJ7Q\TRAINERINSTANCE; database=BankAPP; integrated security = true");
        public string CreateAccount(Accounts newAccount){
            SqlCommand cmd_createAccount = new SqlCommand("insert into Accounts values(@userName,@passW,@accountName,@accountEmail, @accountBalance, @accountIsActive)",con);
                
                cmd_createAccount.Parameters.AddWithValue("@userName", newAccount.userName);
                cmd_createAccount.Parameters.AddWithValue("@passW", newAccount.passW);
                cmd_createAccount.Parameters.AddWithValue("@accountName", newAccount.accountName);
                cmd_createAccount.Parameters.AddWithValue("@accountEmail", newAccount.accountEmail);
                cmd_createAccount.Parameters.AddWithValue("@accountBalance", 0);
                cmd_createAccount.Parameters.AddWithValue("@accountIsActive", "YES");
                try
                {
                    con.Open();
                    cmd_createAccount.ExecuteNonQuery();                    
                }
                catch(SqlException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            return "Your Account was successfully created!";

            }
            #endregion

        #region Get Details
                public List<Accounts> GetDetails(string userN)
                {

                SqlCommand cmd_allInfo = new SqlCommand("select  *  from Accounts where userName = @userN",con);
                cmd_allInfo.Parameters.AddWithValue("@userN", userN);
                SqlDataReader readInfo = null;
                List<Accounts> lst_FromDB = new List<Accounts>();

                try
                {  
                    con.Open();
                    readInfo = cmd_allInfo.ExecuteReader();
                    while (readInfo.Read())
                    {
                
                        lst_FromDB.Add(new Accounts()
                        {
                            accountName = readInfo[2].ToString(),
                            accNumber = Convert.ToInt32(readInfo[3]),
                            accountEmail = readInfo[4].ToString(),
                            accountBalance = Convert.ToInt32(readInfo[5]),

                        });
                    }
                }
                catch(SqlException se)
                {
                    throw new Exception(se.Message);
                }
                finally
                {
                    readInfo.Close();
                    con.Close();

                }
                return lst_FromDB;

            }
            #endregion
        
        #region Get Balance
                public int GetBalance(string userName)
                {
                int balanceDB;
                SqlCommand cmd_allInfo = new SqlCommand("select  accountBalance  from Accounts where userName = @userName",con);
                cmd_allInfo.Parameters.AddWithValue("@userName", userName);
                try
                {  
                    con.Open();
                    balanceDB = (Int32)cmd_allInfo.ExecuteScalar();
                }
                catch(SqlException se)
                {
                    throw new Exception(se.Message);
                }
                finally
                {
            
                    con.Close();

                }
                return balanceDB;

            }

            #endregion

        #region Deposit
                public string depositMethod(Accounts newAccount){
                SqlCommand cmd_createAccount = new SqlCommand("UPDATE Accounts SET accountBalance = accountBalance+@depositAmount WHERE userName = @username;",con);
                
                cmd_createAccount.Parameters.AddWithValue("@userName", newAccount.userName);
                cmd_createAccount.Parameters.AddWithValue("@depositAmount", newAccount.depositAmount);
                
                try
                {
                    con.Open();
                    cmd_createAccount.ExecuteNonQuery();   
                                         
                }
                catch(SqlException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            return "\nTransaction was successfully performed!";

            }
        #endregion
            
        #region Withdraw
                public string withdrawMethod(Accounts newAccount){
                SqlCommand cmd_createAccount = new SqlCommand("UPDATE Accounts SET accountBalance = accountBalance - @withdrawAmount WHERE userName = @username;",con);
                
                cmd_createAccount.Parameters.AddWithValue("@userName", newAccount.userName);
                cmd_createAccount.Parameters.AddWithValue("@withdrawAmount", newAccount.withdrawAmount);
                
                try
                {
                    con.Open();
                    cmd_createAccount.ExecuteNonQuery();                    
                }
                catch(SqlException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            return "\nThank You!";
            #endregion


        }
    }
}
  




