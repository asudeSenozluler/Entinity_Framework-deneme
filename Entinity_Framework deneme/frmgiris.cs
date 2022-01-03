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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DbEntinityUrunEntities db = new DbEntinityUrunEntities();
            var sorgu = from x in db.TBLADMIN where x.KULLANICI == textBox1.Text && x.SIFRE == textBox2.Text select x;
            if(sorgu.Any())
            {
                frmanaform fr = new frmanaform();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");

            }
        }
    }
}
