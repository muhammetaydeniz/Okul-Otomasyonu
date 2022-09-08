namespace OkulOtomasyonu
{
    partial class FrmSinavNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinavNotlar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSınav1 = new System.Windows.Forms.Label();
            this.txtSınav1 = new System.Windows.Forms.TextBox();
            this.lblDers = new System.Windows.Forms.Label();
            this.lblDersId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSınav2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSınav3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(823, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(121, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 80;
            // 
            // lblSınav1
            // 
            this.lblSınav1.AutoSize = true;
            this.lblSınav1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSınav1.ForeColor = System.Drawing.Color.White;
            this.lblSınav1.Location = new System.Drawing.Point(15, 114);
            this.lblSınav1.Name = "lblSınav1";
            this.lblSınav1.Size = new System.Drawing.Size(81, 24);
            this.lblSınav1.TabIndex = 78;
            this.lblSınav1.Text = "SINAV1:";
            // 
            // txtSınav1
            // 
            this.txtSınav1.Location = new System.Drawing.Point(121, 114);
            this.txtSınav1.Name = "txtSınav1";
            this.txtSınav1.Size = new System.Drawing.Size(169, 20);
            this.txtSınav1.TabIndex = 77;
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDers.ForeColor = System.Drawing.Color.White;
            this.lblDers.Location = new System.Drawing.Point(15, 79);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(66, 24);
            this.lblDers.TabIndex = 76;
            this.lblDers.Text = "DERS:";
            // 
            // lblDersId
            // 
            this.lblDersId.AutoSize = true;
            this.lblDersId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersId.ForeColor = System.Drawing.Color.White;
            this.lblDersId.Location = new System.Drawing.Point(15, 44);
            this.lblDersId.Name = "lblDersId";
            this.lblDersId.Size = new System.Drawing.Size(88, 24);
            this.lblDersId.TabIndex = 75;
            this.lblDersId.Text = "DERS ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(121, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 20);
            this.txtID.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 82;
            this.label1.Text = "SINAV2:";
            // 
            // txtSınav2
            // 
            this.txtSınav2.Location = new System.Drawing.Point(121, 150);
            this.txtSınav2.Name = "txtSınav2";
            this.txtSınav2.Size = new System.Drawing.Size(169, 20);
            this.txtSınav2.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 84;
            this.label2.Text = "SINAV3:";
            // 
            // txtSınav3
            // 
            this.txtSınav3.Location = new System.Drawing.Point(122, 186);
            this.txtSınav3.Name = "txtSınav3";
            this.txtSınav3.Size = new System.Drawing.Size(169, 20);
            this.txtSınav3.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(346, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 86;
            this.label3.Text = "PROJE:";
            // 
            // txtProje
            // 
            this.txtProje.Location = new System.Drawing.Point(429, 51);
            this.txtProje.Name = "txtProje";
            this.txtProje.Size = new System.Drawing.Size(169, 20);
            this.txtProje.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(303, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 88;
            this.label4.Text = "ORTALAMA:";
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(429, 89);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(169, 20);
            this.txtOrtalama.TabIndex = 87;
            this.txtOrtalama.TextChanged += new System.EventHandler(this.txtOrtalama_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(340, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 90;
            this.label5.Text = "DURUM:";
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(429, 128);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(169, 20);
            this.txtDurum.TabIndex = 89;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.Transparent;
            this.btnHesapla.Location = new System.Drawing.Point(672, 50);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(107, 32);
            this.btnHesapla.TabIndex = 92;
            this.btnHesapla.Text = "button1";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(618, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.Location = new System.Drawing.Point(671, 88);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(107, 32);
            this.btnGuncelle.TabIndex = 94;
            this.btnGuncelle.Text = "button1";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(618, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Transparent;
            this.btnTemizle.Location = new System.Drawing.Point(671, 128);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(107, 32);
            this.btnTemizle.TabIndex = 96;
            this.btnTemizle.Text = "button1";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(618, 128);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 95;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(618, 167);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 98;
            this.pictureBox7.TabStop = false;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.Transparent;
            this.btnAra.Location = new System.Drawing.Point(671, 167);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(107, 32);
            this.btnAra.TabIndex = 97;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(787, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 99;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(0, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 100;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 25);
            this.label7.TabIndex = 101;
            this.label7.Text = "NOT İŞLEMLERİ";
            // 
            // FrmSinavNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(824, 439);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSınav3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSınav2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSınav1);
            this.Controls.Add(this.txtSınav1);
            this.Controls.Add(this.lblDers);
            this.Controls.Add(this.lblDersId);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSinavNotlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSinavNotlar";
            this.Load += new System.EventHandler(this.FrmSinavNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSınav1;
        private System.Windows.Forms.TextBox txtSınav1;
        private System.Windows.Forms.Label lblDers;
        private System.Windows.Forms.Label lblDersId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSınav2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSınav3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
    }
}