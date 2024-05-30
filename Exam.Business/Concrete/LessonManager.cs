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
   public class LessonManager:ILessonService
    {
        ILessonDal _lessonDal;

        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }

        public IResult Add(Lesson lesson)
        {

            _lessonDal.Add(lesson);
            return new SuccessResult(Messages.LessonAdded);
        }

        public IResult Delete(Lesson lesson)
        {
            _lessonDal.Delete(lesson);
            return new SuccessResult(Messages.LessonDeleted);
        }

        public IDataResult<List<Lesson>> GetAll()
        {
            return new SuccessDataResult<List<Lesson>>(_lessonDal.GetAll().ToList().OrderBy(c => c.LessonId).ToList());
        }

        public IDataResult<Lesson> GetById(int lessonId)
        {
            return new SuccessDataResult<Lesson>(_lessonDal.Get(c => c.LessonId == lessonId));
        }

        public IResult Update(Lesson lesson)
        {
            _lessonDal.Update(lesson);
            return new SuccessResult(Messages.LessonUpdated);
        }
    }
}
