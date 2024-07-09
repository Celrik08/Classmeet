namespace Classmeet
{
    partial class PaketLaundry
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
            label2 = new Label();
            label3 = new Label();
            TextNama = new TextBox();
            TextHarga = new TextBox();
            TextDeskripsi = new TextBox();
            DataLaundry = new DataGridView();
            Nama = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            BtnSimpan = new Button();
            BtnUbah = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataLaundry).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 74);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama Paket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 105);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 139);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Deskripsi";
            // 
            // TextNama
            // 
            TextNama.Location = new Point(117, 71);
            TextNama.Name = "TextNama";
            TextNama.Size = new Size(125, 27);
            TextNama.TabIndex = 4;
            TextNama.KeyPress += TextNama_KeyPress;
            // 
            // TextHarga
            // 
            TextHarga.Location = new Point(117, 104);
            TextHarga.Name = "TextHarga";
            TextHarga.Size = new Size(125, 27);
            TextHarga.TabIndex = 5;
            TextHarga.KeyPress += TextHarga_KeyPress;
            // 
            // TextDeskripsi
            // 
            TextDeskripsi.Location = new Point(117, 136);
            TextDeskripsi.Name = "TextDeskripsi";
            TextDeskripsi.Size = new Size(125, 27);
            TextDeskripsi.TabIndex = 6;
            TextDeskripsi.KeyPress += TextDeskripsi_KeyPress;
            // 
            // DataLaundry
            // 
            DataLaundry.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataLaundry.Columns.AddRange(new DataGridViewColumn[] { Nama, Harga, Deskripsi });
            DataLaundry.Location = new Point(25, 188);
            DataLaundry.Name = "DataLaundry";
            DataLaundry.RowHeadersWidth = 51;
            DataLaundry.RowTemplate.Height = 29;
            DataLaundry.Size = new Size(763, 292);
            DataLaundry.TabIndex = 7;
            DataLaundry.CellContentClick += DataLaundry_CellContentClick;
            // 
            // Nama
            // 
            Nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nama.HeaderText = "Nama Paket";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            // 
            // Harga
            // 
            Harga.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Harga.HeaderText = "Harga";
            Harga.MinimumWidth = 6;
            Harga.Name = "Harga";
            // 
            // Deskripsi
            // 
            Deskripsi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 6;
            Deskripsi.Name = "Deskripsi";
            // 
            // BtnSimpan
            // 
            BtnSimpan.Location = new Point(312, 24);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(94, 29);
            BtnSimpan.TabIndex = 8;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // BtnUbah
            // 
            BtnUbah.Location = new Point(432, 24);
            BtnUbah.Name = "BtnUbah";
            BtnUbah.Size = new Size(94, 29);
            BtnUbah.TabIndex = 9;
            BtnUbah.Text = "Ubah";
            BtnUbah.UseVisualStyleBackColor = true;
            BtnUbah.Click += BtnUbah_Click;
            // 
            // button3
            // 
            button3.Location = new Point(312, 59);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Hapus";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(432, 59);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 41);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 12;
            label4.Text = "Id Paket";
            // 
            // PaketLaundry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(BtnUbah);
            Controls.Add(BtnSimpan);
            Controls.Add(DataLaundry);
            Controls.Add(TextDeskripsi);
            Controls.Add(TextHarga);
            Controls.Add(TextNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PaketLaundry";
            Text = "PaketLaundry";
            ((System.ComponentModel.ISupportInitialize)DataLaundry).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextNama;
        private TextBox TextHarga;
        private TextBox TextDeskripsi;
        private DataGridView DataLaundry;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Harga;
        private DataGridViewTextBoxColumn Deskripsi;
        private Button BtnSimpan;
        private Button BtnUbah;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label4;
    }
}