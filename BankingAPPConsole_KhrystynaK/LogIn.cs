using System;
using System.Data.SqlClient;

namespace BankingAPPConsole_KhrystynaK
{
    class LogIn
    {
           public bool Login(string userName,string passW)
          {
             SqlConnection con = new SqlConnection(@"server=DESKTOP-OO7BJ7Q\TRAINERINSTANCE; database=BankAPP; integrated security = true");
             SqlCommand cmd_login = new SqlCommand("select count(*) from Accounts where userName = @userName and passW = @passW",con);

             cmd_login.Parameters.AddWithValue("@userName",userName);
             cmd_login.Parameters.AddWithValue("@passW", passW);

             try
             {
                 con.Open();
                 int cre_count =(int) cmd_login.ExecuteScalar();
                 if (cre_count > 0)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             }
             catch (System.Exception es)
             {
                 
                 throw new Exception(es.Message);
             }
             finally
             {
                 con.Close();
             }
        }
    }
}