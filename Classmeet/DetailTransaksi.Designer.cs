namespace Classmeet
{
    partial class DetailTransaksi
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
            label1 = new Label();
            DataDetail = new DataGridView();
            Kode = new DataGridViewTextBoxColumn();
            Paket = new DataGridViewTextBoxColumn();
            Pelanggan = new DataGridViewTextBoxColumn();
            Kasir = new DataGridViewTextBoxColumn();
            BtnTambah = new Button();
            BtnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)DataDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Detail Transaksi";
            // 
            // DataDetail
            // 
            DataDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataDetail.Columns.AddRange(new DataGridViewColumn[] { Kode, Paket, Pelanggan, Kasir });
            DataDetail.Location = new Point(12, 125);
            DataDetail.Name = "DataDetail";
            DataDetail.RowHeadersWidth = 51;
            DataDetail.RowTemplate.Height = 29;
            DataDetail.Size = new Size(776, 313);
            DataDetail.TabIndex = 1;
            // 
            // Kode
            // 
            Kode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kode.HeaderText = "Kode Transaksi";
            Kode.MinimumWidth = 6;
            Kode.Name = "Kode";
            // 
            // Paket
            // 
            Paket.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Paket.HeaderText = "Nama Paket";
            Paket.MinimumWidth = 6;
            Paket.Name = "Paket";
            // 
            // Pelanggan
            // 
            Pelanggan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pelanggan.HeaderText = "Nama Pelanggan";
            Pelanggan.MinimumWidth = 6;
            Pelanggan.Name = "Pelanggan";
            // 
            // Kasir
            // 
            Kasir.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kasir.HeaderText = "Nama Kasir";
            Kasir.MinimumWidth = 6;
            Kasir.Name = "Kasir";
            // 
            // BtnTambah
            // 
            BtnTambah.Location = new Point(537, 59);
            BtnTambah.Name = "BtnTambah";
            BtnTambah.Size = new Size(94, 29);
            BtnTambah.TabIndex = 2;
            BtnTambah.Text = "Tambah";
            BtnTambah.UseVisualStyleBackColor = true;
            BtnTambah.Click += BtnTambah_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(656, 59);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 3;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // DetailTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBack);
            Controls.Add(BtnTambah);
            Controls.Add(DataDetail);
            Controls.Add(label1);
            Name = "DetailTransaksi";
            Text = "DetailTransaksi";
            ((System.ComponentModel.ISupportInitialize)DataDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DataDetail;
        private DataGridViewTextBoxColumn Kode;
        private DataGridViewTextBoxColumn Paket;
        private DataGridViewTextBoxColumn Pelanggan;
        private DataGridViewTextBoxColumn Kasir;
        private Button BtnTambah;
        private Button BtnBack;
    }
}