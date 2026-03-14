namespace AppCahierText.Views.Parametre
{
    partial class frmClasse
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgClasse = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlibelle = new System.Windows.Forms.TextBox();
            this.cbbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClasse
            // 
            this.dgClasse.AllowUserToAddRows = false;
            this.dgClasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClasse.Location = new System.Drawing.Point(260, 40);
            this.dgClasse.Name = "dgClasse";
            this.dgClasse.ReadOnly = true;
            this.dgClasse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClasse.Size = new System.Drawing.Size(500, 300);
            this.dgClasse.TabIndex = 0;
            this.dgClasse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClasse_CellClick);
            // 
            // label1
            // 
            this.label1.Text = "Libellé Classe :";
            this.label1.Location = new System.Drawing.Point(20, 25);
            // 
            // txtlibelle
            // 
            this.txtlibelle.Location = new System.Drawing.Point(20, 45);
            this.txtlibelle.Size = new System.Drawing.Size(200, 20);
            // 
            // label2
            // 
            this.label2.Text = "Année Académique :";
            this.label2.Location = new System.Drawing.Point(20, 85);
            // 
            // cbbAnneeAcademique
            // 
            this.cbbAnneeAcademique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAnneeAcademique.Location = new System.Drawing.Point(20, 105);
            this.cbbAnneeAcademique.Size = new System.Drawing.Size(200, 21);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 150);
            this.btnAdd.Size = new System.Drawing.Size(95, 30);
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(125, 150);
            this.btnM.Size = new System.Drawing.Size(95, 30);
            this.btnM.Text = "Modifier";
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // frmClasse
            // 
            this.ClientSize = new System.Drawing.Size(780, 360);
            this.Controls.Add(this.dgClasse);
            this.Controls.Add(this.txtlibelle);
            this.Controls.Add(this.cbbAnneeAcademique);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnM);
            this.Name = "frmClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Classes";
            this.Load += new System.EventHandler(this.frmClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgClasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlibelle;
        private System.Windows.Forms.ComboBox cbbAnneeAcademique;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnM;
    }
}