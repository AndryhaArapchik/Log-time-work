using Contracts.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess;

namespace Services
{
    public class UsersService : IUsersService
    {
        private readonly DataBaseContext dbContext;
        public UsersService()
        {
            dbContext = new DataBaseContext();
        }
        public Guid CreateUser(User NewUser)
        {
            User CurrentUser = dbContext.Users.Where(x => x.Login == NewUser.Login).FirstOrDefault();
            if (CurrentUser == null)
            {
                dbContext.Users.Add(NewUser);
                dbContext.SaveChanges();
            }
            return dbContext.Users.Where(x => x.Login == NewUser.Login).FirstOrDefault().Id;
        }

        public bool DeleteUser(Guid DeletedUserId)
        {
            User DeletedUser = dbContext.Users.Where(x => x.Id == DeletedUserId).FirstOrDefault();
            if (DeletedUser != null)
            {
                dbContext.Users.Remove(DeletedUser);
                dbContext.SaveChanges();
                DeletedUser = dbContext.Users.Where(x => x.Id == DeletedUserId).FirstOrDefault();
            }
            return (DeletedUser == null);
        }

        public bool DeleteUser(string DeletedUserLogin)
        {
            User DeletedUser = dbContext.Users.Where(x => x.Login == DeletedUserLogin).FirstOrDefault();
            if (DeletedUser != null)
            {
                dbContext.Users.Remove(DeletedUser);
                dbContext.SaveChanges();
                DeletedUser = dbContext.Users.Where(x => x.Login == DeletedUserLogin).FirstOrDefault();
            }
            return (DeletedUser == null);
        }

        public bool DeleteUser(User DeletedUser)
        {
            if (dbContext.Users.Contains(DeletedUser))
            {
                dbContext.Users.Remove(DeletedUser);
                dbContext.SaveChanges();
            }
            return !(dbContext.Users.Contains(DeletedUser));
        }

        public List<User> GetAllUser()
        {
            List<User> Users = dbContext.Users.ToList();
            return Users;
        }

        public User GetUser(Guid Id)
        {
            return dbContext.Users.Where(x => x.Id == Id).FirstOrDefault();
        }

        public User GetUser(string Login)
        {
            return dbContext.Users.Where(x => x.Login == Login).FirstOrDefault();
        }
    }
}
