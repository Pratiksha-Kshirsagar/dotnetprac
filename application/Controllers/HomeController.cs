using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using application.Models;
using BLL;
using BOL;

namespace application.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Studentdata sd = new Studentdata();
        List<Student> students = sd.getAll();
        this.ViewData["students"] = students; 
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
     public IActionResult login()
    {
        return View();
    }
     public IActionResult newpage()
    {
        return View();
    }
    public IActionResult auth(string fname,string lname)
    {
        Studentdata sd=new Studentdata();
        sd.insert(fname,lname);
        return Redirect("/home/newpage");
       
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
