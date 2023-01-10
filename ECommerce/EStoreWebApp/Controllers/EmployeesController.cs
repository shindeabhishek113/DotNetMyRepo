using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;

using BOL;
using BLL;

namespace EStoreWebApp.Controllers;

public class EmployeesController : Controller
{
    private readonly ILogger<EmployeesController> _logger;

    public EmployeesController(ILogger<EmployeesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HRManager mgr = new HRManager();
        List<Employee> employees = mgr.GetAllEmployees();
        this.ViewData["employees"]=employees;
        return View();
    }

     
}