using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraAutos
{
    class PistaCarreras
    {
        public string nombre;
        public float longitud;

        public void Competir(AutoCarreras auto1, AutoCarreras auto3)
        {
            Console.WriteLine("Iniciando carrera entre" 
                + auto1.modelo + "y" + auto3.modelo);
            
            if(auto1.velocidad > auto3.velocidad)
            {
                Console.WriteLine("Gano "+ auto1.modelo);
            }
            else if (auto3.velocidad > auto1.velocidad)
            {
                 Console.WriteLine("Gano "+ auto3.modelo);
            }
            else
                 //tienen la misma velocidad
            {
                 Console.WriteLine("Hubo empate");
            }
        }

    }
}
