using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCahierText.Views.Parametre;

namespace AppCahierText
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void matiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatiere f = new frmMatiere();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
                
        }

        private void anneeAcademiqToolStripMenuItem_Click(object sender, EventArgs e)
        {
			frmAnneeAcademique f = new frmAnneeAcademique();
			f.MdiParent = this;
			f.Show();
            f.WindowState = FormWindowState.Maximized;

        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
			frmClasse f = new frmClasse();
			f.MdiParent = this;
			f.Show();
		}

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
