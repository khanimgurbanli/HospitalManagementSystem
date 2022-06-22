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


        public async Task<IActionResult> Index()
        {
           return View( await _service.GetAllAsync());
        }
          

        public IActionResult Create() =>  View();
      


        [HttpPost]
        public async Task<IActionResult> Create(Doctor addDoctor)
        {
            if(!ModelState.IsValid)
                return View(addDoctor);

            addDoctor.FullName = addDoctor.Name + addDoctor.Surname;

          await  _service.AddAsync(addDoctor);

            return RedirectToAction("Index","Appointment");
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

            doctor.FullName = doctor.Name + doctor.Surname;

            await _service.UpdateAsync(id, doctor);

            return RedirectToAction("Index", "Appointment");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);

            return RedirectToAction("Index", "Appointment");
        }


    }
}
