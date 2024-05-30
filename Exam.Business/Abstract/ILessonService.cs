using Core.Utilities.Results;
using Exam.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Business.Abstract
{
    public interface ILessonService
    {
        IDataResult<List<Lesson>> GetAll();
        IDataResult<Lesson> GetById(int lessonId);
        IResult Add(Lesson lesson);
        IResult Update(Lesson lesson);
        IResult Delete(Lesson lesson);
    }
}
