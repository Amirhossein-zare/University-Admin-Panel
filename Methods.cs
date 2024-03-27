using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Panel_Uni
{
    internal class Methods
    {
        public static void PrintJustNumber(string word)
        {
            DateTime.Now.PrintDateTime();
            Console.WriteLine("Warning !!!\n");
            Thread.Sleep(2000);
            Console.WriteLine("\tJust Numbers");
            Console.WriteLine("\tYou can type only number for {0}",word);
            Console.WriteLine("\tPlease wait a moment");
            Thread.Sleep(5000);
            DateTime.Now.PrintDateTime();
        }
        public static void PrintJustEnglish() 
        {
            DateTime.Now.PrintDateTime();
            Console.WriteLine("Warning !!!\n");
            Thread.Sleep(2000);
            Console.WriteLine("\tWe understood");
            Console.WriteLine("\tBut remember to type only in English");
            Console.WriteLine("\tplease wait a moment");
            Thread.Sleep(5000);
        }
    }
}
