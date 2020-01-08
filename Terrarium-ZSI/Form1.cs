using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Terrarium_ZSI
{
    public partial class Form1 : Form
    {
        public double[,] Transponowana = new double[61, 5];
        public double[,] TransponowanaWilgotnosc = new double[61, 5];

        public int TemperaturaDocelowa = 0;
        public int TemperaturaStarowa = 0;
        public int iter = 1;
        public int TemperaturaOsiagnieta = 0;
        public int Srednia = 0;

        public int WilgotnoscDocelowa = 0;
        public int WilgotnoscStartowa = 0;
        public int WilgotnoscOsiagnieta = 0;
        public int SredniaWilgotnosc = 0;

        public float RozmytaTemperatura = 0;
        public float RozmytaOdleglosc = 0;
        public float RozmytaWilgotnosc = 0;

        public int Term1 = 0;
        public int Term2 = 0;
        public int Term3 = 0;

        public int TempMin = 0;
        public int TempMax = 0;

        public Temperatura temperatura = new Temperatura();
        public Wilgotnosc wilgotnosc = new Wilgotnosc();
        public Plant Lamparci, Orzesiony, Placzacy, Waz, Zolw, Agama;
        Logika logika = new Logika();

        public Form1()
        {
            InitializeComponent();
        }

        public void OdswiezWykres()
        {
            MinMax();

            temperatura.TermyWew(temperatura.TemperaturaWewnetrzna, TempMin, TempMax);
            //temperatura.TermyZew();

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            logika.MocGrzania(0);

            for (int i = 0; i < 61; i++)
            {
                Transponowana[i, 1] = logika.temperatura[1, i];
                Transponowana[i, 2] = logika.temperatura[2, i];
                Transponowana[i, 3] = logika.temperatura[3, i];
                Transponowana[i, 4] = logika.temperatura[4, i];
            }

            for (int i = 1; i < 61; i++)
            {
                chart1.Series["Zimno"].Points.Add(Transponowana[i, 1]);
                chart1.Series["Ciepło"].Points.Add(Transponowana[i, 2]);
                chart1.Series["Gorąco"].Points.Add(Transponowana[i, 3]);
                chart1.Series["Bardzo Gorąco"].Points.Add(Transponowana[i, 4]);
            }

            chart1.Series.Invalidate();

            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }

            wilgotnosc.TermyWew(wilgotnosc.WilgotnoscWew, SredniaWilgotnosc);

            LogikaWilgotnosc logikaWilgotnosc = new LogikaWilgotnosc();
            logikaWilgotnosc.MocZraszania(0);

            for (int i = 0; i < 61; i++)
            {
                TransponowanaWilgotnosc[i, 1] = logikaWilgotnosc.wilgotnosc[1, i];
                TransponowanaWilgotnosc[i, 2] = logikaWilgotnosc.wilgotnosc[2, i];
                TransponowanaWilgotnosc[i, 3] = logikaWilgotnosc.wilgotnosc[3, i];
                TransponowanaWilgotnosc[i, 4] = logikaWilgotnosc.wilgotnosc[4, i];
            }

            for (int i = 1; i < 61; i++)
            {
                chart2.Series["Sucho"].Points.Add(TransponowanaWilgotnosc[i, 1]);
                chart2.Series["Wilgotno"].Points.Add(TransponowanaWilgotnosc[i, 2]);
                chart2.Series["Mokro"].Points.Add(TransponowanaWilgotnosc[i, 3]);
                chart2.Series["Bardzo Mokro"].Points.Add(TransponowanaWilgotnosc[i, 4]);
            }

            chart2.Series.Invalidate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Blanciki();
            MinMax();

            #region Temperatura wykres

            temperatura.TermyWew(temperatura.TemperaturaWewnetrzna, 25, 30);
            temperatura.TermyZew(temperatura.TemperaturaZewnetrzna);
            temperatura.TermyZew();

            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            chart1.MouseWheel += chart1_MouseWheel;

            //.Series.Add("Zimno");
            chart1.Series["Zimno"].BorderWidth = 3;
            chart1.Series["Zimno"].ChartType = SeriesChartType.Line;
            chart1.Series["Zimno"].ChartArea = "ChartArea1";

            //chart1.Series.Add("Ciepło");
            chart1.Series["Ciepło"].BorderWidth = 3;
            chart1.Series["Ciepło"].ChartType = SeriesChartType.Line;
            chart1.Series["Ciepło"].ChartArea = "ChartArea1";

            //chart1.Series.Add("Gorąco");
            chart1.Series["Gorąco"].BorderWidth = 3;
            chart1.Series["Gorąco"].ChartType = SeriesChartType.Line;
            chart1.Series["Gorąco"].ChartArea = "ChartArea1";

            //chart1.Series.Add("Bardzo Gorąco");
            chart1.Series["Bardzo Gorąco"].BorderWidth = 3;
            chart1.Series["Bardzo Gorąco"].ChartType = SeriesChartType.Line;
            chart1.Series["Bardzo Gorąco"].ChartArea = "ChartArea1";

            logika.MocGrzania(0);

            for (int i = 0; i < 61; i++)
            {
                Transponowana[i, 1] = logika.temperatura[1, i];
                Transponowana[i, 2] = logika.temperatura[2, i];
                Transponowana[i, 3] = logika.temperatura[3, i];
                Transponowana[i, 4] = logika.temperatura[4, i];
            }

            for (int i = 1; i < 61; i++)
            {
                chart1.Series["Zimno"].Points.Add(Transponowana[i, 1]);
                chart1.Series["Ciepło"].Points.Add(Transponowana[i, 2]);
                chart1.Series["Gorąco"].Points.Add(Transponowana[i, 3]);
                chart1.Series["Bardzo Gorąco"].Points.Add(Transponowana[i, 4]);
            }

            #endregion

            #region Wilgotność

            wilgotnosc.TermyWew(wilgotnosc.WilgotnoscWew, 60);
            //wilgotnosc.Test();

            //chart2.Series.Add("Sucho");
            chart2.Series["Sucho"].BorderWidth = 3;
            chart2.Series["Sucho"].ChartType = SeriesChartType.Line;
            chart2.Series["Sucho"].ChartArea = "ChartArea1";

            //chart2.Series.Add("Wilgotno");
            chart2.Series["Wilgotno"].BorderWidth = 3;
            chart2.Series["Wilgotno"].ChartType = SeriesChartType.Line;
            chart2.Series["Wilgotno"].ChartArea = "ChartArea1";

            //chart2.Series.Add("Mokro");
            chart2.Series["Mokro"].BorderWidth = 3;
            chart2.Series["Mokro"].ChartType = SeriesChartType.Line;
            chart2.Series["Mokro"].ChartArea = "ChartArea1";

            //chart2.Series.Add("Bardzo Mokro");
            chart2.Series["Bardzo Mokro"].BorderWidth = 3;
            chart2.Series["Bardzo Mokro"].ChartType = SeriesChartType.Line;
            chart2.Series["Bardzo Mokro"].ChartArea = "ChartArea1";

            LogikaWilgotnosc logikaWilgotnosc = new LogikaWilgotnosc();
            logikaWilgotnosc.MocZraszania(0);

            for (int i = 0; i < 61; i++)
            {
                TransponowanaWilgotnosc[i, 1] = logikaWilgotnosc.wilgotnosc[1, i];
                TransponowanaWilgotnosc[i, 2] = logikaWilgotnosc.wilgotnosc[2, i];
                TransponowanaWilgotnosc[i, 3] = logikaWilgotnosc.wilgotnosc[3, i];
                TransponowanaWilgotnosc[i, 4] = logikaWilgotnosc.wilgotnosc[4, i];
            }

            for (int i = 1; i < 61; i++)
            {
                chart2.Series["Sucho"].Points.Add(TransponowanaWilgotnosc[i, 1]);
                chart2.Series["Wilgotno"].Points.Add(TransponowanaWilgotnosc[i, 2]);
                chart2.Series["Mokro"].Points.Add(TransponowanaWilgotnosc[i, 3]);
                chart2.Series["Bardzo Mokro"].Points.Add(TransponowanaWilgotnosc[i, 3]);
            }

            #endregion
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            tbarTemperatura.Enabled = false;
            tbarWilgotnosc.Enabled = false;

            tboxTemperatura.Enabled = false;
            tboxWilgotnosc.Enabled = false;


            TemperaturaStarowa = tbarTemperatura.Value;
            TemperaturaDocelowa = Srednia;

            WilgotnoscStartowa = tbarWilgotnosc.Value;
            WilgotnoscDocelowa = SredniaWilgotnosc;

            RozmytaTemperatura = TemperaturaStarowa;
            RozmytaWilgotnosc = WilgotnoscStartowa;

            iter = 1;

            timer1.Enabled = true;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var roznica = Int32.Parse(lbSredniaTemperatura.Text) - pbTemperatura.Value;

            double outPut = 0;

            if (tbZewnatrz.Value < RozmytaTemperatura)
            {
                var zmniejszanie = tbZewnatrz.Value * 0.00001F;
                pbTemperatura.Value = pbTemperatura.Value - (int)zmniejszanie;
                RozmytaTemperatura = RozmytaTemperatura - (float)zmniejszanie;

                if (lbGrzanie.Text == "0")
                {
                    while(RozmytaTemperatura > TempMin)
                    {
                        zmniejszanie = tbZewnatrz.Value * 0.00001F;
                        pbTemperatura.Value = pbTemperatura.Value - (int)zmniejszanie;
                        RozmytaTemperatura = RozmytaTemperatura - (float)zmniejszanie;
                        Console.WriteLine(RozmytaTemperatura);
                    }
                }
            }
            
            outPut = logika.MocGrzania(roznica);

            if (Double.IsNaN(outPut) || Double.IsInfinity(outPut))
            {
                outPut = 0;
            }

            TemperaturaOsiagnieta = TemperaturaDocelowa - TemperaturaStarowa;
            RozmytaTemperatura = RozmytaTemperatura + (((float)outPut / 100) * TemperaturaOsiagnieta) / 50;

            label1.Text = RozmytaTemperatura.ToString();
            lbGrzanie.Text = outPut.ToString();
            tboxAktualnaTemperatura.Text = Math.Round(RozmytaTemperatura, MidpointRounding.ToEven).ToString();

            ////////////////////////////////////

            LogikaWilgotnosc logikaWilgotnosc = new LogikaWilgotnosc();

            var roznicaWilgotnosc = Int32.Parse(lbSredniaWilgotnosc.Text) - pbWilgotnosc.Value;

            double outPutWilgotnosc = 0;
            outPutWilgotnosc = logikaWilgotnosc.MocZraszania(roznicaWilgotnosc);

            if (Double.IsNaN(outPutWilgotnosc) || Double.IsInfinity(outPutWilgotnosc))
            {
                outPutWilgotnosc = 0;
            }

            WilgotnoscOsiagnieta = WilgotnoscDocelowa - WilgotnoscStartowa;
            RozmytaWilgotnosc = RozmytaWilgotnosc + (((float)outPutWilgotnosc / 100) * WilgotnoscOsiagnieta) / 50;

            label7.Text = RozmytaWilgotnosc.ToString();
            lbZraszanie.Text = outPutWilgotnosc.ToString();
            tboxAktualnaWilgotnosc.Text = Math.Round(RozmytaWilgotnosc, MidpointRounding.ToEven).ToString();

            ///////////////////////////////////////

            #region Stare

            /*
            double _zimno = 0;
            double _cieplo = 0;
            double _goraco = 0;

            if (iter < 60)
            {
                _zimno = temperatura.TemperaturaWewnetrzna[iter, 1];
                _cieplo = temperatura.TemperaturaWewnetrzna[iter, 2];
                _goraco = temperatura.TemperaturaWewnetrzna[iter, 3];
            }

            if (iter == 99)
            {
                Console.WriteLine();
            }

            var _sucho = wilgotnosc.WilgotnoscWew[iter, 1];
            var _wilgotno = wilgotnosc.WilgotnoscWew[iter, 2];
            var _mokro = wilgotnosc.WilgotnoscWew[iter, 3];

            var R1 = Math.Min(_zimno, _sucho);
            var R2 = Math.Min(_zimno, _wilgotno);
            var R3 = Math.Min(_zimno, _mokro);

            var R4 = Math.Min(_cieplo, _sucho);
            var R5 = Math.Min(_cieplo, _wilgotno);
            var R6 = Math.Min(_cieplo, _mokro);

            var R7 = Math.Min(_goraco, _sucho);
            var R8 = Math.Min(_goraco, _wilgotno);
            var R9 = Math.Min(_goraco, _mokro);

            var YZM = new double[] { R1, R4, R7}.Max();
            var YZS = new double[] { R2, R5, R8 }.Max();
            var YZ0 = new double[] { R3, R6, R9 }.Max();

            var R10 = Math.Min(_zimno, _sucho);
            var R11 = Math.Min(_zimno, _wilgotno);
            var R12 = Math.Min(_zimno, _mokro);

            var R13 = Math.Min(_cieplo, _sucho);
            var R14 = Math.Min(_cieplo, _wilgotno);
            var R15 = Math.Min(_cieplo, _mokro);

            var R16 = Math.Min(_goraco, _sucho);
            var R17 = Math.Min(_goraco, _wilgotno);
            var R18 = Math.Min(_goraco, _mokro);

            var YGM = new double[] { R10, R11, R12 }.Max();
            var YGS = new double[] { R13, R14, R15 }.Max();
            var YG0 = new double[] { R16, R17, R18 }.Max();

            var YZraszanie = (float)((YZM * 100) + (YZS * 50) + (YZ0 * 0)) / (float)(YZM + YZS + YZ0);
            var YGrzanie = (float)((YGM * 100) + (YGS * 50) + (YG0 * 0)) / (float)(YGM + YGS + YG0);

            if (Double.IsNaN(YZraszanie))
            {
                YZraszanie = 0;
            }

            if (Double.IsNaN(YGrzanie))
            {
                YGrzanie = 0;
            }

            TemperaturaOsiagnieta = TemperaturaDocelowa - TemperaturaStarowa;
            RozmytaTemperatura = RozmytaTemperatura + ((YGrzanie / 100) * TemperaturaOsiagnieta) / 50;

            WilgotnoscOsiagnieta = WilgotnoscDocelowa - WilgotnoscStartowa;
            RozmytaWilgotnosc = RozmytaWilgotnosc + ((YZraszanie / 100) * WilgotnoscOsiagnieta) / 50;

            if (iter < 60)
            {
                if (tbZewnatrz.Value > RozmytaTemperatura)
                {
                    //RozmytaTemperatura = RozmytaTemperatura * 0.05F;
                }
                else
                {
                    //RozmytaTemperatura = RozmytaTemperatura * 1.02F;
                }
            }

            if (tbZewnatrz.Value < RozmytaTemperatura)
            {
                RozmytaTemperatura = RozmytaTemperatura * 0.99999F;
            }

            RozmytaWilgotnosc = RozmytaWilgotnosc * 0.99999F;

            lbGrzanie.Text = YGrzanie.ToString();
            lbZraszanie.Text = YZraszanie.ToString();

            label1.Text = RozmytaTemperatura.ToString();
            label7.Text = RozmytaWilgotnosc.ToString();

            tboxAktualnaTemperatura.Text = Math.Round(RozmytaTemperatura, MidpointRounding.ToEven).ToString();
            tboxAktualnaWilgotnosc.Text = Math.Round(RozmytaWilgotnosc, MidpointRounding.ToEven).ToString();

            iter++;

            if (iter > 60 && RozmytaTemperatura < Srednia)
            {
                TemperaturaStarowa = pbTemperatura.Value;
                TemperaturaDocelowa = Srednia;

                WilgotnoscStartowa = pbWilgotnosc.Value;
                WilgotnoscDocelowa = SredniaWilgotnosc;

                RozmytaTemperatura = TemperaturaStarowa;
                RozmytaWilgotnosc = WilgotnoscStartowa;

                iter = 1;

                timer1_Tick(this, e);
            }

            if (iter > 100)
            {
                timer1.Stop();
            }
            */
            #endregion
        }

        #region stare
        /*
        private void stare()
        {
            Odleglosc = Odleglosc + 1;

            label1.Text = Odleglosc.ToString();

            //termy

            if (Odleglosc > 0 && Odleglosc < 250)
            {
                Term1 = 1000;
                Term2 = 0;
                Term3 = 0;
            }

            if (Odleglosc > 250 && Odleglosc < 500)
            {
                Term1 = 1000 + ((250 - Odleglosc) * 4);
                Term2 = (Odleglosc - 250) * 4;
                Term3 = 0;
            }

            if (Odleglosc > 500 && Odleglosc < 750)
            {
                Term1 = 0;
                Term2 = 1000 + ((500 - Odleglosc) * 4);
                Term3 = (Odleglosc - 500) * 4;
            }

            if (Odleglosc > 750 & Odleglosc < 1000)
            {
                Term1 = 0;
                Term2 = 0;
                Term3 = 1000;
            }

            // wartość przynależności

            int y = (Term1 * 1000 + Term2 * 500 + Term3 * 0) / (Term1 + Term2 + Term3);
            float y1 = y;
            float y2 = y1 / 1000;

            TemperaturaOsiagnieta = TemperaturaDocelowa - TemperaturaStarowa;

            WilgotnoscOsiagnieta = WilgotnoscDocelowa - WilgotnoscStartowa;

            float termometr = TemperaturaOsiagnieta;
            float wilgotnosc = WilgotnoscOsiagnieta;

            RozmytaTemperatura = RozmytaTemperatura + (y2 * termometr) / 500;
            RozmytaWilgotnosc = RozmytaWilgotnosc + (y2 * wilgotnosc) / 500;

            Console.WriteLine("Prawdziwa wartość temperatury: " + RozmytaTemperatura);
            Console.WriteLine("Prawdziwa wartość wilgotności: " + RozmytaWilgotnosc);

            var TemperaturaWynikowa = Math.Round(RozmytaTemperatura, MidpointRounding.ToEven);
            var WilgotnoscWynikowa = Math.Round(RozmytaWilgotnosc, MidpointRounding.ToEven);

            tboxAktualnaTemperatura.Text = TemperaturaWynikowa.ToString();
            tboxAktualnaWilgotnosc.Text = WilgotnoscWynikowa.ToString();

            if (Odleglosc == 1000)
            {
                TemperaturaStarowa = TemperaturaDocelowa;
                WilgotnoscStartowa = WilgotnoscDocelowa;

                tbarTemperatura.Enabled = true;
                tbarWilgotnosc.Enabled = true;

                tboxTemperatura.Enabled = true;
                tboxWilgotnosc.Enabled = true;

                timer1.Stop();
            }
        }
        */
        #endregion

        private void tbarTemperatura_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tboxTemperatura.Text = tbarTemperatura.Value.ToString();
                tboxAktualnaTemperatura.Text = tbarTemperatura.Value.ToString();

                pbTemperatura.Value = tbarTemperatura.Value;
            }
            catch
            {

            }
        }

        private void rbLamparci_CheckedChanged(object sender, EventArgs e)
        {
            lbSredniaTemperatura.Text = Lamparci.SredniaTemperatura.ToString();
            lbSredniaWilgotnosc.Text = Lamparci.Wilgotnosc.ToString();

            Srednia = Lamparci.SredniaTemperatura;
            SredniaWilgotnosc = Lamparci.Wilgotnosc;

            OdswiezWykres();
        }

        private void rbOrzesiony_CheckedChanged(object sender, EventArgs e)
        {
            lbSredniaTemperatura.Text = Orzesiony.SredniaTemperatura.ToString();
            lbSredniaWilgotnosc.Text = Orzesiony.Wilgotnosc.ToString();

            Srednia = Orzesiony.SredniaTemperatura;
            SredniaWilgotnosc = Orzesiony.Wilgotnosc;

            OdswiezWykres();
        }

        private void rbPlaczacy_CheckedChanged(object sender, EventArgs e)
        {
            lbSredniaTemperatura.Text = Placzacy.SredniaTemperatura.ToString();
            lbSredniaWilgotnosc.Text = Placzacy.Wilgotnosc.ToString();

            Srednia = Placzacy.SredniaTemperatura;
            SredniaWilgotnosc = Placzacy.Wilgotnosc;

            OdswiezWykres();
        }

        private void rbAgama_CheckedChanged(object sender, EventArgs e)
        {
            lbSredniaTemperatura.Text = Agama.SredniaTemperatura.ToString();
            lbSredniaWilgotnosc.Text = Agama.Wilgotnosc.ToString();

            Srednia = Agama.SredniaTemperatura;
            SredniaWilgotnosc = Agama.Wilgotnosc;

            OdswiezWykres();
        }

        private void rbWaz_CheckedChanged(object sender, EventArgs e)
        {
            lbSredniaTemperatura.Text = Waz.SredniaTemperatura.ToString();
            lbSredniaWilgotnosc.Text = Waz.Wilgotnosc.ToString();

            Srednia = Waz.SredniaTemperatura;
            SredniaWilgotnosc = Waz.Wilgotnosc;

            OdswiezWykres();
        }

        private void rbZolw_CheckedChanged(object sender, EventArgs e)
        {
            lbSredniaTemperatura.Text = Zolw.SredniaTemperatura.ToString();
            lbSredniaWilgotnosc.Text = Zolw.Wilgotnosc.ToString();

            Srednia = Zolw.SredniaTemperatura;
            SredniaWilgotnosc = Zolw.Wilgotnosc;

            OdswiezWykres();
        }

        private void tboxTemperatura_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbarTemperatura.Value = Int32.Parse(tboxTemperatura.Text);
            }
            catch
            {

            }
        }

        private void tbarWilgotnosc_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tboxWilgotnosc.Text = tbarWilgotnosc.Value.ToString();
                tboxAktualnaWilgotnosc.Text = tbarWilgotnosc.Value.ToString();

                pbWilgotnosc.Value = tbarWilgotnosc.Value;
            }
            catch
            {

            }
        }

        private void tboxWilgotnosc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbarWilgotnosc.Value = Int32.Parse(tboxWilgotnosc.Text);
            }
            catch
            {

            }
        }

        private void tbZewnatrz_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = tbZewnatrz.Value.ToString();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            tbarTemperatura.Enabled = true;
            tbarWilgotnosc.Enabled = true;

            tboxTemperatura.Enabled = true;
            tboxWilgotnosc.Enabled = true;
        }

        private void tboxAktualnaTemperatura_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pbTemperatura.Value = Int32.Parse(tboxAktualnaTemperatura.Text);
            }
            catch
            {

            }
        }

        private void tboxAktualnaWilgotnosc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pbWilgotnosc.Value = Int32.Parse(tboxAktualnaWilgotnosc.Text);
            }
            catch
            {

            }
        }

        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }

        private void MinMax()
        {
            if (rbLamparci.Checked)
            {
                TempMin = Lamparci.MinimalnaTemperatura;
                TempMax = Lamparci.MaksymalnaTemperatura;
            }

            if (rbAgama.Checked)
            {
                TempMin = Agama.MinimalnaTemperatura;
                TempMax = Agama.MaksymalnaTemperatura;
            }

            if (rbOrzesiony.Checked)
            {
                TempMin = Orzesiony.MinimalnaTemperatura;
                TempMax = Orzesiony.MaksymalnaTemperatura;
            }

            if (rbPlaczacy.Checked)
            {
                TempMin = Placzacy.MinimalnaTemperatura;
                TempMax = Placzacy.MaksymalnaTemperatura;
            }

            if (rbWaz.Checked)
            {
                TempMin = Waz.MinimalnaTemperatura;
                TempMax = Waz.MaksymalnaTemperatura;
            }

            if (rbZolw.Checked)
            {
                TempMin = Zolw.MinimalnaTemperatura;
                TempMax = Zolw.MaksymalnaTemperatura;
            }
        }

        private void Blanciki()
        {
            Lamparci = new Plant();
            Lamparci.MinimalnaTemperatura = 25;
            Lamparci.MaksymalnaTemperatura = 30;
            Lamparci.Wilgotnosc = 60;
            Lamparci.SetSredniaTemperatura();

            Orzesiony = new Plant();
            Orzesiony.MinimalnaTemperatura = 22;
            Orzesiony.MaksymalnaTemperatura = 27;
            Orzesiony.Wilgotnosc = 70;
            Orzesiony.SetSredniaTemperatura();

            Placzacy = new Plant();
            Placzacy.MinimalnaTemperatura = 25;
            Placzacy.MaksymalnaTemperatura = 30;
            Placzacy.Wilgotnosc = 80;
            Placzacy.SetSredniaTemperatura();

            Waz = new Plant();
            Waz.MinimalnaTemperatura = 27;
            Waz.MaksymalnaTemperatura = 29;
            Waz.Wilgotnosc = 60;
            Waz.SetSredniaTemperatura();

            Zolw = new Plant();
            Zolw.MinimalnaTemperatura = 26;
            Zolw.MaksymalnaTemperatura = 28;
            Zolw.Wilgotnosc = 45;
            Zolw.SetSredniaTemperatura();

            Agama = new Plant();
            Agama.MinimalnaTemperatura = 38;
            Agama.MaksymalnaTemperatura = 40;
            Agama.Wilgotnosc = 55;
            Agama.SetSredniaTemperatura();
        }
    }
}
