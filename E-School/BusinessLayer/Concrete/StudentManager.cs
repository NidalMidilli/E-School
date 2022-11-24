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
    public class StudentManager : IStudentService
    {
        IStudentDAL studentdal;
        public StudentManager(IStudentDAL studentdal)
        {
            this.studentdal = studentdal;
        }

        public int AddStudent(Student student)
        {
            return studentdal.Add(student);
        }

        public int DeleteStudent(Student student)
        {
            return studentdal.Delete(student);
        }

        public List<Student> GetAllStudents(Expression<Func<Student, bool>> filter = null)
        {
            return studentdal.ListAll();
            
        }

        public Student GetById(int id)
        {
            return studentdal.GetById(id);
        }

        public int UpdateStudent(Student student)
        {
            return studentdal.Update(student);
        }
    }
}
