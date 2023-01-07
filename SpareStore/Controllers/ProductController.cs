using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
namespace SpareStore.Controllers;
using spares;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

   
    public IActionResult Addproduct(string name,double price,int quantity){
        Product prod = new Product();
        List<Product> p = prod.restoreProductData();

        Product tempproduct = new Product(name,price,quantity);

        p.Add(tempproduct);
        prod.saveProductData(p);

         //return Redirect("/Home");

         return View();
        
    }

    // public IActionResult Displayproduct(){

    // }

    
}
