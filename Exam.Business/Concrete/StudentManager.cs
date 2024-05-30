using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using Exam.Business.Abstract;
using Exam.Business.Constants;
using Exam.Business.ValidationRules.FluentValidation;
using Exam.DataAccess.Abstract;
using Exam.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

       
        [ValidationAspect(typeof(StudentValidator))]
        public IResult Add(Student student)
        {
            try
            {
                _studentDal.Add(student);
                return new SuccessResult(Messages.StudentAdded);
            }
            catch (ValidationException validationException)
            {
                // ValidationException'ın error mesajını qaytarmaq
                return new ErrorResult(validationException.Message);
            }
           
           
        }

        public IResult Delete(Student student)
        {
            _studentDal.Delete(student);
            return new SuccessResult(Messages.StudentDeleted);
        }

        public IDataResult<List<Student>> GetAll()
        {
            return new SuccessDataResult<List<Student>>(_studentDal.GetAll().ToList().OrderBy(c => c.StudentId).ToList());
        }

        public IDataResult<Student> GetById(int studentId)
        {
            return new SuccessDataResult<Student>(_studentDal.Get(c => c.StudentId == studentId));
        }

        public IResult Update(Student student)
        {
            _studentDal.Update(student);
            return new SuccessResult(Messages.StudentUpdated);
        }
    }
}
