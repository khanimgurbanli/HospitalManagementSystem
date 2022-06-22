using HospitalManagementSystemTask.Data.Context;
using HospitalManagementSystemTask.Data.Services;
using HospitalManagementSystemTask.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HospitalManagementSystemTask.Controllers
{
    [Authorize]
    public class AppointmentController : Controller
    {
        private readonly IDoctorService _doctorSer;
        private readonly IAppointmentService _appointSer;
        private readonly AppDbContext _db;


        public AppointmentController(IAppointmentService appointSer, IDoctorService doctorSer, AppDbContext db)
        {
            _doctorSer = doctorSer;
            _appointSer = appointSer;
            _db = db;
        }


        public async Task<IActionResult> Index()
        {
            var values = await _doctorSer.GetAllAsync();

            var a = 9;

            return View(values);
        }

        public async Task<IActionResult> Myappointments()
        {
            List<SelectListItem> getDoctors = (from e in _db.Doctors.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = e.Name,
                                                   Value = e.Id.ToString()
                                               }).ToList();

            ViewData["Doctors"] = getDoctors;

            var values = await _appointSer.GetAllAsync();

            return View(values);
        }



        public IActionResult Create(int id)
        {
            List<SelectListItem> getDoctors = (from e in _db.Doctors.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = e.Name,
                                                   Value = e.Id.ToString()
                                               }).ToList();

            ViewData["Doctors"] = getDoctors;


            ViewData["posientCount"] = _db.Appointments.Where(x => x.DoctorId == id).ToList().Count(); ;
            ViewData["DoctorInfo"] = _db.Doctors.FirstOrDefault(x => x.Id == id).FullName;

            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Create(int id, [Bind("PasientName, PasientSurname, Age,Tel,Disease,Complaint,DateAndTime,DoctorId")] Appointment appointment)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> getDoctors = (from e in _db.Doctors.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = e.Name,
                                                       Value = e.Id.ToString()
                                                   }).ToList();

                ViewData["Doctors"] = getDoctors;

                return View(appointment);
            }

           appointment.UserId= User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await _appointSer.AddAsync(appointment);

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Edit(int id)
        {
            List<SelectListItem> getDoctors = (from e in _db.Doctors.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = e.Name,
                                                   Value = e.Id.ToString()
                                               }).ToList();

            ViewData["Doctors"] = getDoctors;

            var findAppointment = await _appointSer.GetByIdAsync(id);

            if (findAppointment == null)
                return View("NotFound");

            return View(findAppointment);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PasientName, PasientSurname, Age,Tel,Disease,Complaint,DoctorId")] Appointment appointment)
        {
            if (!ModelState.IsValid)
            {

                List<SelectListItem> getDoctors = (from e in _db.Doctors.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = e.Name,
                                                       Value = e.Id.ToString()
                                                   }).ToList();

                ViewData["Doctors"] = getDoctors;

                return View(appointment);
            }

            await _appointSer.UpdateAsync(id,appointment);

            return RedirectToAction("Myappointments", "Appointment");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _appointSer.DeleteAsync(id);

            return RedirectToAction("Index", "Appointment");
        }

    }
}
