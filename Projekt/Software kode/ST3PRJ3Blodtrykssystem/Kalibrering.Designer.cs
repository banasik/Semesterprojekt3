namespace ST3PRJ3Blodtrykssystem
{
    partial class Kalibrering
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
            this.Labelkali = new System.Windows.Forms.Label();
            this.JAkali = new System.Windows.Forms.Button();
            this.nejkali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Labelkali
            // 
            this.Labelkali.AutoSize = true;
            this.Labelkali.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelkali.ForeColor = System.Drawing.Color.White;
            this.Labelkali.Location = new System.Drawing.Point(95, 60);
            this.Labelkali.Name = "Labelkali";
            this.Labelkali.Size = new System.Drawing.Size(197, 28);
            this.Labelkali.TabIndex = 0;
            this.Labelkali.Text = "Ønskes kalibrering?";
            // 
            // JAkali
            // 
            this.JAkali.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.JAkali.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JAkali.Location = new System.Drawing.Point(59, 119);
            this.JAkali.Name = "JAkali";
            this.JAkali.Size = new System.Drawing.Size(126, 58);
            this.JAkali.TabIndex = 1;
            this.JAkali.Text = "JA";
            this.JAkali.UseVisualStyleBackColor = false;
            this.JAkali.Click += new System.EventHandler(this.JAkali_Click);
            // 
            // nejkali
            // 
            this.nejkali.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.nejkali.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nejkali.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nejkali.Location = new System.Drawing.Point(201, 119);
            this.nejkali.Name = "nejkali";
            this.nejkali.Size = new System.Drawing.Size(126, 58);
            this.nejkali.TabIndex = 2;
            this.nejkali.Text = "NEJ";
            this.nejkali.UseVisualStyleBackColor = false;
            this.nejkali.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kalibrering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(398, 250);
            this.Controls.Add(this.nejkali);
            this.Controls.Add(this.JAkali);
            this.Controls.Add(this.Labelkali);
            this.Name = "Kalibrering";
            this.Text = "Kalibrering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Labelkali;
        private System.Windows.Forms.Button JAkali;
        private System.Windows.Forms.Button nejkali;
    }
}