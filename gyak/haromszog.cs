using System;
using System.Collections.Generic;

namespace gyak
{
    internal class haromszog
    {
        private double a;
        private double b;
        private double c;

        public double terulet { get; private set; }
        public double kerulet { get; private set; }
        public bool szerkesztheto { get; private set; }
        private void szerk()
        {
            if (a+b>c && a+c>b&&b+c>a)
            {
                szerkesztheto = true;
                terulet = tszam();
                kerulet = kszam();
            }
            else
            {
                szerkesztheto = false;
                kerulet = 0;
                terulet = 0;
            }
        }
        private double tszam()
        {
            double s = (a + b + c) / 2;
            double t = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return t;
        }
        private double kszam()
        {
            return a + b + c;
        }
        public List<string> adatok()
        {
            List<string> list = new List<string>();
            
            if (szerkesztheto)
            {
                list.Add($"a: {a}| b: {b}| c:{c} ");
                list.Add($"Kerület: {kerulet} Terület: {terulet}");
            }
            else
            {
                list.Add("Nem szerkeszthető");
            }
            return list;
        }
        public haromszog(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            szerk();
            
        }
    }
}