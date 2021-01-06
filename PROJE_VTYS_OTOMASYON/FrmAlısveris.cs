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

namespace PROJE_VTYS_OTOMASYON
{
    public partial class FrmAlısveris : Form
    {
        public FrmAlısveris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From alısveris_table", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void temizle()
        {
            textBox1.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
        }

        private void FrmAlısveris_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into alısveris_table (URUNADI,BARKODNO,URUNADEDI_KG,BIRIMFIYATI,TOPLAMTUTAR) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox6.Text);
            komut.Parameters.AddWithValue("@p2", int.Parse((textBox5.Text).ToString()));
            komut.Parameters.AddWithValue("@p3", decimal.Parse((textBox4.Text).ToString()));
            komut.Parameters.AddWithValue("@p4", decimal.Parse((textBox3.Text).ToString()));
            komut.Parameters.AddWithValue("@p5", decimal.Parse((textBox2.Text).ToString()));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From alısveris_table where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update alisveris_table set URUNADI=@p1,BARKODNO=@P2,URUNADEDI_KG=@P3,BIRIMFIYATI=@P4,TOPLAMTUTAR=@P5 where ID=@P6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox6.Text);
            komut.Parameters.AddWithValue("@p2", int.Parse((textBox5.Text).ToString()));
            komut.Parameters.AddWithValue("@p3", decimal.Parse((textBox4.Text).ToString()));
            komut.Parameters.AddWithValue("@p4", decimal.Parse((textBox3.Text).ToString()));
            komut.Parameters.AddWithValue("@p5", decimal.Parse((textBox2.Text).ToString()));
            komut.Parameters.Add("@p8", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            temizle();
        }
    }


}
