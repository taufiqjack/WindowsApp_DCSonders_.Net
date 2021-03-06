namespace DC_Sounders
{
    partial class RentalSound
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalSound));
            this.btnBatalSound = new System.Windows.Forms.Button();
            this.btnPsn = new System.Windows.Forms.Button();
            this.boxAlmt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.boxHrg = new System.Windows.Forms.TextBox();
            this.cmbJnisSound = new System.Windows.Forms.ComboBox();
            this.soundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Rental_soundDataSet = new DC_Sounders._Rental_soundDataSet();
            this.soundTableAdapter = new DC_Sounders._Rental_soundDataSetTableAdapters.SoundTableAdapter();
            this.boxDateTgl = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.soundBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rental_soundDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBatalSound
            // 
            this.btnBatalSound.Location = new System.Drawing.Point(146, 362);
            this.btnBatalSound.Name = "btnBatalSound";
            this.btnBatalSound.Size = new System.Drawing.Size(75, 23);
            this.btnBatalSound.TabIndex = 62;
            this.btnBatalSound.Text = "Batal";
            this.btnBatalSound.UseVisualStyleBackColor = true;
            this.btnBatalSound.Click += new System.EventHandler(this.btnBatalSound_Click);
            // 
            // btnPsn
            // 
            this.btnPsn.Location = new System.Drawing.Point(249, 362);
            this.btnPsn.Name = "btnPsn";
            this.btnPsn.Size = new System.Drawing.Size(75, 23);
            this.btnPsn.TabIndex = 61;
            this.btnPsn.Text = "Pesan";
            this.btnPsn.UseVisualStyleBackColor = true;
            this.btnPsn.Click += new System.EventHandler(this.btnPsn_Click);
            // 
            // boxAlmt
            // 
            this.boxAlmt.Location = new System.Drawing.Point(178, 239);
            this.boxAlmt.Name = "boxAlmt";
            this.boxAlmt.Size = new System.Drawing.Size(157, 20);
            this.boxAlmt.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lemon/Milk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(108, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 23);
            this.label9.TabIndex = 59;
            this.label9.Text = "Pesan Rental Sound";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(93, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 12);
            this.label7.TabIndex = 55;
            this.label7.Text = "Tanggal Sewa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 12);
            this.label8.TabIndex = 54;
            this.label8.Text = "Harga";
            // 
            // boxTelp
            // 
            this.boxTelp.Location = new System.Drawing.Point(178, 173);
            this.boxTelp.Name = "boxTelp";
            this.boxTelp.Size = new System.Drawing.Size(157, 20);
            this.boxTelp.TabIndex = 53;
            this.boxTelp.TextChanged += new System.EventHandler(this.boxTelp_TextChanged);
            this.boxTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxTelp_KeyPress);
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(178, 136);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(157, 20);
            this.boxEmail.TabIndex = 52;
            // 
            // boxKtp
            // 
            this.boxKtp.Location = new System.Drawing.Point(178, 99);
            this.boxKtp.Name = "boxKtp";
            this.boxKtp.Size = new System.Drawing.Size(157, 20);
            this.boxKtp.TabIndex = 51;
            this.boxKtp.TextChanged += new System.EventHandler(this.boxKtp_TextChanged);
            this.boxKtp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxKtp_KeyPress);
            // 
            // BoxNama
            // 
            this.BoxNama.Location = new System.Drawing.Point(178, 65);
            this.BoxNama.Name = "BoxNama";
            this.BoxNama.Size = new System.Drawing.Size(157, 20);
            this.BoxNama.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 48;
            this.label5.Text = "Jenis Rental";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 12);
            this.label6.TabIndex = 47;
            this.label6.Text = "No Telp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 12);
            this.label3.TabIndex = 46;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "No KTP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nama Anda";
            // 
            // boxHrg
            // 
            this.boxHrg.Location = new System.Drawing.Point(178, 273);
            this.boxHrg.Name = "boxHrg";
            this.boxHrg.Size = new System.Drawing.Size(157, 20);
            this.boxHrg.TabIndex = 64;
            // 
            // cmbJnisSound
            // 
            this.cmbJnisSound.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soundBindingSource, "nama_Sound", true));
            this.cmbJnisSound.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.soundBindingSource, "nama_Sound", true));
            this.cmbJnisSound.FormattingEnabled = true;
            this.cmbJnisSound.Location = new System.Drawing.Point(178, 204);
            this.cmbJnisSound.Name = "cmbJnisSound";
            this.cmbJnisSound.Size = new System.Drawing.Size(157, 21);
            this.cmbJnisSound.TabIndex = 65;
            this.cmbJnisSound.SelectedIndexChanged += new System.EventHandler(this.cmbJnisSound_SelectedIndexChanged);
            // 
            // soundBindingSource
            // 
            this.soundBindingSource.DataMember = "Sound";
            this.soundBindingSource.DataSource = this._Rental_soundDataSet;
            // 
            // _Rental_soundDataSet
            // 
            this._Rental_soundDataSet.DataSetName = "_Rental_soundDataSet";
            this._Rental_soundDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soundTableAdapter
            // 
            this.soundTableAdapter.ClearBeforeFill = true;
            // 
            // boxDateTgl
            // 
            this.boxDateTgl.Location = new System.Drawing.Point(178, 308);
            this.boxDateTgl.Name = "boxDateTgl";
            this.boxDateTgl.Size = new System.Drawing.Size(157, 20);
            this.boxDateTgl.TabIndex = 66;
            this.boxDateTgl.ValueChanged += new System.EventHandler(this.boxDateTgl_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // RentalSound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boxDateTgl);
            this.Controls.Add(this.cmbJnisSound);
            this.Controls.Add(this.boxHrg);
            this.Controls.Add(this.btnBatalSound);
            this.Controls.Add(this.btnPsn);
            this.Controls.Add(this.boxAlmt);
            this.Controls.Add(this.label9);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RentalSound";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesan Sound";
            this.Load += new System.EventHandler(this.RentalSound_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soundBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Rental_soundDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBatalSound;
        private System.Windows.Forms.Button btnPsn;
        private System.Windows.Forms.TextBox boxAlmt;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.TextBox boxHrg;
        private System.Windows.Forms.ComboBox cmbJnisSound;
        private _Rental_soundDataSet _Rental_soundDataSet;
        private System.Windows.Forms.BindingSource soundBindingSource;
        private _Rental_soundDataSetTableAdapters.SoundTableAdapter soundTableAdapter;
        private System.Windows.Forms.DateTimePicker boxDateTgl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}