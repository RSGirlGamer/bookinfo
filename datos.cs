using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto___DAS
{
    public class datos
        
    {
        public static List<Programas> Defineprogramas()
        {
            List<Programas> listaPrograms = new List<Programas>();


            listaPrograms.Add(new Programas
            {
                Nombre = "GAME OF THRONES",
                imagen = global::Proyecto___DAS.Properties.Resources.gameofthrones,
                percent = 40,
                title = "Juego de tronos",
                creado = "David Benioff, D. B. Weiss",
                protas = "Sean Bean, Nikolaj Coster-Waldau, Peter Dinklage, Emilia Clarke, Lena Headey, Iain Glen, Kit Harington, Sophie Turner, Maisie Williams, Isaac Hempstead-Wright, Natalie Dormer",
                origen = "Estados Unidos",
                seasons = "8",
                caps = "73",
                sinopsis = "La trama de Game of Thrones está basada en la serie de novelas Canción de hielo y fuego, y relata las vivencias de un grupo de personajes de distintas casas nobiliarias en el continente ficticio Poniente para tener el control del Trono de Hierro y gobernar los siete reinos que conforman el territorio."
            });

            listaPrograms.Add(new Programas
            {
                Nombre = "CHERNOBYL",
                imagen = global::Proyecto___DAS.Properties.Resources.chernobyl,
                percent = 34,
                title = "Chernóbil",
                creado = "Craig Mazin",
                protas = "Jared Harris, Stellan Skarsgård, Emily Watson",
                origen = "Estados Unidos, Reino Unido",
                seasons = "1",
                caps = "5",
                sinopsis = "La serie gira en torno al desastre nuclear de Chernóbil de abril de 1986 y los esfuerzos de limpieza sin precedentes que siguieron. Cuenta con un reparto encabezado por Jared Harris, Stellan Skarsgård y Emily Watson."
            });

            listaPrograms.Add(new Programas
            {
                Nombre = "THE MARVELOUS MRS. MAISEL",
                imagen = global::Proyecto___DAS.Properties.Resources.marvelous,
                percent = 26,
                title = "La maravillosa Señora Maisel",
                creado = "Amy Sherman-Palladino",
                protas = "Rachel Brosnahan, Michael Zegen, Alex Borstein, Tony Shalhoub, Marin Hinkle",
                origen = "Estados Unidos",
                seasons = "3",
                caps = "26",
                sinopsis = "La serie cuenta la historia de un ama de casa en Nueva York que descubre que tiene una habilidad especial para la comedia en vivo. El primer episodio se estrenó como parte de la temporada de pilotos de primavera de Amazon Studios el 17 de marzo de 2017, recibiendo la aclamación de la crítica."
            });
            return listaPrograms;

        }
        public static List<Libros> DefineBooks()
        {

            List<Libros> listaBooks = new List<Libros>();

            // Agregar libros a la lista
            listaBooks.Add(new Libros
            {
                Nombre = "Harry Potter",
                imagen = global::Proyecto___DAS.Properties.Resources.harrypotter,
                percent = 44,
                autor = "J. K. Rowling",
                generos = "Novela",
                subs = "Literatura fantástica, literatura juvenil, novela de desarrollo y literatura infantil y juvenil",
                pages = "3407 (ENG), 3665 (ESP)",
                protas = "Harry Potter, Ron weasley, Hermione Granger, Ginny Weasley, Neville Longbottom, Albus Dumbledore",
                antag = "Lord Voldemort, Mortífagos",
                argumento = "La historia comienza con la celebración del mundo mágico. Durante muchos años, había sido aterrorizado por el malvado mago Lord Voldemort. La noche del 31 de octubre, mató a Lily y James Potter. Sin embargo, cuando intenta matar a su hijo de 1 año, Harry, la maldición asesina Avada Kedavra se vuelve sobre sí mismo. El cuerpo de Voldemort resulta destruido, pero él sobrevive: no está muerto ni vivo. Por su parte, a Harry solo le queda una cicatriz con forma de rayo en la frente que es el único remanente físico de la maldición de Voldemort. Harry es el único sobreviviente de la maldición asesina, y a raíz de la misteriosa derrota de Voldemort, el mundo mágico empieza a llamarlo como «el niño que sobrevivió»."
            });

            listaBooks.Add(new Libros
            {
                Nombre = "Goosebumps",
                imagen = global::Proyecto___DAS.Properties.Resources.goosebumps,
                percent = 30,
                autor = "Robert Lawrence Stine",
                generos = "Ciencia ficción, literatura infantil y suspenso",
                subs = "Suspenso, terror, juvenil",
                pages = "---",
                protas = "El protagonista principal de una historia de Pesadillas / Escalofríos, es a menudo situado en una ubicación remota o de alguna manera aislada en algunas situaciones.",
                antag = "----",
                argumento = "La serie consta de un total de 60 libros para España, el último de los cuales (Sangre de monstruo IV) se publicó en 1999, mientras que en Hispanoamérica consta de 45 historias. El nombre se tradujo en España como Pesadillas y en Hispanoamérica como Escalofríos."
            });

            listaBooks.Add(new Libros
            {
                Nombre = "Perry Mason",
                imagen = global::Proyecto___DAS.Properties.Resources.perrymasson,
                percent = 26,
                autor = "Erle Stanley Gardner",
                generos = "Novela policiaca",
                subs = "xx",
                pages = "xx",
                protas = "Perry Mason",
                antag = "xx",
                argumento = "El personaje era un abogado que llegó a aparecer en 80 novelas e historias cortas, la mayoría de las cuales versaban sobre la defensa de un cliente que había sido acusado de asesinato. En general, Perry Mason era capaz de demostrar la inocencia de su cliente mediante la averiguación de la culpabilidad del verdadero asesino, otro personaje de la historia."
            });

            return listaBooks;
        }
        public static List<Lenguajes> DefineLanguages()
        {
            List<Lenguajes> listaLanguage = new List<Lenguajes>();

            listaLanguage.Add(new Lenguajes
            {
                Nombre = "PYTHON",
                imagen = global::Proyecto___DAS.Properties.Resources.python,
                percent = 47,
                devs = "Python Software Foundation",
                exts = ".py, .pyc, .pyd, .pyo, .pyw, .pyz",
                OS = "Multiplataforma",
                paradigma = "Multiparadigma: orientado a objetos, imperativo, funcional, reflexivo",
                latestV = "3.8.3",
                license = "Python Software Foundation License",
                released = "1991"
            });

            listaLanguage.Add(new Lenguajes
            {
                Nombre = "JAVA",
                imagen = global::Proyecto___DAS.Properties.Resources.java,
                percent = 38,
                devs = "James Gosling y Sun Microsystems",
                exts = "java, class, jar, jad y jmod",
                OS = "Multiplataforma",
                paradigma = "Orientado a objetos, imperativo",
                latestV = "14.01",
                license = "GNU GPL / Java Community Process",
                released = "1996"
            });

            listaLanguage.Add(new Lenguajes
            {
                Nombre = "JAVASCRIPT",
                imagen = global::Proyecto___DAS.Properties.Resources.javascript,
                percent = 15,
                devs = "xx",
                exts = ".js",
                OS = "xx",
                paradigma = "Multiparadigma, programación funcional, programación basada en prototipos, imperativo, interpretado (scripting)",
                latestV = "ECMAScript2016",
                license = "xx",
                released = "1995"
            });
            return listaLanguage;
        }


        static List<LoginInfo> DefinePersonas()
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

