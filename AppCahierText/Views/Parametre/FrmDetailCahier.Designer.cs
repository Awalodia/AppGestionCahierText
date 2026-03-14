namespace AppCahierText.Views.Parametre
{
    partial class FrmDetailCahier
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMatiere = new System.Windows.Forms.Label();
            this.lblHeures = new System.Windows.Forms.Label();
            this.lblChapitre = new System.Windows.Forms.Label();
            this.lblResume = new System.Windows.Forms.Label();
            this.cbbMatiere = new System.Windows.Forms.ComboBox();
            this.txtDebut = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtChapitre = new System.Windows.Forms.TextBox();
            this.txtResume = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.panelSaisie = new System.Windows.Forms.Panel();
            this.groupBoxChoixCahier = new System.Windows.Forms.GroupBox();
            this.lblCahier = new System.Windows.Forms.Label();
            this.cbbCahier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panelSaisie.SuspendLayout();
            this.groupBoxChoixCahier.SuspendLayout();
            this.SuspendLayout();

            this.lblMatiere.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatiere.Location = new System.Drawing.Point(10, 10);
            this.lblMatiere.Name = "lblMatiere";
            this.lblMatiere.Size = new System.Drawing.Size(100, 23);
            this.lblMatiere.TabIndex = 0;
            this.lblMatiere.Text = "MATIÈRE";

            
            this.lblHeures.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblHeures.Location = new System.Drawing.Point(10, 65);
            this.lblHeures.Name = "lblHeures";
            this.lblHeures.Size = new System.Drawing.Size(150, 23);
            this.lblHeures.TabIndex = 2;
            this.lblHeures.Text = "HEURES (DÉBUT / FIN)";

           
            this.lblChapitre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblChapitre.Location = new System.Drawing.Point(10, 115);
            this.lblChapitre.Name = "lblChapitre";
            this.lblChapitre.Size = new System.Drawing.Size(150, 23);
            this.lblChapitre.TabIndex = 5;
            this.lblChapitre.Text = "TITRE DU CHAPITRE";

            this.lblResume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResume.Location = new System.Drawing.Point(10, 165);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(150, 23);
            this.lblResume.TabIndex = 7;
            this.lblResume.Text = "RÉSUMÉ DU COURS";

        
            this.cbbMatiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMatiere.Location = new System.Drawing.Point(10, 30);
            this.cbbMatiere.Name = "cbbMatiere";
            this.cbbMatiere.Size = new System.Drawing.Size(250, 21);
            this.cbbMatiere.TabIndex = 1;

          
            this.txtDebut.Location = new System.Drawing.Point(10, 85);
            this.txtDebut.Name = "txtDebut";
            this.txtDebut.Size = new System.Drawing.Size(120, 20);
            this.txtDebut.TabIndex = 3;

           
            this.txtFin.Location = new System.Drawing.Point(140, 85);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(120, 20);
            this.txtFin.TabIndex = 4;

          
            this.txtChapitre.Location = new System.Drawing.Point(10, 135);
            this.txtChapitre.Name = "txtChapitre";
            this.txtChapitre.Size = new System.Drawing.Size(250, 20);
            this.txtChapitre.TabIndex = 6;

          
            this.txtResume.Location = new System.Drawing.Point(10, 185);
            this.txtResume.Multiline = true;
            this.txtResume.Name = "txtResume";
            this.txtResume.Size = new System.Drawing.Size(250, 75);
            this.txtResume.TabIndex = 8;

          
            this.btnEnregistrer.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(10, 270);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(250, 35);
            this.btnEnregistrer.TabIndex = 9;
            this.btnEnregistrer.Text = "ENREGISTRER LE COURS";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);

          
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.Location = new System.Drawing.Point(305, 85);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.Size = new System.Drawing.Size(603, 313);
            this.dgvDetails.TabIndex = 2;

            this.panelSaisie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSaisie.Controls.Add(this.lblMatiere);
            this.panelSaisie.Controls.Add(this.cbbMatiere);
            this.panelSaisie.Controls.Add(this.lblHeures);
            this.panelSaisie.Controls.Add(this.txtDebut);
            this.panelSaisie.Controls.Add(this.txtFin);
            this.panelSaisie.Controls.Add(this.lblChapitre);
            this.panelSaisie.Controls.Add(this.txtChapitre);
            this.panelSaisie.Controls.Add(this.lblResume);
            this.panelSaisie.Controls.Add(this.txtResume);
            this.panelSaisie.Controls.Add(this.btnEnregistrer);
            this.panelSaisie.Location = new System.Drawing.Point(12, 85);
            this.panelSaisie.Name = "panelSaisie";
            this.panelSaisie.Size = new System.Drawing.Size(280, 313);
            this.panelSaisie.TabIndex = 1;

           
            this.groupBoxChoixCahier.Controls.Add(this.lblCahier);
            this.groupBoxChoixCahier.Controls.Add(this.cbbCahier);
            this.groupBoxChoixCahier.Location = new System.Drawing.Point(12, 12);
            this.groupBoxChoixCahier.Name = "groupBoxChoixCahier";
            this.groupBoxChoixCahier.Size = new System.Drawing.Size(896, 60);
            this.groupBoxChoixCahier.TabIndex = 0;
            this.groupBoxChoixCahier.TabStop = false;
            this.groupBoxChoixCahier.Text = "SÉLECTION DU CAHIER";

            // 
            // lblCahier
            // 
            this.lblCahier.AutoSize = true;
            this.lblCahier.Location = new System.Drawing.Point(15, 25);
            this.lblCahier.Name = "lblCahier";
            this.lblCahier.Size = new System.Drawing.Size(84, 13);
            this.lblCahier.TabIndex = 0;
            this.lblCahier.Text = "Cahier de texte :";

           
            this.cbbCahier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCahier.Location = new System.Drawing.Point(120, 22);
            this.cbbCahier.Name = "cbbCahier";
            this.cbbCahier.Size = new System.Drawing.Size(450, 21);
            this.cbbCahier.TabIndex = 1;
            this.cbbCahier.SelectedIndexChanged += new System.EventHandler(this.cbbCahier_SelectedIndexChanged);

            this.ClientSize = new System.Drawing.Size(920, 410);
            this.Controls.Add(this.groupBoxChoixCahier);
            this.Controls.Add(this.panelSaisie);
            this.Controls.Add(this.dgvDetails);
            this.Name = "FrmDetailCahier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Détails du Cahier";

            
            this.Load += new System.EventHandler(this.FrmDetailCahier_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panelSaisie.ResumeLayout(false);
            this.panelSaisie.PerformLayout();
            this.groupBoxChoixCahier.ResumeLayout(false);
            this.groupBoxChoixCahier.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxChoixCahier;
        private System.Windows.Forms.ComboBox cbbCahier;
        private System.Windows.Forms.Label lblCahier, lblMatiere, lblHeures, lblChapitre, lblResume;
        private System.Windows.Forms.ComboBox cbbMatiere;
        private System.Windows.Forms.TextBox txtDebut, txtFin, txtChapitre, txtResume;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Panel panelSaisie;
    }
}