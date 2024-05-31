using ComposicionSobreHerencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionSobreHerencia.Engines
{
    public class ElectricEngine : IEngine
    {
        public void Move()
        {
            Console.WriteLine("Desplazamiento de auto eléctrico.");
        }
    }
}
