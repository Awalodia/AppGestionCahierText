using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AppCahierText.Model;

namespace AppCahierText.Views.Parametre
{
    public partial class FrmDetailCahier : Form
    {
        private BdCahierTexteContext db = new BdCahierTexteContext();
        private int _idCahier;

        public FrmDetailCahier()
        {
            InitializeComponent();
           
            this.dgvDetails.CellContentClick += new DataGridViewCellEventHandler(this.dgvDetails_CellContentClick);
        }

        private void FrmDetailCahier_Load(object sender, EventArgs e)
        {
            ChargerListeCahiers();
            ChargerMatieres();
            ConfigurerGrille();
        }

        private void ConfigurerGrille()
        {
            dgvDetails.AutoGenerateColumns = false;
            dgvDetails.Columns.Clear();

          
            dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdDetail",
                DataPropertyName = "IdDetail",
                Visible = false
            });

            dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Matiere",
                HeaderText = "MATIÈRE",
                DataPropertyName = "Matiere",
                FillWeight = 100
            });
            dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Debut",
                HeaderText = "DÉBUT",
                DataPropertyName = "Debut",
                FillWeight = 50
            });
            dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fin",
                HeaderText = "FIN",
                DataPropertyName = "Fin",
                FillWeight = 50
            });
            dgvDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Chapitre",
                HeaderText = "CHAPITRE",
                DataPropertyName = "Chapitre",
                FillWeight = 150
            });

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "ACTION";
            btnDelete.Text = "Supprimer";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            dgvDetails.Columns.Add(btnDelete);
        }

        private void ChargerListeCahiers()
        {
            try
            {
                var cahiers = db.CahierTextes
                    .Select(c => new {
                        Id = c.IdCahierTexte,
                        Infos = c.DateCahierTexte.Day + "/" + c.DateCahierTexte.Month + " - " + c.TitreCahierTexte
                    }).ToList();

                cbbCahier.DataSource = cahiers;
                cbbCahier.DisplayMember = "Infos";
                cbbCahier.ValueMember = "Id";
                cbbCahier.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Erreur cahiers : " + ex.Message); }
        }

        private void ChargerMatieres()
        {
            try
            {
              
                cbbMatiere.DataSource = db.Matieres.OrderBy(m => m.LibelleMatiere).ToList();
                cbbMatiere.DisplayMember = "LibelleMatiere";
                cbbMatiere.ValueMember = "IdMatiere";
                cbbMatiere.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show("Erreur matières : " + ex.Message); }
        }

        private void cbbCahier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCahier.SelectedValue != null && cbbCahier.SelectedValue is int)
            {
                this._idCahier = (int)cbbCahier.SelectedValue;
                btnEnregistrer.Enabled = true;
                ActualiserGrille();
            }
        }

        public void ActualiserGrille()
        {
            try
            {
                db = new BdCahierTexteContext();
                var liste = db.DetailCahierTextes
                    .Where(d => d.IdCahierTexte == _idCahier)
                    .Select(d => new
                    {
                        d.IdDetail,
                        Matiere = d.Matiere.LibelleMatiere,
                        Debut = d.HeureDebut,
                        Fin = d.HeureFin,
                        Chapitre = d.ChapitreCours
                    }).ToList();

                dgvDetails.DataSource = liste;
            }
            catch (Exception ex) { MessageBox.Show("Erreur grille : " + ex.Message); }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (cbbMatiere.SelectedValue == null || string.IsNullOrWhiteSpace(txtChapitre.Text))
            {
                MessageBox.Show("Veuillez remplir la matière et le chapitre.");
                return;
            }

            try
            {
                DetailCahierTexte detail = new DetailCahierTexte
                {
                    IdCahierTexte = this._idCahier,
                    IdMatiere = (int)cbbMatiere.SelectedValue,
                    HeureDebut = txtDebut.Text.Trim(),
                    HeureFin = txtFin.Text.Trim(),
                    ChapitreCours = txtChapitre.Text.Trim(),
                    ResumeCours = txtResume.Text.Trim()
                };

                db.DetailCahierTextes.Add(detail);
                db.SaveChanges();

                ActualiserGrille();
                NettoyerChamps();
            }
            catch (Exception ex) { MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message); }
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetails.Columns[e.ColumnIndex].Name == "btnDelete" && e.RowIndex >= 0)
            {
                int id = (int)dgvDetails.Rows[e.RowIndex].Cells["IdDetail"].Value;

                if (MessageBox.Show("Supprimer ce cours ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var d = db.DetailCahierTextes.Find(id);
                    if (d != null)
                    {
                        db.DetailCahierTextes.Remove(d);
                        db.SaveChanges();
                        ActualiserGrille();
                    }
                }
            }
        }

        private void NettoyerChamps()
        {
            txtDebut.Clear(); txtFin.Clear(); txtChapitre.Clear(); txtResume.Clear();
            cbbMatiere.SelectedIndex = -1;
            txtDebut.Focus();
        }
    }
}