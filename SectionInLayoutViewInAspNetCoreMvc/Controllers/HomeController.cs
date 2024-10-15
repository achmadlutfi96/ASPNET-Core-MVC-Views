using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SectionInLayoutViewInAspNetCoreMvc.Models;

namespace SectionInLayoutViewInAspNetCoreMvc.Controllers;

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
