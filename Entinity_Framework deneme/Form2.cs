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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DbEntinityUrunDataSet1.TBLURUN' table. You can move, or remove it, as needed.
            this.TBLURUNTableAdapter.Fill(this.DbEntinityUrunDataSet1.TBLURUN);

            this.reportViewer1.RefreshReport();
        }
    }
}
