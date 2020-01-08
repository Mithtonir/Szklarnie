using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrarium_ZSI
{
    public class Logika
    {
        public double[,] temperatura = new double[5, 61];

        public double MocGrzania(double _roznicaTemperatur)
        {
            #region Zmienne

            double[,] mocGrzania = new double[5, 61];
            double[,] wnioskowanieGrzanie = new double[5, 61];
            double[,] agregacjaGrzanie = new double[2, 61];

            double zimno;
            double cieplo;
            double srednioCieplo;
            double goraco;

            double slabo;
            double srednio;
            double srednioMocno;
            double mocno;

            double rozmytaZimno = 0;
            double rozmytaCieplo = 0;
            double rozmytaSrednioCieplo = 0;
            double rozmytaGoraco = 0;

            double wejscie;
            double srodek;
            double gora = 0;
            double dol = 0;

            double a;
            double b;
            double x;
            double x0;
            double x1;
            double x2;

            double tmp = 0;
            double tmp2 = 0;

            #endregion

            #region Zmienna lingwistyczna różnica temperatur

            for (int i = 0; i < temperatura.GetLength(0); i++)
            {
                for (int y = 0; y < 61; y++)
                {
                    temperatura[i, y] = 0;
                    mocGrzania[i, y] = 0;
                }
            }

            for (int i = 0; i < 61; i++)
            {
                x = i;

                temperatura[0, i] = x;

                a = 0;
                x1 = 0;
                x2 = 5;
                b = 10;

                if (a <= x && x <= x1)
                {
                    double temp = x1 - a;
                    if (temp != 0)
                    {
                        zimno = (x - a) / (x1 - a);
                    }
                    else
                    {
                        zimno = 1;
                    }
                }
                else if (x1 <= x && x <= x2)
                {
                    zimno = 1;
                }
                else if (x2 <= x && x <= b)
                {
                    zimno = (b - x) / (b - x2);
                }
                else
                {
                    zimno = 0;
                }

                a = 5;
                x0 = 10;
                b = 15;

                if (a <= x && x <= x0)
                {
                    double temp = x0 - a;
                    if (temp != 0)
                    {
                        cieplo = (x - a) / (x0 - a);
                    }
                    else
                    {
                        cieplo = 1;
                    }
                }
                else if (x0 <= x && x <= b)
                {
                    cieplo = (b - x) / (b - x0);
                }
                else
                {
                    cieplo = 0;
                }

                a = 10;
                x0 = 15;
                b = 20;

                if (a <= x && x <= x0)
                {
                    srednioCieplo = (x - a) / (x0 - a);
                }
                else if (x0 <= x && x <= b)
                {
                    srednioCieplo = (b - x) / (b - x0);
                }
                else
                {
                    srednioCieplo = 0;
                }

                a = 15;
                x1 = 20;
                x2 = 60;
                b = 60;

                if (a <= x && x <= x1)
                {
                    double temp = x1 - a;
                    if (temp != 0)
                    {
                        goraco = (x - a) / (x1 - a);
                    }
                    else
                    {
                        goraco = 1;
                    }
                }
                else if (x1 <= x && x <= x2)
                {
                    goraco = 1;
                }
                else if (x2 <= x && x <= b)
                {
                    goraco = (b - x) / (b - x2);
                }
                else
                {
                    goraco = 0;
                }


                temperatura[1, i] = zimno;
                temperatura[2, i] = cieplo;
                temperatura[3, i] = srednioCieplo;
                temperatura[4, i] = goraco;
            }

            #endregion

            #region Zmienna lingwistyczna moc grzania

            for (int i = 0; i < 61; i++)
            {
                x = i * 1.639344;
                mocGrzania[0, i] = x;

                a = 0;
                x1 = 0;
                x2 = 15;
                b = 30;

                if (a <= x && x <= x1)
                {
                    double temp = x1 - a;
                    if (temp != 0)
                    {
                        slabo = (x - a) / (x1 - a);
                    }
                    else
                    {
                        slabo = 1;
                    }
                }
                else if (x1 <= x && x <= x2)
                {
                    slabo = 1;
                }
                else if (x2 <= x && x <= b)
                {
                    slabo = (b - x) / (b - x2);
                }
                else
                {
                    slabo = 0;
                }

                a = 20;
                x0 = 40;
                b = 60;

                if (a <= x && x <= x0)
                {
                    srednio = (x - a) / (x0 - a);
                }
                else if (x0 <= x && x <= b)
                {
                    srednio = (b - x) / (b - x0);
                }
                else
                {
                    srednio = 0;
                }

                a = 40;
                x0 = 60;
                b = 80;

                if (a <= x && x <= x0)
                {
                    srednioMocno = (x - a) / (x0 - a);
                }
                else if (x0 <= x && x <= b)
                {
                    srednioMocno = (b - x) / (b - x0);
                }
                else
                {
                    srednioMocno = 0;
                }

                a = 70;
                x1 = 85;
                x2 = 100;
                b = 100;

                if (a <= x && x <= x1)
                {
                    mocno = (x - a) / (x1 - a);
                }
                else if (x1 <= x && x <= x2)
                {
                    mocno = 1;
                }
                else if (x2 <= x && x <= b)
                {
                    double temp = b - x2;
                    if (temp != 0)
                    {
                        mocno = (b - x) / (b - x2);
                    }
                    else
                    {
                        mocno = 1;
                    }
                }
                else
                {
                    mocno = 0;
                }

                mocGrzania[1, i] = slabo;
                mocGrzania[2, i] = srednio;
                mocGrzania[3, i] = srednioMocno;
                mocGrzania[4, i] = mocno;
            }

            #endregion

            wejscie = _roznicaTemperatur;

            #region Rozmywanie temperatury

            for (int i = 0; i < 61; i++)
            {
                if (temperatura[0, i] == wejscie)
                {
                    rozmytaZimno = temperatura[1, i];
                    rozmytaCieplo = temperatura[2, i];
                    rozmytaSrednioCieplo = temperatura[3, i];
                    rozmytaGoraco = temperatura[4, i];
                }
            }

            #endregion

            #region Wnioskowanie

            for (int i = 0; i < 61; i++)
            {
                wnioskowanieGrzanie[0, i] = i * 1.639344;
                agregacjaGrzanie[0, i] = i * 1.639344;

                if (mocGrzania[1, i] > rozmytaZimno)
                {
                    wnioskowanieGrzanie[1, i] = rozmytaZimno;
                }
                else
                {
                    wnioskowanieGrzanie[1, i] = mocGrzania[1, i];
                }

                if (mocGrzania[2, i] > rozmytaCieplo)
                {
                    wnioskowanieGrzanie[2, i] = rozmytaCieplo;
                }
                else
                {
                    wnioskowanieGrzanie[2, i] = mocGrzania[2, i];
                }

                if (mocGrzania[3, i] > rozmytaSrednioCieplo) 
                {
                    wnioskowanieGrzanie[3, i] = rozmytaSrednioCieplo;
                }
                else
                {
                    wnioskowanieGrzanie[3, i] = mocGrzania[3, i];
                }

                if (mocGrzania[4, i] > rozmytaGoraco) 
                {
                    wnioskowanieGrzanie[4, i] = rozmytaGoraco;
                }
                else
                {
                    wnioskowanieGrzanie[4, i] = mocGrzania[4, i];
                }

                tmp = Math.Max(wnioskowanieGrzanie[1, i], wnioskowanieGrzanie[2, i]);
                tmp2 = Math.Max(tmp, wnioskowanieGrzanie[3, i]);
                agregacjaGrzanie[1, i] = Math.Max(tmp2, wnioskowanieGrzanie[4, i]);
                gora = gora + (agregacjaGrzanie[1, i] * agregacjaGrzanie[0, i]);
                dol = dol + (agregacjaGrzanie[1, i]);

            }

            #endregion

            srodek = gora / dol;

            return srodek;
        }
    }
}
