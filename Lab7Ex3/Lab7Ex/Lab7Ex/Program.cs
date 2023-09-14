using System;

namespace Lab7Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor Tdi = new Motor(2000, 144, "Motorina");
            Motor TFSI = new Motor(2000, 12234, "Benzina");
            Motor TFSI2 = new Motor(1400, 924, "Motorina");
            Usa usi = new Usa(5);
            Autoturism Golf6 = new Autoturism("VW", 2012, "Golf6", usi, Tdi);
            Autoturism Golf5 = new Autoturism("VW", 2006, "Golf5", usi, TFSI);
            Autoturism Corsa = new Autoturism("Opel", 2012, "Corsa", usi, TFSI2);
            Console.WriteLine(Golf6.GetDescription());
          
            Golf6.PornesteMasina();
            Golf6.OpresteMasina();
            Autoturism.SHowTotalAutoturisme();
            Console.WriteLine(Autoturism.CelMaiPuternic());
        }
    }
}
