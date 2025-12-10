namespace WinFormsApp1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            BtnKaydet = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            rbtKadin = new RadioButton();
            rbErkek = new RadioButton();
            label3 = new Label();
            txttSoyAd = new TextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            BtnDersEkle = new Button();
            comboBox1 = new ComboBox();
            label7 = new Label();
            txtDersKodu = new TextBox();
            label5 = new Label();
            txtDersAd = new TextBox();
            label6 = new Label();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(22, 32);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(737, 392);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.PeachPuff;
            tabPage1.Controls.Add(BtnKaydet);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(rbtKadin);
            tabPage1.Controls.Add(rbErkek);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txttSoyAd);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtAd);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(729, 359);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Öğrenci Ekle";
            // 
            // BtnKaydet
            // 
            BtnKaydet.BackColor = Color.FromArgb(192, 255, 192);
            BtnKaydet.Location = new Point(177, 260);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(161, 51);
            BtnKaydet.TabIndex = 9;
            BtnKaydet.Text = "Ekle";
            BtnKaydet.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 200);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 7;
            label4.Text = "Öğrenci No :";
            // 
            // rbtKadin
            // 
            rbtKadin.AutoSize = true;
            rbtKadin.Location = new Point(249, 154);
            rbtKadin.Name = "rbtKadin";
            rbtKadin.Size = new Size(68, 24);
            rbtKadin.TabIndex = 6;
            rbtKadin.TabStop = true;
            rbtKadin.Text = "Kadın";
            rbtKadin.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(157, 152);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(65, 24);
            rbErkek.TabIndex = 5;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 154);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "Cinsiyet :";
            // 
            // txttSoyAd
            // 
            txttSoyAd.Location = new Point(158, 96);
            txttSoyAd.Name = "txttSoyAd";
            txttSoyAd.Size = new Size(125, 27);
            txttSoyAd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 97);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "SoyAdı :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(158, 43);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 44);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.RosyBrown;
            tabPage2.Controls.Add(BtnDersEkle);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtDersKodu);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtDersAd);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(729, 359);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ders Ekle";
            // 
            // BtnDersEkle
            // 
            BtnDersEkle.BackColor = Color.FromArgb(192, 255, 192);
            BtnDersEkle.Location = new Point(212, 245);
            BtnDersEkle.Name = "BtnDersEkle";
            BtnDersEkle.Size = new Size(149, 48);
            BtnDersEkle.TabIndex = 10;
            BtnDersEkle.Text = "Ders Ekle";
            BtnDersEkle.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" });
            comboBox1.Location = new Point(210, 150);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(104, 151);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 8;
            label7.Text = "Ders Kredisi :";
            // 
            // txtDersKodu
            // 
            txtDersKodu.Location = new Point(209, 97);
            txtDersKodu.Name = "txtDersKodu";
            txtDersKodu.Size = new Size(125, 27);
            txtDersKodu.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 97);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 6;
            label5.Text = "Ders Kodu :";
            // 
            // txtDersAd
            // 
            txtDersAd.Location = new Point(209, 44);
            txtDersAd.Name = "txtDersAd";
            txtDersAd.Size = new Size(125, 27);
            txtDersAd.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 44);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 4;
            label6.Text = "Ders Adı :";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(729, 359);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button BtnKaydet;
        private TextBox textBox1;
        private Label label4;
        private RadioButton rbtKadin;
        private RadioButton rbErkek;
        private Label label3;
        private TextBox txttSoyAd;
        private Label label2;
        private TextBox txtAd;
        private Label label1;
        private Button BtnDersEkle;
        private ComboBox comboBox1;
        private Label label7;
        private TextBox txtDersKodu;
        private Label label5;
        private TextBox txtDersAd;
        private Label label6;
        private TabPage tabPage3;
    }
}
