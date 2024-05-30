using Core.DataAccess;
using Exam.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DataAccess.Abstract
{
    public interface IStudentDal : IEntityRepository<Student>
    {
    }
}
