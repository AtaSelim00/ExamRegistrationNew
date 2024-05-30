using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Entities.Concrete
{
    public class Examm:IEntity
    {
        [Key]
        public int ExamId { get; set; }
        public string LessonCode { get; set; }
        public int StudentNo { get; set; }
        public DateTime ExamDate { get; set; }
        public byte Point { get; set; }
    }
}
