using Lab1_Barcode.Models;
using System;


namespace Lab1_Barcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Authors:{Environment.NewLine}*Nazar Kozhin {Environment.NewLine}*Max Zayarnuk {Environment.NewLine}*Nastya Stadnyk. {Environment.NewLine} ^^^^Version 1.^^^^");
            var container = new Container();

            Console.WriteLine(container.ToString());
        }
    }
}
