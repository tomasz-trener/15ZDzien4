namespace P03EdytorTekstowy
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
            this.txtDane = new System.Windows.Forms.TextBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.txtSciezka = new System.Windows.Forms.TextBox();
            this.btnNaDuze = new System.Windows.Forms.Button();
            this.btnNaMale = new System.Windows.Forms.Button();
            this.txtSzukanyWyraz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPolicz = new System.Windows.Forms.Button();
            this.lblWynikZliczenia = new System.Windows.Forms.Label();
            this.lbDane = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtDane
            // 
            this.txtDane.Location = new System.Drawing.Point(12, 43);
            this.txtDane.Multiline = true;
            this.txtDane.Name = "txtDane";
            this.txtDane.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDane.Size = new System.Drawing.Size(395, 395);
            this.txtDane.TabIndex = 0;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(332, 14);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // txtSciezka
            // 
            this.txtSciezka.Location = new System.Drawing.Point(13, 17);
            this.txtSciezka.Name = "txtSciezka";
            this.txtSciezka.Size = new System.Drawing.Size(313, 20);
            this.txtSciezka.TabIndex = 2;
            this.txtSciezka.Click += new System.EventHandler(this.txtSciezka_Click);
            // 
            // btnNaDuze
            // 
            this.btnNaDuze.Location = new System.Drawing.Point(414, 43);
            this.btnNaDuze.Name = "btnNaDuze";
            this.btnNaDuze.Size = new System.Drawing.Size(75, 23);
            this.btnNaDuze.TabIndex = 3;
            this.btnNaDuze.Text = "Na duże";
            this.btnNaDuze.UseVisualStyleBackColor = true;
            this.btnNaDuze.Click += new System.EventHandler(this.btnNaDuze_Click);
            // 
            // btnNaMale
            // 
            this.btnNaMale.Location = new System.Drawing.Point(414, 72);
            this.btnNaMale.Name = "btnNaMale";
            this.btnNaMale.Size = new System.Drawing.Size(75, 23);
            this.btnNaMale.TabIndex = 4;
            this.btnNaMale.Text = "Na małe";
            this.btnNaMale.UseVisualStyleBackColor = true;
            this.btnNaMale.Click += new System.EventHandler(this.btnNaMale_Click);
            // 
            // txtSzukanyWyraz
            // 
            this.txtSzukanyWyraz.Location = new System.Drawing.Point(414, 143);
            this.txtSzukanyWyraz.Name = "txtSzukanyWyraz";
            this.txtSzukanyWyraz.Size = new System.Drawing.Size(106, 20);
            this.txtSzukanyWyraz.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Podaj dowolny wyraz";
            // 
            // btnPolicz
            // 
            this.btnPolicz.Location = new System.Drawing.Point(526, 140);
            this.btnPolicz.Name = "btnPolicz";
            this.btnPolicz.Size = new System.Drawing.Size(75, 23);
            this.btnPolicz.TabIndex = 7;
            this.btnPolicz.Text = "Policz";
            this.btnPolicz.UseVisualStyleBackColor = true;
            this.btnPolicz.Click += new System.EventHandler(this.btnPolicz_Click);
            // 
            // lblWynikZliczenia
            // 
            this.lblWynikZliczenia.AutoSize = true;
            this.lblWynikZliczenia.Location = new System.Drawing.Point(414, 176);
            this.lblWynikZliczenia.Name = "lblWynikZliczenia";
            this.lblWynikZliczenia.Size = new System.Drawing.Size(13, 13);
            this.lblWynikZliczenia.TabIndex = 8;
            this.lblWynikZliczenia.Text = "0";
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(413, 192);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(192, 251);
            this.lbDane.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.lbDane);
            this.Controls.Add(this.lblWynikZliczenia);
            this.Controls.Add(this.btnPolicz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSzukanyWyraz);
            this.Controls.Add(this.btnNaMale);
            this.Controls.Add(this.btnNaDuze);
            this.Controls.Add(this.txtSciezka);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.txtDane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.TextBox txtSciezka;
        private System.Windows.Forms.Button btnNaDuze;
        private System.Windows.Forms.Button btnNaMale;
        private System.Windows.Forms.TextBox txtSzukanyWyraz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPolicz;
        private System.Windows.Forms.Label lblWynikZliczenia;
        private System.Windows.Forms.ListBox lbDane;
    }
}

