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
    public class LessonManager:ILessonService
    {
        ILessonDAL lessondal;
        public LessonManager(ILessonDAL lessondal)
        {
            this.lessondal = lessondal;
        }

        public int AddLesson(Lesson lesson)
        {
            return lessondal.Add(lesson);
        }

        public int DeleteLesson(Lesson lesson)
        {
            return lessondal.Delete(lesson);
        }

        public List<Lesson> GetAllLessons(Expression<Func<Lesson, bool>> filter = null)
        {
            return lessondal.ListAll();
        }

        public Lesson GetById(int id)
        {
            return lessondal.GetById(id);
        }

        public int UpdateLesson(Lesson lesson)
        {
            return lessondal.Update(lesson);
        }
    }
}
