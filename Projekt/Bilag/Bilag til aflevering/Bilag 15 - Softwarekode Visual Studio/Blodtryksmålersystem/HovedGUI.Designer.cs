namespace Blodtryksmålersystem
{
    partial class HovedGUI
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
            this.forsøgsnavn = new System.Windows.Forms.Label();
            this.textForsøgsnavn = new System.Windows.Forms.TextBox();
            this.vælg = new System.Windows.Forms.Label();
            this.filtreret = new System.Windows.Forms.RadioButton();
            this.ufiltreret = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.StartKnap = new System.Windows.Forms.Button();
            this.StopGemKnap = new System.Windows.Forms.Button();
            this.GemKnap = new System.Windows.Forms.Button();
            this.StopKnap = new System.Windows.Forms.Button();
            this.textPuls = new System.Windows.Forms.TextBox();
            this.textDia = new System.Windows.Forms.TextBox();
            this.textSys = new System.Windows.Forms.TextBox();
            this.Puls = new System.Windows.Forms.Label();
            this.Diastolisk = new System.Windows.Forms.Label();
            this.Systolisk = new System.Windows.Forms.Label();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textFilnavn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // forsøgsnavn
            // 
            this.forsøgsnavn.AutoSize = true;
            this.forsøgsnavn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forsøgsnavn.ForeColor = System.Drawing.Color.White;
            this.forsøgsnavn.Location = new System.Drawing.Point(33, 80);
            this.forsøgsnavn.Name = "forsøgsnavn";
            this.forsøgsnavn.Size = new System.Drawing.Size(251, 32);
            this.forsøgsnavn.TabIndex = 2;
            this.forsøgsnavn.Text = "Indtast forsøgsnavn:";
            // 
            // textForsøgsnavn
            // 
            this.textForsøgsnavn.BackColor = System.Drawing.Color.DimGray;
            this.textForsøgsnavn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textForsøgsnavn.Location = new System.Drawing.Point(48, 134);
            this.textForsøgsnavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textForsøgsnavn.Name = "textForsøgsnavn";
            this.textForsøgsnavn.Size = new System.Drawing.Size(196, 39);
            this.textForsøgsnavn.TabIndex = 3;
            this.textForsøgsnavn.TextChanged += new System.EventHandler(this.textForsøgsnavn_TextChanged);
            // 
            // vælg
            // 
            this.vælg.AutoSize = true;
            this.vælg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vælg.ForeColor = System.Drawing.Color.White;
            this.vælg.Location = new System.Drawing.Point(33, 218);
            this.vælg.Name = "vælg";
            this.vælg.Size = new System.Drawing.Size(78, 32);
            this.vælg.TabIndex = 15;
            this.vælg.Text = "Vælg:";
            // 
            // filtreret
            // 
            this.filtreret.AutoSize = true;
            this.filtreret.Checked = true;
            this.filtreret.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtreret.Location = new System.Drawing.Point(48, 275);
            this.filtreret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filtreret.Name = "filtreret";
            this.filtreret.Size = new System.Drawing.Size(174, 34);
            this.filtreret.TabIndex = 16;
            this.filtreret.TabStop = true;
            this.filtreret.Text = "Filtreret signal";
            this.filtreret.UseVisualStyleBackColor = true;
            this.filtreret.CheckedChanged += new System.EventHandler(this.filtreret_CheckedChanged);
            // 
            // ufiltreret
            // 
            this.ufiltreret.AutoSize = true;
            this.ufiltreret.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ufiltreret.Location = new System.Drawing.Point(48, 318);
            this.ufiltreret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ufiltreret.Name = "ufiltreret";
            this.ufiltreret.Size = new System.Drawing.Size(185, 34);
            this.ufiltreret.TabIndex = 17;
            this.ufiltreret.Text = "Ufiltreret signal";
            this.ufiltreret.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Filnavn:";
            // 
            // StartKnap
            // 
            this.StartKnap.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.StartKnap.Enabled = false;
            this.StartKnap.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.StartKnap.FlatAppearance.BorderSize = 4;
            this.StartKnap.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartKnap.Location = new System.Drawing.Point(39, 482);
            this.StartKnap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartKnap.Name = "StartKnap";
            this.StartKnap.Size = new System.Drawing.Size(237, 148);
            this.StartKnap.TabIndex = 20;
            this.StartKnap.Text = "START MÅLING";
            this.StartKnap.UseVisualStyleBackColor = false;
            this.StartKnap.Click += new System.EventHandler(this.StartKnap_Click);
            // 
            // StopGemKnap
            // 
            this.StopGemKnap.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.StopGemKnap.Enabled = false;
            this.StopGemKnap.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopGemKnap.Location = new System.Drawing.Point(808, 482);
            this.StopGemKnap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopGemKnap.Name = "StopGemKnap";
            this.StopGemKnap.Size = new System.Drawing.Size(234, 148);
            this.StopGemKnap.TabIndex = 21;
            this.StopGemKnap.Text = "STOP GEM";
            this.StopGemKnap.UseVisualStyleBackColor = false;
            this.StopGemKnap.Click += new System.EventHandler(this.StopGemKnap_Click);
            // 
            // GemKnap
            // 
            this.GemKnap.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.GemKnap.Enabled = false;
            this.GemKnap.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GemKnap.Location = new System.Drawing.Point(554, 482);
            this.GemKnap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GemKnap.Name = "GemKnap";
            this.GemKnap.Size = new System.Drawing.Size(237, 148);
            this.GemKnap.TabIndex = 22;
            this.GemKnap.Text = "START GEM";
            this.GemKnap.UseVisualStyleBackColor = false;
            this.GemKnap.Click += new System.EventHandler(this.GemKnap_Click);
            // 
            // StopKnap
            // 
            this.StopKnap.BackColor = System.Drawing.Color.DarkGray;
            this.StopKnap.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopKnap.Location = new System.Drawing.Point(296, 482);
            this.StopKnap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopKnap.Name = "StopKnap";
            this.StopKnap.Size = new System.Drawing.Size(237, 148);
            this.StopKnap.TabIndex = 23;
            this.StopKnap.Text = "STOP MÅLING";
            this.StopKnap.UseVisualStyleBackColor = false;
            this.StopKnap.Click += new System.EventHandler(this.StopKnap_Click);
            // 
            // textPuls
            // 
            this.textPuls.BackColor = System.Drawing.Color.DimGray;
            this.textPuls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPuls.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPuls.ForeColor = System.Drawing.Color.YellowGreen;
            this.textPuls.Location = new System.Drawing.Point(1162, 382);
            this.textPuls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPuls.Name = "textPuls";
            this.textPuls.Size = new System.Drawing.Size(112, 55);
            this.textPuls.TabIndex = 37;
            this.textPuls.Text = "--/-";
            // 
            // textDia
            // 
            this.textDia.BackColor = System.Drawing.Color.DimGray;
            this.textDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDia.ForeColor = System.Drawing.Color.Firebrick;
            this.textDia.Location = new System.Drawing.Point(1162, 249);
            this.textDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDia.Name = "textDia";
            this.textDia.Size = new System.Drawing.Size(112, 55);
            this.textDia.TabIndex = 36;
            this.textDia.Text = "--/-";
            // 
            // textSys
            // 
            this.textSys.BackColor = System.Drawing.Color.DimGray;
            this.textSys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSys.ForeColor = System.Drawing.Color.Firebrick;
            this.textSys.Location = new System.Drawing.Point(1162, 118);
            this.textSys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSys.Name = "textSys";
            this.textSys.Size = new System.Drawing.Size(112, 55);
            this.textSys.TabIndex = 35;
            this.textSys.Text = "--/-";
            // 
            // Puls
            // 
            this.Puls.AutoSize = true;
            this.Puls.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puls.Location = new System.Drawing.Point(1154, 349);
            this.Puls.Name = "Puls";
            this.Puls.Size = new System.Drawing.Size(51, 30);
            this.Puls.TabIndex = 34;
            this.Puls.Text = "Puls";
            // 
            // Diastolisk
            // 
            this.Diastolisk.AutoSize = true;
            this.Diastolisk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diastolisk.Location = new System.Drawing.Point(1154, 218);
            this.Diastolisk.Name = "Diastolisk";
            this.Diastolisk.Size = new System.Drawing.Size(104, 30);
            this.Diastolisk.TabIndex = 33;
            this.Diastolisk.Text = "Diastolisk";
            // 
            // Systolisk
            // 
            this.Systolisk.AutoSize = true;
            this.Systolisk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Systolisk.Location = new System.Drawing.Point(1154, 86);
            this.Systolisk.Name = "Systolisk";
            this.Systolisk.Size = new System.Drawing.Size(94, 30);
            this.Systolisk.TabIndex = 32;
            this.Systolisk.Text = "Systolisk";
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.Transparent;
            this.Chart.BackImageTransparentColor = System.Drawing.Color.DimGray;
            this.Chart.BackSecondaryColor = System.Drawing.Color.DimGray;
            this.Chart.BorderSkin.BackSecondaryColor = System.Drawing.Color.DimGray;
            this.Chart.BorderSkin.PageColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.Title = "Samples";
            chartArea1.AxisY.Title = "Tryk [mmHg]";
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(284, 11);
            this.Chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(1042, 462);
            this.Chart.TabIndex = 31;
            this.Chart.Text = "chart2";
            // 
            // textFilnavn
            // 
            this.textFilnavn.BackColor = System.Drawing.Color.DimGray;
            this.textFilnavn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFilnavn.Location = new System.Drawing.Point(129, 382);
            this.textFilnavn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textFilnavn.Name = "textFilnavn";
            this.textFilnavn.Size = new System.Drawing.Size(148, 39);
            this.textFilnavn.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ex: forsøgsnavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Ex: forsøgsnavn_XX";
            // 
            // HovedGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1304, 672);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFilnavn);
            this.Controls.Add(this.textPuls);
            this.Controls.Add(this.textDia);
            this.Controls.Add(this.textSys);
            this.Controls.Add(this.Puls);
            this.Controls.Add(this.Diastolisk);
            this.Controls.Add(this.Systolisk);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.StopKnap);
            this.Controls.Add(this.GemKnap);
            this.Controls.Add(this.StopGemKnap);
            this.Controls.Add(this.StartKnap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ufiltreret);
            this.Controls.Add(this.filtreret);
            this.Controls.Add(this.vælg);
            this.Controls.Add(this.textForsøgsnavn);
            this.Controls.Add(this.forsøgsnavn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HovedGUI";
            this.Text = "HovedGUI";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forsøgsnavn;
        private System.Windows.Forms.TextBox textForsøgsnavn;
        private System.Windows.Forms.Label vælg;
        private System.Windows.Forms.RadioButton filtreret;
        private System.Windows.Forms.RadioButton ufiltreret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartKnap;
        private System.Windows.Forms.Button StopGemKnap;
        private System.Windows.Forms.Button GemKnap;
        private System.Windows.Forms.Button StopKnap;
        private System.Windows.Forms.TextBox textPuls;
        private System.Windows.Forms.TextBox textDia;
        private System.Windows.Forms.TextBox textSys;
        private System.Windows.Forms.Label Puls;
        private System.Windows.Forms.Label Diastolisk;
        private System.Windows.Forms.Label Systolisk;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.TextBox textFilnavn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

