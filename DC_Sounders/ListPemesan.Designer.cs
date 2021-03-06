namespace DC_Sounders
{
    partial class ListPemesan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPemesan));
            this.dataGridListPemesanan = new System.Windows.Forms.DataGridView();
            this.btnDelPict = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPictBackReport = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListPemesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictBackReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridListPemesanan
            // 
            this.dataGridListPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListPemesanan.Location = new System.Drawing.Point(12, 40);
            this.dataGridListPemesanan.Name = "dataGridListPemesanan";
            this.dataGridListPemesanan.Size = new System.Drawing.Size(766, 287);
            this.dataGridListPemesanan.TabIndex = 0;
            this.dataGridListPemesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridListPemesanan_CellContentClick);
            this.dataGridListPemesanan.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridListPemesanan_CellContentDoubleClick);
            // 
            // btnDelPict
            // 
            this.btnDelPict.Image = ((System.Drawing.Image)(resources.GetObject("btnDelPict.Image")));
            this.btnDelPict.Location = new System.Drawing.Point(36, 350);
            this.btnDelPict.Name = "btnDelPict";
            this.btnDelPict.Size = new System.Drawing.Size(58, 51);
            this.btnDelPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelPict.TabIndex = 1;
            this.btnDelPict.TabStop = false;
            this.btnDelPict.Click += new System.EventHandler(this.btnDelPict_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hapus Data Pilihan";
            // 
            // btnPictBackReport
            // 
            this.btnPictBackReport.Image = ((System.Drawing.Image)(resources.GetObject("btnPictBackReport.Image")));
            this.btnPictBackReport.Location = new System.Drawing.Point(2, 1);
            this.btnPictBackReport.Name = "btnPictBackReport";
            this.btnPictBackReport.Size = new System.Drawing.Size(29, 19);
            this.btnPictBackReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPictBackReport.TabIndex = 5;
            this.btnPictBackReport.TabStop = false;
            this.btnPictBackReport.Click += new System.EventHandler(this.btnPictBackReport_Click);
            // 
            // ListPemesan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 437);
            this.Controls.Add(this.btnPictBackReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelPict);
            this.Controls.Add(this.dataGridListPemesanan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListPemesan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Data Pemesan";
            this.Load += new System.EventHandler(this.ListPemesan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListPemesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPictBackReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridListPemesanan;
        private System.Windows.Forms.PictureBox btnDelPict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnPictBackReport;
    }
}