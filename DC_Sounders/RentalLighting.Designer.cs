namespace DC_Sounders
{
    partial class RentalLighting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalLighting));
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnPesan = new System.Windows.Forms.Button();
            this.boxAlmt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.boxHrga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boxTelp = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.boxKtp = new System.Windows.Forms.TextBox();
            this.BoxNama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxTglLigh = new System.Windows.Forms.DateTimePicker();
            this.cmbJnsLigh = new System.Windows.Forms.ComboBox();
            this._Rental_soundDataSet = new DC_Sounders._Rental_soundDataSet();
            this.lightingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lightingTableAdapter = new DC_Sounders._Rental_soundDataSetTableAdapters.LightingTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._Rental_soundDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(161, 355);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 43;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnPesan
            // 
            this.btnPesan.Location = new System.Drawing.Point(264, 355);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(75, 23);
            this.btnPesan.TabIndex = 42;
            this.btnPesan.Text = "Pesan";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // boxAlmt
            // 
            this.boxAlmt.Location = new System.Drawing.Point(193, 232);
            this.boxAlmt.Name = "boxAlmt";
            this.boxAlmt.Size = new System.Drawing.Size(157, 20);
            this.boxAlmt.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(123, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 23);
            this.label9.TabIndex = 40;
            this.label9.Text = "Pesan Rental Lighting";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // boxHrga
            // 
            this.boxHrga.Location = new System.Drawing.Point(193, 270);
            this.boxHrga.Name = "boxHrga";
            this.boxHrga.Size = new System.Drawing.Size(157, 20);
            this.boxHrga.TabIndex = 38;
            this.boxHrga.TextChanged += new System.EventHandler(this.boxHrga_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "Tanggal Sewa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(108, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 12);
            this.label8.TabIndex = 35;
            this.label8.Text = "Harga";
            // 
            // boxTelp
            // 
            this.boxTelp.Location = new System.Drawing.Point(193, 166);
            this.boxTelp.Name = "boxTelp";
            this.boxTelp.Size = new System.Drawing.Size(157, 20);
            this.boxTelp.TabIndex = 34;
            this.boxTelp.TextChanged += new System.EventHandler(this.boxTelp_TextChanged);
            this.boxTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxTelp_KeyPress);
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(193, 129);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(157, 20);
            this.boxEmail.TabIndex = 33;
            // 
            // boxKtp
            // 
            this.boxKtp.Location = new System.Drawing.Point(193, 92);
            this.boxKtp.Name = "boxKtp";
            this.boxKtp.Size = new System.Drawing.Size(157, 20);
            this.boxKtp.TabIndex = 32;
            this.boxKtp.TextChanged += new System.EventHandler(this.boxKtp_TextChanged);
            this.boxKtp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxKtp_KeyPress);
            // 
            // BoxNama
            // 
            this.BoxNama.Location = new System.Drawing.Point(193, 58);
            this.BoxNama.Name = "BoxNama";
            this.BoxNama.Size = new System.Drawing.Size(157, 20);
            this.BoxNama.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "Jenis Rental";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "No Telp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "No KTP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nama Anda";
            // 
            // boxTglLigh
            // 
            this.boxTglLigh.Location = new System.Drawing.Point(193, 303);
            this.boxTglLigh.Name = "boxTglLigh";
            this.boxTglLigh.Size = new System.Drawing.Size(157, 20);
            this.boxTglLigh.TabIndex = 44;
            // 
            // cmbJnsLigh
            // 
            this.cmbJnsLigh.FormattingEnabled = true;
            this.cmbJnsLigh.Location = new System.Drawing.Point(193, 196);
            this.cmbJnsLigh.Name = "cmbJnsLigh";
            this.cmbJnsLigh.Size = new System.Drawing.Size(157, 21);
            this.cmbJnsLigh.TabIndex = 45;
            this.cmbJnsLigh.SelectedIndexChanged += new System.EventHandler(this.cmbJnsLigh_SelectedIndexChanged);
            // 
            // _Rental_soundDataSet
            // 
            this._Rental_soundDataSet.DataSetName = "_Rental_soundDataSet";
            this._Rental_soundDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lightingBindingSource
            // 
            this.lightingBindingSource.DataMember = "Lighting";
            this.lightingBindingSource.DataSource = this._Rental_soundDataSet;
            // 
            // lightingTableAdapter
            // 
            this.lightingTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // RentalLighting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 412);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmbJnsLigh);
            this.Controls.Add(this.boxTglLigh);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.boxAlmt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boxHrga);
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
            this.Name = "RentalLighting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesan Lighting";
            this.Load += new System.EventHandler(this.RentalLighting_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Rental_soundDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.TextBox boxAlmt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boxHrga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxTelp;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.TextBox boxKtp;
        private System.Windows.Forms.TextBox BoxNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker boxTglLigh;
        private System.Windows.Forms.ComboBox cmbJnsLigh;
        private _Rental_soundDataSet _Rental_soundDataSet;
        private System.Windows.Forms.BindingSource lightingBindingSource;
        private _Rental_soundDataSetTableAdapters.LightingTableAdapter lightingTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}