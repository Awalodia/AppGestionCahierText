using AppCahierText.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace AppCahierText.Views.Parametre
{
    public partial class PrintMatiere : Form
    {
        // Utilisation d'underscores pour les variables de classe (standard C#)
        private BdCahierTexteContext _db = new BdCahierTexteContext();
        private PrintDocument _doc = new PrintDocument();
        private List<Matiere> _liste;
        private int _index = 0;

        public PrintMatiere()
        {
            InitializeComponent();
        }

        private void PrintMatiere_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Charger les données depuis la base
                _liste = _db.Matieres.ToList();

                // 2. Configurer les événements du document
                // BeginPrint s'exécute AVANT la première page (aperçu ou impression)
                _doc.BeginPrint += (s, ev) => { _index = 0; };
                _doc.PrintPage += PrintDocument_PrintPage;

                // 3. Lier au contrôle d'aperçu
                printPreviewControl1.Document = _doc;
                printPreviewControl1.Zoom = 1.0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement : " + ex.Message);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float x = 50; // Marge gauche
            float y = 50; // Marge haute
            float ligneHauteur = 25;
            Font policeTitre = new Font("Arial", 16, FontStyle.Bold);
            Font policeEntete = new Font("Arial", 11, FontStyle.Bold);
            Font policeCorps = new Font("Arial", 10);

            // --- TITRE DU DOCUMENT ---
            g.DrawString("LISTE DES MATIÈRES RÉPERTORIÉES", policeTitre, Brushes.DarkBlue, x, y);
            y += 60;

            // --- ENTÊTE DU TABLEAU ---
            g.DrawString("LIBELLÉ", policeEntete, Brushes.Black, x, y);
            g.DrawString("NIVEAU", policeEntete, Brushes.Black, x + 300, y);
            y += 5;
            g.DrawLine(new Pen(Color.Black, 2), x, y + 20, e.PageBounds.Width - 50, y + 20);
            y += 30;

            // --- BOUCLE D'IMPRESSION ---
            while (_index < _liste.Count)
            {
                Matiere m = _liste[_index];

                // Dessiner la ligne
                g.DrawString(m.LibelleMatiere, policeCorps, Brushes.Black, x, y);
                g.DrawString(m.Niveau, policeCorps, Brushes.Black, x + 300, y);

                y += ligneHauteur;
                _index++;

                // Gérer le saut de page (si y dépasse la marge basse)
                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true; // Dit à Windows qu'il y a une suite
                    return; // Sort de la méthode pour préparer la page suivante
                }
            }

            // Fin du document
            e.HasMorePages = false;
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            // Ouvrir la boîte de dialogue d'impression standard
            PrintDialog pd = new PrintDialog();
            pd.Document = _doc;

            if (pd.ShowDialog() == DialogResult.OK)
            {
                _doc.Print();
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {
            // Optionnel : clic pour zoomer
            printPreviewControl1.Zoom = (printPreviewControl1.Zoom == 1.0) ? 1.5 : 1.0;
        }
    }
}