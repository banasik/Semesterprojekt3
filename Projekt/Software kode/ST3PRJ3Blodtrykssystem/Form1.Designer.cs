namespace ST3PRJ3Blodtrykssystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.forsøgsnavn = new System.Windows.Forms.Label();
            this.textForsøgsnavn = new System.Windows.Forms.TextBox();
            this.filtreret = new System.Windows.Forms.RadioButton();
            this.ufiltreret = new System.Windows.Forms.RadioButton();
            this.start = new System.Windows.Forms.Button();
            this.gem = new System.Windows.Forms.Button();
            this.afslut = new System.Windows.Forms.Button();
            this.systolisk = new System.Windows.Forms.Label();
            this.diastolisk = new System.Windows.Forms.Label();
            this.puls = new System.Windows.Forms.Label();
            this.textSys = new System.Windows.Forms.TextBox();
            this.textDia = new System.Windows.Forms.TextBox();
            this.textPuls = new System.Windows.Forms.TextBox();
            this.vælg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.DimGray;
            this.chart1.BackSecondaryColor = System.Drawing.Color.DimGray;
            this.chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.DimGray;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.Title = "Tid [sek]";
            chartArea1.AxisY.Title = "Tryk [mmHg]";
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(227, 6);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(927, 371);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // forsøgsnavn
            // 
            this.forsøgsnavn.AutoSize = true;
            this.forsøgsnavn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forsøgsnavn.ForeColor = System.Drawing.Color.White;
            this.forsøgsnavn.Location = new System.Drawing.Point(34, 68);
            this.forsøgsnavn.Name = "forsøgsnavn";
            this.forsøgsnavn.Size = new System.Drawing.Size(205, 28);
            this.forsøgsnavn.TabIndex = 1;
            this.forsøgsnavn.Text = "Indtast forsøgsnavn:";
            // 
            // textForsøgsnavn
            // 
            this.textForsøgsnavn.BackColor = System.Drawing.Color.DimGray;
            this.textForsøgsnavn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textForsøgsnavn.Location = new System.Drawing.Point(46, 110);
            this.textForsøgsnavn.Name = "textForsøgsnavn";
            this.textForsøgsnavn.Size = new System.Drawing.Size(175, 34);
            this.textForsøgsnavn.TabIndex = 2;
            this.textForsøgsnavn.TextChanged += new System.EventHandler(this.textForsøgsnavn_TextChanged);
            // 
            // filtreret
            // 
            this.filtreret.AutoSize = true;
            this.filtreret.Checked = true;
            this.filtreret.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtreret.Location = new System.Drawing.Point(46, 212);
            this.filtreret.Name = "filtreret";
            this.filtreret.Size = new System.Drawing.Size(139, 27);
            this.filtreret.TabIndex = 3;
            this.filtreret.TabStop = true;
            this.filtreret.Text = "Filtreret signal";
            this.filtreret.UseVisualStyleBackColor = true;
            // 
            // ufiltreret
            // 
            this.ufiltreret.AutoSize = true;
            this.ufiltreret.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ufiltreret.Location = new System.Drawing.Point(46, 255);
            this.ufiltreret.Name = "ufiltreret";
            this.ufiltreret.Size = new System.Drawing.Size(148, 27);
            this.ufiltreret.TabIndex = 4;
            this.ufiltreret.TabStop = true;
            this.ufiltreret.Text = "Ufiltreret signal";
            this.ufiltreret.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.start.Enabled = false;
            this.start.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.start.FlatAppearance.BorderSize = 4;
            this.start.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(39, 379);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(211, 118);
            this.start.TabIndex = 5;
            this.start.Text = "START MÅLING";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // gem
            // 
            this.gem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gem.Enabled = false;
            this.gem.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gem.Location = new System.Drawing.Point(498, 379);
            this.gem.Name = "gem";
            this.gem.Size = new System.Drawing.Size(210, 118);
            this.gem.TabIndex = 6;
            this.gem.Text = "GEM";
            this.gem.UseVisualStyleBackColor = false;
            this.gem.Click += new System.EventHandler(this.gem_Click);
            // 
            // afslut
            // 
            this.afslut.BackColor = System.Drawing.Color.IndianRed;
            this.afslut.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afslut.Location = new System.Drawing.Point(726, 379);
            this.afslut.Name = "afslut";
            this.afslut.Size = new System.Drawing.Size(210, 118);
            this.afslut.TabIndex = 7;
            this.afslut.Text = "AFSLUT";
            this.afslut.UseVisualStyleBackColor = false;
            this.afslut.Click += new System.EventHandler(this.afslut_Click);
            // 
            // systolisk
            // 
            this.systolisk.AutoSize = true;
            this.systolisk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systolisk.Location = new System.Drawing.Point(1034, 73);
            this.systolisk.Name = "systolisk";
            this.systolisk.Size = new System.Drawing.Size(75, 23);
            this.systolisk.TabIndex = 8;
            this.systolisk.Text = "Systolisk";
            // 
            // diastolisk
            // 
            this.diastolisk.AutoSize = true;
            this.diastolisk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diastolisk.Location = new System.Drawing.Point(1034, 177);
            this.diastolisk.Name = "diastolisk";
            this.diastolisk.Size = new System.Drawing.Size(82, 23);
            this.diastolisk.TabIndex = 9;
            this.diastolisk.Text = "Diastolisk";
            // 
            // puls
            // 
            this.puls.AutoSize = true;
            this.puls.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puls.Location = new System.Drawing.Point(1034, 283);
            this.puls.Name = "puls";
            this.puls.Size = new System.Drawing.Size(41, 23);
            this.puls.TabIndex = 10;
            this.puls.Text = "Puls";
            // 
            // textSys
            // 
            this.textSys.BackColor = System.Drawing.Color.DimGray;
            this.textSys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSys.ForeColor = System.Drawing.Color.Red;
            this.textSys.Location = new System.Drawing.Point(1042, 99);
            this.textSys.Name = "textSys";
            this.textSys.Size = new System.Drawing.Size(100, 68);
            this.textSys.TabIndex = 11;
            this.textSys.Text = "--/-";
            // 
            // textDia
            // 
            this.textDia.BackColor = System.Drawing.Color.DimGray;
            this.textDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDia.ForeColor = System.Drawing.Color.Red;
            this.textDia.Location = new System.Drawing.Point(1042, 203);
            this.textDia.Name = "textDia";
            this.textDia.Size = new System.Drawing.Size(100, 68);
            this.textDia.TabIndex = 12;
            this.textDia.Text = "--/-";
            // 
            // textPuls
            // 
            this.textPuls.BackColor = System.Drawing.Color.DimGray;
            this.textPuls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPuls.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPuls.ForeColor = System.Drawing.Color.LimeGreen;
            this.textPuls.Location = new System.Drawing.Point(1042, 309);
            this.textPuls.Name = "textPuls";
            this.textPuls.Size = new System.Drawing.Size(100, 68);
            this.textPuls.TabIndex = 13;
            this.textPuls.Text = "--/-";
            // 
            // vælg
            // 
            this.vælg.AutoSize = true;
            this.vælg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vælg.ForeColor = System.Drawing.Color.White;
            this.vælg.Location = new System.Drawing.Point(34, 169);
            this.vælg.Name = "vælg";
            this.vælg.Size = new System.Drawing.Size(63, 28);
            this.vælg.TabIndex = 14;
            this.vælg.Text = "Vælg:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(271, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 118);
            this.button1.TabIndex = 15;
            this.button1.Text = "STOP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Filnavn:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(118, 309);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 34);
            this.textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1156, 534);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vælg);
            this.Controls.Add(this.textPuls);
            this.Controls.Add(this.textDia);
            this.Controls.Add(this.textSys);
            this.Controls.Add(this.puls);
            this.Controls.Add(this.diastolisk);
            this.Controls.Add(this.systolisk);
            this.Controls.Add(this.afslut);
            this.Controls.Add(this.gem);
            this.Controls.Add(this.start);
            this.Controls.Add(this.ufiltreret);
            this.Controls.Add(this.filtreret);
            this.Controls.Add(this.textForsøgsnavn);
            this.Controls.Add(this.forsøgsnavn);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Blodtrykssystem";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label forsøgsnavn;
        private System.Windows.Forms.TextBox textForsøgsnavn;
        private System.Windows.Forms.RadioButton filtreret;
        private System.Windows.Forms.RadioButton ufiltreret;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button gem;
        private System.Windows.Forms.Button afslut;
        private System.Windows.Forms.Label systolisk;
        private System.Windows.Forms.Label diastolisk;
        private System.Windows.Forms.Label puls;
        private System.Windows.Forms.TextBox textSys;
        private System.Windows.Forms.TextBox textDia;
        private System.Windows.Forms.TextBox textPuls;
        private System.Windows.Forms.Label vælg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;

    }
}

