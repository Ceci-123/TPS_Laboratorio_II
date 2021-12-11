using System;
using System.Collections.Generic;
using System.IO;
using Calanna.Cecilia._2A.TPFinal;

namespace Consolita
{
    class Program
    {
        static void Main(string[] args)
        {

            Personaje p1 = new Personaje("Iron Man", "Tony Stark");
            Personaje p2 = new Personaje("Capitan America", "Steve Rogers");
            Personaje p3 = new Personaje("Hulk", "Bruce Banner");
            Personaje p4 = new Personaje("Scarlet Witch", "Wanda Maximoff");
            Personaje p5 = new Personaje("Vision", "Sintezoide");
            Personaje p6 = new Personaje("Thor", "Odinson");
            Personaje p7 = new Personaje("Spiderman", "Peter Parker");

            Pelicula peli1 = new Pelicula("Age of Ultron", DateTime.Parse("13/5/2015"), 4);
            peli1 += p1;
            peli1 += p2;
            peli1 += p6;
            Console.WriteLine(peli1.ToString());
            Console.WriteLine(".:.-------------------------.:.");
            bool respuesta = peli1 == p2;
            if (respuesta)
            {
                Console.WriteLine("este personaje esta en la pelicula");

            }
            Console.WriteLine(".:.-------------------------.:.");
            
            Pelicula peli2 = new Pelicula("Iron Man 3", DateTime.Parse("03/5/2013"), 2);
            peli2 += p1;
            peli2 += p2;

            Pelicula peli3 = new Pelicula("SpiderMan Homecoming", DateTime.Parse("07/7/2017"), 3);
            peli3 += p7;
            peli3 += p1;
            Pelicula peli4 = new Pelicula("Thor Ragnarok", DateTime.Parse("03/11/2017"), 3);
            peli4 += p6;
            peli4 += p3;
            Pelicula peli5 = new Pelicula("Black Widow", DateTime.Parse("09/7/2021"), 4);
            peli5 += p4;
            peli5 += p5;

            bool prueba = Pelicula.ValidarFase(peli1.NumeroDeFase);
            if (prueba)
            {
               Console.WriteLine("La fase de la pelicula esta correctamente validada");

            }

            Serie serie1 = new Serie("Wanda Vision", DateTime.Parse("15/1/2021"), 9, Plataformas.Disney);
            serie1 += p4;
            serie1 += p5;

            
            Console.WriteLine("");
            Console.WriteLine(serie1.ToString());


            ListaGeneral<Serie> listaGeneralSeries = new ListaGeneral<Serie>(2);

            listaGeneralSeries.listaGeneral.Add(serie1);
            List<Pelicula> listado = new List<Pelicula>();
            listado.Add(peli1);
            listado.Add(peli2);
            listado.Add(peli3);
            listado.Add(peli4);
            listado.Add(peli5);

            // guardar datos en un archivo
            //Pelicula.ExportarATxt(listado);
            //Pelicula.ExportarACsv(listado);
            
            //Pelicula.SerializeNow(peli1);
            //Pelicula.DeSerializeNow();






        }
    }
} 
