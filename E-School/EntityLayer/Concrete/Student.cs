using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Student
    {
        [Key]
        public int studentId { get; set; }
        public string studentName { get; set; }

        public string studentSurname { get; set; }

        public int studentNo { get; set; }
        public int lessonId { get; set; }

        public int teacherId { get; set; }
        public DateTime startedDate { get; set; }
        public Lesson Lesson { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}
