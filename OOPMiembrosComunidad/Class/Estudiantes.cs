using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiembrosComunidad.Class
{
    public class Estudiantes : MiembroDeLaComunidad, IMiembros
    {
        public String? StudentNumber { get; set; }
        public String? Major { get; set; }

        public override void Greeting()
        {
            Console.WriteLine($"Hi, I'm {Name}, a student, and I'm {Age} years old.");
        }
    }
}
