using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyfirstApp.Models;
using HR;
//using System.Collections.Generic;


namespace MyfirstApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Login(){

        return View();
    }

    public IActionResult Registration(){

        return View();
    }
    public IActionResult LoginUser(string email, string password)
    {
        User u1 = new User();
        List<User> data = u1.restoreUserData();
        User tempuser = new User(email, password);
        foreach (User u in data){
            if(u.Email.Equals(email) && u.Password.Equals(password)){
               
                return Redirect("Welcome");
            }        
        }
        return Redirect ("Login");
        
        
    }

    public IActionResult RegisterUser(string fullname,string city,string email,string password){
        List<User>userdata = new List<User>();
        User tempuser = new User(fullname,city,email,password);
        userdata.Add(tempuser);
        User u = new User();
        u.saveUserData(userdata);
        return Redirect("/Home");
    }

     public IActionResult Welcome()
    {
        return View();
    }

   
}
