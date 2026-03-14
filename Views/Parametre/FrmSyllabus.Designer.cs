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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyllabus)).BeginInit();
            this.SuspendLayout();

            // DataGridView
            this.dgvSyllabus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyllabus.Location = new System.Drawing.Point(12, 180);
            this.dgvSyllabus.Name = "dgvSyllabus";
            this.dgvSyllabus.Size = new System.Drawing.Size(760, 260);
            this.dgvSyllabus.TabIndex = 0;
            this.dgvSyllabus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSyllabus_CellClick);

            // Inputs (Positionnement rapide pour l'exemple)
            this.txtLibelle.Location = new System.Drawing.Point(100, 20);
            this.txtLibelle.Size = new System.Drawing.Size(200, 20);

            this.txtDescription.Location = new System.Drawing.Point(100, 50);
            this.txtDescription.Size = new System.Drawing.Size(200, 60);
            this.txtDescription.Multiline = true;

            this.txtVolume.Location = new System.Drawing.Point(400, 20);
            this.txtNiveau.Location = new System.Drawing.Point(400, 50);

            // Boutons
            this.btnAjouter.Location = new System.Drawing.Point(100, 130);
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            this.btnModifier.Location = new System.Drawing.Point(200, 130);
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            this.btnSupprimer.Location = new System.Drawing.Point(300, 130);
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvSyllabus);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtNiveau);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Name = "frmSyllabus";
            this.Text = "Gestion des Syllabus";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}