using ComposicionSobreHerencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionSobreHerencia.Drivers
{
    public class Human : IDriver
    {
        public void Navigate(string destination)
        {
            Console.WriteLine($"Navegando a {destination} usando un conductor humano.");
        }
    }
}
