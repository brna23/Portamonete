using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bernabe.mattia._4j.portamonete.models
{
    class Portamonete
    {
        public double totale;
        public double num50;
        public double num1;
        public double num2;

        public Portamonete()
        {
            totale = 0.0;
            num50 = 0;
            num1 = 0;
            num2 = 0;
        }
        public Portamonete(int a, int b, int c)
        {
            num50 = a;
            num1 = b;
            num2 = c;
            totale = (0.50 * a) + (1 * b) + (1 * c);
        }
        public double inserisci(double valore)
        {
            if (valore == 50 || valore == 1 || valore == 2)
            {
                if (valore == 50)
                    valore = 0.50;
                totale += valore;
                switch (valore)
                {
                    case 0.50:
                        num50 ++;
                        break;
                    case 1:
                        num1 ++;
                        break;
                    case 2:
                        num2 ++;
                        break;
                }
                return totale;
            }
            return 1;
        }
        public double inserisci(double valore, int n)
        {
            if (valore == 50 || valore == 1 || valore == 2)
            {
                if (valore == 50)
                    valore = 0.50;
                totale += (valore * n);
                switch (valore)
                {
                    case 0.50:
                        num50+=n;
                        break;
                    case 1:
                        num1 += n;
                        break;
                    case 2:
                        num2 += n;
                        break;
                }
                return totale;
            }
            return 1;
        }
        public string denaro()
        {
            double c = 0;
            c = totale;
            return Convert.ToString(c);
        }
        public string denaroTipo()
        {
            return $"Monete da 50cent (" + num50 + ") / Monete da 1€ (" + num1 + ") / Monete da 2€ (" + num2 + ")";
        }
    }
}
