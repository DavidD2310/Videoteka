namespace Videoteka
{
    partial class Form2
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
            this.Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iznajmi = new System.Windows.Forms.Button();
            this.pregledaj = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(41, 291);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(108, 34);
            this.Close.TabIndex = 0;
            this.Close.Text = "button1";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.iznajmi);
            this.panel1.Controls.Add(this.pregledaj);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // iznajmi
            // 
            this.iznajmi.Location = new System.Drawing.Point(41, 28);
            this.iznajmi.Name = "iznajmi";
            this.iznajmi.Size = new System.Drawing.Size(108, 41);
            this.iznajmi.TabIndex = 2;
            this.iznajmi.Text = "iznajmi";
            this.iznajmi.UseVisualStyleBackColor = true;
            // 
            // pregledaj
            // 
            this.pregledaj.Location = new System.Drawing.Point(41, 85);
            this.pregledaj.Name = "pregledaj";
            this.pregledaj.Size = new System.Drawing.Size(108, 38);
            this.pregledaj.TabIndex = 3;
            this.pregledaj.Text = "pregledaj";
            this.pregledaj.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "vrati";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 39);
            this.button4.TabIndex = 5;
            this.button4.Text = "pregledaj filmove";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(193, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 331);
            this.panel3.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button iznajmi;
        private System.Windows.Forms.Button pregledaj;
    }
}