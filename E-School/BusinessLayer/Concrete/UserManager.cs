using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager:IUserService
    {
        IUserDAL userdal;
        public UserManager(IUserDAL userdal)
        {
            this.userdal = userdal;
        }

        public int AddUser(User user)
        {
            return userdal.Add(user);
        }

        public int DeleteUser(User user)
        {
            return userdal.Delete(user);
        }

        public List<User> GetAllUser(Expression<Func<User, bool>> filter = null)
        {
            return userdal.ListAll();
        }

        public User GetById(int id)
        {
           return userdal.GetById(id);
        }

        public int UpdateUser(User user)
        {
            return userdal.Update(user);
        }
    }
}
