using System;

namespace Smartphone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia de Smartphone
            Smartphone smartphoneMotoG42 = new Smartphone();
            smartphoneMotoG42.dimension.Ancho = 73.5f;
            smartphoneMotoG42.dimension.Alto = 160.4f;
            smartphoneMotoG42.dimension.Profundidad = 8f;
            smartphoneMotoG42.Peso = 175;
            smartphoneMotoG42.Build = "Glass front, plastic frame, plastic back";
            smartphoneMotoG42.Sim = "Dual Sim";
            smartphoneMotoG42.Type = "AMOLED";
            smartphoneMotoG42.Tamanio = 98.9f;
            smartphoneMotoG42.Resolution = "1080 x 2400 pixels, 20:9 ratio";
            smartphoneMotoG42.Os = "Android 12";
            smartphoneMotoG42.Chipset = "Qualcomm SM6225 Snapdragon 680 4G";
            smartphoneMotoG42.CpU = "Octa-Core";
            smartphoneMotoG42.Gpu = "Adreno 610";
            smartphoneMotoG42.CardSlot = "microSDXC";
            smartphoneMotoG42.MemoryInternal = "64GB 4GB RAM, 128GB 4GB RAM";
            smartphoneMotoG42.NumDeCamaras = 4;
            smartphoneMotoG42.CalidadDeVideo = "1080 px, 30fps";




        }
    }
}
