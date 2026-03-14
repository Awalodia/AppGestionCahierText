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
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.profil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label(); // Téléphone
            this.label6 = new System.Windows.Forms.Label(); // Identifiant
            this.label7 = new System.Windows.Forms.Label(); // Password
            this.label8 = new System.Windows.Forms.Label(); // Adresse
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilisateurs)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvUtilisateurs
            // 
            this.dgvUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilisateurs.Location = new System.Drawing.Point(320, 50);
            this.dgvUtilisateurs.Name = "dgvUtilisateurs";
            this.dgvUtilisateurs.Size = new System.Drawing.Size(630, 450);
            this.dgvUtilisateurs.TabIndex = 10;
            this.dgvUtilisateurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUtilisateurs_CellClick);

            // Labels et Textbox (Alignement Vertical)
            // Nom
            this.label1.Text = "Nom :";
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.txtNom.Location = new System.Drawing.Point(20, 50);
            this.txtNom.Size = new System.Drawing.Size(250, 20);

            // Prénom
            this.label2.Text = "Prénom :";
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.txtPrenom.Location = new System.Drawing.Point(20, 100);
            this.txtPrenom.Size = new System.Drawing.Size(250, 20);

            // Email
            this.label3.Text = "Email :";
            this.label3.Location = new System.Drawing.Point(20, 130);
            this.txtEmail.Location = new System.Drawing.Point(20, 150);
            this.txtEmail.Size = new System.Drawing.Size(250, 20);

            // Téléphone
            this.label5.Text = "Téléphone :";
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.txtTel.Location = new System.Drawing.Point(20, 200);
            this.txtTel.Size = new System.Drawing.Size(250, 20);

            // Adresse
            this.label8.Text = "Adresse :";
            this.label8.Location = new System.Drawing.Point(20, 230);
            this.txtAdresse.Location = new System.Drawing.Point(20, 250);
            this.txtAdresse.Size = new System.Drawing.Size(250, 20);

            // Identifiant
            this.label6.Text = "Identifiant (Login) :";
            this.label6.Location = new System.Drawing.Point(20, 280);
            this.txtIdentifiant.Location = new System.Drawing.Point(20, 300);
            this.txtIdentifiant.Size = new System.Drawing.Size(250, 20);

            // Password
            this.label7.Text = "Mot de passe :";
            this.label7.Location = new System.Drawing.Point(20, 330);
            this.txtPassword.Location = new System.Drawing.Point(20, 350);
            this.txtPassword.Size = new System.Drawing.Size(250, 20);
            this.txtPassword.UseSystemPasswordChar = true; // ✅ Masque les caractères

            // Profil
            this.label4.Text = "Profil :";
            this.label4.Location = new System.Drawing.Point(20, 380);
            this.profil.Location = new System.Drawing.Point(20, 400);
            this.profil.Size = new System.Drawing.Size(250, 21);
            this.profil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profil.Items.AddRange(new object[] { "ChefDepartement", "Enseignant", "Etudiant" });

            // Boutons
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Location = new System.Drawing.Point(20, 450);
            this.btnAjouter.Size = new System.Drawing.Size(80, 30);
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            this.btnModifier.Text = "Modifier";
            this.btnModifier.Location = new System.Drawing.Point(105, 450);
            this.btnModifier.Size = new System.Drawing.Size(80, 30);
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.Location = new System.Drawing.Point(190, 450);
            this.btnEffacer.Size = new System.Drawing.Size(80, 30);
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);

            // frmUtilisateurs
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnEffacer);
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
        private System.Windows.Forms.Button btnAjouter, btnModifier, btnEffacer;
    }
}