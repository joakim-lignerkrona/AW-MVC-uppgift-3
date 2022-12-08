﻿using AW_MVC_uppgift_3.Models;
using Microsoft.AspNetCore.Mvc;


namespace ACME.Controllers
{
    public class EmployeesController : Controller
    {

        DataService service;
        public EmployeesController()
        {
            service = new DataService();
        }
        [HttpGet(""), HttpGet("index")]
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
        [HttpGet("details")]
        public IActionResult Details(int id)
        {
            var employee = service.GetById(id);
            return View(employee);
        }

    }
}