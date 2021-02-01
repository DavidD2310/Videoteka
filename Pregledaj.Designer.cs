namespace Videoteka
{
    partial class Pregledaj
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
            this.Filmovi = new System.Windows.Forms.ListBox();
            this.količina = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Filmovi
            // 
            this.Filmovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Filmovi.FormattingEnabled = true;
            this.Filmovi.ItemHeight = 16;
            this.Filmovi.Location = new System.Drawing.Point(201, 111);
            this.Filmovi.Name = "Filmovi";
            this.Filmovi.Size = new System.Drawing.Size(120, 132);
            this.Filmovi.TabIndex = 0;
            // 
            // količina
            // 
            this.količina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.količina.FormattingEnabled = true;
            this.količina.ItemHeight = 16;
            this.količina.Location = new System.Drawing.Point(327, 111);
            this.količina.Name = "količina";
            this.količina.Size = new System.Drawing.Size(44, 132);
            this.količina.TabIndex = 1;
            // 
            // Pregledaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(594, 353);
            this.Controls.Add(this.količina);
            this.Controls.Add(this.Filmovi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pregledaj";
            this.Text = "Pregledaj";
            this.Load += new System.EventHandler(this.Pregledaj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Filmovi;
        private System.Windows.Forms.ListBox količina;
    }
}