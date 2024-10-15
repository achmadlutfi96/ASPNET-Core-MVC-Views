using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewstartInAspNetCoreMvc.Models;

namespace ViewstartInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    public ViewResult Index(){
        return View();
    }
    [HttpGet("~/details")]
    public ViewResult Details(){
        return View();
    }
}
