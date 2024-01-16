using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class Student
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; } // per la data d'iscrizione all'università
        public ICollection<Enrollment> Enrollments { get; set; } // navigazione delle properties 
        public string Mail { get; set; }  // mail dello studente
        public int Age { get; set; } //l'eta dello studente
    }
}
