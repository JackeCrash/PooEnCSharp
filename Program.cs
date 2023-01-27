using AvisosVarios;
using System;

//Clase principal
namespace PracticandoAbstracto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano humanoEzequiel = new Humano("Ezequiel");
            Caballo Juan = new Caballo("Juan");

            Mamiferos[] arrayMamiferos = new Mamiferos[2];

            arrayMamiferos[0] = humanoEzequiel;
            arrayMamiferos[1] = Juan;

            foreach (Mamiferos item in arrayMamiferos)
            {
                item.GetNombre();
                item.Pensar();
            }



        }
    }

   

}