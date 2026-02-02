namespace AppCahierText
{
    partial class frmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.txtIdentifiant = new System.Windows.Forms.TextBox();
			this.btnQuitter = new System.Windows.Forms.Button();
			this.btnSeConnecter = new System.Windows.Forms.Button();
			this.txtMotDePasse = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(72, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Identifiant";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtIdentifiant
			// 
			this.txtIdentifiant.Location = new System.Drawing.Point(76, 50);
			this.txtIdentifiant.Name = "txtIdentifiant";
			this.txtIdentifiant.Size = new System.Drawing.Size(256, 26);
			this.txtIdentifiant.TabIndex = 1;
			// 
			// btnQuitter
			// 
			this.btnQuitter.Location = new System.Drawing.Point(76, 282);
			this.btnQuitter.Name = "btnQuitter";
			this.btnQuitter.Size = new System.Drawing.Size(123, 59);
			this.btnQuitter.TabIndex = 4;
			this.btnQuitter.Text = "&Quitter";
			this.btnQuitter.UseVisualStyleBackColor = true;
			this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
			// 
			// btnSeConnecter
			// 
			this.btnSeConnecter.Location = new System.Drawing.Point(320, 282);
			this.btnSeConnecter.Name = "btnSeConnecter";
			this.btnSeConnecter.Size = new System.Drawing.Size(115, 59);
			this.btnSeConnecter.TabIndex = 3;
			this.btnSeConnecter.Text = "&Se connecter";
			this.btnSeConnecter.UseVisualStyleBackColor = true;
			this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
			// 
			// txtMotDePasse
			// 
			this.txtMotDePasse.Location = new System.Drawing.Point(76, 183);
			this.txtMotDePasse.Name = "txtMotDePasse";
			this.txtMotDePasse.Size = new System.Drawing.Size(256, 26);
			this.txtMotDePasse.TabIndex = 2;
			this.txtMotDePasse.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(72, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Mot de passe";
			// 
			// frmConnexion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(512, 450);
			this.ControlBox = false;
			this.Controls.Add(this.txtMotDePasse);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSeConnecter);
			this.Controls.Add(this.btnQuitter);
			this.Controls.Add(this.txtIdentifiant);
			this.Controls.Add(this.label1);
			this.Name = "frmConnexion";
			this.Text = "Gestion de cahier de texte";
			this.Load += new System.EventHandler(this.frmConnexion_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label label2;
    }
}

