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
                securiteToolStripMenuItem.Visible = false;
            }
        }

        private void FermerEnfants()
        {
            foreach (Form enfant in this.MdiChildren)
            {
                enfant.Close();
            }
        }

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConnexion f = new frmConnexion();
            f.ShowDialog();
            this.Close();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void matiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants();
            frmMatiere f = new frmMatiere();
            f.MdiParent = this;
            f.Show();
        }

        private void anneeAcademiqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants();
            frmAnneeAcademique f = new frmAnneeAcademique();
            f.MdiParent = this;
            f.Show();
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants();
            frmClasse f = new frmClasse();
            f.MdiParent = this;
            f.Show();
        }
        private void cahierTexteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants();
            frmCahierTexte f = new frmCahierTexte();
            f.MdiParent = this;
            f.Show();
        }

        private void detailsCahierTexteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants();
            FrmDetailCahier f = new FrmDetailCahier();
            f.MdiParent = this;
            f.Show();
        }

        private void syllabusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants();
            frmSyllabus f = new frmSyllabus();
            f.MdiParent = this;
            f.Show();
        }

        private void detailsSyllabusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants();
            FrmDetailsSyllabus f = new FrmDetailsSyllabus();
            f.MdiParent = this;
            f.Show();
        }

     
        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants();
            frmUtilisateurs f = new frmUtilisateurs();
            f.MdiParent = this;
            f.Show();
        }

        private void responsableDeClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FermerEnfants();
            FrmResponsableClasse f = new FrmResponsableClasse();
            f.MdiParent = this;
            f.Show();
        }
    }
}