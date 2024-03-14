using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Proyecto___DAS
{
    public class datos
        
    {
        static void defineDatos()
        {
            List<programas> listaPrograms = new List<programas>();
            List<Libros> listaBooks = new List<Libros>();
            List<Lenguajes> listaLanguage = new List<Lenguajes>();

            listaPrograms.Add(new programas
            {
                Nombre = "GAME OF THRONES",
                percent = 40,
                title = "Juego de tronos",
                creado = "David Benioff, D. B. Weiss",
                protas = "Sean Bean, Nikolaj Coster-Waldau, Peter Dinklage, Emilia Clarke, Lena Headey, Iain Glen, Kit Harington, Sophie Turner, Maisie Williams, Isaac Hempstead-Wright, Natalie Dormer",
                origen = "Estados Unidos",
                seasons = "8",
                caps = "73",
                sinopsis = "La trama de Game of Thrones está basada en la serie de novelas Canción de hielo y fuego, y relata las vivencias de un grupo de personajes de distintas casas nobiliarias en el continente ficticio Poniente para tener el control del Trono de Hierro y gobernar los siete reinos que conforman el territorio."
            });

            listaPrograms.Add(new programas
            {
                Nombre = "CHERNOBYL",
                percent = 34,
                title = "Chernóbil",
                creado = "Craig Mazin",
                protas = "Jared Harris, Stellan Skarsgård, Emily Watson",
                origen = "Estados Unidos, Reino Unido",
                seasons = "1",
                caps = "5",
                sinopsis = "La serie gira en torno al desastre nuclear de Chernóbil de abril de 1986 y los esfuerzos de limpieza sin precedentes que siguieron. Cuenta con un reparto encabezado por Jared Harris, Stellan Skarsgård y Emily Watson."
            });

            listaPrograms.Add(new programas
            {
                Nombre = "THE MARVELOUS MRS. MAISEL",
                percent = 26,
                title = "La maravillosa Señora Maisel",
                creado = "Amy Sherman-Palladino",
                protas = "Rachel Brosnahan, Michael Zegen, Alex Borstein, Tony Shalhoub, Marin Hinkle",
                origen = "Estados Unidos",
                seasons = "3",
                caps = "26",
                sinopsis = "La serie cuenta la historia de un ama de casa en Nueva York que descubre que tiene una habilidad especial para la comedia en vivo. El primer episodio se estrenó como parte de la temporada de pilotos de primavera de Amazon Studios el 17 de marzo de 2017, recibiendo la aclamación de la crítica."
            });


        }




    }
}
