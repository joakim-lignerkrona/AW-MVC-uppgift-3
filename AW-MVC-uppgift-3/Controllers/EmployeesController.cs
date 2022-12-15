﻿using AW_MVC_uppgift_3.Models;
using AW_MVC_uppgift_3.Models.Entities;
using Microsoft.AspNetCore.Mvc;


namespace ACME.Controllers
{
    public class EmployeesController : Controller
    {

        DataService service;
        public EmployeesController(DataService service)
        {
            this.service = service;
        }

        [HttpGet("")]
        [HttpGet("index")]
        public IActionResult Index()
        {
            var employees = service.GetAll();
            return View(employees);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Employee employee)
        {
            if(!ModelState.IsValid)
                return View();
            service.Add(employee);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var employee = service.GetById(id);
            return View(employee);
        }

        [HttpPost("employees/delete/{id}")]

        public IActionResult Delete(int id)
        {

            // service.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
