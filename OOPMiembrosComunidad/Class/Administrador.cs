using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiembrosComunidad.Class
{
    public class Administrador : Docente, IMiembros
    {
        public String? AccessLevel { get; set; }
        public String? Responsability { get; set; }

        public override void Greeting()
        {
            Console.WriteLine($"Hi, I'm {Name}, a administrator, and I'm {Age} years old.");
        }
    }
}
