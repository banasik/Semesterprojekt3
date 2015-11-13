namespace Blodtryksmålersystem
{
    partial class KalibreringGUI
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
            this.JaKnapKali = new System.Windows.Forms.Button();
            this.NejKnapKali = new System.Windows.Forms.Button();
            this.Labelkali = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JaKnapKali
            // 
            this.JaKnapKali.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.JaKnapKali.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JaKnapKali.Location = new System.Drawing.Point(56, 126);
            this.JaKnapKali.Name = "JaKnapKali";
            this.JaKnapKali.Size = new System.Drawing.Size(127, 60);
            this.JaKnapKali.TabIndex = 0;
            this.JaKnapKali.Text = "JA";
            this.JaKnapKali.UseVisualStyleBackColor = false;
            this.JaKnapKali.Click += new System.EventHandler(this.JaKnapKali_Click);
            // 
            // NejKnapKali
            // 
            this.NejKnapKali.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NejKnapKali.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NejKnapKali.Location = new System.Drawing.Point(201, 126);
            this.NejKnapKali.Name = "NejKnapKali";
            this.NejKnapKali.Size = new System.Drawing.Size(127, 60);
            this.NejKnapKali.TabIndex = 1;
            this.NejKnapKali.Text = "NEJ";
            this.NejKnapKali.UseVisualStyleBackColor = false;
            this.NejKnapKali.Click += new System.EventHandler(this.NejKnapKali_Click);
            // 
            // Labelkali
            // 
            this.Labelkali.AutoSize = true;
            this.Labelkali.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelkali.ForeColor = System.Drawing.Color.White;
            this.Labelkali.Location = new System.Drawing.Point(99, 70);
            this.Labelkali.Name = "Labelkali";
            this.Labelkali.Size = new System.Drawing.Size(197, 28);
            this.Labelkali.TabIndex = 2;
            this.Labelkali.Text = "Ønskes kalibrering?";
            // 
            // KalibreringGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(392, 250);
            this.Controls.Add(this.Labelkali);
            this.Controls.Add(this.NejKnapKali);
            this.Controls.Add(this.JaKnapKali);
            this.Name = "KalibreringGUI";
            this.Text = "KalibreringGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JaKnapKali;
        private System.Windows.Forms.Button NejKnapKali;
        private System.Windows.Forms.Label Labelkali;
    }
}