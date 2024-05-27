using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiembrosComunidad.Class
{
    public class Administrativo : Empleado, IMiembros
    {
        public String? Deparment { get; set; }
        public String? Rol { get; set; }

        public override void Greeting()
        {
            Console.WriteLine($"Hi, I'm {Name}, a administrative person , and I'm {Age} years old.");
        }
    }
}
