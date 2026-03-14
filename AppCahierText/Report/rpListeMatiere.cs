using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace AppCahierText.Report
{
    public partial class rpListeMatiere : Form
    {
        private List<MatiereRptView> _liste;

        public rpListeMatiere(List<MatiereRptView> liste)
        {
            InitializeComponent();
            this._liste = liste;
        }

        private void rpListeMatiere_Load(object sender, EventArgs e)
        {
            try
            {
                // Configuration de l'affichage
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

                // Chemin du fichier RDLC
                reportViewer1.LocalReport.ReportPath = "Report/rptMatiere.rdlc";

                // Injection des données
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetMatiere", _liste));

                // Rafraîchissement
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement du rapport : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cette méthode doit exister car elle est déclarée dans le Designer
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // Peut rester vide
        }
    }
}