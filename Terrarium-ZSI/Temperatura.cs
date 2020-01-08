using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrarium_ZSI
{
    public class Temperatura
    {
        public double[,] TemperaturaZewnetrzna = new double[61, 4];
        public double[,]TemperaturaWewnetrzna = new double[61, 5];

        public void TermyWew(double[,] zakres, int minimalna, int maksymalna)
        {
            for (int i = 1; i < 61; i++)
            {
                double _zimno;
                float _cieplo;
                float _goraco;
                
                // zimno
                if (i >= 0 && i <= minimalna + 1)
                {
                    var min = minimalna + 1;
                    _zimno = (float)(min - i) / (float)(minimalna + 1);
                }
                else
                {
                    _zimno = 0;
                }

                // cieplo
                if (i >= minimalna && i <= (minimalna + maksymalna) / 2)
                {
                    _cieplo = (float)(i - minimalna) / (float)(((minimalna + maksymalna) / 2) - minimalna);
                }
                else if (i > (minimalna + maksymalna) / 2 && i <= maksymalna)
                {
                    _cieplo = (float)(maksymalna - i) / (float)(((minimalna + maksymalna) / 2) - minimalna);
                }
                else
                {
                    _cieplo = 0;
                }

                // gorąco
                var max = maksymalna - 1;
                if (i >= max && i <= 60)
                {
                    _goraco = (float)(i - max) / (float)(60 - max);
                }
                else
                {
                    _goraco = 0;
                }

                zakres[i, 0] = i;
                zakres[i, 1] = _zimno;
                zakres[i, 2] = _cieplo;
                zakres[i, 3] = _goraco;
            }
        }

        public void TermyZew(double[,] zakres)
        {
            for (int i = 1; i < 61; i++)
            {
                double _zimno;
                float _cieplo;
                float _goraco;

                // zimno
                if (i >= 0 && i <= 16)
                {
                    _zimno = (float)(16 - i) / (float)(16);
                }
                else
                {
                    _zimno = 0;
                }

                // cieplo
                if (i >= 15 && i <= 20)
                {
                    _cieplo = (float)(i - 15) / (float)(5);
                }
                else if (i > 20 && i <= 25)
                {
                    _cieplo = (float)(25 - i) / (float)(5);
                }
                else
                {
                    _cieplo = 0;
                }

                // gorąco
                if (i >= 24 && i <= 60)
                {
                    _goraco = (float)(i - 24) / (float)(36);
                }
                else
                {
                    _goraco = 0;
                }

                zakres[i, 0] = i;
                zakres[i, 1] = _zimno;
                zakres[i, 2] = _cieplo;
                zakres[i, 3] = _goraco;
            }
        }

        public void TermyZew ()
        {
            for (int i = 1; i < 61; i++)
            {
                Console.WriteLine(" Temp: " + TemperaturaWewnetrzna[i,0]);
            }

            for (int i = 1; i < 61; i++)
            {
                Console.WriteLine(" Zimno[" + i + "] : " + TemperaturaWewnetrzna[i, 1]);
            }

            for (int i = 1; i < 61; i++)
            {
                Console.WriteLine(" Ciepło[" + i + "] : " + TemperaturaWewnetrzna[i, 2]);
            }

            for (int i = 1; i < 61; i++)
            {
                Console.WriteLine(" Gorąco[" + i + "] : " + TemperaturaWewnetrzna[i, 3]);
            }
        }
    }
}
