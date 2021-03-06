namespace DC_Sounders
{
    partial class CekPemesanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CekPemesanan));
            this.btnCari = new System.Windows.Forms.Button();
            this.boxCari = new System.Windows.Forms.TextBox();
            this.dataGridCari = new System.Windows.Forms.DataGridView();
            this.btnBatalCek = new System.Windows.Forms.Button();
            this.btnPictEdit = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(246, 90);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 0;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // boxCari
            // 
            this.boxCari.Location = new System.Drawing.Point(182, 54);
            this.boxCari.Name = "boxCari";
            this.boxCari.Size = new System.Drawing.Size(213, 20);
            this.boxCari.TabIndex = 2;
            this.boxCari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxCari.TextChanged += new System.EventHandler(this.boxCari_TextChanged);
            // 
            // dataGridCari
            // 
            this.dataGridCari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCari.Location = new System.Drawing.Point(13, 138);
            this.dataGridCari.Name = "dataGridCari";
            this.dataGridCari.Size = new System.Drawing.Size(551, 235);
            this.dataGridCari.TabIndex = 3;
            this.dataGridCari.Visible = false;
            this.dataGridCari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCari_CellContentClick);
            // 
            // btnBatalCek
            // 
            this.btnBatalCek.Location = new System.Drawing.Point(8, 6);
            this.btnBatalCek.Name = "btnBatalCek";
            this.btnBatalCek.Size = new System.Drawing.Size(75, 23);
            this.btnBatalCek.TabIndex = 83;
            this.btnBatalCek.Text = "Batal";
            this.btnBatalCek.UseVisualStyleBackColor = true;
            this.btnBatalCek.Click += new System.EventHandler(this.btnBatalCek_Click);
            // 
            // btnPictEdit
            // 
            this.btnPictEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnPictEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnPictEdit.Image")));
            this.btnPictEdit.Location = new System.Drawing.Point(464, 378);
            this.btnPictEdit.Name = "btnPictEdit";
            this.btnPictEdit.Size = new System.Drawing.Size(55, 49);
            this.btnPictEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPictEdit.TabIndex = 84;
            this.btnPictEdit.TabStop = false;
            this.btnPictEdit.Visible = false;
            this.btnPictEdit.Click += new System.EventHandler(this.btnPictEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(479, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Edit";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(161, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 64);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cek Pemesanan Anda";
            // 
            // CekPemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPictEdit);
            this.Controls.Add(this.btnBatalCek);
            this.Controls.Add(this.dataGridCari);
            this.Controls.Add(this.boxCari);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CekPemesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cek Pemesanan";
            this.Load += new System.EventHandler(this.Pemesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox boxCari;
        private System.Windows.Forms.DataGridView dataGridCari;
        private System.Windows.Forms.Button btnBatalCek;
        private System.Windows.Forms.PictureBox btnPictEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}