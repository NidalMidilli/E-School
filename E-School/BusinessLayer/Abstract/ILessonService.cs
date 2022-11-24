using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILessonService
    {
        int AddLesson(Lesson lesson);
        int UpdateLesson(Lesson lesson);

        int DeleteLesson(Lesson lesson);

        List<Lesson> GetAllLessons(Expression<Func<Lesson, bool>> filter = null);

        Lesson GetById(int id);
    }
}
