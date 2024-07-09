namespace Classmeet
{
    partial class MenuUtama
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
            menuStrip1 = new MenuStrip();
            DataMaster = new ToolStripMenuItem();
            PaketLaundry = new ToolStripMenuItem();
            DetailTransaksi = new ToolStripMenuItem();
            DataTransaksi = new ToolStripMenuItem();
            DataKasir = new ToolStripMenuItem();
            Back = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { DataMaster, DataTransaksi, Back });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // DataMaster
            // 
            DataMaster.DropDownItems.AddRange(new ToolStripItem[] { PaketLaundry, DetailTransaksi });
            DataMaster.Name = "DataMaster";
            DataMaster.Size = new Size(104, 24);
            DataMaster.Text = "Data Master";
            // 
            // PaketLaundry
            // 
            PaketLaundry.Name = "PaketLaundry";
            PaketLaundry.Size = new Size(195, 26);
            PaketLaundry.Text = "Paket Laundry";
            PaketLaundry.Click += PaketLaundry_Click;
            // 
            // DetailTransaksi
            // 
            DetailTransaksi.Name = "DetailTransaksi";
            DetailTransaksi.Size = new Size(195, 26);
            DetailTransaksi.Text = "Detail Transaksi";
            DetailTransaksi.Click += DetailTransaksi_Click;
            // 
            // DataTransaksi
            // 
            DataTransaksi.DropDownItems.AddRange(new ToolStripItem[] { DataKasir });
            DataTransaksi.Name = "DataTransaksi";
            DataTransaksi.Size = new Size(118, 24);
            DataTransaksi.Text = "Data Transaski";
            // 
            // DataKasir
            // 
            DataKasir.Name = "DataKasir";
            DataKasir.Size = new Size(160, 26);
            DataKasir.Text = "Data Kasir";
            DataKasir.Click += DataKasir_Click;
            // 
            // Back
            // 
            Back.Name = "Back";
            Back.Size = new Size(54, 24);
            Back.Text = "Back";
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 42);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Menu Utama";
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuUtama";
            Text = "MenuUtama";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem DataMaster;
        private ToolStripMenuItem PaketLaundry;
        private ToolStripMenuItem DataTransaksi;
        private ToolStripMenuItem DataKasir;
        private ToolStripMenuItem DetailTransaksi;
        private Label label1;
        private ToolStripMenuItem Back;
    }
}