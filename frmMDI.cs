using System;
using System.Drawing;
using System.Windows.Forms;
using AppCahierText.Views.Parametre;
using AppCahierText.Views.Account;

namespace AppCahierText
{
    public partial class frmMDI : Form
    {
        public string profil;

        public frmMDI()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            AppliquerProfil();
        }

        private void AppliquerProfil()
        {
            bool estAdmin = string.Equals(profil, "ChefDepartement", StringComparison.OrdinalIgnoreCase);

            if (securiteToolStripMenuItem != null)
                securiteToolStripMenuItem.Visible = estAdmin;

            // On active ou désactive les menus selon le profil
            if (anneeAcademiqToolStripMenuItem != null) anneeAcademiqToolStripMenuItem.Enabled = estAdmin;
            if (classeToolStripMenuItem != null) classeToolStripMenuItem.Enabled = estAdmin;
            if (matiereToolStripMenuItem != null) matiereToolStripMenuItem.Enabled = estAdmin;
        }

        private void fermer()
        {
            foreach (Form enfant in this.MdiChildren)
            {
                enfant.Close();
            }
        }

        // --- LES MÉTHODES MANQUANTES (Vérifie bien l'orthographe) ---

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            this.Hide();
            frmConnexion login = new frmConnexion();
            login.ShowDialog();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void matiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmMatiere f = new frmMatiere { MdiParent = this };
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void anneeAcademiqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmAnneeAcademique f = new frmAnneeAcademique { MdiParent = this };
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmClasse f = new frmClasse { MdiParent = this };
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmUtilisateurs f = new frmUtilisateurs { MdiParent = this };
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void responsableDeClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            // FrmResponsableClasse f = new FrmResponsableClasse { MdiParent = this };
            // f.Show();
        }

        private void imprimerMatiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            // Code pour l'impression ici
        }
    }
}