using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtons
{
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RdoHappy_CheckedChanged(object sender, EventArgs e)
        {
            PicHappy.Visible = true;
            PicSad.Visible = false;

        }

        private void PicSad_Click(object sender, EventArgs e)
        {
            
        }

        private void RdoSad_CheckedChanged(object sender, EventArgs e)
        {
            PicHappy.Visible = false;
            PicSad.Visible = true;
        }

        private void FrmRadio_Load(object sender, EventArgs e)
        {

        }
    }
}
