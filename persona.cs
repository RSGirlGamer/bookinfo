using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___DAS
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }

    class LoginInfo : Persona
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Preferencia { get; set; }
    }
}
