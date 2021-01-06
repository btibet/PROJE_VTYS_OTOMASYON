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
    public partial class FrmStok : Form
    {
        public FrmStok()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From stok_table", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        private void musterisoyadilabel_Click(object sender, EventArgs e)
        {

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
        private void FrmStok_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into stok_table (IRSALIYENO,URUNID,BARKODNO,BIRIMGIRDIFIYATI,URUNADEDI_KG) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", int.Parse((textBox6.Text).ToString()));
            komut.Parameters.AddWithValue("@p2", int.Parse((textBox5.Text).ToString()));
            komut.Parameters.AddWithValue("@p3", textBox4.Text);
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
            SqlCommand komutsil = new SqlCommand("Delete From stok_table where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update stok_table set IRSALIYENO=@P1,URUNID=@P2,BARKODNO=@P3,BIRIMGIRDIFIYATI=@P4,URUNADEDI_KG=@P5, where ID=@P6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", int.Parse((textBox6.Text).ToString()));
            komut.Parameters.AddWithValue("@p2", int.Parse((textBox5.Text).ToString()));
            komut.Parameters.AddWithValue("@p3", textBox4.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse((textBox3.Text).ToString()));
            komut.Parameters.AddWithValue("@p5", decimal.Parse((textBox2.Text).ToString()));
            komut.Parameters.Add("@p6", textBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            textBox6.Text = dr["IRSALIYENO"].ToString();
            textBox5.Text = dr["URUNID"].ToString();
            textBox4.Text = dr["BARKODNO"].ToString();
            textBox3.Text = dr["BIRIMGIRDIFIYATI"].ToString();
            textBox2.Text = dr["URUNADEDI_KG"].ToString();
            textBox1.Text = dr["ID"].ToString();
        }
    }
}
