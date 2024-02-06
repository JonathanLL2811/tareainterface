using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareainterface
{
    class Perro : IAnimal
{
    public string nombre;

    public Perro(string nombre)
    {
        this.nombre = nombre;
    }

    public void HacerSonido()
    {
        Console.WriteLine("Guau!");
    }
}

}
