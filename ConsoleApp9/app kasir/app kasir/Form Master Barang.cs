using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1
using System.Data.SqlClient;

namespace app_kasir
{
    public partial class Form_Master_Barang : Form
    {
        koneksi konn = new koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        void munculSatuan()
        {
            comboBox1.Items.Add("PCS");
            comboBox1.Items.Add("BOX");
            comboBox1.Items.Add("BOTOL");
            comboBox1.Items.Add("PACK"); 
            comboBox1.Items.Add("SET");
            comboBox1.Items.Add("PAKET");
        }
        void KondisiAwal()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            munculSatuan();
            MunculDataBarang();
        }
        void MunculDataBarang()
        {
            SqlConnection conn = konn.GetConn();
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

        public Form_Master_Barang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form_Master_Barang_Load(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void INPUT_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Anda Mengisi Dengan Lengkap");
            }
            else
            {
                SqlConnection conn = konn.GetConn();

                cmd = new SqlCommand("Insert Into Table_barang values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasir Di Upload");
                KondisiAwal();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Anda Mengisi Dengan Lengkap");
            }
            else
            {
                SqlConnection conn = konn.GetConn();

                cmd = new SqlCommand("Update  Table_barang set NamaBrang = '" + textBox2.Text + "',HargaBeli='" + textBox3.Text + "',hargajual ='" + textBox4.Text + "',jumplahbarang ='"+textBox5.Text+ "',satuanbarang='" +comboBox1.Text + "'where KodeBarang='" + textBox1.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasir Di Perbarui");
                KondisiAwal();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Anda Mengisi Dengan Lengkap");
            }
            else
            {
                SqlConnection conn = konn.GetConn();

                cmd = new SqlCommand("Delete Table_barang where KodeBarang = '" + textBox1.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasir Di Hapus");
                KondisiAwal();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["KodeBarang"].Value.ToString();
                textBox2.Text = row.Cells["NamaBrang"].Value.ToString();
                textBox3.Text = row.Cells["HargaBeli"].Value.ToString();
                textBox4.Text = row.Cells["hargajual"].Value.ToString();
                textBox5.Text = row.Cells["jumplahbarang"].Value.ToString();
                comboBox1.Text = row.Cells["satuanbarang"].Value.ToString();
            }
            catch(Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }
    }
}
