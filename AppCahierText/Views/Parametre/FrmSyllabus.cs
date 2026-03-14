using AppCahierText.Model;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace AppCahierText.Views.Parametre
{
    public partial class frmSyllabus : Form
    {
        private BdCahierTexteContext db = new BdCahierTexteContext();

        public frmSyllabus()
        {
            InitializeComponent();
        }

        private void frmSyllabus_Load(object sender, EventArgs e)
        {
            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            db = new BdCahierTexteContext(); // Rafraîchir le contexte
            dgvSyllabus.DataSource = db.Syllabus.AsNoTracking()
                .Select(s => new {
                    s.SyllabusId,
                    s.LibelleSyllabus,
                    s.VolumeHoraireSyllabus,
                    s.NiveauSyllabus,
                    s.DescriptionSyllabus
                }).ToList();

            if (dgvSyllabus.Columns.Contains("SyllabusId"))
                dgvSyllabus.Columns["SyllabusId"].Visible = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            try
            {
                using (var ctx = new BdCahierTexteContext())
                {
                    var s = new Syllabus
                    {
                        LibelleSyllabus = txtLibelle.Text.Trim(),
                        DescriptionSyllabus = txtDescription.Text.Trim(),
                        VolumeHoraireSyllabus = string.IsNullOrEmpty(txtVolume.Text) ? (int?)null : int.Parse(txtVolume.Text),
                        NiveauSyllabus = txtNiveau.Text.Trim()
                    };

                    ctx.Syllabus.Add(s);
                    ctx.SaveChanges();
                }
                MessageBox.Show("Syllabus ajouté avec succès !");
                Effacer();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.GetBaseException().Message);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvSyllabus.CurrentRow == null) return;
            int id = (int)dgvSyllabus.CurrentRow.Cells["SyllabusId"].Value;

            if (!ValiderChamps()) return;

            try
            {
                using (var ctx = new BdCahierTexteContext())
                {
                    var s = ctx.Syllabus.Find(id);
                    if (s != null)
                    {
                        s.LibelleSyllabus = txtLibelle.Text.Trim();
                        s.DescriptionSyllabus = txtDescription.Text.Trim();
                        s.VolumeHoraireSyllabus = int.Parse(txtVolume.Text);
                        s.NiveauSyllabus = txtNiveau.Text.Trim();
                        ctx.SaveChanges();
                    }
                }
                MessageBox.Show("Syllabus mis à jour !");
                Effacer();
            }
            catch (Exception ex) { MessageBox.Show(ex.GetBaseException().Message); }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvSyllabus.CurrentRow == null) return;
            int id = (int)dgvSyllabus.CurrentRow.Cells["SyllabusId"].Value;

            if (MessageBox.Show("Supprimer ce syllabus ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var ctx = new BdCahierTexteContext())
                    {
                        var s = ctx.Syllabus.Find(id);
                        if (s != null)
                        {
                            ctx.Syllabus.Remove(s);
                            ctx.SaveChanges();
                        }
                    }
                    Effacer();
                }
                catch (Exception ex) { MessageBox.Show(ex.GetBaseException().Message); }
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Effacer();
        }

        private void dgvSyllabus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSyllabus.Rows[e.RowIndex];
                txtLibelle.Text = row.Cells["LibelleSyllabus"].Value?.ToString();
                txtDescription.Text = row.Cells["DescriptionSyllabus"].Value?.ToString();
                txtVolume.Text = row.Cells["VolumeHoraireSyllabus"].Value?.ToString();
                txtNiveau.Text = row.Cells["NiveauSyllabus"].Value?.ToString();
            }
        }

        private void Effacer()
        {
            txtLibelle.Clear();
            txtDescription.Clear();
            txtVolume.Clear();
            txtNiveau.Clear();
            ChargerDonnees();
            txtLibelle.Focus();
        }

        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(txtLibelle.Text) || string.IsNullOrWhiteSpace(txtNiveau.Text))
            {
                MessageBox.Show("Le libellé et le niveau sont obligatoires !");
                return false;
            }
            return true;
        }
    }
}