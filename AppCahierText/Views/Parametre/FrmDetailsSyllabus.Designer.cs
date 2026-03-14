namespace AppCahierText.Views.Parametre
{
    partial class FrmDetailsSyllabus
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgDetailsSyllabus = new System.Windows.Forms.DataGridView();
            this.lblSyllabus = new System.Windows.Forms.Label();
            this.cbbSyllabus = new System.Windows.Forms.ComboBox();
            this.lblSeance = new System.Windows.Forms.Label();
            this.txtSeance = new System.Windows.Forms.TextBox();
            this.lblContenu = new System.Windows.Forms.Label();
            this.txtContenu = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailsSyllabus)).BeginInit();
            this.SuspendLayout();
             
            this.dgDetailsSyllabus.AllowUserToAddRows = false;
            this.dgDetailsSyllabus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDetailsSyllabus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetailsSyllabus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetailsSyllabus.Location = new System.Drawing.Point(230, 12);
            this.dgDetailsSyllabus.MultiSelect = false;
            this.dgDetailsSyllabus.Name = "dgDetailsSyllabus";
            this.dgDetailsSyllabus.ReadOnly = true;
            this.dgDetailsSyllabus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetailsSyllabus.Size = new System.Drawing.Size(758, 426);
            this.dgDetailsSyllabus.TabIndex = 10;
            this.dgDetailsSyllabus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetailsSyllabus_CellClick);
            
         
            this.lblSyllabus.AutoSize = true;
            this.lblSyllabus.Location = new System.Drawing.Point(12, 12);
            this.lblSyllabus.Name = "lblSyllabus";
            this.lblSyllabus.Size = new System.Drawing.Size(46, 13);
            this.lblSyllabus.Text = "Syllabus";
            
            this.cbbSyllabus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSyllabus.FormattingEnabled = true;
            this.cbbSyllabus.Location = new System.Drawing.Point(12, 28);
            this.cbbSyllabus.Name = "cbbSyllabus";
            this.cbbSyllabus.Size = new System.Drawing.Size(200, 21);
            this.cbbSyllabus.TabIndex = 1;
           
            this.lblSeance.AutoSize = true;
            this.lblSeance.Location = new System.Drawing.Point(12, 62);
            this.lblSeance.Name = "lblSeance";
            this.lblSeance.Size = new System.Drawing.Size(44, 13);
            this.lblSeance.Text = "Séance";
          
            this.txtSeance.Location = new System.Drawing.Point(12, 78);
            this.txtSeance.MaxLength = 10;
            this.txtSeance.Name = "txtSeance";
            this.txtSeance.Size = new System.Drawing.Size(200, 20);
            this.txtSeance.TabIndex = 2;
            
            this.lblContenu.AutoSize = true;
            this.lblContenu.Location = new System.Drawing.Point(12, 112);
            this.lblContenu.Name = "lblContenu";
            this.lblContenu.Size = new System.Drawing.Size(47, 13);
            this.lblContenu.Text = "Contenu";
          
            this.txtContenu.Location = new System.Drawing.Point(12, 128);
            this.txtContenu.MaxLength = 500;
            this.txtContenu.Multiline = true;
            this.txtContenu.Name = "txtContenu";
            this.txtContenu.Size = new System.Drawing.Size(200, 80);
            this.txtContenu.TabIndex = 3;
          
            this.btnAjouter.Location = new System.Drawing.Point(12, 225);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(200, 30);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
         
            this.btnModifier.Location = new System.Drawing.Point(12, 261);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(200, 30);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
          
            this.btnSupprimer.Location = new System.Drawing.Point(12, 297);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(200, 30);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
         
            this.btnEffacer.Location = new System.Drawing.Point(12, 333);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(200, 30);
            this.btnEffacer.TabIndex = 7;
            this.btnEffacer.Text = "Vider / Nouveau";
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
       
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtContenu);
            this.Controls.Add(this.lblContenu);
            this.Controls.Add(this.txtSeance);
            this.Controls.Add(this.lblSeance);
            this.Controls.Add(this.cbbSyllabus);
            this.Controls.Add(this.lblSyllabus);
            this.Controls.Add(this.dgDetailsSyllabus);
            this.Name = "FrmDetailsSyllabus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Détails du Syllabus";
            this.Load += new System.EventHandler(this.FrmDetailsSyllabus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailsSyllabus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgDetailsSyllabus;
        private System.Windows.Forms.Label lblSyllabus;
        private System.Windows.Forms.ComboBox cbbSyllabus;
        private System.Windows.Forms.Label lblSeance;
        private System.Windows.Forms.TextBox txtSeance;
        private System.Windows.Forms.Label lblContenu;
        private System.Windows.Forms.TextBox txtContenu;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnEffacer;
    }
}