using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilksCoefficient
{
    public class WilksCoefficient
    {
        // https://en.wikipedia.org/wiki/Wilks_Coefficient
        // http://mywilks.com


        private double wilksScore;

        public WilksCoefficient(double total, double weight, bool isMale)
        {
            Coefficients coefficients = new Coefficients(isMale);

            double x = weight;

            wilksScore = total * 500 / (coefficients.a + coefficients.b * x + coefficients.c * Math.Pow(x, 2) + coefficients.d * Math.Pow(x, 3) +
                coefficients.e * Math.Pow(x, 4) + coefficients.f * Math.Pow(x, 5));

        }

        public double GetScore()
        {
            return Math.Round(wilksScore, 2);
        }
    }
}
