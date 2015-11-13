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
            this.StopKnap = new System.Windows.Forms.Button();
            this.GemKnap = new System.Windows.Forms.Button();
            this.AfslutKnap = new System.Windows.Forms.Button();
            this.textPuls = new System.Windows.Forms.TextBox();
            this.textDia = new System.Windows.Forms.TextBox();
            this.textSys = new System.Windows.Forms.TextBox();
            this.Puls = new System.Windows.Forms.Label();
            this.Diastolisk = new System.Windows.Forms.Label();
            this.Systolisk = new System.Windows.Forms.Label();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textFilnavn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // forsøgsnavn
            // 
            this.forsøgsnavn.AutoSize = true;
            this.forsøgsnavn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forsøgsnavn.ForeColor = System.Drawing.Color.White;
            this.forsøgsnavn.Location = new System.Drawing.Point(22, 52);
            this.forsøgsnavn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forsøgsnavn.Name = "forsøgsnavn";
            this.forsøgsnavn.Size = new System.Drawing.Size(251, 32);
            this.forsøgsnavn.TabIndex = 2;
            this.forsøgsnavn.Text = "Indtast forsøgsnavn:";
            // 
            // textForsøgsnavn
            // 
            this.textForsøgsnavn.BackColor = System.Drawing.Color.DimGray;
            this.textForsøgsnavn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textForsøgsnavn.Location = new System.Drawing.Point(32, 87);
            this.textForsøgsnavn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textForsøgsnavn.Name = "textForsøgsnavn";
            this.textForsøgsnavn.Size = new System.Drawing.Size(132, 39);
            this.textForsøgsnavn.TabIndex = 3;
            this.textForsøgsnavn.TextChanged += new System.EventHandler(this.textForsøgsnavn_TextChanged);
            // 
            // vælg
            // 
            this.vælg.AutoSize = true;
            this.vælg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vælg.ForeColor = System.Drawing.Color.White;
            this.vælg.Location = new System.Drawing.Point(22, 141);
            this.vælg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.filtreret.Location = new System.Drawing.Point(32, 179);
            this.filtreret.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filtreret.Name = "filtreret";
            this.filtreret.Size = new System.Drawing.Size(174, 34);
            this.filtreret.TabIndex = 16;
            this.filtreret.TabStop = true;
            this.filtreret.Text = "Filtreret signal";
            this.filtreret.UseVisualStyleBackColor = true;
            // 
            // ufiltreret
            // 
            this.ufiltreret.AutoSize = true;
            this.ufiltreret.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ufiltreret.Location = new System.Drawing.Point(32, 206);
            this.ufiltreret.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ufiltreret.Name = "ufiltreret";
            this.ufiltreret.Size = new System.Drawing.Size(185, 34);
            this.ufiltreret.TabIndex = 17;
            this.ufiltreret.TabStop = true;
            this.ufiltreret.Text = "Ufiltreret signal";
            this.ufiltreret.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.StartKnap.Location = new System.Drawing.Point(26, 313);
            this.StartKnap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartKnap.Name = "StartKnap";
            this.StartKnap.Size = new System.Drawing.Size(158, 96);
            this.StartKnap.TabIndex = 20;
            this.StartKnap.Text = "START MÅLING";
            this.StartKnap.UseVisualStyleBackColor = false;
            this.StartKnap.Click += new System.EventHandler(this.StartKnap_Click);
            // 
            // StopKnap
            // 
            this.StopKnap.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.StopKnap.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopKnap.Location = new System.Drawing.Point(200, 313);
            this.StopKnap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StopKnap.Name = "StopKnap";
            this.StopKnap.Size = new System.Drawing.Size(156, 96);
            this.StopKnap.TabIndex = 21;
            this.StopKnap.Text = "STOP";
            this.StopKnap.UseVisualStyleBackColor = false;
            this.StopKnap.Click += new System.EventHandler(this.StopKnap_Click);
            // 
            // GemKnap
            // 
            this.GemKnap.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.GemKnap.Enabled = false;
            this.GemKnap.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GemKnap.Location = new System.Drawing.Point(371, 313);
            this.GemKnap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GemKnap.Name = "GemKnap";
            this.GemKnap.Size = new System.Drawing.Size(158, 96);
            this.GemKnap.TabIndex = 22;
            this.GemKnap.Text = "GEM";
            this.GemKnap.UseVisualStyleBackColor = false;
            this.GemKnap.Click += new System.EventHandler(this.GemKnap_Click);
            // 
            // AfslutKnap
            // 
            this.AfslutKnap.BackColor = System.Drawing.Color.IndianRed;
            this.AfslutKnap.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfslutKnap.Location = new System.Drawing.Point(544, 314);
            this.AfslutKnap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AfslutKnap.Name = "AfslutKnap";
            this.AfslutKnap.Size = new System.Drawing.Size(158, 96);
            this.AfslutKnap.TabIndex = 23;
            this.AfslutKnap.Text = "AFSLUT";
            this.AfslutKnap.UseVisualStyleBackColor = false;
            this.AfslutKnap.Click += new System.EventHandler(this.AfslutKnap_Click);
            // 
            // textPuls
            // 
            this.textPuls.BackColor = System.Drawing.Color.DimGray;
            this.textPuls.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPuls.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPuls.ForeColor = System.Drawing.Color.LimeGreen;
            this.textPuls.Location = new System.Drawing.Point(775, 248);
            this.textPuls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPuls.Name = "textPuls";
            this.textPuls.Size = new System.Drawing.Size(75, 82);
            this.textPuls.TabIndex = 37;
            this.textPuls.Text = "--/-";
            // 
            // textDia
            // 
            this.textDia.BackColor = System.Drawing.Color.DimGray;
            this.textDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDia.ForeColor = System.Drawing.Color.Red;
            this.textDia.Location = new System.Drawing.Point(775, 162);
            this.textDia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDia.Name = "textDia";
            this.textDia.Size = new System.Drawing.Size(75, 82);
            this.textDia.TabIndex = 36;
            this.textDia.Text = "--/-";
            // 
            // textSys
            // 
            this.textSys.BackColor = System.Drawing.Color.DimGray;
            this.textSys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSys.ForeColor = System.Drawing.Color.Red;
            this.textSys.Location = new System.Drawing.Point(775, 77);
            this.textSys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSys.Name = "textSys";
            this.textSys.Size = new System.Drawing.Size(75, 82);
            this.textSys.TabIndex = 35;
            this.textSys.Text = "--/-";
            // 
            // Puls
            // 
            this.Puls.AutoSize = true;
            this.Puls.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puls.Location = new System.Drawing.Point(769, 227);
            this.Puls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Puls.Name = "Puls";
            this.Puls.Size = new System.Drawing.Size(51, 30);
            this.Puls.TabIndex = 34;
            this.Puls.Text = "Puls";
            // 
            // Diastolisk
            // 
            this.Diastolisk.AutoSize = true;
            this.Diastolisk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diastolisk.Location = new System.Drawing.Point(769, 141);
            this.Diastolisk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Diastolisk.Name = "Diastolisk";
            this.Diastolisk.Size = new System.Drawing.Size(104, 30);
            this.Diastolisk.TabIndex = 33;
            this.Diastolisk.Text = "Diastolisk";
            // 
            // Systolisk
            // 
            this.Systolisk.AutoSize = true;
            this.Systolisk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Systolisk.Location = new System.Drawing.Point(769, 56);
            this.Systolisk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            chartArea1.AxisX.Title = "Tid [sek]";
            chartArea1.AxisY.Title = "Tryk [mmHg]";
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(165, 10);
            this.Chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(695, 301);
            this.Chart.TabIndex = 31;
            this.Chart.Text = "chart2";
            // 
            // textFilnavn
            // 
            this.textFilnavn.BackColor = System.Drawing.Color.DimGray;
            this.textFilnavn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFilnavn.Location = new System.Drawing.Point(86, 248);
            this.textFilnavn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textFilnavn.Name = "textFilnavn";
            this.textFilnavn.Size = new System.Drawing.Size(100, 39);
            this.textFilnavn.TabIndex = 38;
            // 
            // HovedGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(869, 437);
            this.Controls.Add(this.textFilnavn);
            this.Controls.Add(this.textPuls);
            this.Controls.Add(this.textDia);
            this.Controls.Add(this.textSys);
            this.Controls.Add(this.Puls);
            this.Controls.Add(this.Diastolisk);
            this.Controls.Add(this.Systolisk);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.AfslutKnap);
            this.Controls.Add(this.GemKnap);
            this.Controls.Add(this.StopKnap);
            this.Controls.Add(this.StartKnap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ufiltreret);
            this.Controls.Add(this.filtreret);
            this.Controls.Add(this.vælg);
            this.Controls.Add(this.textForsøgsnavn);
            this.Controls.Add(this.forsøgsnavn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button StopKnap;
        private System.Windows.Forms.Button GemKnap;
        private System.Windows.Forms.Button AfslutKnap;
        private System.Windows.Forms.TextBox textPuls;
        private System.Windows.Forms.TextBox textDia;
        private System.Windows.Forms.TextBox textSys;
        private System.Windows.Forms.Label Puls;
        private System.Windows.Forms.Label Diastolisk;
        private System.Windows.Forms.Label Systolisk;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.TextBox textFilnavn;
    }
}

