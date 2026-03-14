using AppCahierText.Model;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace AppCahierText.Views.Parametre
{
    public partial class frmMatiere : Form
    {
        private BdCahierTexteContext db = new BdCahierTexteContext();

        public frmMatiere()
        {
            InitializeComponent();
        }

        // ─── Chargement ──────────────────────────────────────────────────────
        private void frmMatiere_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        // ─── Ajouter ─────────────────────────────────────────────────────────
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            try
            {
                using (var ctx = new BdCahierTexteContext())
                {
                    var m = new Matiere
                    {
                        LibelleMatiere = txtLibelle.Text.Trim(),
                        VolumeHoraireMatiere = int.Parse(txtVolume.Text.Trim()),
                        Niveau = txtNiveau.Text.Trim()
                    };
                    ctx.Matieres.Add(m);
                    ctx.SaveChanges();
                }

                MessageBox.Show("Matière ajoutée avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Effacer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Erreur lors de l'ajout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Modifier ─────────────────────────────────────────────────────────
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedMatiereId(out var id))
            {
                MessageBox.Show("Veuillez sélectionner une matière à modifier.",
                    "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValiderChamps()) return;

            try
            {
                using (var ctx = new BdCahierTexteContext())
                {
                    var m = ctx.Matieres.Find(id);
                    if (m == null)
                    {
                        MessageBox.Show("Matière introuvable.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    m.LibelleMatiere = txtLibelle.Text.Trim();
                    m.VolumeHoraireMatiere = int.Parse(txtVolume.Text.Trim());
                    m.Niveau = txtNiveau.Text.Trim();
                    ctx.SaveChanges();
                }

                MessageBox.Show("Matière modifiée avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Effacer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Erreur lors de la modification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Supprimer ────────────────────────────────────────────────────────
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedMatiereId(out var id))
            {
                MessageBox.Show("Veuillez sélectionner une matière à supprimer.",
                    "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Confirmer la suppression ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var ctx = new BdCahierTexteContext())
                {
                    var m = new Matiere { IdMatiere = id };
                    ctx.Entry(m).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }

                MessageBox.Show("Matière supprimée avec succès !", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Effacer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Erreur lors de la suppression",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Imprimer ─────────────────────────────────────────────────────────
        private void btnImprimer_Click(object sender, EventArgs e)
        {
            PrintMatiere print = new PrintMatiere();
            print.MdiParent = this.MdiParent;
            print.Show();
            print.WindowState = FormWindowState.Maximized;
        }

        // ─── Sélection DataGridView ───────────────────────────────────────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtLibelle.Text = row.Cells["LibelleMatiere"].Value?.ToString();
            txtVolume.Text = row.Cells["VolumeHoraireMatiere"].Value?.ToString();
            txtNiveau.Text = row.Cells["Niveau"].Value?.ToString();
        }

        // ─── Helpers ──────────────────────────────────────────────────────────
        private void ChargerDonnees()
        {
            dataGridView1.DataSource = db.Matieres.AsNoTracking()
                .Select(m => new
                {
                    m.IdMatiere,
                    m.LibelleMatiere,
                    m.VolumeHoraireMatiere,
                    m.Niveau
                }).ToList();

            if (dataGridView1.Columns.Contains("IdMatiere"))
                dataGridView1.Columns["IdMatiere"].Visible = false;
        }

        private void Effacer()
        {
            txtLibelle.Clear();
            txtVolume.Clear();
            txtNiveau.Clear();
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

            if (!int.TryParse(txtVolume.Text.Trim(), out _))
            {
                MessageBox.Show("Le volume horaire doit être un nombre entier.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVolume.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNiveau.Text))
            {
                MessageBox.Show("Le niveau est obligatoire.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNiveau.Focus();
                return false;
            }

            return true;
        }

        private bool TryGetSelectedMatiereId(out int id)
        {
            id = 0;
            if (dataGridView1.CurrentRow == null) return false;
            return int.TryParse(
                Convert.ToString(dataGridView1.CurrentRow.Cells["IdMatiere"].Value), out id);
        }

        // ─── Handlers conservés pour le designer ─────────────────────────────
        private void label1_Click(object sender, EventArgs e) { }
        private void btnConnexion_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}