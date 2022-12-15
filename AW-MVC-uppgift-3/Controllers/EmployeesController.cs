using AW_MVC_uppgift_3.Models;
using AW_MVC_uppgift_3.Models.Entities;
using AW_MVC_uppgift_3.Views.Employees;
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
        public IActionResult Create(CreateVM employee)
        {
            if(!ModelState.IsValid)
                return View();

            var converted = new Employee
            {
                Email = employee.Email,
                Name = employee.Name
            };

            service.Add(converted);
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

            service.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
