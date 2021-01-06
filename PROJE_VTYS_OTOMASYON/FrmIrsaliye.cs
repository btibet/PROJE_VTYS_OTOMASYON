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
    public partial class FrmIrsaliye : Form
    {
        public FrmIrsaliye()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From irsaliye_table", bgl.baglanti());
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
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void FrmIrsaliye_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into irsaliye_table (URUNADEDI_KG,BIRIMGIRDIFIYATI,IRSALIYENO,BORCTARIHI,FIRMAADI,IRSALIYETARIHI,TOPLAMTUTAR) values (@p1,@p2,@p3,@p4,@p5,@p6,p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", decimal.Parse((textBox6.Text).ToString()));
            komut.Parameters.AddWithValue("@p2", decimal.Parse((textBox5.Text).ToString()));
            komut.Parameters.AddWithValue("@p3", int.Parse((textBox4.Text).ToString()));
            komut.Parameters.AddWithValue("@p4", textBox3.Text);
            komut.Parameters.AddWithValue("@p5", textBox2.Text);
            komut.Parameters.AddWithValue("@p6", decimal.Parse((textBox7.Text).ToString()));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From irsaliye_table where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update irsaliye_table set URUNADEDI_KG=@p1,BIRIMGIRDIFIYATI=@P2,IRSALIYENO=@P3,FIRMAADI=@P4,IRSALIYETARIHI=@P5,TOPLAMTUTAR=@P6 where ID=@P7", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", decimal.Parse((textBox6.Text).ToString()));
            komut.Parameters.AddWithValue("@p2", decimal.Parse((textBox5.Text).ToString()));
            komut.Parameters.AddWithValue("@p3", int.Parse((textBox4.Text).ToString()));
            komut.Parameters.AddWithValue("@p4", textBox3.Text);
            komut.Parameters.AddWithValue("@p5", textBox2.Text);
            komut.Parameters.AddWithValue("@p6", decimal.Parse((textBox7.Text).ToString()));
            komut.Parameters.Add("@p7", textBox1.Text);
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
            textBox6.Text = dr["URUNADEDI_KG"].ToString();
            textBox5.Text = dr["BIRIMGIRDIFIYATI"].ToString();
            textBox4.Text = dr["IRSALIYENO"].ToString();
            textBox3.Text = dr["FIRMADI"].ToString();
            textBox2.Text = dr["IRSALIYETARIHI"].ToString();
            textBox7.Text = dr["TOPLAMTUTAR"].ToString();
        }
    }
}
