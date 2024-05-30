using Core.Utilities.Results;
using Exam.Business.Abstract;
using Exam.Business.Constants;
using Exam.DataAccess.Abstract;
using Exam.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Business.Concrete
{
    public class ExamManager:IExamService
    {
        IExamDal _examDal;

        public ExamManager(IExamDal examDal)
        {
            _examDal = examDal;
        }

        public IResult Add(Examm exam)
        {

            _examDal.Add(exam);
            return new SuccessResult(Messages.ExamAdded);
        }

        public IResult Delete(Examm exam)
        {
            _examDal.Delete(exam);
            return new SuccessResult(Messages.ExamDeleted);
        }

        public IDataResult<List<Examm>> GetAll()
        {
            return new SuccessDataResult<List<Examm>>(_examDal.GetAll().ToList().OrderBy(c => c.ExamId).ToList());
        }

        public IDataResult<Examm> GetById(int examId)
        {
            return new SuccessDataResult<Examm>(_examDal.Get(c => c.ExamId == examId));
        }

        public IResult Update(Examm exam)
        {
            _examDal.Update(exam);
            return new SuccessResult(Messages.ExamUpdated);
        }
    }
}
