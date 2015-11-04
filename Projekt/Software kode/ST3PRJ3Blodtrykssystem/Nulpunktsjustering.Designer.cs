namespace ST3PRJ3Blodtrykssystem
{
    partial class Nulpunktsjustering
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
            this.JAnul = new System.Windows.Forms.Button();
            this.NEJnul = new System.Windows.Forms.Button();
            this.Labelnul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JAnul
            // 
            this.JAnul.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.JAnul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JAnul.Location = new System.Drawing.Point(58, 126);
            this.JAnul.Name = "JAnul";
            this.JAnul.Size = new System.Drawing.Size(129, 59);
            this.JAnul.TabIndex = 0;
            this.JAnul.Text = "JA";
            this.JAnul.UseVisualStyleBackColor = false;
            this.JAnul.Click += new System.EventHandler(this.JAnul_Click);
            // 
            // NEJnul
            // 
            this.NEJnul.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NEJnul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEJnul.Location = new System.Drawing.Point(230, 126);
            this.NEJnul.Name = "NEJnul";
            this.NEJnul.Size = new System.Drawing.Size(127, 59);
            this.NEJnul.TabIndex = 1;
            this.NEJnul.Text = "NEJ";
            this.NEJnul.UseVisualStyleBackColor = false;
            this.NEJnul.Click += new System.EventHandler(this.NEJnul_Click);
            // 
            // Labelnul
            // 
            this.Labelnul.AutoSize = true;
            this.Labelnul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelnul.ForeColor = System.Drawing.Color.White;
            this.Labelnul.Location = new System.Drawing.Point(76, 57);
            this.Labelnul.Name = "Labelnul";
            this.Labelnul.Size = new System.Drawing.Size(272, 28);
            this.Labelnul.TabIndex = 2;
            this.Labelnul.Text = "Ønskes nulpunktsjustering?";
            // 
            // Nulpunktsjustering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(427, 250);
            this.Controls.Add(this.Labelnul);
            this.Controls.Add(this.NEJnul);
            this.Controls.Add(this.JAnul);
            this.Name = "Nulpunktsjustering";
            this.Text = "Nulpunktsjustering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JAnul;
        private System.Windows.Forms.Button NEJnul;
        private System.Windows.Forms.Label Labelnul;
    }
}