using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilksCoefficient
{
    public class Coefficients
    {
        public double a;
        public double b;
        public double c;
        public double d;
        public double e;
        public double f;

        public Coefficients(bool isMale)
        {
            if (isMale)
            {
                a = -216.0475144;
                b = 16.2606339;
                c = -0.002388645;
                d = -0.00113732;
                e = 7.01863E-06;
                f = -1.291E-08;
            }
            else
            {
                a = 594.31747775582;
                b = -27.23842536447;
                c = 0.82112226871;
                d = -0.00930733913;
                e = 0.00004731582;
                f = -0.00000009054;
            }
        }

    }
}

