using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Text.RegularExpressions;

namespace OppgaveAbaxOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vehicleRegistry = new VehicleRegistry();
            vehicleRegistry.Run();
        }
    }
}