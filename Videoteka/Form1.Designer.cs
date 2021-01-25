namespace Videoteka
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PotvrdiPrijavu = new System.Windows.Forms.Button();
            this.lozinka = new System.Windows.Forms.TextBox();
            this.korisnik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PotvrdiPrijavu);
            this.groupBox1.Controls.Add(this.lozinka);
            this.groupBox1.Controls.Add(this.korisnik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(212, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(264, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prijava";
            // 
            // PotvrdiPrijavu
            // 
            this.PotvrdiPrijavu.Location = new System.Drawing.Point(102, 146);
            this.PotvrdiPrijavu.Margin = new System.Windows.Forms.Padding(2);
            this.PotvrdiPrijavu.Name = "PotvrdiPrijavu";
            this.PotvrdiPrijavu.Size = new System.Drawing.Size(70, 32);
            this.PotvrdiPrijavu.TabIndex = 4;
            this.PotvrdiPrijavu.Text = "Potvrdi";
            this.PotvrdiPrijavu.UseVisualStyleBackColor = true;
            this.PotvrdiPrijavu.Click += new System.EventHandler(this.PotvrdiPrijavu_Click);
            // 
            // lozinka
            // 
            this.lozinka.Location = new System.Drawing.Point(142, 95);
            this.lozinka.Margin = new System.Windows.Forms.Padding(2);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(76, 20);
            this.lozinka.TabIndex = 3;
            this.lozinka.Text = "admin";
            // 
            // korisnik
            // 
            this.korisnik.Location = new System.Drawing.Point(142, 54);
            this.korisnik.Margin = new System.Windows.Forms.Padding(2);
            this.korisnik.Name = "korisnik";
            this.korisnik.Size = new System.Drawing.Size(76, 20);
            this.korisnik.TabIndex = 2;
            this.korisnik.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lozinka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 366);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button PotvrdiPrijavu;
        private System.Windows.Forms.TextBox lozinka;
        private System.Windows.Forms.TextBox korisnik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

