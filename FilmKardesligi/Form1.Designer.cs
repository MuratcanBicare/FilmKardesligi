
namespace FilmKardesligi
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
            if (disposing)
            {
                db.Dispose();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFilmTurleri = new System.Windows.Forms.ToolStripMenuItem();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.lstFilmler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.gboPuan = new System.Windows.Forms.GroupBox();
            this.rbPuan1 = new System.Windows.Forms.RadioButton();
            this.rbPuan5 = new System.Windows.Forms.RadioButton();
            this.rbPuan2 = new System.Windows.Forms.RadioButton();
            this.rbPuan4 = new System.Windows.Forms.RadioButton();
            this.rbPuan3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.clbTur = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.gboPuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilmTurleri});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFilmTurleri
            // 
            this.tsmiFilmTurleri.Name = "tsmiFilmTurleri";
            this.tsmiFilmTurleri.Size = new System.Drawing.Size(79, 20);
            this.tsmiFilmTurleri.Text = "Film Türleri";
            this.tsmiFilmTurleri.Click += new System.EventHandler(this.tsmiFilmTurleri_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnİptal.Location = new System.Drawing.Point(24, 510);
            this.btnİptal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(130, 35);
            this.btnİptal.TabIndex = 6;
            this.btnİptal.Text = "İPTAL";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Visible = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Location = new System.Drawing.Point(326, 510);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(248, 35);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.Location = new System.Drawing.Point(604, 510);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(248, 35);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // lstFilmler
            // 
            this.lstFilmler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFilmler.DisplayMember = "Kunye";
            this.lstFilmler.FormattingEnabled = true;
            this.lstFilmler.ItemHeight = 20;
            this.lstFilmler.Location = new System.Drawing.Point(326, 76);
            this.lstFilmler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstFilmler.Name = "lstFilmler";
            this.lstFilmler.Size = new System.Drawing.Size(528, 424);
            this.lstFilmler.TabIndex = 8;
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEkle.Location = new System.Drawing.Point(173, 510);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(127, 35);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Adı:";
            // 
            // txtFilm
            // 
            this.txtFilm.Location = new System.Drawing.Point(88, 33);
            this.txtFilm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(223, 26);
            this.txtFilm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Türü:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(25, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 21);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "Çok Kötü";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(25, 92);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 21);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "Kötü";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.Location = new System.Drawing.Point(25, 128);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 21);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.Tag = "3";
            this.radioButton3.Text = "Orta";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton4.Location = new System.Drawing.Point(25, 169);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(39, 21);
            this.radioButton4.TabIndex = 20;
            this.radioButton4.Tag = "4";
            this.radioButton4.Text = "İyi";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton5.Location = new System.Drawing.Point(25, 205);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(67, 21);
            this.radioButton5.TabIndex = 21;
            this.radioButton5.Tag = "5";
            this.radioButton5.Text = "Çok İyi";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // gboPuan
            // 
            this.gboPuan.Controls.Add(this.rbPuan1);
            this.gboPuan.Controls.Add(this.rbPuan5);
            this.gboPuan.Controls.Add(this.radioButton1);
            this.gboPuan.Controls.Add(this.rbPuan2);
            this.gboPuan.Controls.Add(this.radioButton5);
            this.gboPuan.Controls.Add(this.rbPuan4);
            this.gboPuan.Controls.Add(this.radioButton2);
            this.gboPuan.Controls.Add(this.rbPuan3);
            this.gboPuan.Controls.Add(this.radioButton4);
            this.gboPuan.Controls.Add(this.radioButton3);
            this.gboPuan.Location = new System.Drawing.Point(46, 219);
            this.gboPuan.Name = "gboPuan";
            this.gboPuan.Size = new System.Drawing.Size(265, 266);
            this.gboPuan.TabIndex = 22;
            this.gboPuan.TabStop = false;
            this.gboPuan.Text = "Puan";
            // 
            // rbPuan1
            // 
            this.rbPuan1.AutoSize = true;
            this.rbPuan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan1.Location = new System.Drawing.Point(25, 55);
            this.rbPuan1.Name = "rbPuan1";
            this.rbPuan1.Size = new System.Drawing.Size(83, 21);
            this.rbPuan1.TabIndex = 17;
            this.rbPuan1.Tag = "1";
            this.rbPuan1.Text = "Çok Kötü";
            this.rbPuan1.UseVisualStyleBackColor = true;
            // 
            // rbPuan5
            // 
            this.rbPuan5.AutoSize = true;
            this.rbPuan5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan5.Location = new System.Drawing.Point(25, 205);
            this.rbPuan5.Name = "rbPuan5";
            this.rbPuan5.Size = new System.Drawing.Size(67, 21);
            this.rbPuan5.TabIndex = 21;
            this.rbPuan5.Tag = "5";
            this.rbPuan5.Text = "Çok İyi";
            this.rbPuan5.UseVisualStyleBackColor = true;
            // 
            // rbPuan2
            // 
            this.rbPuan2.AutoSize = true;
            this.rbPuan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan2.Location = new System.Drawing.Point(25, 92);
            this.rbPuan2.Name = "rbPuan2";
            this.rbPuan2.Size = new System.Drawing.Size(55, 21);
            this.rbPuan2.TabIndex = 18;
            this.rbPuan2.Tag = "2";
            this.rbPuan2.Text = "Kötü";
            this.rbPuan2.UseVisualStyleBackColor = true;
            // 
            // rbPuan4
            // 
            this.rbPuan4.AutoSize = true;
            this.rbPuan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan4.Location = new System.Drawing.Point(25, 169);
            this.rbPuan4.Name = "rbPuan4";
            this.rbPuan4.Size = new System.Drawing.Size(39, 21);
            this.rbPuan4.TabIndex = 20;
            this.rbPuan4.Tag = "4";
            this.rbPuan4.Text = "İyi";
            this.rbPuan4.UseVisualStyleBackColor = true;
            // 
            // rbPuan3
            // 
            this.rbPuan3.AutoSize = true;
            this.rbPuan3.Checked = true;
            this.rbPuan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan3.Location = new System.Drawing.Point(25, 128);
            this.rbPuan3.Name = "rbPuan3";
            this.rbPuan3.Size = new System.Drawing.Size(54, 21);
            this.rbPuan3.TabIndex = 19;
            this.rbPuan3.TabStop = true;
            this.rbPuan3.Tag = "3";
            this.rbPuan3.Text = "Orta";
            this.rbPuan3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Filmler";
            // 
            // clbTur
            // 
            this.clbTur.CheckOnClick = true;
            this.clbTur.FormattingEnabled = true;
            this.clbTur.Location = new System.Drawing.Point(87, 87);
            this.clbTur.Name = "clbTur";
            this.clbTur.Size = new System.Drawing.Size(224, 130);
            this.clbTur.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 572);
            this.Controls.Add(this.clbTur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gboPuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.lstFilmler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilm);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(880, 611);
            this.Name = "Form1";
            this.Text = "FilmForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gboPuan.ResumeLayout(false);
            this.gboPuan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilmTurleri;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.ListBox lstFilmler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox gboPuan;
        private System.Windows.Forms.RadioButton rbPuan1;
        private System.Windows.Forms.RadioButton rbPuan5;
        private System.Windows.Forms.RadioButton rbPuan2;
        private System.Windows.Forms.RadioButton rbPuan4;
        private System.Windows.Forms.RadioButton rbPuan3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbTur;
    }
}

