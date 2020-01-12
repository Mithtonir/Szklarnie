namespace Terrarium_ZSI
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rbLamparci = new System.Windows.Forms.RadioButton();
            this.rbOrzesiony = new System.Windows.Forms.RadioButton();
            this.rbAnanas = new System.Windows.Forms.RadioButton();
            this.rbPlaczacy = new System.Windows.Forms.RadioButton();
            this.rbZolw = new System.Windows.Forms.RadioButton();
            this.rbWaz = new System.Windows.Forms.RadioButton();
            this.tbarTemperatura = new System.Windows.Forms.TrackBar();
            this.lbTemperatura = new System.Windows.Forms.Label();
            this.tboxTemperatura = new System.Windows.Forms.TextBox();
            this.lbEtykieta = new System.Windows.Forms.Label();
            this.lbEtykieta2 = new System.Windows.Forms.Label();
            this.tboxWilgotnosc = new System.Windows.Forms.TextBox();
            this.lbWilgotnosc = new System.Windows.Forms.Label();
            this.tbarWilgotnosc = new System.Windows.Forms.TrackBar();
            this.pbTemperatura = new System.Windows.Forms.ProgressBar();
            this.lbAktualnaTemperatura = new System.Windows.Forms.Label();
            this.lbAktualnaWilgotnosc = new System.Windows.Forms.Label();
            this.pbWilgotnosc = new System.Windows.Forms.ProgressBar();
            this.lbEtykieta3 = new System.Windows.Forms.Label();
            this.tboxAktualnaTemperatura = new System.Windows.Forms.TextBox();
            this.lbEtykieta4 = new System.Windows.Forms.Label();
            this.tboxAktualnaWilgotnosc = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.lbDocelowaTemperatura = new System.Windows.Forms.Label();
            this.lbDocelowaWilgotnosc = new System.Windows.Forms.Label();
            this.lbSredniaTemperatura = new System.Windows.Forms.Label();
            this.lbSredniaWilgotnosc = new System.Windows.Forms.Label();
            this.lbEtykieta5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEtykieta6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbMocGrzania = new System.Windows.Forms.Label();
            this.lbMocZraszania = new System.Windows.Forms.Label();
            this.lbGrzanie = new System.Windows.Forms.Label();
            this.lbZraszanie = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbZewnatrz = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbarTemperatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarWilgotnosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZewnatrz)).BeginInit();
            this.SuspendLayout();
            // 
            // rbLamparci
            // 
            this.rbLamparci.AutoSize = true;
            this.rbLamparci.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbLamparci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbLamparci.Image = global::Terrarium_ZSI.Properties.Resources.lamparci;
            this.rbLamparci.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbLamparci.Location = new System.Drawing.Point(12, 12);
            this.rbLamparci.Name = "rbLamparci";
            this.rbLamparci.Size = new System.Drawing.Size(140, 121);
            this.rbLamparci.TabIndex = 2;
            this.rbLamparci.TabStop = true;
            this.rbLamparci.Text = "Gekon Lamparci";
            this.rbLamparci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbLamparci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbLamparci.UseVisualStyleBackColor = true;
            this.rbLamparci.CheckedChanged += new System.EventHandler(this.rbLamparci_CheckedChanged);
            // 
            // rbOrzesiony
            // 
            this.rbOrzesiony.AutoSize = true;
            this.rbOrzesiony.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbOrzesiony.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbOrzesiony.Image = global::Terrarium_ZSI.Properties.Resources.orzesiony;
            this.rbOrzesiony.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbOrzesiony.Location = new System.Drawing.Point(158, 8);
            this.rbOrzesiony.Name = "rbOrzesiony";
            this.rbOrzesiony.Size = new System.Drawing.Size(132, 125);
            this.rbOrzesiony.TabIndex = 3;
            this.rbOrzesiony.TabStop = true;
            this.rbOrzesiony.Text = "Gekon Orzęsiony";
            this.rbOrzesiony.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbOrzesiony.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbOrzesiony.UseVisualStyleBackColor = true;
            this.rbOrzesiony.CheckedChanged += new System.EventHandler(this.rbOrzesiony_CheckedChanged);
            // 
            // rbAnanas
            // 
            this.rbAnanas.AutoSize = true;
            this.rbAnanas.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbAnanas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbAnanas.Image = global::Terrarium_ZSI.Properties.Resources.ananas;
            this.rbAnanas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbAnanas.Location = new System.Drawing.Point(450, 14);
            this.rbAnanas.Name = "rbAnanas";
            this.rbAnanas.Size = new System.Drawing.Size(133, 119);
            this.rbAnanas.TabIndex = 5;
            this.rbAnanas.TabStop = true;
            this.rbAnanas.Text = "Ananas";
            this.rbAnanas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbAnanas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbAnanas.UseVisualStyleBackColor = true;
            this.rbAnanas.CheckedChanged += new System.EventHandler(this.rbAnanas_CheckedChanged);
            // 
            // rbPlaczacy
            // 
            this.rbPlaczacy.AutoSize = true;
            this.rbPlaczacy.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbPlaczacy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPlaczacy.Image = global::Terrarium_ZSI.Properties.Resources.placzacy;
            this.rbPlaczacy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbPlaczacy.Location = new System.Drawing.Point(304, -6);
            this.rbPlaczacy.Name = "rbPlaczacy";
            this.rbPlaczacy.Size = new System.Drawing.Size(151, 139);
            this.rbPlaczacy.TabIndex = 4;
            this.rbPlaczacy.TabStop = true;
            this.rbPlaczacy.Text = "Gekon Płaczący";
            this.rbPlaczacy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbPlaczacy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbPlaczacy.UseVisualStyleBackColor = true;
            this.rbPlaczacy.CheckedChanged += new System.EventHandler(this.rbPlaczacy_CheckedChanged);
            // 
            // rbZolw
            // 
            this.rbZolw.AutoSize = true;
            this.rbZolw.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbZolw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbZolw.Image = global::Terrarium_ZSI.Properties.Resources.zlow;
            this.rbZolw.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbZolw.Location = new System.Drawing.Point(742, 22);
            this.rbZolw.Name = "rbZolw";
            this.rbZolw.Size = new System.Drawing.Size(119, 111);
            this.rbZolw.TabIndex = 7;
            this.rbZolw.TabStop = true;
            this.rbZolw.Text = "Żółw Lamparci";
            this.rbZolw.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbZolw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbZolw.UseVisualStyleBackColor = true;
            this.rbZolw.CheckedChanged += new System.EventHandler(this.rbZolw_CheckedChanged);
            // 
            // rbWaz
            // 
            this.rbWaz.AutoSize = true;
            this.rbWaz.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbWaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbWaz.Image = global::Terrarium_ZSI.Properties.Resources.zbozowy;
            this.rbWaz.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbWaz.Location = new System.Drawing.Point(596, 15);
            this.rbWaz.Name = "rbWaz";
            this.rbWaz.Size = new System.Drawing.Size(146, 118);
            this.rbWaz.TabIndex = 6;
            this.rbWaz.TabStop = true;
            this.rbWaz.Text = "Wąż zbożowy";
            this.rbWaz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbWaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rbWaz.UseVisualStyleBackColor = true;
            this.rbWaz.CheckedChanged += new System.EventHandler(this.rbWaz_CheckedChanged);
            // 
            // tbarTemperatura
            // 
            this.tbarTemperatura.Location = new System.Drawing.Point(12, 175);
            this.tbarTemperatura.Maximum = 60;
            this.tbarTemperatura.Name = "tbarTemperatura";
            this.tbarTemperatura.Size = new System.Drawing.Size(508, 45);
            this.tbarTemperatura.TabIndex = 8;
            this.tbarTemperatura.ValueChanged += new System.EventHandler(this.tbarTemperatura_ValueChanged);
            // 
            // lbTemperatura
            // 
            this.lbTemperatura.AutoSize = true;
            this.lbTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTemperatura.Location = new System.Drawing.Point(12, 156);
            this.lbTemperatura.Name = "lbTemperatura";
            this.lbTemperatura.Size = new System.Drawing.Size(101, 16);
            this.lbTemperatura.TabIndex = 9;
            this.lbTemperatura.Text = "Temperatura:";
            // 
            // tboxTemperatura
            // 
            this.tboxTemperatura.Location = new System.Drawing.Point(526, 175);
            this.tboxTemperatura.Name = "tboxTemperatura";
            this.tboxTemperatura.Size = new System.Drawing.Size(34, 20);
            this.tboxTemperatura.TabIndex = 10;
            this.tboxTemperatura.TextChanged += new System.EventHandler(this.tboxTemperatura_TextChanged);
            // 
            // lbEtykieta
            // 
            this.lbEtykieta.AutoSize = true;
            this.lbEtykieta.Location = new System.Drawing.Point(566, 178);
            this.lbEtykieta.Name = "lbEtykieta";
            this.lbEtykieta.Size = new System.Drawing.Size(18, 13);
            this.lbEtykieta.TabIndex = 11;
            this.lbEtykieta.Text = "°C";
            // 
            // lbEtykieta2
            // 
            this.lbEtykieta2.AutoSize = true;
            this.lbEtykieta2.Location = new System.Drawing.Point(566, 245);
            this.lbEtykieta2.Name = "lbEtykieta2";
            this.lbEtykieta2.Size = new System.Drawing.Size(15, 13);
            this.lbEtykieta2.TabIndex = 15;
            this.lbEtykieta2.Text = "%";
            // 
            // tboxWilgotnosc
            // 
            this.tboxWilgotnosc.Location = new System.Drawing.Point(526, 242);
            this.tboxWilgotnosc.Name = "tboxWilgotnosc";
            this.tboxWilgotnosc.Size = new System.Drawing.Size(34, 20);
            this.tboxWilgotnosc.TabIndex = 14;
            this.tboxWilgotnosc.TextChanged += new System.EventHandler(this.tboxWilgotnosc_TextChanged);
            // 
            // lbWilgotnosc
            // 
            this.lbWilgotnosc.AutoSize = true;
            this.lbWilgotnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbWilgotnosc.Location = new System.Drawing.Point(12, 223);
            this.lbWilgotnosc.Name = "lbWilgotnosc";
            this.lbWilgotnosc.Size = new System.Drawing.Size(89, 16);
            this.lbWilgotnosc.TabIndex = 13;
            this.lbWilgotnosc.Text = "Wilgotność:";
            // 
            // tbarWilgotnosc
            // 
            this.tbarWilgotnosc.Location = new System.Drawing.Point(12, 242);
            this.tbarWilgotnosc.Maximum = 100;
            this.tbarWilgotnosc.Minimum = 21;
            this.tbarWilgotnosc.Name = "tbarWilgotnosc";
            this.tbarWilgotnosc.Size = new System.Drawing.Size(508, 45);
            this.tbarWilgotnosc.TabIndex = 12;
            this.tbarWilgotnosc.Value = 21;
            this.tbarWilgotnosc.ValueChanged += new System.EventHandler(this.tbarWilgotnosc_ValueChanged);
            // 
            // pbTemperatura
            // 
            this.pbTemperatura.Location = new System.Drawing.Point(199, 374);
            this.pbTemperatura.Maximum = 60;
            this.pbTemperatura.Name = "pbTemperatura";
            this.pbTemperatura.Size = new System.Drawing.Size(256, 16);
            this.pbTemperatura.TabIndex = 16;
            // 
            // lbAktualnaTemperatura
            // 
            this.lbAktualnaTemperatura.AutoSize = true;
            this.lbAktualnaTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAktualnaTemperatura.Location = new System.Drawing.Point(12, 374);
            this.lbAktualnaTemperatura.Name = "lbAktualnaTemperatura";
            this.lbAktualnaTemperatura.Size = new System.Drawing.Size(165, 16);
            this.lbAktualnaTemperatura.TabIndex = 17;
            this.lbAktualnaTemperatura.Text = "Aktualna Temperatura:";
            // 
            // lbAktualnaWilgotnosc
            // 
            this.lbAktualnaWilgotnosc.AutoSize = true;
            this.lbAktualnaWilgotnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAktualnaWilgotnosc.Location = new System.Drawing.Point(12, 406);
            this.lbAktualnaWilgotnosc.Name = "lbAktualnaWilgotnosc";
            this.lbAktualnaWilgotnosc.Size = new System.Drawing.Size(153, 16);
            this.lbAktualnaWilgotnosc.TabIndex = 19;
            this.lbAktualnaWilgotnosc.Text = "Aktualna Wilgotność:";
            // 
            // pbWilgotnosc
            // 
            this.pbWilgotnosc.Location = new System.Drawing.Point(199, 406);
            this.pbWilgotnosc.Name = "pbWilgotnosc";
            this.pbWilgotnosc.Size = new System.Drawing.Size(256, 16);
            this.pbWilgotnosc.TabIndex = 18;
            // 
            // lbEtykieta3
            // 
            this.lbEtykieta3.AutoSize = true;
            this.lbEtykieta3.Location = new System.Drawing.Point(509, 376);
            this.lbEtykieta3.Name = "lbEtykieta3";
            this.lbEtykieta3.Size = new System.Drawing.Size(18, 13);
            this.lbEtykieta3.TabIndex = 21;
            this.lbEtykieta3.Text = "°C";
            // 
            // tboxAktualnaTemperatura
            // 
            this.tboxAktualnaTemperatura.Location = new System.Drawing.Point(461, 373);
            this.tboxAktualnaTemperatura.Name = "tboxAktualnaTemperatura";
            this.tboxAktualnaTemperatura.Size = new System.Drawing.Size(42, 20);
            this.tboxAktualnaTemperatura.TabIndex = 20;
            this.tboxAktualnaTemperatura.TextChanged += new System.EventHandler(this.tboxAktualnaTemperatura_TextChanged);
            // 
            // lbEtykieta4
            // 
            this.lbEtykieta4.AutoSize = true;
            this.lbEtykieta4.Location = new System.Drawing.Point(509, 408);
            this.lbEtykieta4.Name = "lbEtykieta4";
            this.lbEtykieta4.Size = new System.Drawing.Size(15, 13);
            this.lbEtykieta4.TabIndex = 23;
            this.lbEtykieta4.Text = "%";
            // 
            // tboxAktualnaWilgotnosc
            // 
            this.tboxAktualnaWilgotnosc.Location = new System.Drawing.Point(461, 405);
            this.tboxAktualnaWilgotnosc.Name = "tboxAktualnaWilgotnosc";
            this.tboxAktualnaWilgotnosc.Size = new System.Drawing.Size(42, 20);
            this.tboxAktualnaWilgotnosc.TabIndex = 22;
            this.tboxAktualnaWilgotnosc.TextChanged += new System.EventHandler(this.tboxAktualnaWilgotnosc_TextChanged);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(15, 457);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 24;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbDocelowaTemperatura
            // 
            this.lbDocelowaTemperatura.AutoSize = true;
            this.lbDocelowaTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDocelowaTemperatura.Location = new System.Drawing.Point(622, 175);
            this.lbDocelowaTemperatura.Name = "lbDocelowaTemperatura";
            this.lbDocelowaTemperatura.Size = new System.Drawing.Size(174, 16);
            this.lbDocelowaTemperatura.TabIndex = 25;
            this.lbDocelowaTemperatura.Text = "Docelowa Temperatura:";
            // 
            // lbDocelowaWilgotnosc
            // 
            this.lbDocelowaWilgotnosc.AutoSize = true;
            this.lbDocelowaWilgotnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDocelowaWilgotnosc.Location = new System.Drawing.Point(622, 223);
            this.lbDocelowaWilgotnosc.Name = "lbDocelowaWilgotnosc";
            this.lbDocelowaWilgotnosc.Size = new System.Drawing.Size(162, 16);
            this.lbDocelowaWilgotnosc.TabIndex = 26;
            this.lbDocelowaWilgotnosc.Text = "Docelowa Wilgotność:";
            // 
            // lbSredniaTemperatura
            // 
            this.lbSredniaTemperatura.AutoSize = true;
            this.lbSredniaTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSredniaTemperatura.Location = new System.Drawing.Point(802, 175);
            this.lbSredniaTemperatura.Name = "lbSredniaTemperatura";
            this.lbSredniaTemperatura.Size = new System.Drawing.Size(16, 16);
            this.lbSredniaTemperatura.TabIndex = 27;
            this.lbSredniaTemperatura.Text = "0";
            // 
            // lbSredniaWilgotnosc
            // 
            this.lbSredniaWilgotnosc.AutoSize = true;
            this.lbSredniaWilgotnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSredniaWilgotnosc.Location = new System.Drawing.Point(802, 223);
            this.lbSredniaWilgotnosc.Name = "lbSredniaWilgotnosc";
            this.lbSredniaWilgotnosc.Size = new System.Drawing.Size(16, 16);
            this.lbSredniaWilgotnosc.TabIndex = 28;
            this.lbSredniaWilgotnosc.Text = "0";
            // 
            // lbEtykieta5
            // 
            this.lbEtykieta5.AutoSize = true;
            this.lbEtykieta5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbEtykieta5.Location = new System.Drawing.Point(837, 175);
            this.lbEtykieta5.Name = "lbEtykieta5";
            this.lbEtykieta5.Size = new System.Drawing.Size(23, 16);
            this.lbEtykieta5.TabIndex = 29;
            this.lbEtykieta5.Text = "°C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(566, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 30;
            // 
            // lbEtykieta6
            // 
            this.lbEtykieta6.AutoSize = true;
            this.lbEtykieta6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbEtykieta6.Location = new System.Drawing.Point(837, 223);
            this.lbEtykieta6.Name = "lbEtykieta6";
            this.lbEtykieta6.Size = new System.Drawing.Size(21, 16);
            this.lbEtykieta6.TabIndex = 31;
            this.lbEtykieta6.Text = "%";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(74, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "0";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.PointDepth = 1;
            chartArea1.AxisX.Interval = 3D;
            chartArea1.AxisY.Interval = 0.2D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(138, 457);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "Zimno";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Lime;
            series2.Legend = "Legend1";
            series2.Name = "Ciepło";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Gorąco";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Bardzo Gorąco";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(743, 177);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.PointDepth = 1;
            chartArea2.AxisX.Interval = 10D;
            chartArea2.AxisY.Interval = 0.2D;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(138, 640);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Yellow;
            series5.Legend = "Legend1";
            series5.Name = "Sucho";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.SystemColors.Highlight;
            series6.Legend = "Legend1";
            series6.Name = "Wilgotno";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Red;
            series7.Legend = "Legend1";
            series7.Name = "Mokro";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Bardzo Mokro";
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(743, 177);
            this.chart2.TabIndex = 34;
            this.chart2.Text = "chart2";
            // 
            // lbMocGrzania
            // 
            this.lbMocGrzania.AutoSize = true;
            this.lbMocGrzania.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMocGrzania.Location = new System.Drawing.Point(544, 373);
            this.lbMocGrzania.Name = "lbMocGrzania";
            this.lbMocGrzania.Size = new System.Drawing.Size(98, 16);
            this.lbMocGrzania.TabIndex = 35;
            this.lbMocGrzania.Text = "Moc Grzania:";
            // 
            // lbMocZraszania
            // 
            this.lbMocZraszania.AutoSize = true;
            this.lbMocZraszania.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMocZraszania.Location = new System.Drawing.Point(544, 405);
            this.lbMocZraszania.Name = "lbMocZraszania";
            this.lbMocZraszania.Size = new System.Drawing.Size(113, 16);
            this.lbMocZraszania.TabIndex = 36;
            this.lbMocZraszania.Text = "Moc Zraszania:";
            // 
            // lbGrzanie
            // 
            this.lbGrzanie.AutoSize = true;
            this.lbGrzanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbGrzanie.Location = new System.Drawing.Point(677, 373);
            this.lbGrzanie.Name = "lbGrzanie";
            this.lbGrzanie.Size = new System.Drawing.Size(16, 16);
            this.lbGrzanie.TabIndex = 37;
            this.lbGrzanie.Text = "0";
            // 
            // lbZraszanie
            // 
            this.lbZraszanie.AutoSize = true;
            this.lbZraszanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbZraszanie.Location = new System.Drawing.Point(677, 405);
            this.lbZraszanie.Name = "lbZraszanie";
            this.lbZraszanie.Size = new System.Drawing.Size(16, 16);
            this.lbZraszanie.TabIndex = 38;
            this.lbZraszanie.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(526, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Temperatura na zewnątrz:";
            // 
            // tbZewnatrz
            // 
            this.tbZewnatrz.Location = new System.Drawing.Point(12, 309);
            this.tbZewnatrz.Maximum = 60;
            this.tbZewnatrz.Name = "tbZewnatrz";
            this.tbZewnatrz.Size = new System.Drawing.Size(508, 45);
            this.tbZewnatrz.TabIndex = 39;
            this.tbZewnatrz.ValueChanged += new System.EventHandler(this.tbZewnatrz_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "°C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "Temp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Wilg:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(74, 583);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "STOP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 812);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbZewnatrz);
            this.Controls.Add(this.lbZraszanie);
            this.Controls.Add(this.lbGrzanie);
            this.Controls.Add(this.lbMocZraszania);
            this.Controls.Add(this.lbMocGrzania);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEtykieta6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbEtykieta5);
            this.Controls.Add(this.lbSredniaWilgotnosc);
            this.Controls.Add(this.lbSredniaTemperatura);
            this.Controls.Add(this.lbDocelowaWilgotnosc);
            this.Controls.Add(this.lbDocelowaTemperatura);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbEtykieta4);
            this.Controls.Add(this.tboxAktualnaWilgotnosc);
            this.Controls.Add(this.lbEtykieta3);
            this.Controls.Add(this.tboxAktualnaTemperatura);
            this.Controls.Add(this.lbAktualnaWilgotnosc);
            this.Controls.Add(this.pbWilgotnosc);
            this.Controls.Add(this.lbAktualnaTemperatura);
            this.Controls.Add(this.pbTemperatura);
            this.Controls.Add(this.lbEtykieta2);
            this.Controls.Add(this.tboxWilgotnosc);
            this.Controls.Add(this.lbWilgotnosc);
            this.Controls.Add(this.tbarWilgotnosc);
            this.Controls.Add(this.lbEtykieta);
            this.Controls.Add(this.tboxTemperatura);
            this.Controls.Add(this.lbTemperatura);
            this.Controls.Add(this.tbarTemperatura);
            this.Controls.Add(this.rbZolw);
            this.Controls.Add(this.rbWaz);
            this.Controls.Add(this.rbAnanas);
            this.Controls.Add(this.rbPlaczacy);
            this.Controls.Add(this.rbOrzesiony);
            this.Controls.Add(this.rbLamparci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbarTemperatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarWilgotnosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZewnatrz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbLamparci;
        private System.Windows.Forms.RadioButton rbOrzesiony;
        private System.Windows.Forms.RadioButton rbAnanas;
        private System.Windows.Forms.RadioButton rbPlaczacy;
        private System.Windows.Forms.RadioButton rbZolw;
        private System.Windows.Forms.RadioButton rbWaz;
        private System.Windows.Forms.TrackBar tbarTemperatura;
        private System.Windows.Forms.Label lbTemperatura;
        private System.Windows.Forms.TextBox tboxTemperatura;
        private System.Windows.Forms.Label lbEtykieta;
        private System.Windows.Forms.Label lbEtykieta2;
        private System.Windows.Forms.TextBox tboxWilgotnosc;
        private System.Windows.Forms.Label lbWilgotnosc;
        private System.Windows.Forms.TrackBar tbarWilgotnosc;
        private System.Windows.Forms.ProgressBar pbTemperatura;
        private System.Windows.Forms.Label lbAktualnaTemperatura;
        private System.Windows.Forms.Label lbAktualnaWilgotnosc;
        private System.Windows.Forms.ProgressBar pbWilgotnosc;
        private System.Windows.Forms.Label lbEtykieta3;
        private System.Windows.Forms.TextBox tboxAktualnaTemperatura;
        private System.Windows.Forms.Label lbEtykieta4;
        private System.Windows.Forms.TextBox tboxAktualnaWilgotnosc;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbDocelowaTemperatura;
        private System.Windows.Forms.Label lbDocelowaWilgotnosc;
        private System.Windows.Forms.Label lbSredniaTemperatura;
        private System.Windows.Forms.Label lbSredniaWilgotnosc;
        private System.Windows.Forms.Label lbEtykieta5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEtykieta6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lbMocGrzania;
        private System.Windows.Forms.Label lbMocZraszania;
        private System.Windows.Forms.Label lbGrzanie;
        private System.Windows.Forms.Label lbZraszanie;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbZewnatrz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

