namespace soru_hesaplama
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
            this.lbldogru = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.btnHesaplama = new System.Windows.Forms.Button();
            this.cmbDogru = new System.Windows.Forms.ComboBox();
            this.cmbYanıs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldogru.Location = new System.Drawing.Point(73, 38);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(118, 24);
            this.lbldogru.TabIndex = 0;
            this.lbldogru.Text = "Dogru Sayi =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yanlıs Sayi =";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNet.Location = new System.Drawing.Point(73, 119);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(112, 24);
            this.lblNet.TabIndex = 2;
            this.lblNet.Text = "Net Doğru =";
            // 
            // btnHesaplama
            // 
            this.btnHesaplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesaplama.Location = new System.Drawing.Point(99, 155);
            this.btnHesaplama.Name = "btnHesaplama";
            this.btnHesaplama.Size = new System.Drawing.Size(155, 95);
            this.btnHesaplama.TabIndex = 5;
            this.btnHesaplama.Text = "Net Doğru Hesaplama =";
            this.btnHesaplama.UseVisualStyleBackColor = true;
            this.btnHesaplama.Click += new System.EventHandler(this.btnHesaplama_Click);
            // 
            // cmbDogru
            // 
            this.cmbDogru.FormattingEnabled = true;
            this.cmbDogru.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbDogru.Location = new System.Drawing.Point(225, 38);
            this.cmbDogru.Name = "cmbDogru";
            this.cmbDogru.Size = new System.Drawing.Size(121, 21);
            this.cmbDogru.TabIndex = 6;
            // 
            // cmbYanıs
            // 
            this.cmbYanıs.FormattingEnabled = true;
            this.cmbYanıs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbYanıs.Location = new System.Drawing.Point(225, 76);
            this.cmbYanıs.Name = "cmbYanıs";
            this.cmbYanıs.Size = new System.Drawing.Size(121, 21);
            this.cmbYanıs.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 292);
            this.Controls.Add(this.cmbYanıs);
            this.Controls.Add(this.cmbDogru);
            this.Controls.Add(this.btnHesaplama);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldogru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbldogru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Button btnHesaplama;
        private System.Windows.Forms.ComboBox cmbDogru;
        private System.Windows.Forms.ComboBox cmbYanıs;
    }
}

