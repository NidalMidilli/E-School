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
    public class TeacherManager : ITeacherService
    {
        ITeacherDAL teacherdal;

        public TeacherManager(ITeacherDAL teacherdal)
        {
            this.teacherdal = teacherdal;
        }
        public int AddTeacher(Teacher teacher)
        {
            return teacherdal.Add(teacher);
        }

        public int DeleteTeacher(Teacher teacher)
        {
            return teacherdal.Delete(teacher);
        }

        public Teacher GetById(int id)
        {
            return teacherdal.GetById(id);
        }

        public List<Teacher> ListAllTeacher(Expression<Func<Teacher, bool>> filter = null)
        {
            return teacherdal.ListAll();
        }

        public int UpdateTeacher(Teacher teacher)
        {
            return teacherdal.Update(teacher);
        }
    }
}
