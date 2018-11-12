using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_L1.Models;
using System.Net;

namespace MVC_L1.Controllers
{
    public class EmployeesController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView> {
            new EmployeeView{ID = new Guid("db08861a-7f63-4ec6-9971-57d27fbeaad4"), Age = 10, LastName="Васечкин", Name="Петр", Patronymic="Иванович"},
            new EmployeeView{ID = new Guid("db08861a-7f63-4ec6-9971-57d27fbeaad3"), Age = 60, LastName="Басаев", Name="Шамиль", Patronymic="Рауфович"},
        };

        public IActionResult Index()
        {
            return View(_employees);
        }

        public IActionResult Details(Guid guid)
        {
            EmployeeView employee = _employees.FirstOrDefault(e => e.ID == guid);
            foreach (var e in _employees)
                if (e.ID == guid)
                    return View(employee);

            
            return NotFound();
        }
    }
}