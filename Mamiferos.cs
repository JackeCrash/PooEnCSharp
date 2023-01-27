namespace AvisosVarios
{
    //Clase Mamiferos heredando la clase abstracta.
    class Mamiferos : Animal
    {

        public Mamiferos(string Nombre)
        {
            nombreAnimal = Nombre;
        }

        public override void Respirar() => Console.WriteLine("Soy un animal mamifero capaz de respirar");

        public override void GetNombre() => Console.WriteLine("El nombre del animal mamifero es: " + nombreAnimal);


        public void CuidarCrias() => Console.WriteLine("Cuido de mis crias hasta que se independizen");

        public virtual void Pensar() => Console.WriteLine("Pensamiento basico instintivo");

    }
    class Gato : Mamiferos
    {

        public Gato(string NombreGatito) : base(NombreGatito)
        {

        }

        public void Maullar() => Console.WriteLine("Soy capaz de maullar");

        public override void Pensar() => Console.WriteLine("Pensamiento instintivo avanzado");

    }

    sealed class Perro : Mamiferos
    {

        public Perro(string NombrePerrito) : base(NombrePerrito)
        {

        }
        public void Ladrar() => Console.WriteLine("Soy capaz de ladrar");
    }

    sealed class Elefante : Mamiferos
    {

        public Elefante(string NombreElefante) : base(NombreElefante)
        {

        }

        public void Trompear() => Console.WriteLine("Soy capaz de utilizar mi trompa hacer sonidos");

    }

    sealed class Humano : Mamiferos
    {

        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }

        public sealed override void Pensar() => Console.WriteLine("Soy capaz de pensar y de razonar (?)");

    }

    sealed class Gorila : Mamiferos
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }

    }

    sealed class Caballo : Mamiferos
    {
        public Caballo(string NombreCaballo) : base(NombreCaballo)
        {

        }

        public void Galopar() => Console.WriteLine("Soy capaz de galopar");


    }


}
