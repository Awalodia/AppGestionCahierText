namespace AppCahierText.Views.Parametre
{
    partial class frmSyllabus
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvSyllabus = new System.Windows.Forms.DataGridView();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtNiveau = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblNiveau = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyllabus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSyllabus
            // 
            this.dgvSyllabus.AllowUserToAddRows = false;
            this.dgvSyllabus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSyllabus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSyllabus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyllabus.Location = new System.Drawing.Point(220, 12);
            this.dgvSyllabus.MultiSelect = false;
            this.dgvSyllabus.Name = "dgvSyllabus";
            this.dgvSyllabus.ReadOnly = true;
            this.dgvSyllabus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSyllabus.Size = new System.Drawing.Size(552, 437);
            this.dgvSyllabus.TabIndex = 9;
            this.dgvSyllabus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSyllabus_CellClick);
            // 
            // lblLibelle
            // 
            this.lblLibelle.Location = new System.Drawing.Point(12, 12);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(100, 15);
            this.lblLibelle.Text = "Libellé";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(12, 30);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(190, 20);
            this.txtLibelle.TabIndex = 1;
            // 
            // lblVolume
            // 
            this.lblVolume.Location = new System.Drawing.Point(12, 60);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(100, 15);
            this.lblVolume.Text = "Volume Horaire";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(12, 78);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(190, 20);
            this.txtVolume.TabIndex = 2;
            // 
            // lblNiveau
            // 
            this.lblNiveau.Location = new System.Drawing.Point(12, 110);
            this.lblNiveau.Name = "lblNiveau";
            this.lblNiveau.Size = new System.Drawing.Size(100, 15);
            this.lblNiveau.Text = "Niveau";
            // 
            // txtNiveau
            // 
            this.txtNiveau.Location = new System.Drawing.Point(12, 128);
            this.txtNiveau.Name = "txtNiveau";
            this.txtNiveau.Size = new System.Drawing.Size(190, 20);
            this.txtNiveau.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 160);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 15);
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 178);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(190, 60);
            this.txtDescription.TabIndex = 4;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 250);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(190, 30);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(12, 286);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(190, 30);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(12, 322);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(190, 30);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(12, 358);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(190, 30);
            this.btnEffacer.TabIndex = 8;
            this.btnEffacer.Text = "Vider / Nouveau";
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // frmSyllabus
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNiveau);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.dgvSyllabus);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtNiveau);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Name = "frmSyllabus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramétrage des Syllabus";
            this.Load += new System.EventHandler(this.frmSyllabus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyllabus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvSyllabus;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtNiveau;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblNiveau;
        private System.Windows.Forms.Label lblDescription;
    }
}