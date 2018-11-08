using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_L1.Models;
using System.Net;

namespace MVC_L1.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView> {
            new EmployeeView{ID = Guid.NewGuid(), Age = 10, LastName="Васечкин", Name="Петр", Patronymic="Иванов"},
            new EmployeeView{ID = Guid.NewGuid(), Age = 60, LastName="Басаев", Name="Шамиль", Patronymic="Рауфович"},
        };

        public IActionResult Index()
        {
            return View(_employees);
        }

        public IActionResult Details(Guid guid)
        {
            return View(_employees.FirstOrDefault(e => e.ID == guid));
        }
    }
}