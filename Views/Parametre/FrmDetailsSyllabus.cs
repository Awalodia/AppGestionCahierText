using AppCahierText.Model;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppCahierText.Views.Parametre
{
    public partial class FrmDetailsSyllabus : Form
    {
        BdCahierTexteContext db = new BdCahierTexteContext();

        public FrmDetailsSyllabus()
        {
            InitializeComponent();
        }

        // ─── Chargement ──────────────────────────────────────────────────────
        private void FrmDetailsSyllabus_Load(object sender, EventArgs e)
        {
            ChargerSyllabus();
            ChargerDonnees();
        }

        // ─── Ajouter ─────────────────────────────────────────────────────────
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            try
            {
                DetailsSyllabus detail = new DetailsSyllabus
                {
                    SeanceSyllabus = txtSeance.Text.Trim(),
                    ContenuSyllabus = txtContenu.Text.Trim(),
                    SyllabusId = (int?)cbbSyllabus.SelectedValue
                };

                db.DetailsSyllabus.Add(detail);
                db.SaveChanges();

                MessageBox.Show("Détail ajouté avec succès !", "Succès",
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
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Modifier ─────────────────────────────────────────────────────────
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgDetailsSyllabus.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un détail à modifier.",
                    "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValiderChamps()) return;

            try
            {
                int id = Convert.ToInt32(dgDetailsSyllabus.SelectedRows[0].Cells["IdDetailsSyllabus"].Value);
                var detail = db.DetailsSyllabus.Find(id);

                if (detail == null)
                {
                    MessageBox.Show("Détail introuvable.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                detail.SeanceSyllabus = txtSeance.Text.Trim();
                detail.ContenuSyllabus = txtContenu.Text.Trim();
                detail.SyllabusId = (int?)cbbSyllabus.SelectedValue;

                db.SaveChanges();

                MessageBox.Show("Détail modifié avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Effacer();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Supprimer ────────────────────────────────────────────────────────
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgDetailsSyllabus.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un détail à supprimer.",
                    "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Confirmer la suppression ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int id = Convert.ToInt32(dgDetailsSyllabus.SelectedRows[0].Cells["IdDetailsSyllabus"].Value);
                var detail = db.DetailsSyllabus.Find(id);

                if (detail != null)
                {
                    db.DetailsSyllabus.Remove(detail);
                    db.SaveChanges();

                    MessageBox.Show("Détail supprimé avec succès !", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Effacer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Effacer ──────────────────────────────────────────────────────────
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Effacer();
        }

        // ─── Sélection DataGridView ───────────────────────────────────────────
        private void dgDetailsSyllabus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgDetailsSyllabus.Rows[e.RowIndex];
            txtSeance.Text = row.Cells["SeanceSyllabus"].Value?.ToString();
            txtContenu.Text = row.Cells["ContenuSyllabus"].Value?.ToString();

            if (row.Cells["SyllabusId"].Value != null)
                cbbSyllabus.SelectedValue = row.Cells["SyllabusId"].Value;
        }

        // ─── Helpers ──────────────────────────────────────────────────────────
        private void ChargerSyllabus()
        {
            var liste = db.Syllabus
                .Select(s => new { s.SyllabusId, s.LibelleSyllabus })
                .ToList();

            cbbSyllabus.DataSource = liste;
            cbbSyllabus.DisplayMember = "LibelleSyllabus";
            cbbSyllabus.ValueMember = "SyllabusId";
        }

        private void ChargerDonnees()
        {
            dgDetailsSyllabus.DataSource = db.DetailsSyllabus
                .Select(d => new
                {
                    d.IdDetailsSyllabus,
                    d.SeanceSyllabus,
                    d.ContenuSyllabus,
                    d.SyllabusId
                }).ToList();

            if (dgDetailsSyllabus.Columns.Contains("IdDetailsSyllabus"))
                dgDetailsSyllabus.Columns["IdDetailsSyllabus"].Visible = false;
        }

        private void Effacer()
        {
            txtSeance.Clear();
            txtContenu.Clear();
            ChargerSyllabus();
            ChargerDonnees();
            txtSeance.Focus();
        }

        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(txtSeance.Text))
            {
                MessageBox.Show("La séance est obligatoire.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSeance.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContenu.Text))
            {
                MessageBox.Show("Le contenu est obligatoire.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContenu.Focus();
                return false;
            }

            if (cbbSyllabus.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un syllabus.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbSyllabus.Focus();
                return false;
            }

            return true;
        }
    }
}