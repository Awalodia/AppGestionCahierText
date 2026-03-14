using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AppCahierText.Model;

namespace AppCahierText.Views.Parametre
{
    public partial class frmClasse : Form
    {
        BdCahierTexteContext db = new BdCahierTexteContext();
        int? idSelectionne = null;

        public frmClasse()
        {
            InitializeComponent();
        }

        private void frmClasse_Load(object sender, EventArgs e)
        {
            ActualiserGrille();
            ChargerComboAnnee();
        }

        private void ChargerComboAnnee()
        {
            // Utilisation exacte des noms de votre modèle AnneeAcademique
            cbbAnneeAcademique.DataSource = db.AnneesAcademiques.ToList();
            cbbAnneeAcademique.DisplayMember = "LibelleAnneeAcademique";
            cbbAnneeAcademique.ValueMember = "IdAnneeAcademique";
            cbbAnneeAcademique.SelectedIndex = -1;
        }

        private void ActualiserGrille()
        {
            dgClasse.DataSource = db.Classes.Select(c => new
            {
                c.IdClasse,
                c.LibelleClasse,
                // Accès à la propriété via la relation de navigation
                Annee = c.AnneeAcademique.LibelleAnneeAcademique
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtlibelle.Text) || cbbAnneeAcademique.SelectedValue == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            Classe cl = new Classe
            {
                LibelleClasse = txtlibelle.Text,
                IdAnneeAcademique = (int)cbbAnneeAcademique.SelectedValue
            };

            db.Classes.Add(cl);
            db.SaveChanges();
            ActualiserGrille();
            Vider();
        }

        private void dgClasse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSelectionne = (int)dgClasse.Rows[e.RowIndex].Cells[0].Value;
                var cl = db.Classes.Find(idSelectionne);
                if (cl != null)
                {
                    txtlibelle.Text = cl.LibelleClasse;
                    cbbAnneeAcademique.SelectedValue = cl.IdAnneeAcademique;
                }
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (idSelectionne == null)
            {
                MessageBox.Show("Veuillez sélectionner une classe dans la grille.");
                return;
            }

            var cl = db.Classes.Find(idSelectionne);
            if (cl != null)
            {
                cl.LibelleClasse = txtlibelle.Text;
                cl.IdAnneeAcademique = (int)cbbAnneeAcademique.SelectedValue;

                db.SaveChanges();
                ActualiserGrille();
                Vider();
                MessageBox.Show("Classe modifiée avec succès !");
            }
        }

        private void Vider()
        {
            txtlibelle.Clear();
            cbbAnneeAcademique.SelectedIndex = -1;
            idSelectionne = null;
        }
    }
}