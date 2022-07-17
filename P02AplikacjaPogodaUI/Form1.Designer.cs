namespace P02AplikacjaPogodaUI
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
            this.txtNazwaMiasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPodajTemeprature = new System.Windows.Forms.Button();
            this.cbMiasta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNazwaMiasta
            // 
            this.txtNazwaMiasta.Location = new System.Drawing.Point(12, 37);
            this.txtNazwaMiasta.Name = "txtNazwaMiasta";
            this.txtNazwaMiasta.Size = new System.Drawing.Size(165, 20);
            this.txtNazwaMiasta.TabIndex = 0;
            this.txtNazwaMiasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNazwaMiasta_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa miasta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnPodajTemeprature
            // 
            this.btnPodajTemeprature.Location = new System.Drawing.Point(183, 34);
            this.btnPodajTemeprature.Name = "btnPodajTemeprature";
            this.btnPodajTemeprature.Size = new System.Drawing.Size(75, 23);
            this.btnPodajTemeprature.TabIndex = 2;
            this.btnPodajTemeprature.Text = "Wczytaj";
            this.btnPodajTemeprature.UseVisualStyleBackColor = true;
            this.btnPodajTemeprature.Click += new System.EventHandler(this.btnPodajTemeprature_Click);
            // 
            // cbMiasta
            // 
            this.cbMiasta.FormattingEnabled = true;
            this.cbMiasta.Location = new System.Drawing.Point(12, 72);
            this.cbMiasta.Name = "cbMiasta";
            this.cbMiasta.Size = new System.Drawing.Size(165, 21);
            this.cbMiasta.TabIndex = 3;
            this.cbMiasta.SelectedIndexChanged += new System.EventHandler(this.cbMiasta_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 113);
            this.Controls.Add(this.cbMiasta);
            this.Controls.Add(this.btnPodajTemeprature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazwaMiasta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazwaMiasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPodajTemeprature;
        private System.Windows.Forms.ComboBox cbMiasta;
    }
}

