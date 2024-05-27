using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPMiembrosComunidad.Class
{
    public class Docente : Empleado, IMiembros
    {
        public String? Subject { get; set; }
        public int? YearsofExperience { get; set;}

        public override void Greeting()
        {
            Console.WriteLine($"Hi, I'm {Name}, a teacher, and I'm {Age} years old.");
        }
    }
}
