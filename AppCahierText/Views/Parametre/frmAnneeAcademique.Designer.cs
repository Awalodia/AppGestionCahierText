namespace AppCahierText.Views.Parametre
{
    partial class frmAnneeAcademique
    {
     
        private System.ComponentModel.IContainer components = null;

    
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region

       
        private void InitializeComponent()
        {
            this.dgAnneeAcademique = new System.Windows.Forms.DataGridView();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblValeur = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnneeAcademique)).BeginInit();
            this.SuspendLayout();

           
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(18, 20);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(120, 13);
            this.lblLibelle.TabIndex = 0;
            this.lblLibelle.Text = "Libellé";

           
            this.txtLibelle.Location = new System.Drawing.Point(18, 40);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(200, 20);
            this.txtLibelle.TabIndex = 1;
            this.txtLibelle.MaxLength = 10;

           
            this.lblValeur.AutoSize = true;
            this.lblValeur.Location = new System.Drawing.Point(18, 75);
            this.lblValeur.Name = "lblValeur";
            this.lblValeur.Size = new System.Drawing.Size(110, 13);
            this.lblValeur.TabIndex = 2;
            this.lblValeur.Text = "Valeur année";

           
            this.txtValeur.Location = new System.Drawing.Point(18, 95);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(200, 20);
            this.txtValeur.TabIndex = 3;
            this.txtValeur.MaxLength = 4;
            this.txtValeur.Text = System.DateTime.Now.Year.ToString();

           
            this.btnAjouter.Location = new System.Drawing.Point(18, 135);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(200, 30);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

          
            this.btnModifier.Location = new System.Drawing.Point(18, 175);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(200, 30);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

           
            this.btnSupprimer.Location = new System.Drawing.Point(18, 215);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(200, 30);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            
            this.btnEffacer.Location = new System.Drawing.Point(18, 255);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(200, 30);
            this.btnEffacer.TabIndex = 7;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);

         
            this.dgAnneeAcademique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnneeAcademique.Location = new System.Drawing.Point(240, 20);
            this.dgAnneeAcademique.Name = "dgAnneeAcademique";
            this.dgAnneeAcademique.Size = new System.Drawing.Size(530, 400);
            this.dgAnneeAcademique.TabIndex = 8;
            this.dgAnneeAcademique.ReadOnly = true;
            this.dgAnneeAcademique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAnneeAcademique.MultiSelect = false;
            this.dgAnneeAcademique.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAnneeAcademique.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAnneeAcademique_CellClick);

          
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Name = "frmAnneeAcademique";
            this.Text = "Gestion des Années Académiques";
            this.Load += new System.EventHandler(this.frmAnneeAcademique_Load);

            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.lblValeur);
            this.Controls.Add(this.txtValeur);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.dgAnneeAcademique);

            ((System.ComponentModel.ISupportInitialize)(this.dgAnneeAcademique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgAnneeAcademique;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblValeur;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnEffacer;
    }
}