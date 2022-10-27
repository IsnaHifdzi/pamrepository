using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //1


namespace app_kasir
{
    public partial class FormMasterKasir : Form
    {
        koneksi konn = new koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        
        void munculLevel()
        {
            comboBox1.Items.Add("ADMIN");
            comboBox1.Items.Add("USER");
        }
        void KondisiAwal()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            munculLevel();
            MunculDataKasir();
        }
        public FormMasterKasir()
        {
            InitializeComponent();
        }

        private void INPUT_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()== ""|| textBox2.Text.Trim() == ""||textBox3.Text.Trim() == "" ||comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Anda Mengisi Dengan Lengkap");
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                
                cmd = new SqlCommand("Insert Into TBL_KASIR values ('"+textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')",conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasir Di Upload");
                KondisiAwal();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void MunculDataKasir()
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select*from TBL_KASIR", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_KASIR");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TBL_KASIR";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        private void FormMasterKasir_Load(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                SqlConnection conn = konn.GetConn();

                cmd = new SqlCommand("select * from Into TBL_KASIR where KodeKasir='" + textBox1.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    textBox1.Text = rd[0].ToString();
                    textBox2.Text = rd[1].ToString();
                    textBox3.Text = rd[2].ToString();
                    comboBox1.Text = rd[3].ToString();
                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan");
                }
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

                cmd = new SqlCommand("Update TBL_KASIR set NamaKasir = '"  + textBox2.Text + "',PasswordKasir='" + textBox3.Text + "',LevelKasir ='" + comboBox1.Text + "'where kodeKasir='" + textBox1.Text +"'", conn);
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

                cmd = new SqlCommand("Delete TBL_KASIR where KodeKasir = '" + textBox1.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasir Di Hapus");
                KondisiAwal();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["kodeKasir"].Value.ToString();
                textBox2.Text = row.Cells["NamaKasir"].Value.ToString();
                textBox3.Text = row.Cells["PasswordKasir"].Value.ToString();
                comboBox1.Text = row.Cells["LevelKasir"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
