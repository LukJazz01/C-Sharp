using System;

namespace Peronismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Puerta puerta = new Puerta();
            puerta.color = "Marron";
            Departamentinho departamentinho = new Departamentinho(puerta);
            Persona persona = new Persona();

            persona.casa = departamentinho;
            persona.nombre = "Juan Domingo";

            persona.ShowData();
        }
    }
}