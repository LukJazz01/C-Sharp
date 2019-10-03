using System;

namespace Peronismo
{
    public class Persona
    {
        public string nombre;
        public Casa casa;

        public void ShowData()
        {
            Console.WriteLine(nombre);
        }

    }
}