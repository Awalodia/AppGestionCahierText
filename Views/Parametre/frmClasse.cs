using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AppCahierText.Model;
using AppCahierText.Shared;
using System.Data.Entity;

namespace AppCahierText.Views.Parametre
{
    public partial class frmClasse : Form
    {
        BdCahierTexteContext db = new BdCahierTexteContext();

        public frmClasse()
        {
            InitializeComponent();
            // Liaison de l'événement de clic pour la sélection automatique
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        }

        private void Effacer()
        {
            txtlibelle.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

            // Remplissage du ComboBox
            var annees = Shared.FillListOption.fillAnneeAcademique();
            cbbAnneeAcademique.DataSource = null;

            if (annees != null && annees.Any())
            {
                cbbAnneeAcademique.DisplayMember = "Text";
                cbbAnneeAcademique.ValueMember = "Value";
                cbbAnneeAcademique.DataSource = annees;
            }

            ChargerGrille();
            txtlibelle.Focus();
        }

        private void ChargerGrille()
        {
            // Utilisation de .Include pour charger la relation maintenant décommentée
            dataGridView1.DataSource = db.Classes
                .Include(c => c.AnneeAcademique)
                .AsNoTracking()
                .Select(c => new
                {
                    c.IdClasse,
                    Classe = c.LibelleClasse,
                    // Si AnneeAcademique est nulle, on affiche "N/A"
                    Annee = c.AnneeAcademique != null ? c.AnneeAcademique.LibelleAnneeAcademique : "N/A",
                    IdAnnee = c.IdAnneeAcademique
                }).ToList();

            if (dataGridView1.Columns.Contains("IdClasse")) dataGridView1.Columns["IdClasse"].Visible = false;
            if (dataGridView1.Columns.Contains("IdAnnee")) dataGridView1.Columns["IdAnnee"].Visible = false;
        }

        private void frmClasse_Load_1(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var lib = txtlibelle.Text?.Trim();
            if (string.IsNullOrWhiteSpace(lib))
            {
                MessageBox.Show("Le libellé est requis.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbbAnneeAcademique.SelectedValue == null)
            {
                MessageBox.Show("Sélectionnez une année.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idAnnee = Convert.ToInt32(cbbAnneeAcademique.SelectedValue);

            var c = new Classe { LibelleClasse = lib, IdAnneeAcademique = idAnnee };
            db.Classes.Add(c);

            try
            {
                db.SaveChanges();
                Effacer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Erreur lors de l'ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdClasse"].Value);

            var c = db.Classes.Find(id);
            if (c != null)
            {
                c.LibelleClasse = txtlibelle.Text.Trim();
                c.IdAnneeAcademique = Convert.ToInt32(cbbAnneeAcademique.SelectedValue);

                try
                {
                    db.SaveChanges();
                    Effacer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message, "Erreur lors de la modification");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdClasse"].Value);

            if (MessageBox.Show("Voulez-vous vraiment supprimer cette classe ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var c = db.Classes.Find(id);
                if (c != null)
                {
                    db.Classes.Remove(c);
                    db.SaveChanges();
                    Effacer();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtlibelle.Text = dataGridView1.Rows[e.RowIndex].Cells["Classe"].Value?.ToString();
                cbbAnneeAcademique.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells["IdAnnee"].Value;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var query = db.Classes.Include(c => c.AnneeAcademique).AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string search = textBox1.Text.ToUpper();
                query = query.Where(c => c.LibelleClasse.ToUpper().Contains(search));
            }

            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                string searchAnnee = textBox2.Text.ToUpper();
                query = query.Where(c => c.AnneeAcademique.LibelleAnneeAcademique.ToUpper().Contains(searchAnnee));
            }

            dataGridView1.DataSource = query.Select(c => new
            {
                c.IdClasse,
                Classe = c.LibelleClasse,
                Annee = c.AnneeAcademique != null ? c.AnneeAcademique.LibelleAnneeAcademique : "N/A",
                IdAnnee = c.IdAnneeAcademique
            }).ToList();
        }

        private void BtnSelect(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                dataGridView1_CellClick(null, new DataGridViewCellEventArgs(0, dataGridView1.CurrentRow.Index));
        }

        private void label2_Click(object sender, EventArgs e) { }
    }
}