using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoCarreras ferrari = new AutoCarreras();
            ferrari.modelo = "Ferrati F150";
            ferrari.peso = 1.3f;
            ferrari.velocidad = 230;

            AutoCarreras lamborgini = new AutoCarreras();
            lamborgini.modelo = "Lamborgini Aventador";
            lamborgini.peso = 1.4f;
            lamborgini.velocidad = 255;

            AutoCarreras mcLaren = new AutoCarreras();
            mcLaren.modelo = "McLaren 540c";
            mcLaren.peso = 1.6f;
            mcLaren.velocidad = 240;

            PistaCarreras hnsRodriguez = new PistaCarreras();
            hnsRodriguez.nombre = "Autodromo Hermanos Rodriguez";
            hnsRodriguez.longitud = 5.6f; //km

            //Mando a competir a los autos
            hnsRodriguez.Competir(ferrari, lamborgini);

            hnsRodriguez.Competir(ferrari, mcLaren);

            hnsRodriguez.Competir(mcLaren, lamborgini);

            //Esta instruccion espera a que des enter
            //para continuar
            Console.ReadLine();
        }
    }
}
