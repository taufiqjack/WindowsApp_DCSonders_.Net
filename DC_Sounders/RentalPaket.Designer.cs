namespace DC_Sounders
{
    partial class RentalPaket
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalPaket));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BoxNama = new System.Windows.Forms.TextBox();
            this.boxKtp = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.boxTelp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boxAlamat = new System.Windows.Forms.TextBox();
            this._Rental_soundDataSet = new DC_Sounders._Rental_soundDataSet();
            this.paketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paketTableAdapter = new DC_Sounders._Rental_soundDataSetTableAdapters.PaketTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.boxHarga = new System.Windows.Forms.TextBox();
            this.btnPesanNow = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.pemesananTableAdapter = new DC_Sounders._Rental_soundDataSetTableAdapters.PemesananTableAdapter();
            this.cmbBoxJns = new System.Windows.Forms.ComboBox();
            this.boxTglPaket = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rental_soundDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Anda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "No KTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Jenis Rental";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "No Telp";
            // 
            // BoxNama
            // 
            this.BoxNama.Location = new System.Drawing.Point(193, 57);
            this.BoxNama.Name = "BoxNama";
            this.BoxNama.Size = new System.Drawing.Size(157, 20);
            this.BoxNama.TabIndex = 8;
            this.BoxNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxNama_KeyPress);
            // 
            // boxKtp
            // 
            this.boxKtp.Location = new System.Drawing.Point(193, 91);
            this.boxKtp.Name = "boxKtp";
            this.boxKtp.Size = new System.Drawing.Size(157, 20);
            this.boxKtp.TabIndex = 9;
            this.boxKtp.TextChanged += new System.EventHandler(this.boxKtp_TextChanged);
            this.boxKtp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxKtp_KeyPress);
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(193, 128);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(157, 20);
            this.boxEmail.TabIndex = 10;
            // 
            // boxTelp
            // 
            this.boxTelp.Location = new System.Drawing.Point(193, 165);
            this.boxTelp.Name = "boxTelp";
            this.boxTelp.Size = new System.Drawing.Size(157, 20);
            this.boxTelp.TabIndex = 11;
            this.boxTelp.TextChanged += new System.EventHandler(this.boxTelp_TextChanged);
            this.boxTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxTelp_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tanggal Sewa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(108, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "Harga";
            // 
            // boxAlamat
            // 
            this.boxAlamat.Location = new System.Drawing.Point(193, 234);
            this.boxAlamat.Name = "boxAlamat";
            this.boxAlamat.Size = new System.Drawing.Size(157, 20);
            this.boxAlamat.TabIndex = 15;
            // 
            // _Rental_soundDataSet
            // 
            this._Rental_soundDataSet.DataSetName = "_Rental_soundDataSet";
            this._Rental_soundDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paketBindingSource
            // 
            this.paketBindingSource.DataMember = "Paket";
            this.paketBindingSource.DataSource = this._Rental_soundDataSet;
            // 
            // paketTableAdapter
            // 
            this.paketTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(141, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Pesan Rental Paket";
            // 
            // boxHarga
            // 
            this.boxHarga.Location = new System.Drawing.Point(193, 266);
            this.boxHarga.Name = "boxHarga";
            this.boxHarga.Size = new System.Drawing.Size(157, 20);
            this.boxHarga.TabIndex = 21;
            // 
            // btnPesanNow
            // 
            this.btnPesanNow.Location = new System.Drawing.Point(264, 354);
            this.btnPesanNow.Name = "btnPesanNow";
            this.btnPesanNow.Size = new System.Drawing.Size(75, 23);
            this.btnPesanNow.TabIndex = 22;
            this.btnPesanNow.Text = "Pesan";
            this.btnPesanNow.UseVisualStyleBackColor = true;
            this.btnPesanNow.Click += new System.EventHandler(this.btnPesanNow_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(161, 354);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 23;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // pemesananTableAdapter
            // 
            this.pemesananTableAdapter.ClearBeforeFill = true;
            // 
            // cmbBoxJns
            // 
            this.cmbBoxJns.FormattingEnabled = true;
            this.cmbBoxJns.Location = new System.Drawing.Point(193, 199);
            this.cmbBoxJns.Name = "cmbBoxJns";
            this.cmbBoxJns.Size = new System.Drawing.Size(157, 21);
            this.cmbBoxJns.TabIndex = 25;
            this.cmbBoxJns.SelectedIndexChanged += new System.EventHandler(this.cmbBoxJns_SelectedIndexChanged);
            // 
            // boxTglPaket
            // 
            this.boxTglPaket.Location = new System.Drawing.Point(193, 307);
            this.boxTglPaket.Name = "boxTglPaket";
            this.boxTglPaket.Size = new System.Drawing.Size(157, 20);
            this.boxTglPaket.TabIndex = 26;
            // 
            // RentalPaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 403);
            this.Controls.Add(this.boxTglPaket);
            this.Controls.Add(this.cmbBoxJns);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnPesanNow);
            this.Controls.Add(this.boxHarga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boxAlamat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxTelp);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.boxKtp);
            this.Controls.Add(this.BoxNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RentalPaket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesan Paket Sound System & Lighting";
            this.Load += new System.EventHandler(this.RentalPaket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rental_soundDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BoxNama;
        private System.Windows.Forms.TextBox boxKtp;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.TextBox boxTelp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxAlamat;
        private _Rental_soundDataSet _Rental_soundDataSet;
        private System.Windows.Forms.BindingSource paketBindingSource;
        private _Rental_soundDataSetTableAdapters.PaketTableAdapter paketTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boxHarga;
        private System.Windows.Forms.Button btnPesanNow;
        private System.Windows.Forms.Button btnBatal;
        private _Rental_soundDataSetTableAdapters.PemesananTableAdapter pemesananTableAdapter;
        private System.Windows.Forms.ComboBox cmbBoxJns;
        private System.Windows.Forms.DateTimePicker boxTglPaket;
    }
}