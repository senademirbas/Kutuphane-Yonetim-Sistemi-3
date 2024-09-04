namespace KütüphaneYönetimSistemi
{
    partial class FormKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitaplar));
            groupBox1 = new GroupBox();
            buttonTemizle = new Button();
            buttonKitabiSil = new Button();
            buttonSorgula = new Button();
            buttonKitapEkle = new Button();
            buttonKitapBilgiGuncelle = new Button();
            textBoxTurKodu = new TextBox();
            textBoxISBN = new TextBox();
            textBoxYazarSoyadi = new TextBox();
            textBoxYazarAdi = new TextBox();
            textBoxKitapAdi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labelID = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonOduncVer = new Button();
            dateTimePickerOduncAlmaTarihi = new DateTimePicker();
            textBoxOduncAlan = new TextBox();
            label9 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            buttonKitabiIadeEt = new Button();
            label11 = new Label();
            labelGecikmeBedeli = new Label();
            buttonGecikmeBedeliHesapla = new Button();
            label10 = new Label();
            groupBox4 = new GroupBox();
            dataGridViewKitaplar = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonTemizle);
            groupBox1.Controls.Add(buttonKitabiSil);
            groupBox1.Controls.Add(buttonSorgula);
            groupBox1.Controls.Add(buttonKitapEkle);
            groupBox1.Controls.Add(buttonKitapBilgiGuncelle);
            groupBox1.Controls.Add(textBoxTurKodu);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(textBoxYazarSoyadi);
            groupBox1.Controls.Add(textBoxYazarAdi);
            groupBox1.Controls.Add(textBoxKitapAdi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 390);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Ekle ve Güncelle";
            // 
            // buttonTemizle
            // 
            buttonTemizle.BackColor = SystemColors.ButtonFace;
            buttonTemizle.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            buttonTemizle.Location = new Point(330, 127);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(113, 31);
            buttonTemizle.TabIndex = 17;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = false;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // buttonKitabiSil
            // 
            buttonKitabiSil.BackColor = SystemColors.ActiveBorder;
            buttonKitabiSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonKitabiSil.Location = new Point(321, 317);
            buttonKitabiSil.Name = "buttonKitabiSil";
            buttonKitabiSil.Size = new Size(113, 62);
            buttonKitabiSil.TabIndex = 18;
            buttonKitabiSil.Text = "Kitabı Sil";
            buttonKitabiSil.UseVisualStyleBackColor = false;
            buttonKitabiSil.Click += buttonKitabiSil_Click;
            // 
            // buttonSorgula
            // 
            buttonSorgula.BackColor = SystemColors.ButtonFace;
            buttonSorgula.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            buttonSorgula.Location = new Point(330, 86);
            buttonSorgula.Name = "buttonSorgula";
            buttonSorgula.Size = new Size(113, 32);
            buttonSorgula.TabIndex = 16;
            buttonSorgula.Text = "Sorgula";
            buttonSorgula.UseVisualStyleBackColor = false;
            buttonSorgula.Click += buttonSorgula_Click;
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.BackColor = SystemColors.ActiveBorder;
            buttonKitapEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonKitapEkle.Location = new Point(177, 317);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(113, 62);
            buttonKitapEkle.TabIndex = 13;
            buttonKitapEkle.Text = "Kitap Ekle";
            buttonKitapEkle.UseVisualStyleBackColor = false;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // buttonKitapBilgiGuncelle
            // 
            buttonKitapBilgiGuncelle.BackColor = SystemColors.ActiveBorder;
            buttonKitapBilgiGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonKitapBilgiGuncelle.Location = new Point(22, 317);
            buttonKitapBilgiGuncelle.Name = "buttonKitapBilgiGuncelle";
            buttonKitapBilgiGuncelle.Size = new Size(125, 62);
            buttonKitapBilgiGuncelle.TabIndex = 12;
            buttonKitapBilgiGuncelle.Text = "Kitap Bilgileri Güncelle";
            buttonKitapBilgiGuncelle.UseVisualStyleBackColor = false;
            buttonKitapBilgiGuncelle.Click += buttonKitapBilgiGuncelle_Click;
            // 
            // textBoxTurKodu
            // 
            textBoxTurKodu.Location = new Point(177, 260);
            textBoxTurKodu.Name = "textBoxTurKodu";
            textBoxTurKodu.Size = new Size(125, 27);
            textBoxTurKodu.TabIndex = 11;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(177, 220);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(125, 27);
            textBoxISBN.TabIndex = 10;
            // 
            // textBoxYazarSoyadi
            // 
            textBoxYazarSoyadi.Location = new Point(177, 175);
            textBoxYazarSoyadi.Name = "textBoxYazarSoyadi";
            textBoxYazarSoyadi.Size = new Size(125, 27);
            textBoxYazarSoyadi.TabIndex = 9;
            // 
            // textBoxYazarAdi
            // 
            textBoxYazarAdi.Location = new Point(177, 131);
            textBoxYazarAdi.Name = "textBoxYazarAdi";
            textBoxYazarAdi.Size = new Size(125, 27);
            textBoxYazarAdi.TabIndex = 8;
            // 
            // textBoxKitapAdi
            // 
            textBoxKitapAdi.Location = new Point(177, 85);
            textBoxKitapAdi.Name = "textBoxKitapAdi";
            textBoxKitapAdi.Size = new Size(125, 27);
            textBoxKitapAdi.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 12F);
            label7.Location = new Point(8, 135);
            label7.Name = "label7";
            label7.Size = new Size(108, 23);
            label7.TabIndex = 6;
            label7.Text = "Yazar Adı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 12F);
            label6.Location = new Point(8, 264);
            label6.Name = "label6";
            label6.Size = new Size(163, 23);
            label6.TabIndex = 5;
            label6.Text = "Kitap Tür Kodu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 12F);
            label5.Location = new Point(8, 224);
            label5.Name = "label5";
            label5.Size = new Size(67, 23);
            label5.TabIndex = 4;
            label5.Text = "ISBN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 12F);
            label4.Location = new Point(8, 179);
            label4.Name = "label4";
            label4.Size = new Size(139, 23);
            label4.TabIndex = 3;
            label4.Text = "Yazar Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 12F);
            label3.Location = new Point(8, 89);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 2;
            label3.Text = "Kitap Adı:";
            // 
            // labelID
            // 
            labelID.AutoEllipsis = true;
            labelID.AutoSize = true;
            labelID.Location = new Point(230, 43);
            labelID.Name = "labelID";
            labelID.Size = new Size(15, 20);
            labelID.TabIndex = 1;
            labelID.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F);
            label1.Location = new Point(8, 40);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 0;
            label1.Text = "Kitap ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonOduncVer);
            groupBox2.Controls.Add(dateTimePickerOduncAlmaTarihi);
            groupBox2.Controls.Add(textBoxOduncAlan);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(488, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 390);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödünç Alma";
            // 
            // buttonOduncVer
            // 
            buttonOduncVer.BackColor = SystemColors.ActiveBorder;
            buttonOduncVer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonOduncVer.Location = new Point(67, 317);
            buttonOduncVer.Name = "buttonOduncVer";
            buttonOduncVer.Size = new Size(139, 62);
            buttonOduncVer.TabIndex = 15;
            buttonOduncVer.Text = "Kitabı Ödünç Ver";
            buttonOduncVer.UseVisualStyleBackColor = false;
            buttonOduncVer.Click += buttonOduncVer_Click;
            // 
            // dateTimePickerOduncAlmaTarihi
            // 
            dateTimePickerOduncAlmaTarihi.Location = new Point(134, 131);
            dateTimePickerOduncAlmaTarihi.Name = "dateTimePickerOduncAlmaTarihi";
            dateTimePickerOduncAlmaTarihi.Size = new Size(136, 27);
            dateTimePickerOduncAlmaTarihi.TabIndex = 4;
            // 
            // textBoxOduncAlan
            // 
            textBoxOduncAlan.Location = new Point(134, 89);
            textBoxOduncAlan.Name = "textBoxOduncAlan";
            textBoxOduncAlan.Size = new Size(136, 27);
            textBoxOduncAlan.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 12F);
            label9.Location = new Point(6, 135);
            label9.Name = "label9";
            label9.Size = new Size(67, 23);
            label9.TabIndex = 4;
            label9.Text = "Tarih:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 12F);
            label8.Location = new Point(6, 89);
            label8.Name = "label8";
            label8.Size = new Size(125, 23);
            label8.TabIndex = 3;
            label8.Text = "Ödünç Alan:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonKitabiIadeEt);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(labelGecikmeBedeli);
            groupBox3.Controls.Add(buttonGecikmeBedeliHesapla);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(770, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(236, 390);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kitap İade";
            // 
            // buttonKitabiIadeEt
            // 
            buttonKitabiIadeEt.BackColor = SystemColors.ActiveBorder;
            buttonKitabiIadeEt.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonKitabiIadeEt.Location = new Point(52, 317);
            buttonKitabiIadeEt.Name = "buttonKitabiIadeEt";
            buttonKitabiIadeEt.Size = new Size(139, 62);
            buttonKitabiIadeEt.TabIndex = 17;
            buttonKitabiIadeEt.Text = "Kitabı İade Et";
            buttonKitabiIadeEt.UseVisualStyleBackColor = false;
            buttonKitabiIadeEt.Click += buttonKitabiIadeEt_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(197, 95);
            label11.Name = "label11";
            label11.Size = new Size(24, 20);
            label11.TabIndex = 16;
            label11.Text = "TL";
            // 
            // labelGecikmeBedeli
            // 
            labelGecikmeBedeli.AutoSize = true;
            labelGecikmeBedeli.Location = new Point(174, 96);
            labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            labelGecikmeBedeli.Size = new Size(17, 20);
            labelGecikmeBedeli.TabIndex = 15;
            labelGecikmeBedeli.Text = "0";
            // 
            // buttonGecikmeBedeliHesapla
            // 
            buttonGecikmeBedeliHesapla.BackColor = SystemColors.Menu;
            buttonGecikmeBedeliHesapla.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            buttonGecikmeBedeliHesapla.Location = new Point(24, 130);
            buttonGecikmeBedeliHesapla.Name = "buttonGecikmeBedeliHesapla";
            buttonGecikmeBedeliHesapla.Size = new Size(197, 33);
            buttonGecikmeBedeliHesapla.TabIndex = 14;
            buttonGecikmeBedeliHesapla.Text = "Gecikme Bedeli Hesapla";
            buttonGecikmeBedeliHesapla.UseVisualStyleBackColor = false;
            buttonGecikmeBedeliHesapla.Click += buttonGecikmeBedeliHesapla_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 12F);
            label10.Location = new Point(6, 93);
            label10.Name = "label10";
            label10.Size = new Size(160, 23);
            label10.TabIndex = 4;
            label10.Text = "Gecikme Bedeli:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewKitaplar);
            groupBox4.Location = new Point(23, 397);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(983, 305);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Dock = DockStyle.Fill;
            dataGridViewKitaplar.Location = new Point(3, 23);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.RowHeadersWidth = 51;
            dataGridViewKitaplar.Size = new Size(977, 279);
            dataGridViewKitaplar.TabIndex = 0;
            dataGridViewKitaplar.CellClick += dataGridViewKitaplar_CellClick;
            // 
            // FormKitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1033, 714);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormKitaplar";
            Text = "Kütüphane Yönetim :3";
            FormClosed += FormKitaplar_FormClosed;
            Load += FormKitaplar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelID;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarSoyadi;
        private TextBox textBoxYazarAdi;
        private TextBox textBoxKitapAdi;
        private Button buttonKitapEkle;
        private Button buttonKitapBilgiGuncelle;
        private TextBox textBoxTurKodu;
        private TextBox textBoxOduncAlan;
        private Label label9;
        private Label label8;
        private GroupBox groupBox4;
        private DataGridView dataGridViewKitaplar;
        private DateTimePicker dateTimePickerOduncAlmaTarihi;
        private Button buttonKitabiIadeEt;
        private Label label11;
        private Label labelGecikmeBedeli;
        private Button buttonGecikmeBedeliHesapla;
        private Label label10;
        private Button buttonOduncVer;
        private Button buttonTemizle;
        private Button buttonSorgula;
        private Button buttonKitabiSil;
    }
}