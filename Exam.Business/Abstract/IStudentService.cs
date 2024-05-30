using Core.Utilities.Results;
using Exam.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Business.Abstract
{
    public interface IStudentService
    {
        IDataResult<List<Student>> GetAll();
        IDataResult<Student> GetById(int studentId);
        IResult Add(Student student);
        IResult Update(Student student);
        IResult Delete(Student student);
    }
}
