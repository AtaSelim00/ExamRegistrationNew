using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Entities.Concrete
{
    public class Lesson:IEntity
    {
        [Key]
        public int LessonId { get; set; }
        public string LessonCode { get; set; }
        public string LessonName { get; set; }
        public string Class { get; set; }
        public string TeacherFirstName { get; set; }
        public string TeacherLastName { get; set; }
    }
}
