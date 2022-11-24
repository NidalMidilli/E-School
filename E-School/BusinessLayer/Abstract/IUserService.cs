using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        int AddUser(User user);
        int UpdateUser(User user);

        int DeleteUser(User user);

        List<User> GetAllUser(Expression<Func<User, bool>> filter = null);

        User GetById(int id);

    }
}
