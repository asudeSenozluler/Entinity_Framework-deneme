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
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }
        DbEntinityUrunEntities db = new DbEntinityUrunEntities();

        private void frmistatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKATEGORI.Count().ToString();
            label18.Text = db.TBLURUN.Count().ToString();
            label21.Text = db.TBLMUSTERI.Count(x => x.DURUM == true).ToString();
            label22.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString();
            label17.Text = db.TBLURUN.Sum(y => y.STOK).ToString();
            label16.Text = db.TBLSATIS.Sum(z => z.FIYAT).ToString();
            label20.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            label23.Text = (from x in db.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            label15.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            label24.Text = db.TBLURUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            label14.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
            label19.Text = db.MARKAGETIR().FirstOrDefault();


        }
    }
}
