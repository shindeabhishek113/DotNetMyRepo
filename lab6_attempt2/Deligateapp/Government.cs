namespace egov;


public delegate void TaxOperation(double amount);

public class Government{

    public void incomeTax(double amount){
        Console.WriteLine("18 % Income Tax");
    }

    public void professionalTax(double amount){

        Console.WriteLine("45% Professional ");
    }
}