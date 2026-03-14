namespace AppCahierText.Views.Parametre
{
    partial class frmCahierTexte
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.cbbResponsable = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dgvListeCahiers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCahiers)).BeginInit();
            this.SuspendLayout();

            this.lblTitre.Location = new System.Drawing.Point(20, 20);
            this.lblTitre.Text = "Titre du Cahier";
            this.txtTitre.Location = new System.Drawing.Point(20, 40);
            this.txtTitre.Size = new System.Drawing.Size(260, 20);

         
            this.lblDate.Location = new System.Drawing.Point(20, 70);
            this.lblDate.Text = "Date de création";
            this.dtpDate.Location = new System.Drawing.Point(20, 90);
            this.dtpDate.Size = new System.Drawing.Size(260, 20);

           
            this.lblResponsable.Location = new System.Drawing.Point(20, 120);
            this.lblResponsable.Text = "Responsable";
            this.cbbResponsable.Location = new System.Drawing.Point(20, 140);
            this.cbbResponsable.Size = new System.Drawing.Size(260, 21);
            this.cbbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblDescription.Location = new System.Drawing.Point(20, 175);
            this.lblDescription.Text = "Description";
            this.txtDescription.Location = new System.Drawing.Point(20, 195);
            this.txtDescription.Size = new System.Drawing.Size(260, 70);
            this.txtDescription.Multiline = true;

           
            this.btnEnregistrer.Location = new System.Drawing.Point(20, 280);
            this.btnEnregistrer.Size = new System.Drawing.Size(125, 40);
            this.btnEnregistrer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Text = "AJOUTER";
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);

            this.btnSupprimer.Location = new System.Drawing.Point(155, 280);
            this.btnSupprimer.Size = new System.Drawing.Size(125, 40);
            this.btnSupprimer.BackColor = System.Drawing.Color.Crimson;
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Text = "SUPPRIMER";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            this.dgvListeCahiers.Location = new System.Drawing.Point(300, 40);
            this.dgvListeCahiers.Size = new System.Drawing.Size(540, 280);
            this.dgvListeCahiers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeCahiers_CellClick);

            this.ClientSize = new System.Drawing.Size(870, 350);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitre, this.txtTitre, this.lblDate, this.dtpDate,
                this.lblResponsable, this.cbbResponsable, this.lblDescription,
                this.txtDescription, this.btnEnregistrer, this.btnSupprimer, this.dgvListeCahiers
            });

            this.Name = "frmCahierTexte";
            this.Text = "Gestion des Cahiers de Texte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCahierTexte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCahiers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitre, lblDate, lblResponsable, lblDescription;
        private System.Windows.Forms.TextBox txtTitre, txtDescription;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbbResponsable;
        private System.Windows.Forms.Button btnEnregistrer, btnSupprimer;
        private System.Windows.Forms.DataGridView dgvListeCahiers;
    }
}