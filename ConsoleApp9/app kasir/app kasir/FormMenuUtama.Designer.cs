﻿
namespace app_kasir
{
    partial class FormMenuUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.kasirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTransaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.penjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLaporan = new System.Windows.Forms.ToolStripMenuItem();
            this.lapDataMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lapPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUtility = new System.Windows.Forms.ToolStripMenuItem();
            this.gantiPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuMaster,
            this.menuTransaksi,
            this.menuLaporan,
            this.menuUtility});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLogin,
            this.menuLogOut,
            this.toolStripMenuItem1,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(54, 29);
            this.menuFile.Text = "File";
            // 
            // menuLogin
            // 
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(174, 34);
            this.menuLogin.Text = "Login";
            this.menuLogin.Click += new System.EventHandler(this.menuLogin_Click);
            // 
            // menuLogOut
            // 
            this.menuLogOut.Name = "menuLogOut";
            this.menuLogOut.Size = new System.Drawing.Size(174, 34);
            this.menuLogOut.Text = "LogOut";
            this.menuLogOut.Click += new System.EventHandler(this.menuLogOut_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(174, 34);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuMaster
            // 
            this.menuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kasirToolStripMenuItem,
            this.barangToolStripMenuItem});
            this.menuMaster.Name = "menuMaster";
            this.menuMaster.Size = new System.Drawing.Size(82, 29);
            this.menuMaster.Text = "Master";
            // 
            // kasirToolStripMenuItem
            // 
            this.kasirToolStripMenuItem.Name = "kasirToolStripMenuItem";
            this.kasirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.kasirToolStripMenuItem.Text = "Kasir";
            this.kasirToolStripMenuItem.Click += new System.EventHandler(this.kasirToolStripMenuItem_Click);
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.barangToolStripMenuItem.Text = "Barang";
            this.barangToolStripMenuItem.Click += new System.EventHandler(this.barangToolStripMenuItem_Click);
            // 
            // menuTransaksi
            // 
            this.menuTransaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penjualanToolStripMenuItem});
            this.menuTransaksi.Name = "menuTransaksi";
            this.menuTransaksi.Size = new System.Drawing.Size(98, 29);
            this.menuTransaksi.Text = "Transaksi";
            // 
            // penjualanToolStripMenuItem
            // 
            this.penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            this.penjualanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.penjualanToolStripMenuItem.Text = "Penjualan";
            this.penjualanToolStripMenuItem.Click += new System.EventHandler(this.penjualanToolStripMenuItem_Click);
            // 
            // menuLaporan
            // 
            this.menuLaporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lapDataMasterToolStripMenuItem,
            this.lapPenjualanToolStripMenuItem});
            this.menuLaporan.Name = "menuLaporan";
            this.menuLaporan.Size = new System.Drawing.Size(92, 29);
            this.menuLaporan.Text = "Laporan";
            // 
            // lapDataMasterToolStripMenuItem
            // 
            this.lapDataMasterToolStripMenuItem.Name = "lapDataMasterToolStripMenuItem";
            this.lapDataMasterToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.lapDataMasterToolStripMenuItem.Text = "Lap Data Master";
            // 
            // lapPenjualanToolStripMenuItem
            // 
            this.lapPenjualanToolStripMenuItem.Name = "lapPenjualanToolStripMenuItem";
            this.lapPenjualanToolStripMenuItem.Size = new System.Drawing.Size(243, 34);
            this.lapPenjualanToolStripMenuItem.Text = "Lap Penjualan";
            // 
            // menuUtility
            // 
            this.menuUtility.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gantiPasswordToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuUtility.Name = "menuUtility";
            this.menuUtility.Size = new System.Drawing.Size(73, 29);
            this.menuUtility.Text = "Utility";
            // 
            // gantiPasswordToolStripMenuItem
            // 
            this.gantiPasswordToolStripMenuItem.Name = "gantiPasswordToolStripMenuItem";
            this.gantiPasswordToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.gantiPasswordToolStripMenuItem.Text = "Ganti Password";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(235, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // FormMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 502);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuUtama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenuUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        public System.Windows.Forms.ToolStripMenuItem menuLogOut;
        public System.Windows.Forms.ToolStripMenuItem menuMaster;
        public System.Windows.Forms.ToolStripMenuItem kasirToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menuTransaksi;
        public System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menuLaporan;
        public System.Windows.Forms.ToolStripMenuItem lapDataMasterToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem lapPenjualanToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menuUtility;
        public System.Windows.Forms.ToolStripMenuItem gantiPasswordToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem menuLogin;
    }
}