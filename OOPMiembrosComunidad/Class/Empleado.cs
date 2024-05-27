using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiembrosComunidad.Class
{
    public class Empleado : MiembroDeLaComunidad, IMiembros
    {
        public DateTime? DateHire { get; set; }
        public String? Position { get; set; }
        public Decimal? Salary { get; set; }

        public override void Greeting()
        {
            Console.WriteLine($"Hi, I'm {Name}, the employee, and I'm {Age} years old.");
        }
    }
}
