using System;
class Accounts
{
    
#region Properties
    public int accountNumber { get; set; }
    public string accountName{ get; set; }
    public string accountType{ get; set; }
    public int accountBalance { get; set; }
    public bool accountIsActive { get; set; }
    public string accountEmail { get; set; }
    #endregion 
    #region Methods
    public int withdraw (int withdraw_amount){
    accountBalance = accountBalance - withdraw_amount;
    return accountBalance;
    }
    public int deposit (int deposit_amount){
        accountBalance = accountBalance + deposit_amount;
        return accountBalance;
    }
    public void getAccountDetails(){
        Console.WriteLine("\nAccount Number : " + accountNumber + ",\n" + "Name: " +  accountName + ",\n" + "Account Balance: " + accountBalance+ ",\n" + "Type: " + accountType + ",\n"+ "Email : " + accountEmail );
    }
    public int CheckBalance(){
        return accountBalance;
    }
    #endregion
}
