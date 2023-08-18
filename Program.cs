using System;


namespace ConsoleApplication1
{
    class Program
    {
        //Este es el metodo main.
        //Sirve com punto de entrada para el programa
        //(inicia desde aqui)
        static void Main(string[] args)
        {
            //Esto es una instancia de Mochila
            Mochila mochilaAna = new Mochila();
            mochilaAna.Disenio = "Piolin";
            mochilaAna.Material = "Vinyl";
            mochilaAna.NumDeBolsas = 3;
            mochilaAna.NumDeLlaveros = 0;
            mochilaAna.Precio = 500.000f;
            mochilaAna.color.Rojo = 100;
            mochilaAna.color.Verde = 20;
            mochilaAna.colo.Azul = 33;
        }
    }
}
