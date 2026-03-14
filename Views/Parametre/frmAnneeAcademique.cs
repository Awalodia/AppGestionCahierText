using AppCahierText.Model;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppCahierText.Views.Parametre
{
    public partial class frmAnneeAcademique : Form
    {
        BdCahierTexteContext db = new BdCahierTexteContext();

        public frmAnneeAcademique()
        {
            InitializeComponent();
        }

        // ─── Chargement ─────────────────────────────────────────────────────────
        private void frmAnneeAcademique_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        // ─── Ajouter ────────────────────────────────────────────────────────────
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            try
            {
                AnneeAcademique annee = new AnneeAcademique
                {
                    LibelleAnneeAcademique = txtLibelle.Text.Trim(),
                    ValueAnneAcademique = int.Parse(txtValeur.Text.Trim())
                };

                db.AnneesAcademiques.Add(annee);
                db.SaveChanges();

                MessageBox.Show("Année académique ajoutée avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Effacer();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                StringBuilder erreurs = new StringBuilder();
                foreach (var entityError in ex.EntityValidationErrors)
                    foreach (var validationError in entityError.ValidationErrors)
                    {
                        erreurs.AppendLine($"Champ : {validationError.PropertyName}");
                        erreurs.AppendLine($"Erreur : {validationError.ErrorMessage}");
                        erreurs.AppendLine("---");
                    }
                MessageBox.Show(erreurs.ToString(), "Erreur de validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur inattendue : {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Modifier ────────────────────────────────────────────────────────────
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une année académique à modifier.",
                    "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValiderChamps()) return;

            try
            {
                int id = Convert.ToInt32(dgAnneeAcademique.SelectedRows[0].Cells["IdAnneeAcademique"].Value);
                var annee = db.AnneesAcademiques.Find(id);

                if (annee == null)
                {
                    MessageBox.Show("Année académique introuvable.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                annee.LibelleAnneeAcademique = txtLibelle.Text.Trim();
                annee.ValueAnneAcademique = int.Parse(txtValeur.Text.Trim());

                db.SaveChanges();

                MessageBox.Show("Année académique modifiée avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Effacer();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Supprimer ───────────────────────────────────────────────────────────
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une année académique à supprimer.",
                    "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Confirmer la suppression ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dgAnneeAcademique.SelectedRows[0].Cells["IdAnneeAcademique"].Value);
                var annee = db.AnneesAcademiques.Find(id);

                if (annee != null)
                {
                    db.AnneesAcademiques.Remove(annee);
                    db.SaveChanges();

                    MessageBox.Show("Année académique supprimée avec succès !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Effacer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression : {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Effacer ─────────────────────────────────────────────────────────────
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Effacer();
        }

        // ─── Sélection dans le DataGridView ──────────────────────────────────────
        private void dgAnneeAcademique_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgAnneeAcademique.Rows[e.RowIndex];
            txtLibelle.Text = row.Cells["LibelleAnneeAcademique"].Value?.ToString();
            txtValeur.Text = row.Cells["ValueAnneAcademique"].Value?.ToString();
        }

        // ─── Helpers ─────────────────────────────────────────────────────────────
        private void ChargerDonnees()
        {
            dgAnneeAcademique.DataSource = db.AnneesAcademiques.ToList();
        }

        private void Effacer()
        {
            txtLibelle.Clear();
            txtValeur.Text = DateTime.Now.Year.ToString();  // valeur par défaut
            ChargerDonnees();
            txtLibelle.Focus();
        }

        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(txtLibelle.Text))
            {
                MessageBox.Show("Le libellé est obligatoire.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLibelle.Focus();
                return false;
            }

            if (!int.TryParse(txtValeur.Text.Trim(), out int valeur) || valeur < 2000 || valeur > 2100)
            {
                MessageBox.Show("La valeur de l'année doit être un nombre valide (ex: 2024).",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValeur.Focus();
                return false;
            }

            return true;
        }
    }
}