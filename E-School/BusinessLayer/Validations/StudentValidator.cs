using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class StudentValidator:AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.studentName).NotEmpty().WithMessage("Student name cant be empty")
                                        .MinimumLength(3).WithMessage("Student name must be greater than 3")
                                        .MaximumLength(30).WithMessage("Student name must be less than 30");
        }
    }
}
