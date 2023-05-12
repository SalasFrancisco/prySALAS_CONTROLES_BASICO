using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySALAS_CONTROLES_BASICO
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            lblEjeX.Text = e.X.ToString();
            lblEjeY.Text = e.Y.ToString();
        }

        private void frmPrincipal_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = true;
        }

        private void lblBienvenida_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void lblBienvenida_MouseEnter(object sender, EventArgs e)
        {
            lblBienvenida.Location = new Point();
        }

    }
}
