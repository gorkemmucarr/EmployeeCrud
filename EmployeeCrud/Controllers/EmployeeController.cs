using EmployeeCrud.Dto;
using EmployeeCrud.Models;
using EmployeeCrud.Service.Contract;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace EmployeeCrud.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IServiceManager _manager;

        public EmployeeController(IServiceManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index(string searchTerm)
        {
            var employees = _manager.EmployeeService.GetAllEmployee();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                employees = employees.Where(p => p.Firstname.ToLower().Contains(searchTerm.ToLower())).ToList();
            }
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            var employee = _manager.EmployeeService.GetOneEmployee(id);
            return View(employee);
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeDto employeeDto)
        {
            if (ModelState.IsValid)
            {
                _manager.EmployeeService.CreateEmployee(employeeDto);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                _manager.EmployeeService.DeleteOneEmployee(id);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Update(int id)
        {
            var employee = _manager.EmployeeService.GetOneEmployee(id);
            
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(EmployeeDto employeeDto)
        {
            if (ModelState.IsValid)
            {
                _manager.EmployeeService.UpdateEmployee(employeeDto);
            }
            return RedirectToAction("Index");
        }


    }
}
