using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTrainingMVC.Controllers
{
    public class HomeController : Controller
    {
        static List<string[]> contactList = new List<string[]> ();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
        return View();
    }   [HttpPost]
        public IActionResult Contact(string name,string phone,string email,string YourMessage)
            
        {
            contactList.Add(new string[] { name, phone, email,YourMessage }); 
            
            ViewBag.contactList = contactList;


            return View("contactList");
            
        }
        public IActionResult Projects()
        {
            return View();
        } 
    }
}
