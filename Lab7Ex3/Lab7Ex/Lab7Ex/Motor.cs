using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Ex
{
    class Motor
    {
        private int capacitateC;
        private int putere;
        private string tipCombustibil;
        public Motor(int capacitateC, int putere, string tipCombustibi)
        {
            this.capacitateC = capacitateC;
            this.putere = putere;
            this.tipCombustibil = tipCombustibi;
        }
        public int CapaticateC
        {
            get { return capacitateC; }

        }

        public int Putere
        {
            get { return putere; }

        }
        public string TipCombustibil
        {
            get { return tipCombustibil; }

        }

        public void PornesteMotor()
        {
            Console.WriteLine("brr");

        }
        public void OpresteMotor()
        {
            Console.WriteLine("par poc pac ");
        }
    }
}
