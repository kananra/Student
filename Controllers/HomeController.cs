using Microsoft.AspNetCore.Mvc;
using Student.DataAccess;
using System.Collections.Generic;
using Student.Models;
using Student.ViewModels;
using System;

namespace Student.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
           return View();
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }




    }






   
}

