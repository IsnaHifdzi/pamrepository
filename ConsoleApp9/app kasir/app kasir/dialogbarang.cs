using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace app_kasir
{
    public partial class dialogbarang : Form
    {
        koneksi konn = new koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        public string KodeBarang, NamaBrang, Hargabeli = "";

         void KondisiAwal()
        {
            textBox1.Text = "";
            MunculDataBarang();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MunculDataBarang();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                KodeBarang = row.Cells["KodeBarang"].Value.ToString();
                NamaBrang = row.Cells["NamaBrang"].Value.ToString();
                Hargabeli = row.Cells["Hargabeli"].Value.ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        public string ambi_kode_barang
        {
            get
            {
                return KodeBarang;
            }
        }
        public string ambil_nama_barang
        {
            get
            {
                return NamaBrang;
            }
        }
        public string ambil_HargaBeli
        {
            get
            {
                return Hargabeli;
            }
        }

        void MunculDataBarang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {

                    conn.Open();
                    cmd = new SqlCommand("select*from Table_barang", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "Table_barang");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Table_barang";
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Refresh();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dialogbarang_Load(object sender, EventArgs e)
        {

        }

        void cari_barang()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from Table_barang where KodeBarang like '%" + textBox1.Text + "%' or NamaBrang like'%" + textBox1.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "Table_barang" );
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "Table_barang";
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public dialogbarang()
        {
            InitializeComponent();
        }
    }
}
