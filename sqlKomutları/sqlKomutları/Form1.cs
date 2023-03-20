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

namespace sqlKomutları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //global alana bağlantı adesini tanımladık...
       SqlConnection baglantim=new SqlConnection("Data Source=103A-7;Initial Catalog=KITAPLIK;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kITAPLIKDataSet.kitap3' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.kitap3TableAdapter.Fill(this.kITAPLIKDataSet.kitap3);
            // TODO: Bu kod satırı 'kUTUPHANEDataSet.kitap' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.kitapTableAdapter.Fill(this.kUTUPHANEDataSet.kitap);

        }

        private void button2_Click(object sender, EventArgs e)
        {//DİsConnection mimari
            SqlDataAdapter dk=new SqlDataAdapter("select*from kitap3",baglantim);
            //sqlAddapter dataset ile sql arasında bağlantı kurarak istenilen  eylemi tabloda yapar
            DataSet ds =new DataSet();
            dk.Fill(ds, "kitap3");
            //dk.Fill(ds) metodu doldurmak için ........Adapter in bir metodu....
            //   dataGridView1.DataSource = ds.Tables[0]; ile de çalışır.....
            dataGridView1.DataSource = ds.Tables["kitap3"];



            

        }

        private void button1_Click(object sender, EventArgs e)
        {//Connection mimari open -close
           
            SqlCommand kayitekle = new SqlCommand
            ("insert into kitap3(kitapno,kitapad,kitapyazar,kitaptur,kitapfiyat,vergi)" +
            "values(@k1,@k2,@k3,@k4,@k5,@k6)", baglantim);

            kayitekle.Parameters.AddWithValue("@k1", textBox1.Text);
            kayitekle.Parameters.AddWithValue("@k2", textBox2.Text);
            kayitekle.Parameters.AddWithValue("@k3", textBox3.Text);
            kayitekle.Parameters.AddWithValue("@k4", textBox4.Text);
            kayitekle.Parameters.AddWithValue("@k5", textBox5.Text);
            kayitekle.Parameters.AddWithValue("@k6", textBox7.Text);


            baglantim.Open();
            kayitekle.ExecuteNonQuery();// girilen değerleri sqle göndermeye yarar....
            MessageBox.Show("Kayıt eklendi.");
            baglantim.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            SqlCommand kayitsil = new SqlCommand("delete from kitap3 where kitapad=@ad", baglantim);
            kayitsil.Parameters.AddWithValue("@ad", textBox2.Text);
            MessageBox.Show("Kayıt silindi");
            kayitsil.ExecuteNonQuery();
            baglantim.Close();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


            //int secim = dataGridView1.SelectedCells[0].RowIndex;
            //string kitapno = dataGridView1.Rows[secim].Cells[0].Value.ToString();


            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }
        

        private void button3_Click(object sender, EventArgs e)
        {

            SqlCommand kayitguncelle = new SqlCommand
            ("update kitap3 set kitapno=@k1,kitapad=@k2,kitapyazar=@k3,kitaptur=@k4,kitapfiyat=@k5,vergi=@k6 where kitapno = @k1 ", baglantim);
            kayitguncelle.Parameters.AddWithValue("@k1", textBox1.Text);
            kayitguncelle.Parameters.AddWithValue("@k2", textBox2.Text);
            kayitguncelle.Parameters.AddWithValue("@k3", textBox3.Text);
            kayitguncelle.Parameters.AddWithValue("@k4", textBox4.Text);
            kayitguncelle.Parameters.AddWithValue("@k5", textBox5.Text);
            kayitguncelle.Parameters.AddWithValue("@k6", textBox7.Text);

            baglantim.Open();
            kayitguncelle.ExecuteNonQuery();// girilen değerleri sqle göndermeye yarar....
            MessageBox.Show("Kayıt güncelledndi.");
            baglantim.Close();

        }

        private void button9_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sorgu = new SqlDataAdapter
            ("select* from kitap3 where kitapad= '"+textBox9.Text+"'", baglantim);

            DataSet ds = new DataSet();
            sorgu.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            textBox9.Clear();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            SqlCommand hesapla1 = new SqlCommand("select max(kitapfiyat) from kitap3", baglantim);
            SqlDataReader okuma1 = hesapla1.ExecuteReader();
            while (okuma1.Read())
            {
                label17.Text = okuma1[0].ToString();
            }
            baglantim.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            SqlCommand hesapla1 = new SqlCommand("select count(kitapno) from kitap3", baglantim);
            SqlDataReader okuma1=hesapla1.ExecuteReader();
            while (okuma1.Read())
            {
                label18.Text = okuma1[0].ToString();
            }
            baglantim.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            SqlCommand hesapla1 = new SqlCommand("select sum(kitapfiyat) from kitap3", baglantim);
            SqlDataReader okuma1 = hesapla1.ExecuteReader();
            while (okuma1.Read())
            {
                label19.Text = okuma1[0].ToString();
            }
            baglantim.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            SqlCommand hesapla1 = new SqlCommand("select sum(kitapfiyat)/count(kitapno) from kitap3", baglantim);
            SqlDataReader okuma1 = hesapla1.ExecuteReader();
            while (okuma1.Read())
            {
                label20.Text = okuma1[0].ToString();
            }
            baglantim.Close();
        }
    }
}
