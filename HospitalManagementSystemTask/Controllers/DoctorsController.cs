using HospitalManagementSystemTask.Data.Services;
using HospitalManagementSystemTask.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystemTask.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly IDoctorService _service;

        public DoctorsController(IDoctorService service) => _service = service;


        public IActionResult Create() =>  View();
      


        [HttpPost]
        public async Task<IActionResult> Create(Doctor addDoctor)
        {
            if(!ModelState.IsValid)
                return View(addDoctor);


          await  _service.AddAsync(addDoctor);

            return RedirectToAction("Index","Home");
        }


        public async Task<IActionResult> Edit(int id)
        {
            var findDoctor =await _service.GetByIdAsync(id);

            if (findDoctor == null)
                return View("NotFound");

            return View(findDoctor);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name, Surname, Age,Experience,Position")] Doctor doctor)
        {
            if (!ModelState.IsValid)
                   return View(doctor);


            await _service.UpdateAsync(id, doctor);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);

            return RedirectToAction("Index", "Home");
        }


    }
}
