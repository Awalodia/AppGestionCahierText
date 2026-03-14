using AppCahierText.Model;
using AppCahierText.Report;
using System;
using System.Collections.Generic;
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

        private void frmMatiere_Load(object sender, EventArgs e)
        {
            ChargerCombos();
            ChargerDonnees();
        }

        private void ChargerCombos()
        {
            try
            {
                var liste = db.Syllabus
                    .Select(s => new { s.SyllabusId, s.LibelleSyllabus })
                    .ToList();

                cbbSyllabus.DataSource = liste;
                cbbSyllabus.DisplayMember = "LibelleSyllabus";
                cbbSyllabus.ValueMember = "SyllabusId";
                cbbSyllabus.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Erreur chargement syllabus : " + ex.Message); }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) { MessageBox.Show("Veuillez remplir correctement les champs."); return; }
            try
            {
                using (var ctx = new BdCahierTexteContext())
                {
                    var m = new Matiere
                    {
                        LibelleMatiere = txtLibelle.Text.Trim(),
                        VolumeHoraireMatiere = int.Parse(txtVolume.Text.Trim()),
                        Niveau = txtNiveau.Text.Trim(),
                        SyllabusId = (int?)cbbSyllabus.SelectedValue
                    };
                    ctx.Matieres.Add(m);
                    ctx.SaveChanges();
                }
                MessageBox.Show("Matière ajoutée avec succès !");
                Effacer();
            }
            catch (Exception ex) { MessageBox.Show("Erreur ajout : " + ex.GetBaseException().Message); }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedMatiereId(out int id)) return;
            if (!ValiderChamps()) return;
            try
            {
                using (var ctx = new BdCahierTexteContext())
                {
                    var m = ctx.Matieres.Find(id);
                    if (m != null)
                    {
                        m.LibelleMatiere = txtLibelle.Text.Trim();
                        m.VolumeHoraireMatiere = int.Parse(txtVolume.Text.Trim());
                        m.Niveau = txtNiveau.Text.Trim();
                        m.SyllabusId = (int?)cbbSyllabus.SelectedValue;
                        ctx.SaveChanges();
                    }
                }
                MessageBox.Show("Matière modifiée !");
                Effacer();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedMatiereId(out int id)) return;
            if (MessageBox.Show("Supprimer cette matière ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                using (var ctx = new BdCahierTexteContext())
                {
                    var m = ctx.Matieres.Find(id);
                    if (m != null)
                    {
                        ctx.Matieres.Remove(m);
                        ctx.SaveChanges();
                    }
                }
                Effacer();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEffacer_Click_1(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new BdCahierTexteContext())
                {
                    var matieres = ctx.Matieres.Include(m => m.Syllabus).ToList();
                    var donneesPourRapport = matieres
                        .Select(m => new MatiereRptView
                        {
                            Code = m.IdMatiere.ToString(),
                            Libelle = m.LibelleMatiere,
                            Departement = m.Syllabus != null ? m.Syllabus.LibelleSyllabus : "Non défini"
                        }).ToList();

                    if (!donneesPourRapport.Any()) return;
                    rpListeMatiere frm = new rpListeMatiere(donneesPourRapport);
                    frm.ShowDialog();
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur impression : " + ex.Message); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtLibelle.Text = row.Cells["LibelleMatiere"].Value?.ToString();
            txtVolume.Text = row.Cells["VolumeHoraireMatiere"].Value?.ToString();
            txtNiveau.Text = row.Cells["Niveau"].Value?.ToString();
            cbbSyllabus.SelectedValue = row.Cells["SyllabusId"].Value;
        }

        private void ChargerDonnees()
        {
            db = new BdCahierTexteContext();
            dataGridView1.DataSource = db.Matieres
                .Select(m => new
                {
                    m.IdMatiere,
                    m.LibelleMatiere,
                    m.VolumeHoraireMatiere,
                    m.Niveau,
                    Syllabus = m.Syllabus != null ? m.Syllabus.LibelleSyllabus : "Aucun",
                    m.SyllabusId
                }).ToList();

            if (dataGridView1.Columns.Contains("IdMatiere")) dataGridView1.Columns["IdMatiere"].Visible = false;
            if (dataGridView1.Columns.Contains("SyllabusId")) dataGridView1.Columns["SyllabusId"].Visible = false;
        }

        private void Effacer()
        {
            txtLibelle.Clear();
            txtVolume.Clear();
            txtNiveau.Clear();
            cbbSyllabus.SelectedIndex = -1;
            ChargerDonnees();
            txtLibelle.Focus();
        }

        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(txtLibelle.Text)) return false;
            return int.TryParse(txtVolume.Text.Trim(), out _);
        }

        private bool TryGetSelectedMatiereId(out int id)
        {
            id = 0;
            if (dataGridView1.CurrentRow == null) return false;
            return int.TryParse(Convert.ToString(dataGridView1.CurrentRow.Cells["IdMatiere"].Value), out id);
        }
    }
}