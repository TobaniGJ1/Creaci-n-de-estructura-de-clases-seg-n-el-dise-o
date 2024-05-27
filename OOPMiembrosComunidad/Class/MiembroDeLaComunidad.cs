using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMiembrosComunidad.Class
{
    public abstract class MiembroDeLaComunidad
    {
        public String? Name { get; set; }
        public String? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public String? Email { get; set; }
        public String? PhoneNumber { get; set; }
        public String? Age { get; set; }


        public virtual void Greeting()
        {
            Console.WriteLine($"Hi, my name is {Name} and i'm {Age} old");
        }

    }
}
