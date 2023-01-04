namespace Bank;
using egov;
using ebankmanager;

public class Account{

    public event TaxOperation overBalance;
    public event BalOperation underBalance;

    public double Balance{get;set;}

    public Account(double amount){
        this.Balance=amount;
    }

    public void deposit(double amount){
        Balance +=amount;
    }

    public void withdraw(double amount){
        if(this.Balance <=5000){
            underBalance(this.Balance);    
        }
        else
        {
        Balance -=amount;
        }

    }

     public override string ToString()
    {
        return base.ToString() + "Current Balance ="+ this.Balance;
    }

    public void ProcessTax(){
        if(this.Balance >=250000){
 
            overBalance(this.Balance);    
        }
    }


}