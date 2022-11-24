using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Teacher
    {
        [Key]
        public int teacherId { get; set; }
        public string teacherName { get; set; }

        public string teacherSurname { get; set; }

        public DateTime startedDate { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
