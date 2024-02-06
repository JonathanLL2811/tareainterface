using tareainterface;

    class Programa
    {
         static void Main(string[] args)
        {
            // Creamos instancias de las clases
            Perro miPerro = new Perro("Fido");
            Gato miGato = new Gato("Whiskers");

            // Mostramos los datos en la consola
            Console.WriteLine("Mi perro:");
            Console.WriteLine("Nombre: " + miPerro.nombre);
            Console.Write("Sonido: ");
            miPerro.HacerSonido();

            Console.WriteLine("\nMi gato:");
            Console.WriteLine("Nombre: " + miGato.nombre);
            Console.Write("Sonido: ");
            miGato.HacerSonido();
        }
    }