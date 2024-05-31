using ComposicionSobreHerencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicionSobreHerencia.Models
{
    public class Transport
    {
        private IEngine _engine;
        private IDriver _driver;

        public Transport(IEngine engine, IDriver driver)
        {
            _engine = engine;
            _driver = driver;
        }

        public void Deliver(string destination, string cargo)
        {
            _driver.Navigate(destination);
            _engine.Move();
            Console.WriteLine($"Entregando {cargo} a {destination}.\n");
        }
    }
}
