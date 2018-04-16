using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contracts.ServiceInterfaces;

namespace LTW.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsersService usersService;
        public UserController(IUsersService usersService)
        {
            this.usersService = usersService;
        }
        public ActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUser(DataAccess.Entities.User Model)
        {
            Guid NewUserId = new Guid();
            try
            {
                NewUserId = usersService.CreateUser(Model);
            }
            catch (Exception)
            {
                throw;
            }
            return Json(NewUserId);
        }
    }
}