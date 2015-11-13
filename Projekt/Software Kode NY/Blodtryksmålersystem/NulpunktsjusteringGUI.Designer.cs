namespace Blodtryksmålersystem
{
    partial class NulpunktsjusteringGUI
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
            this.Labelnul = new System.Windows.Forms.Label();
            this.JaKnapNul = new System.Windows.Forms.Button();
            this.NejKnapNul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Labelnul
            // 
            this.Labelnul.AutoSize = true;
            this.Labelnul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelnul.ForeColor = System.Drawing.Color.White;
            this.Labelnul.Location = new System.Drawing.Point(58, 65);
            this.Labelnul.Name = "Labelnul";
            this.Labelnul.Size = new System.Drawing.Size(272, 28);
            this.Labelnul.TabIndex = 3;
            this.Labelnul.Text = "Ønskes nulpunktsjustering?";
            // 
            // JaKnapNul
            // 
            this.JaKnapNul.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.JaKnapNul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JaKnapNul.Location = new System.Drawing.Point(49, 124);
            this.JaKnapNul.Name = "JaKnapNul";
            this.JaKnapNul.Size = new System.Drawing.Size(129, 59);
            this.JaKnapNul.TabIndex = 4;
            this.JaKnapNul.Text = "JA";
            this.JaKnapNul.UseVisualStyleBackColor = false;
            this.JaKnapNul.Click += new System.EventHandler(this.JaKnapNul_Click);
            // 
            // NejKnapNul
            // 
            this.NejKnapNul.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NejKnapNul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NejKnapNul.Location = new System.Drawing.Point(203, 124);
            this.NejKnapNul.Name = "NejKnapNul";
            this.NejKnapNul.Size = new System.Drawing.Size(127, 59);
            this.NejKnapNul.TabIndex = 5;
            this.NejKnapNul.Text = "NEJ";
            this.NejKnapNul.UseVisualStyleBackColor = false;
            this.NejKnapNul.Click += new System.EventHandler(this.NejKnapNul_Click);
            // 
            // NulpunktsjusteringGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(391, 245);
            this.Controls.Add(this.NejKnapNul);
            this.Controls.Add(this.JaKnapNul);
            this.Controls.Add(this.Labelnul);
            this.Name = "NulpunktsjusteringGUI";
            this.Text = "NulpunktsjusteringGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Labelnul;
        private System.Windows.Forms.Button JaKnapNul;
        private System.Windows.Forms.Button NejKnapNul;
    }
}