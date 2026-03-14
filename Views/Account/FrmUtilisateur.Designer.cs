namespace AppCahierText.Views.Account
{
    partial class frmUtilisateurs
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvUtilisateurs = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox(); // ✅ Déclaré
            this.txtAdresse = new System.Windows.Forms.TextBox(); // ✅ Déclaré
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.profil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).BeginInit();
            this.SuspendLayout();

            // Config DataGridView
            this.dgvUtilisateurs.Location = new System.Drawing.Point(300, 50);
            this.dgvUtilisateurs.Size = new System.Drawing.Size(650, 450);
            this.dgvUtilisateurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUtilisateurs_CellClick);

            // Placement des champs
            this.txtNom.Location = new System.Drawing.Point(20, 50);
            this.txtPrenom.Location = new System.Drawing.Point(20, 100);
            this.txtEmail.Location = new System.Drawing.Point(20, 150);
            this.txtTel.Location = new System.Drawing.Point(20, 200); // ✅ Ajouté
            this.txtAdresse.Location = new System.Drawing.Point(20, 250); // ✅ Ajouté

            this.label4.Text = "Profil :";
            this.label4.Location = new System.Drawing.Point(20, 280);
            this.profil.Location = new System.Drawing.Point(20, 300);
            this.profil.Items.AddRange(new object[] { "ChefDepartement", "Enseignant", "Etudiant" });

            // Boutons
            this.btnAjouter.Location = new System.Drawing.Point(20, 350);
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            this.btnModifier.Location = new System.Drawing.Point(105, 350);
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            this.btnEffacer.Location = new System.Drawing.Point(190, 350);
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);

            // Finalisation
            this.ClientSize = new System.Drawing.Size(980, 550);
            this.Controls.Add(this.dgvUtilisateurs);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.profil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnEffacer);
            this.Load += new System.EventHandler(this.frmUtilisateurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvUtilisateurs;
        private System.Windows.Forms.TextBox txtNom, txtPrenom, txtEmail, txtTel, txtIdentifiant, txtPassword, txtAdresse;
        private System.Windows.Forms.ComboBox profil;
        private System.Windows.Forms.Label label1, label2, label3, label4, label6, label7;
        private System.Windows.Forms.Button btnAjouter, btnModifier, btnEffacer;
    }
}