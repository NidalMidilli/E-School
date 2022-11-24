using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class TeacherValidator:AbstractValidator<Teacher>
    {
        public TeacherValidator()
        {
            RuleFor(x => x.teacherName).NotEmpty().WithMessage("Teacher name cant be empty")
                                        .MinimumLength(3).WithMessage("Teacher name must be greater than 3")
                                        .MaximumLength(30).WithMessage("Teacher name must be less than 30");
        }
    }
}
