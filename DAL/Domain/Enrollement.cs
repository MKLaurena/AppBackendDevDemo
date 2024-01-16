using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    internal class Enrollement
    {
        public int EnrollmmentId { get; set; }  //chiave primaria
        public int CourseId { get; set; }// chiave esterna del corso associato ad un iscrizione
        public int StudentId { get; set; }   // chiave esterna dello studente associato all'iscrizionne
        public Grade? Grade { get; set; } // il voto dello studente
        public Course Course { get; set; } // le due navigation propertie per entrare nel corso associato all'iscrizione 
        public Student Student { get; set; } // le due navigation propertie per entrare nello studente associato all'iscrizione 
    }
}
