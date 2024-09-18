namespace Modul2aplikasi2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bthitung = new Button();
            btclear = new Button();
            txtsisi = new TextBox();
            txtvolume = new TextBox();
            teks = new Label();
            lblvolume = new Label();
            SuspendLayout();
            // 
            // bthitung
            // 
            bthitung.Location = new Point(579, 101);
            bthitung.Name = "bthitung";
            bthitung.Size = new Size(131, 60);
            bthitung.TabIndex = 0;
            bthitung.Text = "Hitung";
            bthitung.UseVisualStyleBackColor = true;
            bthitung.Click += Hitung_Click;
            // 
            // btclear
            // 
            btclear.Location = new Point(579, 197);
            btclear.Name = "btclear";
            btclear.Size = new Size(131, 48);
            btclear.TabIndex = 1;
            btclear.Text = "Clear";
            btclear.UseVisualStyleBackColor = true;
            btclear.Click += button2_Click;
            // 
            // txtsisi
            // 
            txtsisi.Location = new Point(256, 114);
            txtsisi.Name = "txtsisi";
            txtsisi.Size = new Size(231, 27);
            txtsisi.TabIndex = 2;
            txtsisi.TextChanged += txtsisi_TextChanged;
            // 
            // txtvolume
            // 
            txtvolume.Location = new Point(256, 208);
            txtvolume.Name = "txtvolume";
            txtvolume.Size = new Size(231, 27);
            txtvolume.TabIndex = 3;
            // 
            // teks
            // 
            teks.AutoSize = true;
            teks.Location = new Point(110, 117);
            teks.Name = "teks";
            teks.Size = new Size(75, 20);
            teks.TabIndex = 4;
            teks.Text = "Sisi Kubus";
            teks.Click += label1_Click;
            // 
            // lblvolume
            // 
            lblvolume.AutoSize = true;
            lblvolume.Location = new Point(110, 211);
            lblvolume.Name = "lblvolume";
            lblvolume.Size = new Size(103, 20);
            lblvolume.TabIndex = 5;
            lblvolume.Text = "Volume Kubus";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblvolume);
            Controls.Add(teks);
            Controls.Add(txtvolume);
            Controls.Add(txtsisi);
            Controls.Add(btclear);
            Controls.Add(bthitung);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bthitung;
        private Button btclear;
        private TextBox txtsisi;
        private TextBox txtvolume;
        private Label teks;
        private Label lblvolume;
    }
}
