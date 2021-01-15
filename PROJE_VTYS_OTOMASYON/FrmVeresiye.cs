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
    public partial class FrmVeresiye : Form
    {
        public FrmVeresiye()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From veresiye_table", bgl.baglanti());
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
            textBox7.Text = "";
            textBox8.Text = "";
        }
        private void FrmVeresiye_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into veresiye_table (MUSTERIID,MUSTERIAD,MUSTERISOYAD,BORCTARIHI,URUNID,URUNADEDI_KG,BORCU) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", int.Parse((textBox6.Text).ToString()));
            komut.Parameters.AddWithValue("@p2", textBox5.Text);
            komut.Parameters.AddWithValue("@p3", textBox4.Text);
            komut.Parameters.AddWithValue("@p4", textBox3.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((textBox2.Text).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse((textBox7.Text).ToString()));
            komut.Parameters.AddWithValue("@p7", decimal.Parse((textBox8.Text).ToString()));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From veresiye_table where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update veresiye_table set MUSTERIID=@p1,MUSTERIAD=@P2,MUSTERISOYAD=@P3,BORCTARIHI=@P4,URUNID=@P5,URUNADEDI_KG=@P6,BORCU=@P7 where ID=@P8", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", int.Parse((textBox6.Text).ToString()));
            komut.Parameters.AddWithValue("@p2", textBox5.Text);
            komut.Parameters.AddWithValue("@p3", textBox4.Text);
            komut.Parameters.AddWithValue("@p4", textBox3.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((textBox2.Text).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse((textBox7.Text).ToString()));
            komut.Parameters.AddWithValue("@p7", decimal.Parse((textBox8.Text).ToString()));
            komut.Parameters.Add("@p8", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            textBox1.Text = dr["ID"].ToString();
            textBox6.Text = dr["MUSTERIID"].ToString();
            textBox5.Text = dr["MUSTERIAD"].ToString();
            textBox4.Text = dr["MUSTERISOYAD"].ToString();
            textBox3.Text = dr["BORCTARIHI"].ToString();
            textBox2.Text = dr["URUNID"].ToString();
            textBox7.Text = dr["URUNADEDI_KG"].ToString();
            textBox8.Text = dr["BORCU"].ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
