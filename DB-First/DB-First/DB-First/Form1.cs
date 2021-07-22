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


namespace DB_First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-IHFUPUV;Initial Catalog=EntityFrameworkDBFirst;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }
        EntityFrameworkDBFirstEntities1 entity = new EntityFrameworkDBFirstEntities1();
        
        private void button4_Click(object sender, EventArgs e)
        {

            var bilgiler = entity.Ogrencis.ToList();
            dataGridView1.DataSource = bilgiler;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var bilgiler = from item in entity.Notlars
                           select new
                           {
                               item.İd,
                               item.Ogrenci,
                               item.Dersler,
                               item.Sinav1
                           };
            dataGridView1.DataSource = bilgiler.ToList();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible= true;
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox4.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.İsim = textBox1.Text;
            ogr.Soyisim = textBox2.Text;
            ogr.Fotograf = textBox4.Text;

            entity.Ogrencis.Add(ogr);
            entity.SaveChanges();
            MessageBox.Show("Kayıt Edildi Hayırlı Ugurlu Olsun");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            var sorgu = entity.Ogrencis.Find(id);
            entity.Ogrencis.Remove(sorgu);
            entity.SaveChanges();
            MessageBox.Show("silindi");
        }
    }
}
