namespace KütüphaneYönetimSistemi
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            button1 = new Button();
            textBoxKullaniciAdi = new TextBox();
            textBoxSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(298, 219);
            button1.Name = "button1";
            button1.Size = new Size(137, 42);
            button1.TabIndex = 0;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Location = new Point(272, 67);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(188, 27);
            textBoxKullaniciAdi.TabIndex = 1;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(272, 156);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(188, 27);
            textBoxSifre.TabIndex = 2;
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(115, 67);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(115, 156);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 4;
            label2.Text = "Şifre:";
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(517, 287);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxKullaniciAdi);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGiris";
            Text = "Kütüphane Yönetim :3";
            TransparencyKey = Color.Black;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxKullaniciAdi;
        private TextBox textBoxSifre;
        private Label label1;
        private Label label2;
    }
}
