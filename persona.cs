using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto___DAS
{
    public  class Persona
    {
        public  string Nombre { get; set; }
        public  string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }

    public class LoginInfo : Persona
    {
        public string  Username { get; set; }
        public string Password { get; set; }
        public string Preferencia { get; set; }


        public static List<LoginInfo> DefinePersonas()
        {
            List<LoginInfo> listaPersonas = new List<LoginInfo>();

            listaPersonas.Add(new LoginInfo
            {
                Nombre = "Juan",
                Apellido = "Pérez",
                FechaNacimiento = new DateTime(1990, 5, 15),
                Preferencia = "Lenguajes de Programación",
                Username = "juanperez",
                Password = "contraseña123"
            });

            listaPersonas.Add(new LoginInfo
            {
                Nombre = "María",
                Apellido = "Gómez",
                FechaNacimiento = new DateTime(1985, 10, 20),
                Preferencia = "Libros",
                Username = "mariagomez",
                Password = "librospass"
            });

            listaPersonas.Add(new LoginInfo
            {
                Nombre = "Carlos",
                Apellido = "López",
                FechaNacimiento = new DateTime(1995, 3, 8),
                Preferencia = "Programas de Entretenimiento",
                Username = "carloslopez",
                Password = "entretenimientopass"
            });

            listaPersonas.Add(new LoginInfo
            {
                Nombre = "Ana",
                Apellido = "Martínez",
                FechaNacimiento = new DateTime(1988, 7, 12),
                Preferencia = "Lenguajes de Programación",
                Username = "anamartinez",
                Password = "lenguajespass"
            });

            listaPersonas.Add(new LoginInfo
            {
                Nombre = "Pedro",
                Apellido = "Rodríguez",
                FechaNacimiento = new DateTime(1992, 9, 25),
                Preferencia = "Libros",
                Username = "pedrorodriguez",
                Password = "pass1234"
            });
            return listaPersonas;

        }

        
    }
}
