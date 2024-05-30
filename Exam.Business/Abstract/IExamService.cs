using Core.Utilities.Results;
using Exam.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Business.Abstract
{
    public interface IExamService
    {
        IDataResult<List<Examm>> GetAll();
        IDataResult<Examm> GetById(int examId);
        IResult Add(Examm exam);
        IResult Update(Examm exam);
        IResult Delete(Examm exam);
    }
}
