using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IStudentService
    {
        int AddStudent(Student student);

        int UpdateStudent(Student student);

        int DeleteStudent(Student student);

        List<Student> GetAllStudents(Expression<Func<Student, bool>> filter = null);

        Student GetById(int id);

    }
}
