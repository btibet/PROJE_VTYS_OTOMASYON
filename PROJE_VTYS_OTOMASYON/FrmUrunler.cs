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

    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From urun_table",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }




        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into urun_table (URUNADI,BARKODNO,TARIH,URUNADEDI_KG,ALISFIYATI,SATISFIYATI) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox6.Text);
            komut.Parameters.AddWithValue("@p2", int.Parse((textBox5.Text).ToString()));
            komut.Parameters.AddWithValue("@p3", textBox4.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse((textBox3.Text).ToString()));
            komut.Parameters.AddWithValue("@p5", decimal.Parse((textBox2.Text).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse((textBox7.Text).ToString()));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {      
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From urun_table where URUNID=@p1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            textBox1.Text = dr["URUNID"].ToString();
            textBox6.Text = dr["URUNADI"].ToString();
            textBox5.Text = dr["BARKODNO"].ToString();
            textBox4.Text = dr["TARIH"].ToString();
            textBox3.Text = dr["URUNADEDI_KG"].ToString();
            textBox2.Text = dr["ALISFIYATI"].ToString();
            textBox7.Text = dr["SATISFIYATI"].ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update urun_table set URUNADI=@P1,BARKODNO=@P2,TARIH=@P3,URUNADEDI_KG=@P4,ALISFIYATI=@P5,SATISFIYATI=@P6 where URUNID=@P7", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox6.Text);
            komut.Parameters.AddWithValue("@p2", int.Parse((textBox5.Text).ToString()));
            komut.Parameters.AddWithValue("@p3", textBox4.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse((textBox3.Text).ToString()));
            komut.Parameters.AddWithValue("@p5", decimal.Parse((textBox2.Text).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse((textBox7.Text).ToString()));
            komut.Parameters.Add("@p7", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
