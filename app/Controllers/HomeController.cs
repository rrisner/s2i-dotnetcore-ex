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

        [HttpPost]
        public ActionResult SetMortgageDetails(app.Models.Mortgage mortgage)
        {
            Mortgage.examples.Add("That worked!!!");
            Mortgage.examples.Add(mortgage.Principal.ToString());
            Mortgage.examples.Add(mortgage.InterestRate.ToString());
            Mortgage.examples.Add(mortgage.MonthlyPayment.ToString());
            Mortgage.examples.Add(mortgage.ExtraPayment.ToString());
            Mortgage.examples.Add(mortgage.ExtraPaymentMonth.ToString());

            return View();
        }

        [HttpPost]
        public ActionResult SetMortgageDetails(double Principal, double InterestRate, double MonthlyPayment, double ExtraPayment, double ExtraPaymentMonth)
        {
            Mortgage.examples.Add("That worked!!!");
            Mortgage.examples.Add(Principal.ToString());
            Mortgage.examples.Add(InterestRate.ToString());
            Mortgage.examples.Add(MonthlyPayment.ToString());
            Mortgage.examples.Add(ExtraPayment.ToString());
            Mortgage.examples.Add(ExtraPaymentMonth.ToString());

            return View();
        }
    }
}
