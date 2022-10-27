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
    public partial class FormMasterPenjualan : Form
    {
        koneksi konn = new koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        private void bersih()
        {
            textBox6notransaksi.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }
        void KondisiAwal()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
        private void awal()
        {
            bersih();
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM View_cetaktansaksi order by NoTransaksi DESC", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "View_cetaktansaksi");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "View_cetaktansaksi";
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
                groupBox1.Enabled = false;
            }
            
        }

   
        public FormMasterPenjualan()
        {
            InitializeComponent();
            bersih();
            Auto();
           
        }
        private void Auto()
        {
            {
                long hitung;
                string urut;
                SqlConnection conn = konn.GetConn();
                conn.Open();
                cmd = new SqlCommand("selecet NoTransaksi from Table_Penjualan where NoTransaksi in (select max(NoTransaksi) from Table_Penjualan) order by NoTransaksi desc", conn);
                rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NoTransaksi"].ToString().Length - 12, 4)) + 1;
                    string joinsrt = "0000" + hitung;
                    urut = "TRX-" + joinsrt.Substring(joinsrt.Length - 4, 4) + "/" + DateTime.Now.ToString("MM/yyyy");
                }
                else
                {
                    urut = "TRX-0001/" + DateTime.Now.ToString("MM/yyyy");
                }
                rd.Close();
                textBox6notransaksi.Text = urut;
                textBox6notransaksi.Enabled = false;
                conn.Close();
            }
        }

        private void cari_barang_Click(object sender, EventArgs e)
        {
            dialogbarang brg = new dialogbarang();
            brg.ShowDialog();
            textBox1.Text = brg.ambi_kode_barang;
            textBox2.Text = brg.ambil_nama_barang;
            textBox3.Text = brg.ambil_HargaBeli;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void INPUT_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox5.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Anda Mengisi Dengan Lengkap");
            }
            else
            {
                SqlConnection conn = konn.GetConn();

                cmd = new SqlCommand("Insert Into TBL_KASIR values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasir Di Upload");
                KondisiAwal();
            }
        }

        private void textBox6notransaksi_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
