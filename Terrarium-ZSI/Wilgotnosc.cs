using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrarium_ZSI
{
    public class Wilgotnosc
    {
        public double[,] WilgotnoscWew = new double[101, 4];
        
        public void TermyWew(double[,] zakres, int _wilgotnosc)
        {
            for (int i = 1; i < 101; i++)
            {
                double _sucho;
                double _wilgotno;
                double _mokro;

                var wartosc = _wilgotnosc -1;
                if (i >= 0 && i <= wartosc)
                {
                    _sucho = (float)(wartosc - i) / (float)wartosc;
                }
                else
                {
                    _sucho = 0;
                }

                var wartosc2 = _wilgotnosc - 2;
                var wartosc3 = _wilgotnosc + 2;
                if (i >= wartosc2 && i <= _wilgotnosc)
                {
                    _wilgotno = (float)(i - wartosc2) / (float)(_wilgotnosc - wartosc2);
                }
                else if (i >= _wilgotnosc && i <= wartosc3)
                {
                    _wilgotno = (float)(wartosc3 - i) / (float)(wartosc3 - _wilgotnosc);
                }
                else
                {
                    _wilgotno = 0;
                }

                var wartosc4 = _wilgotnosc + 1;
                if (i >= wartosc4 && i <= 100)
                {
                    _mokro = (float)(i - wartosc4) / (float)(100 - wartosc4);
                }
                else
                {
                    _mokro = 0;
                }

                zakres[i, 0] = i;
                zakres[i, 1] = _sucho;
                zakres[i, 2] = _wilgotno;
                zakres[i, 3] = _mokro;
            }
        }

        public void Test()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(" Temp: " + WilgotnoscWew[i, 0]);
            }

            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(" Zimno[" + i + "] : " + WilgotnoscWew[i, 1]);
            }

            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(" Ciepło[" + i + "] : " + WilgotnoscWew[i, 2]);
            }

            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(" Gorąco[" + i + "] : " + WilgotnoscWew[i, 3]);
            }
        }
    }
}
