using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OldPrinter oldPrinter = new OldPrinter();
            PrinterAdapter printerAdapter = new PrinterAdapter(oldPrinter);
            Console.ReadLine();
        }
    }
}
