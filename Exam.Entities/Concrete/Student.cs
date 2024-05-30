using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Entities.Concrete
{
    public class Student: IEntity
    {
        [Key]
        public int StudentId { get; set; }
        public int StudentNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ClassNo { get; set; }

    }
}
