using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceInterfaces
{
    public interface IUsersService
    {
        User GetUser(Guid Id);
        User GetUser(string Login);
        List<User> GetAllUser();
        Guid CreateUser(User NewUser);
        bool DeleteUser(Guid DeletedUserId);
        bool DeleteUser(string DeletedUserLogin);
        bool DeleteUser(User DeletedUser);
    }
}
