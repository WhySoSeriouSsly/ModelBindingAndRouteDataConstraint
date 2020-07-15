using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMVC.Models;

namespace CoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
         public IActionResult listele(News news)
        {
            return View(news);
        }
        [HttpGet]
        public IActionResult deneme() //Get the form
        {
            return View();
        }
        [HttpPost]
        public IActionResult deneme(News news)//Post the form
        {
            
            return View("listele",news);
        }
         public string queryModelBinding(string value)//QueryString
        {
            return value;
        }

        public string getid(int? id)//RouteData Model Binding
        {
            return id==null ? "id yoktur":"id:"+id;
        }

        public List<string> ListeString(List<string> names){
            return names;
        }

        [HttpGet]
        public IActionResult Create(){
            return View();
        }
         [HttpPost]
        public IActionResult Create(List<string> names){
            return View("ListeString",names);
        }
        
    }
}