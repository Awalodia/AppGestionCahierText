using AppCahierText.Model;
using AppCahierText.Shared;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppCahierText.Views.Parametre
{
    public partial class FrmResponsableClasse : Form
    {
        BdCahierTexteContext db = new BdCahierTexteContext();

        public FrmResponsableClasse()
        {
            InitializeComponent();
        }

        private void FrmResponsableClasse_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        // ─── Ajouter un responsable ─────────────────────────────────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            try
            {
                // CORRECTION : Appel simplifié à Crypto
                string passHache = Crypto.GetMd5Hash("passer123");

                ResponsableClasse responsableClasse = new ResponsableClasse
                {
                    NomUtilisateur = txtNom.Text.Trim(),
                    PrenomUtilisateur = txtPrenom.Text.Trim(),
                    AdresseUtilisateur = txtAdresse.Text.Trim(),
                    EmailUtilisateur = txtEmail.Text.Trim(),
                    TelephoneUtilisateur = txtTelephone.Text.Trim(),
                    IdentifiantUtilisateur = txtIdentifiant.Text.Trim(),
                    MotDePasse = passHache,
                    MatriculeResponsable = txtMatricule.Text.Trim()
                };

                db.ResponsablesClasses.Add(responsableClasse);
                db.SaveChanges();

                MessageBox.Show("Responsable ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Effacer();
            }
            catch (Exception ex)
            {
                Logger.Erreur("Erreur lors de l'ajout du responsable", ex);
                MessageBox.Show("Une erreur est survenue lors de l'enregistrement. Consultez les logs.");
            }
        }

        // ─── Modifier un responsable ────────────────────────────────────────────
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgResponsableClasse.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un responsable.");
                return;
            }

            try
            {
                // On récupère l'ID à partir de la ligne sélectionnée (nom de colonne IdUtilisateur selon ton modèle)
                int id = Convert.ToInt32(dgResponsableClasse.CurrentRow.Cells["IdUtilisateur"].Value);
                var responsable = db.ResponsablesClasses.Find(id);

                if (responsable != null)
                {
                    responsable.NomUtilisateur = txtNom.Text.Trim();
                    responsable.PrenomUtilisateur = txtPrenom.Text.Trim();
                    responsable.AdresseUtilisateur = txtAdresse.Text.Trim();
                    responsable.EmailUtilisateur = txtEmail.Text.Trim();
                    responsable.TelephoneUtilisateur = txtTelephone.Text.Trim();
                    responsable.IdentifiantUtilisateur = txtIdentifiant.Text.Trim();
                    responsable.MatriculeResponsable = txtMatricule.Text.Trim();

                    db.SaveChanges();
                    MessageBox.Show("Modification effectuée !");
                    Effacer();
                }
            }
            catch (Exception ex)
            {
                Logger.Erreur("Erreur modification responsable", ex);
                MessageBox.Show("Erreur lors de la modification.");
            }
        }

        // ─── Supprimer un responsable ───────────────────────────────────────────
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgResponsableClasse.CurrentRow == null) return;

            var confirm = MessageBox.Show("Confirmer la suppression ?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dgResponsableClasse.CurrentRow.Cells["IdUtilisateur"].Value);
                var responsable = db.ResponsablesClasses.Find(id);

                if (responsable != null)
                {
                    db.ResponsablesClasses.Remove(responsable);
                    db.SaveChanges();
                    Effacer();
                }
            }
            catch (Exception ex)
            {
                Logger.Erreur("Erreur suppression responsable", ex);
            }
        }

        // ─── Sélection dans le DataGridView ────────────────────────────────────
        private void dgResponsableClasse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgResponsableClasse.Rows[e.RowIndex].Cells["IdUtilisateur"].Value);
            var res = db.ResponsablesClasses.Find(id);

            if (res != null)
            {
                txtNom.Text = res.NomUtilisateur;
                txtPrenom.Text = res.PrenomUtilisateur;
                txtAdresse.Text = res.AdresseUtilisateur;
                txtEmail.Text = res.EmailUtilisateur;
                txtTelephone.Text = res.TelephoneUtilisateur;
                txtIdentifiant.Text = res.IdentifiantUtilisateur;
                txtMatricule.Text = res.MatriculeResponsable;
            }
        }

        // ─── Helpers ────────────────────────────────────────────────────────────
        private void Effacer()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtAdresse.Clear();
            txtEmail.Clear();
            txtTelephone.Clear();
            txtIdentifiant.Clear();
            txtMatricule.Clear();
            ChargerDonnees();
            txtNom.Focus();
        }

        private void ChargerDonnees()
        {
            // On sélectionne les colonnes utiles pour éviter d'afficher le mot de passe haché
            dgResponsableClasse.DataSource = db.ResponsablesClasses
                .Select(r => new {
                    r.IdUtilisateur,
                    r.MatriculeResponsable,
                    r.NomUtilisateur,
                    r.PrenomUtilisateur,
                    r.IdentifiantUtilisateur,
                    r.EmailUtilisateur
                }).ToList();
        }

        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtIdentifiant.Text) ||
                string.IsNullOrWhiteSpace(txtMatricule.Text))
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires (Nom, Prénom, Identifiant, Matricule).");
                return false;
            }
            return true;
        }
    }
}