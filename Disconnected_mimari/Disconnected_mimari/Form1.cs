using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Disconnected_mimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=103A-7; Initial Catalog=KuzeyYeli;Integrated Security=True");


        private void newMethod()
        {
            SqlDataAdapter adp= new SqlDataAdapter("select*from Urunler",baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource= dt;
            dataGridView1.Columns["UrunID"].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            newMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = textBox1.Text;
            decimal fiyat = numericUpDown1.Value;
            decimal stok=numericUpDown2.Value;

            if (adi=="" || fiyat==0 || stok==0)
            {
                MessageBox.Show("Tüm alanları eksiksiz doldurunuz.");
            }

            SqlCommand komut = new SqlCommand();
            komut.CommandText =string.Format("insert Urunler(UrunAdi,Fiyat,Stok) values('{0}',{1},{2})", adi, fiyat, stok);
            komut.Connection=baglanti;
            baglanti.Open();
            int etkilenen = komut.ExecuteNonQuery();
            if (etkilenen>0)
            {
                MessageBox.Show("Kayıt Eklendi");
                newMethod();
            }
            else
            {
                MessageBox.Show("Kaydınız eklenemedi...");
            }

            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format("update Urunler set UrunAdi='{0}',Fiyat = {1}, Stok = {2} where UrunID={3}" , textBox1.Text, numericUpDown1.Value, numericUpDown2.Value, textBox1.Tag);//textbox1.tag = hazfızada tutmak için
            command.Connection = baglanti;
            baglanti.Open();

            try
            {
                int etk = command.ExecuteNonQuery();
                baglanti.Close();
                if (etk > 0)
                {
                    MessageBox.Show("Kayıt Güncellendi");
                    newMethod();
                }
                else
                {
                    MessageBox.Show("kayıt güncellenemedi");
                }
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("kayıt güncellenirken hata oluştu" + ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            textBox1.Tag = dataGridView1.CurrentRow.Cells["UrunID"].Value;
            numericUpDown1.Value = (decimal)dataGridView1.CurrentRow.Cells["Fiyat"].Value;
            numericUpDown2.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Stok"].Value);
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kategoriform ktgr = new Kategoriform();
            ktgr.ShowDialog();//Butonna tıkaldığımızda kategori formunu açılmasını sağladıkkk....
            //ktgr.Show(); sadece show dersek diğer formu da aktif yapar...
 
        }
    }
}
