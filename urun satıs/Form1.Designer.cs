namespace urun_satıs
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
            this.lblfiyat = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.txtFiyat1 = new System.Windows.Forms.TextBox();
            this.txtFiyat2 = new System.Windows.Forms.TextBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.lblTutar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfiyat.Location = new System.Drawing.Point(55, 46);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(91, 24);
            this.lblfiyat.TabIndex = 0;
            this.lblfiyat.Text = "BirimFiyat";
            this.lblfiyat.Click += new System.EventHandler(this.lblfiyat_Click);
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Location = new System.Drawing.Point(65, 91);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(59, 24);
            this.lblMiktar.TabIndex = 1;
            this.lblMiktar.Text = "Miktar";
            // 
            // txtFiyat1
            // 
            this.txtFiyat1.Location = new System.Drawing.Point(165, 51);
            this.txtFiyat1.Name = "txtFiyat1";
            this.txtFiyat1.Size = new System.Drawing.Size(127, 20);
            this.txtFiyat1.TabIndex = 2;
            // 
            // txtFiyat2
            // 
            this.txtFiyat2.Location = new System.Drawing.Point(165, 96);
            this.txtFiyat2.Name = "txtFiyat2";
            this.txtFiyat2.Size = new System.Drawing.Size(127, 20);
            this.txtFiyat2.TabIndex = 3;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.Location = new System.Drawing.Point(345, 75);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(180, 150);
            this.btnhesapla.TabIndex = 4;
            this.btnhesapla.Text = "Fiyatı Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(65, 167);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(63, 24);
            this.lblTutar.TabIndex = 5;
            this.lblTutar.Text = "Tutar :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 334);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.txtFiyat2);
            this.Controls.Add(this.txtFiyat1);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblfiyat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.TextBox txtFiyat1;
        private System.Windows.Forms.TextBox txtFiyat2;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.Label lblTutar;
    }
}

