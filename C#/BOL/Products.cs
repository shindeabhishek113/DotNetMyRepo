namespace BOL;
public class Products{

    public int Id{get;set;}

    public string Name{get;set;}

    public int Price{get;set;}

    public Products(){

    }

    public Products(int id, string name,int price){

        this.Id=id;
        this.Name=name;
        this.Price=price;
    }
}