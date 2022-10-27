using System;
using System.Windows.Forms;

namespace app_kasir
{
    public partial class FormMenuUtama : Form
    {
        public static FormMenuUtama menu;
        MenuStrip mnstrip;
        FormLogin frmLogin;
        FormMasterPenjualan frmJual;
        void frmlogin_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin = null;
        }
        FormMasterKasir frmKasir;
        void frmKasir_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmKasir = null;
        }
        Form_Master_Barang frmBarang;
        void frmBarang_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmBarang = null;
        }
        void frmJual_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmJual = null;
        }

        void MenuTerkunci()
        {
            menuLogin.Enabled = true;
            menuLogOut.Enabled = false;
            menuMaster.Enabled = false;
            menuTransaksi.Enabled = false;
            menuUtility.Enabled = false;
            menuLaporan.Enabled = false;
            menu = this;
        }
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void menuLogin_Click(object sender, EventArgs e)
        {
            if (frmLogin == null)
            {
                frmLogin = new FormLogin();
                frmLogin.FormClosed += new FormClosedEventHandler(frmlogin_fromClosed);
                frmLogin.ShowDialog();
            }
            else
            {
                frmLogin.Activate();
            }
        }

        private void menuLogOut_Click(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void kasirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKasir == null)
            {
                frmKasir = new FormMasterKasir();
                frmKasir.FormClosed += new FormClosedEventHandler(frmKasir_fromClosed);
                frmKasir.ShowDialog();
            }
            else
            {
                frmKasir.Activate();
            }
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmBarang == null)
            {
                frmBarang = new Form_Master_Barang();
                frmBarang.FormClosed += new FormClosedEventHandler(frmBarang_fromClosed);
                frmBarang.ShowDialog();
            }
            else
            {
                frmBarang.Activate();
            }
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmJual == null)
            {
                frmJual = new FormMasterPenjualan();
                frmJual.FormClosed += new FormClosedEventHandler(frmJual_fromClosed);
                frmJual.ShowDialog();
            }
            else
            {
                frmJual.Activate();
            }
        }
    }
}
