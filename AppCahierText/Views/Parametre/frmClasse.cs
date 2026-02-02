using AppCahierText.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCahierText.Views.Parametre
{
    public partial class frmClasse : Form
    {   
        BdCahierTexteContext db=new BdCahierTexteContext();
        private void Effacer()
        {
               txtlibelle.Text=String.Empty;
               cbbAnneeAcademique.Text=String.Empty;
               cbbAnneeAcademique.DataSource= db.AnneesAcademiques.ToList();
               cbbAnneeAcademique.Text = "LibelleAnneeAcademique";
               cbbAnneeAcademique.ValueMember = "ValueAnneeAcademique";
               Dgclasse.DataSource= db.Classes.ToList();
               txtlibelle.Focus();
        }
        public frmClasse()
        {
            InitializeComponent();
        }


        private void btnAdd_TextChanged(object sender, EventArgs e)
        {
            Classe c=new Classe();
            c.AnneeAcademique = txtlibelle.Text ;
            c.IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString());
            db.Classes.Add(c);
            db.SaveChanges();
            Effacer ();
        }


        private void btnM_TextChanged(object sender, EventArgs e)
        {
          int? id= int.Parse(DgClasse.CurrentRow.Cells[0].Value.AToString());
            var c = db.Classes.Find(id);
            c.AnneeAcademique = txtlibelle.Text;
            c.IdAnneeAcademique = int.Parse(cbbAnneeAcademique.SelectedValue.ToString());
            db.SaveChanges();
            Effacer()
        }
        private void btnDelete_TextChanged(object sender, EventArgs e)
        {
            int? id = int.Parse(DgClasse.currentRow.Cells[0].Value.ToString());
            var c = db.Classes.Find(id);
            db.Classes.Remove(c);
            db.SaveChanges();
            Effacer();
        }

        private void frmClasse_Load(object sender, EventArgs e)
        {
            Effacer();
        }

        private void btnconnexion_TextChanged(object sender, EventArgs e)
        {
            txtlibelle.Text = DgClasse.currentRow.cells[1]Value.ToString();
            cbbAnneeAcademique.SelectedValue = DgClasse.CurrentRow.Cells[~~]


        }

    }
}
