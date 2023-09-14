using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Ex
{
    class Usa
    {
        public int NumarUsi { get; set; }

        public Usa(int numarUsi)
        {
            NumarUsi = numarUsi;
        }
        public void DeschideUsa()
        {
            Console.WriteLine("Click");
        }

        public void InchideUsa()
        {
            Console.WriteLine("Clack");
        }
    }
}
