
using HospitalManagementSystemTask.Data.Services;
using HospitalManagementSystemTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystemCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDoctorService _service;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IDoctorService service, ILogger<HomeController> logger)
        {
            _service = service;
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _service.GetAllAsync();

                return View(values);
        }


        public async Task<IActionResult> Filter(string searchString)
        {
            var GetAllDoctors = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                var filterResult = GetAllDoctors.Where(x => x.Name.Contains(searchString) || x.Surname.Contains(searchString));
                return View("Index", filterResult);
            }

            return View("Index", GetAllDoctors);
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
    }
}