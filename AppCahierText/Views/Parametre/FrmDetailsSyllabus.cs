using AppCahierText.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace AppCahierText.Views.Parametre
{
    public partial class FrmDetailsSyllabus : Form
    {
        private BdCahierTexteContext db = new BdCahierTexteContext();

        public FrmDetailsSyllabus()
        {
            InitializeComponent();
        }

        private void FrmDetailsSyllabus_Load(object sender, EventArgs e)
        {
            ChargerSyllabus();
            ChargerDonnees();
        }

        private void ChargerSyllabus()
        {
            try
            {
                var liste = db.Syllabus
                    .Select(s => new { s.SyllabusId, s.LibelleSyllabus })
                    .OrderBy(s => s.LibelleSyllabus)
                    .ToList();

                cbbSyllabus.DataSource = liste;
                cbbSyllabus.DisplayMember = "LibelleSyllabus";
                cbbSyllabus.ValueMember = "SyllabusId";
                cbbSyllabus.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Erreur chargement Syllabus : " + ex.Message); }
        }

        private void ChargerDonnees()
        {
            // On recrée le contexte pour s'assurer d'avoir les données fraîches
            db = new BdCahierTexteContext();
            dgDetailsSyllabus.DataSource = db.DetailsSyllabus
                .Include(d => d.Syllabus)
                .Select(d => new
                {
                    d.IdDetailsSyllabus,
                    Syllabus = d.Syllabus.LibelleSyllabus,
                    Seance = d.SeanceSyllabus,
                    Contenu = d.ContenuSyllabus,
                    d.SyllabusId
                }).ToList();

            if (dgDetailsSyllabus.Columns.Contains("IdDetailsSyllabus"))
                dgDetailsSyllabus.Columns["IdDetailsSyllabus"].Visible = false;

            if (dgDetailsSyllabus.Columns.Contains("SyllabusId"))
                dgDetailsSyllabus.Columns["SyllabusId"].Visible = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            try
            {
                var detail = new DetailsSyllabus
                {
                    SeanceSyllabus = txtSeance.Text.Trim(),
                    ContenuSyllabus = txtContenu.Text.Trim(),
                    SyllabusId = (int)cbbSyllabus.SelectedValue
                };

                db.DetailsSyllabus.Add(detail);
                db.SaveChanges();
                MessageBox.Show("Séance ajoutée au programme avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Effacer();
            }
            catch (Exception ex) { MessageBox.Show("Erreur lors de l'ajout : " + ex.Message); }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgDetailsSyllabus.CurrentRow == null) return;
            if (!ValiderChamps()) return;

            try
            {
                int id = (int)dgDetailsSyllabus.CurrentRow.Cells["IdDetailsSyllabus"].Value;
                var detail = db.DetailsSyllabus.Find(id);

                if (detail != null)
                {
                    detail.SeanceSyllabus = txtSeance.Text.Trim();
                    detail.ContenuSyllabus = txtContenu.Text.Trim();
                    detail.SyllabusId = (int)cbbSyllabus.SelectedValue;

                    db.SaveChanges();
                    MessageBox.Show("Détail mis à jour !");
                    Effacer();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgDetailsSyllabus.CurrentRow == null) return;

            if (MessageBox.Show("Supprimer cette séance du programme ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = (int)dgDetailsSyllabus.CurrentRow.Cells["IdDetailsSyllabus"].Value;
                    var detail = db.DetailsSyllabus.Find(id);
                    if (detail != null)
                    {
                        db.DetailsSyllabus.Remove(detail);
                        db.SaveChanges();
                        Effacer();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e) => Effacer();

        private void dgDetailsSyllabus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgDetailsSyllabus.Rows[e.RowIndex];
                txtSeance.Text = row.Cells["Seance"].Value?.ToString();
                txtContenu.Text = row.Cells["Contenu"].Value?.ToString();
                cbbSyllabus.SelectedValue = row.Cells["SyllabusId"].Value;
            }
        }

        private void Effacer()
        {
            txtSeance.Clear();
            txtContenu.Clear();
            cbbSyllabus.SelectedIndex = -1;
            ChargerDonnees();
            txtSeance.Focus();
        }

        private bool ValiderChamps()
        {
            if (cbbSyllabus.SelectedValue == null || string.IsNullOrWhiteSpace(txtSeance.Text))
            {
                MessageBox.Show("Le Syllabus et le numéro/titre de séance sont obligatoires !");
                return false;
            }
            return true;
        }
    }
}