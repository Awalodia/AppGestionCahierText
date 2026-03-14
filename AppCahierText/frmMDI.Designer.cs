namespace AppCahierText
{
    partial class frmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seConnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anneeAcademiqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syllabusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsSyllabusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsableDeClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.parametreToolStripMenuItem,
            this.securiteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seConnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // seConnecterToolStripMenuItem
            // 
            this.seConnecterToolStripMenuItem.Text = "Se déconnecter";
            this.seConnecterToolStripMenuItem.Click += new System.EventHandler(this.seConnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // parametreToolStripMenuItem
            // 
            this.parametreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matiereToolStripMenuItem,
            this.anneeAcademiqToolStripMenuItem,
            this.classeToolStripMenuItem,
            this.syllabusToolStripMenuItem,
            this.detailsSyllabusToolStripMenuItem});
            this.parametreToolStripMenuItem.Text = "Paramètre";
            // 
            // matiereToolStripMenuItem
            // 
            this.matiereToolStripMenuItem.Text = "Matière";
            this.matiereToolStripMenuItem.Click += new System.EventHandler(this.matiereToolStripMenuItem_Click);
            // 
            // anneeAcademiqToolStripMenuItem
            // 
            this.anneeAcademiqToolStripMenuItem.Text = "Année Académique";
            this.anneeAcademiqToolStripMenuItem.Click += new System.EventHandler(this.anneeAcademiqToolStripMenuItem_Click);
            // 
            // classeToolStripMenuItem
            // 
            this.classeToolStripMenuItem.Text = "Classe";
            this.classeToolStripMenuItem.Click += new System.EventHandler(this.classeToolStripMenuItem_Click);
            // 
            // syllabusToolStripMenuItem
            // 
            this.syllabusToolStripMenuItem.Text = "Syllabus";
            this.syllabusToolStripMenuItem.Click += new System.EventHandler(this.syllabusToolStripMenuItem_Click);
            // 
            // detailsSyllabusToolStripMenuItem
            // 
            this.detailsSyllabusToolStripMenuItem.Text = "Détails Syllabus";
            this.detailsSyllabusToolStripMenuItem.Click += new System.EventHandler(this.detailsSyllabusToolStripMenuItem_Click);
            // 
            // securiteToolStripMenuItem
            // 
            this.securiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem,
            this.responsableDeClasseToolStripMenuItem});
            this.securiteToolStripMenuItem.Text = "Sécurité";
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Text = "Utilisateurs";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // responsableDeClasseToolStripMenuItem
            // 
            this.responsableDeClasseToolStripMenuItem.Text = "Responsable Classe";
            this.responsableDeClasseToolStripMenuItem.Click += new System.EventHandler(this.responsableDeClasseToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Cahier de Texte";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seConnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anneeAcademiqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syllabusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsSyllabusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsableDeClasseToolStripMenuItem;
    }
}