using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Barcode.Models
{
    public class Container
    {
        private Server server;

        /// <summary>
        /// Конструктор копирования.
        /// </summary>
        /// <param name="Sserver"></param>
        public Container(Server Sserver)
        {
            server = Sserver;
        }
        /// <summary>
        /// Консткруктор инициализации.
        /// </summary>
        public Container()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("----------------Program info:----------------");

            this.server = new Server();

            var bar1 = new Barcode("32345675", "Snickers");
            var bar2 = new Barcode("12987671", "Evian water");
            var bar3 = new Barcode("09845319", "Sandora orange juice");
            var bar4 = new Barcode("98547378", "Twix");
            var bar5 = new Barcode("89709176", "M&M's");

            var dev1 = new Device();
            var dev2 = new Device();
            var dev3 = new Device();

            dev1.AddToHistory(bar1);
            dev2.AddToHistory(bar2);
            dev3.AddToHistory(bar3);
            dev1.AddToHistory(bar4);
            dev2.AddToHistory(bar5);
            dev3.AddToHistory(bar1);
            dev2.AddToHistory(bar2);
            dev3.AddToHistory(bar3);
            dev3.AddToHistory(bar4);

            server.AddDevice(dev1);
            server.AddDevice(dev2);
            server.AddDevice(dev3);

            server.AddBarcode(bar1);
            server.AddBarcode(bar2);
            server.AddBarcode(bar3);
            server.AddBarcode(bar4);
            server.AddBarcode(bar5);
        }
        public override string ToString()
        {
            return this.server.ToString();
        }
    }
}
