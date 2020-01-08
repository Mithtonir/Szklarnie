using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrarium_ZSI
{
    public class LogikaWilgotnosc
    {
        public double[,] wilgotnosc = new double[5, 61];

        public double MocZraszania(double _roznicaWilgotnosci)
        {
            #region Zmienne

            double[,] mocZraszania = new double[5, 61];
            double[,] wnioskowanieZraszanie = new double[5, 61];
            double[,] agregacjaZraszanie = new double[2, 61];

            double sucho;
            double wilgotno;
            double mokro;
            double bardzoMokro;

            double slabo;
            double srednio;
            double srednioMocno;
            double mocno;

            double rozmytaSucho = 0;
            double rozmytaWilgotno = 0;
            double rozmytaMokro = 0;
            double rozmytaBardzoMokro = 0;

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

            for (int i = 0; i < wilgotnosc.GetLength(0); i++)
            {
                for (int y = 0; y < 61; y++)
                {
                    wilgotnosc[i, y] = 0;
                    mocZraszania[i, y] = 0;
                }
            }

            for (int i = 0; i < 61; i++)
            {
                x = i;

                wilgotnosc[0, i] = x;

                a = 0;
                x1 = 0;
                x2 = 5;
                b = 10;

                if (a <= x && x <= x1)
                {
                    double temp = x1 - a;
                    if (temp != 0)
                    {
                        sucho = (x - a) / (x1 - a);
                    }
                    else
                    {
                        sucho = 1;
                    }
                }
                else if (x1 <= x && x <= x2)
                {
                    sucho = 1;
                }
                else if (x2 <= x && x <= b)
                {
                    sucho = (b - x) / (b - x2);
                }
                else
                {
                    sucho = 0;
                }

                a = 5;
                x0 = 10;
                b = 15;

                if (a <= x && x <= x0)
                {
                    double temp = x0 - a;
                    if (temp != 0)
                    {
                        wilgotno = (x - a) / (x0 - a);
                    }
                    else
                    {
                        wilgotno = 1;
                    }
                }
                else if (x0 <= x && x <= b)
                {
                    wilgotno = (b - x) / (b - x0);
                }
                else
                {
                    wilgotno = 0;
                }

                a = 10;
                x0 = 15;
                b = 20;

                if (a <= x && x <= x0)
                {
                    mokro = (x - a) / (x0 - a);
                }
                else if (x0 <= x && x <= b)
                {
                    mokro = (b - x) / (b - x0);
                }
                else
                {
                    mokro = 0;
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
                        bardzoMokro = (x - a) / (x1 - a);
                    }
                    else
                    {
                        bardzoMokro = 1;
                    }
                }
                else if (x1 <= x && x <= x2)
                {
                    bardzoMokro = 1;
                }
                else if (x2 <= x && x <= b)
                {
                    bardzoMokro = (b - x) / (b - x2);
                }
                else
                {
                    bardzoMokro = 0;
                }


                wilgotnosc[1, i] = sucho;
                wilgotnosc[2, i] = wilgotno;
                wilgotnosc[3, i] = mokro;
                wilgotnosc[4, i] = bardzoMokro;
            }

            #endregion

            #region Zmienna lingwistyczna moc grzania

            for (int i = 0; i < 61; i++)
            {
                x = i * 1.639344;
                mocZraszania[0, i] = x;

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

                mocZraszania[1, i] = slabo;
                mocZraszania[2, i] = srednio;
                mocZraszania[3, i] = srednioMocno;
                mocZraszania[4, i] = mocno;
            }

            #endregion

            wejscie = _roznicaWilgotnosci;

            #region Rozmywanie temperatury

            for (int i = 0; i < 61; i++)
            {
                if (wilgotnosc[0, i] == wejscie)
                {
                    rozmytaSucho = wilgotnosc[1, i];
                    rozmytaWilgotno = wilgotnosc[2, i];
                    rozmytaMokro = wilgotnosc[3, i];
                    rozmytaBardzoMokro = wilgotnosc[4, i];
                }
            }

            #endregion

            #region Wnioskowanie

            for (int i = 0; i < 61; i++)
            {
                wnioskowanieZraszanie[0, i] = i * 1.639344;
                agregacjaZraszanie[0, i] = i * 1.639344;

                if (mocZraszania[1, i] > rozmytaSucho)
                {
                    wnioskowanieZraszanie[1, i] = rozmytaSucho;
                }
                else
                {
                    wnioskowanieZraszanie[1, i] = mocZraszania[1, i];
                }

                if (mocZraszania[2, i] > rozmytaWilgotno)
                {
                    wnioskowanieZraszanie[2, i] = rozmytaWilgotno;
                }
                else
                {
                    wnioskowanieZraszanie[2, i] = mocZraszania[2, i];
                }

                if (mocZraszania[3, i] > rozmytaMokro)
                {
                    wnioskowanieZraszanie[3, i] = rozmytaMokro;
                }
                else
                {
                    wnioskowanieZraszanie[3, i] = mocZraszania[3, i];
                }

                if (mocZraszania[4, i] > rozmytaBardzoMokro)
                {
                    wnioskowanieZraszanie[4, i] = rozmytaBardzoMokro;
                }
                else
                {
                    wnioskowanieZraszanie[4, i] = mocZraszania[4, i];
                }

                tmp = Math.Max(wnioskowanieZraszanie[1, i], wnioskowanieZraszanie[2, i]);
                tmp2 = Math.Max(tmp, wnioskowanieZraszanie[3, i]);
                agregacjaZraszanie[1, i] = Math.Max(tmp2, wnioskowanieZraszanie[4, i]);
                gora = gora + (agregacjaZraszanie[1, i] * agregacjaZraszanie[0, i]);
                dol = dol + (agregacjaZraszanie[1, i]);

            }

            #endregion

            srodek = gora / dol;

            return srodek;
        }
    }
}
