using ComposicionSobreHerencia.Drivers;
using ComposicionSobreHerencia.Engines;
using ComposicionSobreHerencia.Interfaces;
using ComposicionSobreHerencia.Models;

namespace ComposicionSobreHerencia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEngine combustionEngine = new CombustionEngine();
            IEngine electricEngine = new ElectricEngine();

            IDriver robotDriver = new Robot();
            IDriver humanDriver = new Human();

            Transport transport1 = new Transport(combustionEngine, robotDriver);
            transport1.Deliver("Almacen 1", "Carga A");

            Transport transport2 = new Transport(electricEngine, humanDriver);
            transport2.Deliver("Almacen 2", "Cargo B");
        }
    }
}
