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
            this.imprimerMatiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem(); // <-- AJOUTÉ
            this.securiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsableDeClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.parametreToolStripMenuItem,
            this.securiteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;

            // Action Menu
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seConnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.actionToolStripMenuItem.Text = "&Action";

            this.seConnecterToolStripMenuItem.Text = "&Se deconnecter";
            this.seConnecterToolStripMenuItem.Click += new System.EventHandler(this.seConnecterToolStripMenuItem_Click);

            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);

            // Parametre Menu
            this.parametreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matiereToolStripMenuItem,
            this.anneeAcademiqToolStripMenuItem,
            this.classeToolStripMenuItem,
            new System.Windows.Forms.ToolStripSeparator(), // Petite ligne de séparation
            this.imprimerMatiereToolStripMenuItem}); // <-- AJOUTÉ AU MENU
            this.parametreToolStripMenuItem.Text = "&Parametre";

            this.matiereToolStripMenuItem.Text = "&Gestion des Matières";
            this.matiereToolStripMenuItem.Click += new System.EventHandler(this.matiereToolStripMenuItem_Click);

            this.anneeAcademiqToolStripMenuItem.Text = "&Annee Academique";
            this.anneeAcademiqToolStripMenuItem.Click += new System.EventHandler(this.anneeAcademiqToolStripMenuItem_Click);

            this.classeToolStripMenuItem.Text = "&Classe";
            this.classeToolStripMenuItem.Click += new System.EventHandler(this.classeToolStripMenuItem_Click);

            // Bouton Imprimer (Configuration)
            this.imprimerMatiereToolStripMenuItem.Name = "imprimerMatiereToolStripMenuItem";
            this.imprimerMatiereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimerMatiereToolStripMenuItem.Text = "&Imprimer Liste Matières";
            this.imprimerMatiereToolStripMenuItem.Click += new System.EventHandler(this.imprimerMatiereToolStripMenuItem_Click);

            // Securite Menu
            this.securiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.responsableDeClasseToolStripMenuItem});
            this.securiteToolStripMenuItem.Text = "Securite";

            this.responsableDeClasseToolStripMenuItem.Text = "Responsable de classe";
            this.responsableDeClasseToolStripMenuItem.Click += new System.EventHandler(this.responsableDeClasseToolStripMenuItem_Click);

            // frmMDI
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true; // IMPORTANT
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de cahier de texte";
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
        private System.Windows.Forms.ToolStripMenuItem imprimerMatiereToolStripMenuItem; // <-- DÉCLARÉ ICI
        private System.Windows.Forms.ToolStripMenuItem securiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsableDeClasseToolStripMenuItem;
    }
}