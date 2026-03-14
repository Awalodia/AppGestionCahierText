using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using AppCahierText.Model;

namespace AppCahierText.Views.Parametre
{
    public partial class frmCahierTexte : Form
    {
        private BdCahierTexteContext db = new BdCahierTexteContext();
        private int? _idSelectionne = null;

        public frmCahierTexte()
        {
            InitializeComponent();
        }

        private void frmCahierTexte_Load(object sender, EventArgs e)
        {
            ChargerResponsables();
            ActualiserGrille();
            btnSupprimer.Enabled = false;
        }

        private void ActualiserGrille()
        {
            try
            {
                db = new BdCahierTexteContext();
                var liste = db.CahierTextes
                    .Include(c => c.ResponsableClasse)
                    .Select(c => new
                    {
                        Id = c.IdCahierTexte,
                        Titre = c.TitreCahierTexte,
                        Description = c.DescriptionCahierTexte, 
                        Date = c.DateCahierTexte,
                        Responsable = c.ResponsableClasse != null
                            ? c.ResponsableClasse.NomUtilisateur + " " + c.ResponsableClasse.PrenomUtilisateur
                            : "Aucun"
                    }).ToList();

                dgvListeCahiers.DataSource = liste;
                if (dgvListeCahiers.Columns["Id"] != null) dgvListeCahiers.Columns["Id"].Visible = false;
            }
            catch (Exception ex) { MessageBox.Show("Erreur grille : " + ex.Message); }
        }

        private void ChargerResponsables()
        {
            try
            {
                var responsables = db.ResponsablesClasses
                    .Select(r => new { r.IdUtilisateur, NomComplet = r.NomUtilisateur + " " + r.PrenomUtilisateur })
                    .ToList();
                cbbResponsable.DataSource = responsables;
                cbbResponsable.DisplayMember = "NomComplet";
                cbbResponsable.ValueMember = "IdUtilisateur";
                cbbResponsable.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Erreur responsables : " + ex.Message); }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitre.Text) || cbbResponsable.SelectedValue == null)
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires (Titre et Responsable).");
                return;
            }

            try
            {
                if (_idSelectionne == null) 
                {
                    CahierTexte nouveau = new CahierTexte
                    {
                        TitreCahierTexte = txtTitre.Text.Trim(),
                        DescriptionCahierTexte = txtDescription.Text.Trim(),
                        DateCahierTexte = dtpDate.Value,
                        IdResponsableClasse = (int)cbbResponsable.SelectedValue,
                        Annee = dtpDate.Value.Year
                    };
                    db.CahierTextes.Add(nouveau);
                }
                else 
                {
                    var existant = db.CahierTextes.Find(_idSelectionne);
                    if (existant != null)
                    {
                        existant.TitreCahierTexte = txtTitre.Text.Trim();
                        existant.DescriptionCahierTexte = txtDescription.Text.Trim();
                        existant.DateCahierTexte = dtpDate.Value;
                        existant.IdResponsableClasse = (int)cbbResponsable.SelectedValue;
                    }
                }

                db.SaveChanges();
                ReinitialiserFormulaire(); 
                ActualiserGrille();
            }
            catch (Exception ex) { MessageBox.Show("Erreur : " + ex.Message); }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (_idSelectionne != null)
            {
                var rep = MessageBox.Show("Supprimer définitivement ce cahier ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rep == DialogResult.Yes)
                {
                    var c = db.CahierTextes.Find(_idSelectionne);
                    if (c != null)
                    {
                        db.CahierTextes.Remove(c);
                        db.SaveChanges();
                        ReinitialiserFormulaire();
                        ActualiserGrille();
                    }
                }
            }
        }

        private void dgvListeCahiers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _idSelectionne = (int)dgvListeCahiers.Rows[e.RowIndex].Cells["Id"].Value;
                var c = db.CahierTextes.Find(_idSelectionne);
                if (c != null)
                {
                    txtTitre.Text = c.TitreCahierTexte;
                    txtDescription.Text = c.DescriptionCahierTexte;
                    dtpDate.Value = c.DateCahierTexte;
                    cbbResponsable.SelectedValue = c.IdResponsableClasse;

                    btnEnregistrer.Text = "MODIFIER";
                    btnEnregistrer.BackColor = System.Drawing.Color.Orange;
                    btnSupprimer.Enabled = true;
                }
            }
        }

        private void ReinitialiserFormulaire()
        {
            _idSelectionne = null;
            txtTitre.Clear();
            txtDescription.Clear();
            dtpDate.Value = DateTime.Now;
            cbbResponsable.SelectedIndex = -1;
            btnEnregistrer.Text = "AJOUTER";
            btnEnregistrer.BackColor = System.Drawing.Color.DodgerBlue;
            btnSupprimer.Enabled = false;
        }
    }
}