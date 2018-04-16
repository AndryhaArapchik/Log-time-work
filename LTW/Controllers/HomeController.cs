using Contracts.ServiceInterfaces;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTW.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsersService usersService;
        public HomeController(IUsersService usersService)
        {
            this.usersService = usersService;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}