using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITeacherService
    {
        int AddTeacher(Teacher teacher);
        int UpdateTeacher(Teacher teacher);

        int DeleteTeacher(Teacher teacher);

        List<Teacher> ListAllTeacher(Expression<Func<Teacher, bool>> filter = null);

        Teacher GetById(int id);
    }
}
