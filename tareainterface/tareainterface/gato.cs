using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareainterface
{
    class Gato : IAnimal
    {
        public string nombre;

        public Gato(string nombre)
        {
            this.nombre = nombre;
        }

        public void HacerSonido()
        {
            Console.WriteLine("Miau!");
        }
    }

}
