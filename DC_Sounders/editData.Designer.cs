namespace DC_Sounders
{
    partial class editData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editData));
            this.boxDateTgl = new System.Windows.Forms.DateTimePicker();
            this.cmbJnisSound = new System.Windows.Forms.ComboBox();
            this.boxHrg = new System.Windows.Forms.TextBox();
            this.btnBatalSound = new System.Windows.Forms.Button();
            this.boxAlmt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boxTelp = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.boxKtp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxNama = new System.Windows.Forms.ComboBox();
            this.btnPictBack = new System.Windows.Forms.PictureBox();
            this.pictSave = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSave)).BeginInit();
            this.SuspendLayout();
            // 
            // boxDateTgl
            // 
            this.boxDateTgl.Location = new System.Drawing.Point(149, 305);
            this.boxDateTgl.Name = "boxDateTgl";
            this.boxDateTgl.Size = new System.Drawing.Size(157, 20);
            this.boxDateTgl.TabIndex = 85;
            this.boxDateTgl.ValueChanged += new System.EventHandler(this.boxDateTgl_ValueChanged);
            // 
            // cmbJnisSound
            // 
            this.cmbJnisSound.FormattingEnabled = true;
            this.cmbJnisSound.Location = new System.Drawing.Point(149, 201);
            this.cmbJnisSound.Name = "cmbJnisSound";
            this.cmbJnisSound.Size = new System.Drawing.Size(157, 21);
            this.cmbJnisSound.TabIndex = 84;
            this.cmbJnisSound.Text = "Pilih Jenis Sound";
            this.cmbJnisSound.SelectedIndexChanged += new System.EventHandler(this.cmbJnisSound_SelectedIndexChanged);
            // 
            // boxHrg
            // 
            this.boxHrg.Location = new System.Drawing.Point(149, 270);
            this.boxHrg.Name = "boxHrg";
            this.boxHrg.Size = new System.Drawing.Size(157, 20);
            this.boxHrg.TabIndex = 83;
            this.boxHrg.TextChanged += new System.EventHandler(this.boxHrg_TextChanged);
            // 
            // btnBatalSound
            // 
            this.btnBatalSound.Location = new System.Drawing.Point(66, 359);
            this.btnBatalSound.Name = "btnBatalSound";
            this.btnBatalSound.Size = new System.Drawing.Size(126, 23);
            this.btnBatalSound.TabIndex = 82;
            this.btnBatalSound.Text = "Batalkan Pemesanan";
            this.btnBatalSound.UseVisualStyleBackColor = true;
            this.btnBatalSound.Click += new System.EventHandler(this.btnBatalSound_Click);
            // 
            // boxAlmt
            // 
            this.boxAlmt.Location = new System.Drawing.Point(149, 236);
            this.boxAlmt.Name = "boxAlmt";
            this.boxAlmt.Size = new System.Drawing.Size(157, 20);
            this.boxAlmt.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(79, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 23);
            this.label9.TabIndex = 79;
            this.label9.Text = "EDIT DATA PEMESANAN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 12);
            this.label7.TabIndex = 78;
            this.label7.Text = "Tanggal Sewa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 12);
            this.label8.TabIndex = 77;
            this.label8.Text = "Harga";
            // 
            // boxTelp
            // 
            this.boxTelp.Location = new System.Drawing.Point(149, 170);
            this.boxTelp.Name = "boxTelp";
            this.boxTelp.Size = new System.Drawing.Size(157, 20);
            this.boxTelp.TabIndex = 76;
            this.boxTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxTelp_KeyPress);
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(149, 133);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(157, 20);
            this.boxEmail.TabIndex = 75;
            // 
            // boxKtp
            // 
            this.boxKtp.Location = new System.Drawing.Point(149, 96);
            this.boxKtp.Name = "boxKtp";
            this.boxKtp.Size = new System.Drawing.Size(157, 20);
            this.boxKtp.TabIndex = 74;
            this.boxKtp.TextChanged += new System.EventHandler(this.boxKtp_TextChanged);
            this.boxKtp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxKtp_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 72;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 71;
            this.label5.Text = "Jenis Rental";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 12);
            this.label6.TabIndex = 70;
            this.label6.Text = "No Telp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 12);
            this.label3.TabIndex = 69;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 68;
            this.label2.Text = "No KTP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 67;
            this.label1.Text = "Nama Anda";
            // 
            // cmbBoxNama
            // 
            this.cmbBoxNama.FormattingEnabled = true;
            this.cmbBoxNama.Location = new System.Drawing.Point(149, 58);
            this.cmbBoxNama.Name = "cmbBoxNama";
            this.cmbBoxNama.Size = new System.Drawing.Size(157, 21);
            this.cmbBoxNama.TabIndex = 86;
            this.cmbBoxNama.SelectedIndexChanged += new System.EventHandler(this.cmbBoxNama_SelectedIndexChanged);
            // 
            // btnPictBack
            // 
            this.btnPictBack.Image = ((System.Drawing.Image)(resources.GetObject("btnPictBack.Image")));
            this.btnPictBack.Location = new System.Drawing.Point(2, 2);
            this.btnPictBack.Name = "btnPictBack";
            this.btnPictBack.Size = new System.Drawing.Size(31, 29);
            this.btnPictBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPictBack.TabIndex = 87;
            this.btnPictBack.TabStop = false;
            this.btnPictBack.Click += new System.EventHandler(this.btnPictBack_Click);
            // 
            // pictSave
            // 
            this.pictSave.Image = ((System.Drawing.Image)(resources.GetObject("pictSave.Image")));
            this.pictSave.Location = new System.Drawing.Point(247, 353);
            this.pictSave.Name = "pictSave";
            this.pictSave.Size = new System.Drawing.Size(31, 29);
            this.pictSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictSave.TabIndex = 88;
            this.pictSave.TabStop = false;
            this.pictSave.Click += new System.EventHandler(this.pictSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(229, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 89;
            this.label10.Text = "Simpan Update";
            // 
            // editData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(376, 416);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictSave);
            this.Controls.Add(this.btnPictBack);
            this.Controls.Add(this.cmbBoxNama);
            this.Controls.Add(this.boxDateTgl);
            this.Controls.Add(this.cmbJnisSound);
            this.Controls.Add(this.boxHrg);
            this.Controls.Add(this.btnBatalSound);
            this.Controls.Add(this.boxAlmt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxTelp);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.boxKtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Data Pemesanan";
            this.Load += new System.EventHandler(this.editData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnPictBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker boxDateTgl;
        private System.Windows.Forms.ComboBox cmbJnisSound;
        private System.Windows.Forms.TextBox boxHrg;
        private System.Windows.Forms.Button btnBatalSound;
        private System.Windows.Forms.TextBox boxAlmt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxTelp;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.TextBox boxKtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxNama;
        private System.Windows.Forms.PictureBox btnPictBack;
        private System.Windows.Forms.PictureBox pictSave;
        private System.Windows.Forms.Label label10;
    }
}