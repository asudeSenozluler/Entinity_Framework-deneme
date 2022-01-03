using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entinity_Framework_deneme
{
    public partial class frmurun : Form
    {
        public frmurun()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        DbEntinityUrunEntities db = new DbEntinityUrunEntities();
        private void btnlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.FIYAT,
                                            x.TBLKATEGORI.AD,
                                            x.DURUM

                                        }).ToList();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = txturunad.Text;
            t.MARKA = txtmarka.Text;
            t.STOK = short.Parse(txtstok.Text);
            t.KATEGORI =int.Parse( cmbkategori.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(txtfiyat.Text);
            t.DURUM = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün listeye eklendi");

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün listeden silindi");
        }

        private void btngunc_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD = txturunad.Text;
            urun.MARKA = txtmarka.Text;
            urun.FIYAT = decimal.Parse(txtfiyat.Text);
            urun.STOK = short.Parse(txtstok.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
        }

        private void frmurun_Load(object sender, EventArgs e)
        {
            var kategoriler =(from x in db.TBLKATEGORI
                                  select new
                                  {
                                      x.ID,
                                      x.AD
                                  }
                                  ).ToList();
            cmbkategori.ValueMember="ID";
            cmbkategori.DisplayMember="AD";
            cmbkategori.DataSource=kategoriler;
        }

        private void btntemiz_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            txturunad.Text = " ";
            txtstok.Text = " ";
            txtmarka.Text = " ";
            txtfiyat.Text = " ";
            cmbkategori.Text = " ";
            txtdurum.Text = " ";
        }
    }
}
