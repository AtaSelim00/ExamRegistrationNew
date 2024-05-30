using Exam.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Business.ValidationRules.FluentValidation
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Please student name enter");
            RuleFor(p => p.Name).MinimumLength(2);
            RuleFor(p => p.StudentNo).NotEmpty();
      

        }
    }
}
