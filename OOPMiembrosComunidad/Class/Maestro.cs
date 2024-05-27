using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiembrosComunidad.Class
{
    public class Maestro : Docente, IMiembros
    {
        public String? DegreeGrade { get; set; }

        public override void Greeting()
        {
            Console.WriteLine($"Hi, I'm {Name}, a teacher, and I'm {Age} years old.");
        }
    }
}
