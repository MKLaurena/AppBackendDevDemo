using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class Course
    {

        public int CourseId { get; set; }
        public string Title { get; set; }
        public int credits { get; set; }
        public ICollection<Enrollement> Enrollments { get; set; } //lista di iscrizioni, lista di iscritti a questo corso
        public string Description { get; set; }
    }
}
