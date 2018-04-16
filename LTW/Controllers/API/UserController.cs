using Contracts.ServiceInterfaces;
using DataAccess.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace LTW.Controllers.API
{
    public class UserController : ApiController
    {
        private readonly IUsersService usersService;
        public UserController(IUsersService usersService)
        {
            this.usersService = usersService;
        }
        [HttpGet]
        public JsonResult<List<User>> GetAllUsers()
        {
            List<User> Users  = null;
            try
            {
                Users = usersService.GetAllUser();
            }
            catch (Exception)
            {
               throw;
            }
            return Json(Users);
        }
        [HttpPost]
        public JsonResult<Guid> CreateUser(User NewUser)
        {
            Guid NewUserId = new Guid();
            try
            {
                NewUserId = usersService.CreateUser(NewUser);
            }
            catch (Exception)
            {
                throw;
            }
            return Json(NewUserId);
        }
        [HttpGet]
        public JsonResult<bool> DeleteUser(User NewUser)
        {
            bool Result;
            try
            {
                Result = usersService.DeleteUser(NewUser);
            }
            catch (Exception)
            {
                throw;
            }
            return Json(Result);
        }
        [HttpGet]
        public JsonResult<bool> DeleteUser(Guid Id)
        {
            bool Result;
            try
            {
                Result = usersService.DeleteUser(Id);
            }
            catch (Exception)
            {
                throw;
            }
            return Json(Result);
        }
        [HttpGet]
        public JsonResult<bool> DeleteUser(string Login)
        {
            bool Result;
            try
            {
                Result = usersService.DeleteUser(Login);
            }
            catch (Exception)
            {
                throw;
            }
            return Json(Result);
        }
    }
}