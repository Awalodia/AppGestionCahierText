namespace AppCahierText.Views.Account
{
    partial class frmUtilisateurs
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

        private void InitializeComponent()
        {
            this.dgvUtilisateurs = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.profil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvUtilisateurs
            // 
            this.dgvUtilisateurs.AllowUserToAddRows = false;
            this.dgvUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilisateurs.Location = new System.Drawing.Point(320, 50);
            this.dgvUtilisateurs.Name = "dgvUtilisateurs";
            this.dgvUtilisateurs.ReadOnly = true;
            this.dgvUtilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUtilisateurs.Size = new System.Drawing.Size(630, 450);
            this.dgvUtilisateurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUtilisateurs_CellClick);

            // Labels et TextBoxes
            this.label1.Text = "Nom :"; this.label1.Location = new System.Drawing.Point(20, 30);
            this.txtNom.Location = new System.Drawing.Point(20, 50); this.txtNom.Size = new System.Drawing.Size(250, 20);

            this.label2.Text = "Prénom :"; this.label2.Location = new System.Drawing.Point(20, 80);
            this.txtPrenom.Location = new System.Drawing.Point(20, 100); this.txtPrenom.Size = new System.Drawing.Size(250, 20);

            this.label3.Text = "Email :"; this.label3.Location = new System.Drawing.Point(20, 130);
            this.txtEmail.Location = new System.Drawing.Point(20, 150); this.txtEmail.Size = new System.Drawing.Size(250, 20);

            this.label4.Text = "Téléphone :"; this.label4.Location = new System.Drawing.Point(20, 180);
            this.txtTel.Location = new System.Drawing.Point(20, 200); this.txtTel.Size = new System.Drawing.Size(250, 20);

            this.label5.Text = "Adresse :"; this.label5.Location = new System.Drawing.Point(20, 230);
            this.txtAdresse.Location = new System.Drawing.Point(20, 250); this.txtAdresse.Size = new System.Drawing.Size(250, 20);

            this.label6.Text = "Identifiant :"; this.label6.Location = new System.Drawing.Point(20, 280);
            this.txtIdentifiant.Location = new System.Drawing.Point(20, 300); this.txtIdentifiant.Size = new System.Drawing.Size(250, 20);

            this.label7.Text = "Mot de passe :"; this.label7.Location = new System.Drawing.Point(20, 330);
            this.txtPassword.Location = new System.Drawing.Point(20, 350); this.txtPassword.Size = new System.Drawing.Size(250, 20);
            this.txtPassword.UseSystemPasswordChar = true;

            this.label8.Text = "Profil :"; this.label8.Location = new System.Drawing.Point(20, 380);
            this.profil.Location = new System.Drawing.Point(20, 400); this.profil.Size = new System.Drawing.Size(250, 21);
            this.profil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Bouton Ajouter
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Location = new System.Drawing.Point(20, 450);
            this.btnAjouter.Size = new System.Drawing.Size(70, 30);
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            // Bouton Modifier
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Location = new System.Drawing.Point(95, 450);
            this.btnModifier.Size = new System.Drawing.Size(70, 30);
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            // Bouton Vider
            this.btnEffacer.Text = "Vider";
            this.btnEffacer.Location = new System.Drawing.Point(170, 450);
            this.btnEffacer.Size = new System.Drawing.Size(70, 30);
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);

            // Bouton Supprimer
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Location = new System.Drawing.Point(245, 450);
            this.btnSupprimer.Size = new System.Drawing.Size(70, 30);
            this.btnSupprimer.BackColor = System.Drawing.Color.MistyRose;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(980, 550);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvUtilisateurs, this.txtNom, this.txtPrenom, this.txtEmail,
                this.txtTel, this.txtAdresse, this.txtIdentifiant, this.txtPassword,
                this.profil, this.label1, this.label2, this.label3, this.label4,
                this.label5, this.label6, this.label7, this.label8,
                this.btnAjouter, this.btnModifier, this.btnEffacer, this.btnSupprimer
            });
            this.Name = "frmUtilisateurs";
            this.Text = "Gestion des Utilisateurs";
            this.Load += new System.EventHandler(this.frmUtilisateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvUtilisateurs;
        private System.Windows.Forms.TextBox txtNom, txtPrenom, txtEmail, txtTel, txtIdentifiant, txtPassword, txtAdresse;
        private System.Windows.Forms.ComboBox profil;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7, label8;
        private System.Windows.Forms.Button btnAjouter, btnModifier, btnEffacer, btnSupprimer;
    }
}