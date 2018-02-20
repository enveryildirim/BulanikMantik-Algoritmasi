namespace Bulanık
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_hassaslik = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_miktar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_kirlilik = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_sayisal = new System.Windows.Forms.Label();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hassaslik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_miktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kirlilik)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numericUpDown_kirlilik);
            this.groupBox1.Controls.Add(this.numericUpDown_miktar);
            this.groupBox1.Controls.Add(this.numericUpDown_hassaslik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Değerleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miktar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hassaslık";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kirlilik";
            // 
            // numericUpDown_hassaslik
            // 
            this.numericUpDown_hassaslik.Location = new System.Drawing.Point(64, 33);
            this.numericUpDown_hassaslik.Name = "numericUpDown_hassaslik";
            this.numericUpDown_hassaslik.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_hassaslik.TabIndex = 1;
            // 
            // numericUpDown_miktar
            // 
            this.numericUpDown_miktar.Location = new System.Drawing.Point(64, 54);
            this.numericUpDown_miktar.Name = "numericUpDown_miktar";
            this.numericUpDown_miktar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_miktar.TabIndex = 1;
            // 
            // numericUpDown_kirlilik
            // 
            this.numericUpDown_kirlilik.Location = new System.Drawing.Point(64, 77);
            this.numericUpDown_kirlilik.Name = "numericUpDown_kirlilik";
            this.numericUpDown_kirlilik.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_kirlilik.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_durum);
            this.groupBox2.Controls.Add(this.lbl_sayisal);
            this.groupBox2.Location = new System.Drawing.Point(218, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonuc Degerleri";
            // 
            // lbl_sayisal
            // 
            this.lbl_sayisal.AutoSize = true;
            this.lbl_sayisal.Location = new System.Drawing.Point(6, 16);
            this.lbl_sayisal.Name = "lbl_sayisal";
            this.lbl_sayisal.Size = new System.Drawing.Size(0, 13);
            this.lbl_sayisal.TabIndex = 0;
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.Location = new System.Drawing.Point(10, 48);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(0, 13);
            this.lbl_durum.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hassaslik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_miktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_kirlilik)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_kirlilik;
        private System.Windows.Forms.NumericUpDown numericUpDown_miktar;
        private System.Windows.Forms.NumericUpDown numericUpDown_hassaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_sayisal;
        private System.Windows.Forms.Label lbl_durum;
    }
}

