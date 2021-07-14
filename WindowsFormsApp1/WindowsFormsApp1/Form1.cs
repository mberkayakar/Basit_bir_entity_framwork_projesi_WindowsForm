using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  // entity framwork kullansaydık gerek yoktu

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnderslistele_Click(object sender, EventArgs e)
        {
            SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-67JH255;Initial Catalog=DbEntityDenemesi;Integrated Security=True");
            SqlCommand komut = new SqlCommand("select * from Ders",baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            DbEntityDenemesiEntities db = new DbEntityDenemesiEntities();
            //dataGridView1.DataSource = db.OgrenciTablosus.ToList(); // böyle yaparsan boş kolonalrada gelir yani ilişkililier üzerinde outher join yapar 
            
            //dataGridView1.DataSource = db.OgrenciTablosus.ToList();
            //dataGridView1.Columns[3].Visible = false;
            //dataGridView1.Columns[4].Visible = false;  // bu şekilde navigation proportiesten gelen veriler elenebilir.
            // navigaton proporties ilişkisel veri tabnanındaki ilişki (Fk Pk gibi bu sayede tablolar ilişkilendirilir)

            // biz bunun önüne geçmek için anonimous type değişkenleri (ilişkiden gelen verileri) linq sorgusu yazarak düzeltebiliriz.



            // bunlar ibr yöntemidr 
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
