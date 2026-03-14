using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AppCahierText.Model;

namespace AppCahierText.Views.Parametre
{
    public partial class FrmResponsableClasse : Form
    {
        BdCahierTexteContext db = new BdCahierTexteContext();
        int? idSelectionne = null;

        public FrmResponsableClasse()
        {
            InitializeComponent();
        }

        private void FrmResponsableClasse_Load(object sender, EventArgs e)
        {
            ActualiserGrille();
            ChargerComboClasse();
        }

        private void ChargerComboClasse()
        {
            cbbClasse.DataSource = db.Classes.ToList();
            cbbClasse.DisplayMember = "LibelleClasse";
            cbbClasse.ValueMember = "IdClasse";
            cbbClasse.SelectedIndex = -1;
        }

        private void ActualiserGrille()
        {
            dgResponsableClasse.DataSource = db.ResponsablesClasses.Select(r => new
            {
                r.IdResponsable,
                Nom = r.NomUtilisateur, // Mapping vers NomUtilisateur
                Prenom = r.PrenomUtilisateur, // Mapping vers PrenomUtilisateur
                Email = r.EmailUtilisateur, // Mapping vers EmailUtilisateur
                Telephone = r.TelephoneUtilisateur, // Mapping vers TelephoneUtilisateur
                Classe = r.Classe.LibelleClasse
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || cbbClasse.SelectedValue == null)
            {
                MessageBox.Show("Veuillez remplir les informations obligatoires (Nom et Classe).");
                return;
            }

            ResponsableClasse resp = new ResponsableClasse
            {
                NomUtilisateur = txtNom.Text, // Correction du nom
                PrenomUtilisateur = txtPrenom.Text, // Correction du nom
                EmailUtilisateur = txtEmail.Text, // Correction du nom
                TelephoneUtilisateur = txtTelephone.Text, // Correction du nom
                IdClasse = (int)cbbClasse.SelectedValue,
                MatriculeResponsable = "RESP-" + DateTime.Now.Ticks.ToString().Substring(0, 5),
                // Propriétés obligatoires héritées de Utilisateur
                Profil = "Responsable",
                IdentifiantUtilisateur = txtEmail.Text,
                MotDePasse = "123" // À changer plus tard
            };

            db.ResponsablesClasses.Add(resp);
            db.SaveChanges();
            ActualiserGrille();
            Vider();
        }

        private void dgResponsableClasse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSelectionne = (int)dgResponsableClasse.Rows[e.RowIndex].Cells[0].Value;
                var resp = db.ResponsablesClasses.Find(idSelectionne);
                if (resp != null)
                {
                    txtNom.Text = resp.NomUtilisateur;
                    txtPrenom.Text = resp.PrenomUtilisateur;
                    txtEmail.Text = resp.EmailUtilisateur;
                    txtTelephone.Text = resp.TelephoneUtilisateur;
                    cbbClasse.SelectedValue = resp.IdClasse;
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (idSelectionne == null)
            {
                MessageBox.Show("Veuillez sélectionner un responsable.");
                return;
            }

            var resp = db.ResponsablesClasses.Find(idSelectionne);
            if (resp != null)
            {
                resp.NomUtilisateur = txtNom.Text;
                resp.PrenomUtilisateur = txtPrenom.Text;
                resp.EmailUtilisateur = txtEmail.Text;
                resp.TelephoneUtilisateur = txtTelephone.Text;
                resp.IdClasse = (int)cbbClasse.SelectedValue;

                db.SaveChanges();
                ActualiserGrille();
                Vider();
                MessageBox.Show("Modification effectuée avec succès !");
            }
        }

        private void Vider()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtEmail.Clear();
            txtTelephone.Clear();
            cbbClasse.SelectedIndex = -1;
            idSelectionne = null;
        }
    }
}