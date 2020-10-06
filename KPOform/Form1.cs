using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPOform
{
    public partial class frmFo : Form
    {
        public frmFo()
        {
            InitializeComponent();
            lblJatekos.Text = "";
            lblSzamitogep.Text = "";
            lblGyoztes.Text = "";
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            KezdetiBeallitas();
        }

        private void KezdetiBeallitas()
        {
            lblGyoztes.Text = "";
            lblJatekos.Text = "";
            lblSzamitogep.Text = "";
        }
    }
}
