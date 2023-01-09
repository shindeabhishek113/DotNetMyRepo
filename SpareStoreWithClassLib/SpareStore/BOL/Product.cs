namespace BOL;
public class Product
{
    public int Productid{get;set;}
    public string Name{get;set;}
    public double Price{get;set;}
    public int Quantity{get;set;}


    public Product (){

    }

    public Product (int productid, string name, double price, int quantity){

        this.Productid = productid;

        this.Name = name;

        this.Price = price;

        this.Quantity = quantity;

    }

    

}
