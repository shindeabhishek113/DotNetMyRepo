namespace spares;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
public class Product{
    private static string filename = @".\productdata.json";
    public string Name{get;set;}
    public double Price{get;set;}
    public int Quantity{get;set;}

    public Product(){

    }

    public Product(string name,double price,int quantity){
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
    }

    public  void saveProductData(List<Product> productdata){

        var options = new JsonSerializerOptions { IncludeFields = true };
        var dataJson = JsonSerializer.Serialize(productdata, options);
        File.WriteAllText(filename, dataJson);
    }

    public  List<Product> restoreProductData(){

        string jsonString = File.ReadAllText(filename);
        List<Product>? productd = JsonSerializer.Deserialize<List<Product>>(jsonString);
        return productd;
    }

    public string ToString(){
        return "Name:"+" "+Name+"Price"+" "+Price+"Quantity"+" "+Quantity;
    }



}