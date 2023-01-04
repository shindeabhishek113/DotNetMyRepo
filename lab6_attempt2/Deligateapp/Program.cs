using egov;
using Bank;
using ebankmanager;

Government centralGov = new Government();

TaxOperation itOperation = new TaxOperation(centralGov.incomeTax);
TaxOperation prOperation = new TaxOperation(centralGov.professionalTax);

Account  acct123=new Account(6000);

acct123.overBalance+=itOperation;
acct123.overBalance+=prOperation;
acct123.ProcessTax();
Console.WriteLine("\nAfter Tax process");
Console.WriteLine(acct123);

Console.WriteLine("******************************************************************");


Bankmanager mgr= new Bankmanager();

BalOperation bkOperation= new BalOperation(mgr.blockedAccount); 
BalOperation emailOperation= new BalOperation(mgr.sendEmail); 
BalOperation smsOperation= new BalOperation(mgr.sendsms); 

acct123.underBalance+= bkOperation;
acct123.underBalance+= emailOperation;
acct123.underBalance+= smsOperation;


Console.WriteLine("\nWithdrawing 1000");
acct123.withdraw(1000);
Console.WriteLine("\nAfter Withdrawl");
Console.WriteLine(acct123);

Console.WriteLine("\n\nWithdrawing 1000");
acct123.withdraw(1000);
Console.WriteLine(acct123+"\n");

