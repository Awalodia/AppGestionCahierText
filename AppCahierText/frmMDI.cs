using System;
using System.Windows.Forms;
using AppCahierText.Views.Account;
using AppCahierText.Views.Parametre;

namespace AppCahierText
{
    public partial class frmMDI : Form
    {
        public string profil { get; set; }

        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            GererDroits();
        }

        private void GererDroits()
        {
            if (profil == "Professeur")
            {
                syllabusToolStripMenuItem.Enabled = false;
                utilisateurToolStripMenuItem.Visible = false;
                anneeAcademiqToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Ferme toutes les fenêtres enfants (MDI Children) actuellement ouvertes.
        /// </summary>
        private void FermerEnfants()
        {
            foreach (Form enfant in this.MdiChildren)
            {
                enfant.Close();
            }
        }

        // --- GESTION DES CLICS ---

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConnexion f = new frmConnexion();
            f.ShowDialog();
            this.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants(); // Ferme la fenêtre précédente
            frmUtilisateurs f = new frmUtilisateurs();
            f.MdiParent = this;
            f.Show();
        }

        private void anneeAcademiqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants(); // Ferme la fenêtre précédente
            frmAnneeAcademique f = new frmAnneeAcademique();
            f.MdiParent = this;
            f.Show();
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants(); // Ferme la fenêtre précédente
            frmClasse f = new frmClasse();
            f.MdiParent = this;
            f.Show();
        }

        private void matiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants(); // Ferme la fenêtre précédente
            frmMatiere f = new frmMatiere();
            f.MdiParent = this;
            f.Show();
        }

        private void syllabusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants(); // Ferme la fenêtre précédente
            frmSyllabus f = new frmSyllabus();
            f.MdiParent = this;
            f.Show();
        }

        private void detailsSyllabusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants(); // Ferme la fenêtre précédente
            FrmDetailsSyllabus f = new FrmDetailsSyllabus();
            f.MdiParent = this;
            f.Show();
        }

        private void responsableDeClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants(); // Ferme la fenêtre précédente
            FrmResponsableClasse f = new FrmResponsableClasse();
            f.MdiParent = this;
            f.Show();
        }
    }
}