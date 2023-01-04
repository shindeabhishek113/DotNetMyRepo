namespace ebankmanager;

public delegate void BalOperation(double amount);

public class Bankmanager{

    public void blockedAccount(double amount){
        Console.WriteLine("Account has been blocked due to in-sufficient balance.");
    }

    public void sendEmail(double amount){
        Console.WriteLine("Email has been sent.");
    }

    public void sendsms(double amount){
        Console.WriteLine("SMS has been sent.");
    }

}