﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app.Models;
using Microsoft.AspNetCore.Http;

namespace app.Controllers
{
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
        
        /*[HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {
            foreach (string key in formCollection.Keys)
            {
                Response.WriteAsync("Key = " + key + "\t");
                Response.WriteAsync(formCollection[key]);
                Response.WriteAsync("<br/>");

                app.Models.EmployeeTest.knownEmployees.Add(formCollection[key]);
            }

            if (formCollection.Keys.Count == 0)
            {
                app.Models.EmployeeTest.knownEmployees.Add("A button was pressed, but I didn't get any data.");
            }
            else if (formCollection == null)
            {
                app.Models.EmployeeTest.knownEmployees.Add("The button was pressed, but it did not return a FormCollection.");
            }
                

            //return Content();
            return View();
        }

        public ActionResult Create()
        {
            app.Models.EmployeeTest.knownEmployees.Add("An HTTP action occurred, but I got no data from the form.");
         
            //return Content();
            return View();
        }

        public ActionResult Create(EmployeeTest testE)
        {
            app.Models.EmployeeTest.knownEmployees.Add("The form returned the Employee model itself: " + testE.Name);
         
            //return Content();
            return View();
        }*/

        [Http.HttpPost]
        public ActionResult SetMortgageDetails(double principal, double interestRate, double monthyPayment, double extraPayment, double extraPaymentMonth)
        {
            Mortgage.examples.Add("That worked!!!");
        }
    }
}
