using ComposicionSobreHerencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionSobreHerencia.Engines
{
    public class CombustionEngine : IEngine
    {
        public void Move()
        {
            Console.WriteLine("Desplazamiento de auto con combustible.");
        }
    }
}
