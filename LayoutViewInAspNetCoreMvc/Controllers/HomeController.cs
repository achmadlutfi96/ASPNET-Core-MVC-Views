using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LayoutViewInAspNetCoreMvc.Models;

namespace LayoutViewInAspNetCoreMvc.Controllers;

[Route("/Home")]
public class HomeController : Controller
{
    [Route("/")]
    [Route("")]
    public ViewResult Index(){
        return View();
    }
    [Route("~/Details")]
    public ViewResult Details(){
        return View();
    }
}
