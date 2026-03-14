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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cahierTexteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsCahierTexteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsableDeClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

           
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.parametreToolStripMenuItem,
            this.securiteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";

         
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seConnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";

          
            this.seConnecterToolStripMenuItem.Name = "seConnecterToolStripMenuItem";
            this.seConnecterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seConnecterToolStripMenuItem.Text = "Se déconnecter";
            this.seConnecterToolStripMenuItem.Click += new System.EventHandler(this.seConnecterToolStripMenuItem_Click);

            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);

        
            this.parametreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matiereToolStripMenuItem,
            this.anneeAcademiqToolStripMenuItem,
            this.classeToolStripMenuItem,
            this.syllabusToolStripMenuItem,
            this.detailsSyllabusToolStripMenuItem,
            this.toolStripSeparator1,
            this.cahierTexteToolStripMenuItem,
            this.detailsCahierTexteToolStripMenuItem});
            this.parametreToolStripMenuItem.Name = "parametreToolStripMenuItem";
            this.parametreToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.parametreToolStripMenuItem.Text = "Paramètre";

          
            this.matiereToolStripMenuItem.Name = "matiereToolStripMenuItem";
            this.matiereToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.matiereToolStripMenuItem.Text = "Matière";
            this.matiereToolStripMenuItem.Click += new System.EventHandler(this.matiereToolStripMenuItem_Click);

            
            this.anneeAcademiqToolStripMenuItem.Name = "anneeAcademiqToolStripMenuItem";
            this.anneeAcademiqToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.anneeAcademiqToolStripMenuItem.Text = "Année Académique";
            this.anneeAcademiqToolStripMenuItem.Click += new System.EventHandler(this.anneeAcademiqToolStripMenuItem_Click);

        
            this.classeToolStripMenuItem.Name = "classeToolStripMenuItem";
            this.classeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.classeToolStripMenuItem.Text = "Classe";
            this.classeToolStripMenuItem.Click += new System.EventHandler(this.classeToolStripMenuItem_Click);

          
            this.syllabusToolStripMenuItem.Name = "syllabusToolStripMenuItem";
            this.syllabusToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.syllabusToolStripMenuItem.Text = "Syllabus";
            this.syllabusToolStripMenuItem.Click += new System.EventHandler(this.syllabusToolStripMenuItem_Click);

           
            this.detailsSyllabusToolStripMenuItem.Name = "detailsSyllabusToolStripMenuItem";
            this.detailsSyllabusToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.detailsSyllabusToolStripMenuItem.Text = "Détails Syllabus";
            this.detailsSyllabusToolStripMenuItem.Click += new System.EventHandler(this.detailsSyllabusToolStripMenuItem_Click);

          
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);

            
           
            this.cahierTexteToolStripMenuItem.Name = "cahierTexteToolStripMenuItem";
            this.cahierTexteToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.cahierTexteToolStripMenuItem.Text = "Cahier de Texte";
            this.cahierTexteToolStripMenuItem.Click += new System.EventHandler(this.cahierTexteToolStripMenuItem_Click);

         
            this.detailsCahierTexteToolStripMenuItem.Name = "detailsCahierTexteToolStripMenuItem";
            this.detailsCahierTexteToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.detailsCahierTexteToolStripMenuItem.Text = "Détails Cahier de Texte";
            this.detailsCahierTexteToolStripMenuItem.Click += new System.EventHandler(this.detailsCahierTexteToolStripMenuItem_Click);

            
            this.securiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem,
            this.responsableDeClasseToolStripMenuItem});
            this.securiteToolStripMenuItem.Name = "securiteToolStripMenuItem";
            this.securiteToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.securiteToolStripMenuItem.Text = "Sécurité";

           
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.utilisateurToolStripMenuItem.Text = "Utilisateurs";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);

            this.responsableDeClasseToolStripMenuItem.Name = "responsableDeClasseToolStripMenuItem";
            this.responsableDeClasseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.responsableDeClasseToolStripMenuItem.Text = "Responsable Classe";
            this.responsableDeClasseToolStripMenuItem.Click += new System.EventHandler(this.responsableDeClasseToolStripMenuItem_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Cahier de Texte - Application MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cahierTexteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsCahierTexteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsableDeClasseToolStripMenuItem;
    }
}