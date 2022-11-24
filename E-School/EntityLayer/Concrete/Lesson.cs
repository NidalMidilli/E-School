using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Lesson
    {
        [Key]
        public int lessonId { get; set; }

        public string lessonName { get; set; }

        public int lessonNote { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
