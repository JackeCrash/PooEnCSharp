using Microsoft.VisualBasic;

namespace AvisosVarios
{
    //Clase peces heredando la clase abstracta.
    class Peces : Animal
    {

        public Peces(string NombrePez)
        {
            nombreAnimal = NombrePez;
        }
        public override void Respirar() => Console.WriteLine("Soy un pez capaz de respirar bajo el agua");
        public override void GetNombre() => Console.WriteLine("El nombre del pez es: " + nombreAnimal);
      
    }

    class Tiburon : Peces
    {

        public Tiburon(string NombreTiburon) : base(NombreTiburon)
        {

        }

        public void CapturarPresas() => Console.WriteLine("Soy capaz de capturar a mis presas");


    }

    class PezPayaso : Peces
    {
        public PezPayaso(string nombrePez) : base(nombrePez)
        {

        }

        public void ColoresLlamativos() => Console.WriteLine("Soy capaz de cambiar de color");


    }


}
