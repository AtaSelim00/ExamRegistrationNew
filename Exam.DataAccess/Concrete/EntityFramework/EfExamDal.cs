using Core.DataAccess.EntityFramework;
using Exam.DataAccess.Abstract;
using Exam.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DataAccess.Concrete.EntityFramework
{
    public class EfExamDal : EfEntityRepositoryBase<Examm, ExamRContext>, IExamDal
    {
    }
}
