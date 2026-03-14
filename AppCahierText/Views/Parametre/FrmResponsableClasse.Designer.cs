namespace AppCahierText.Views.Parametre
{
    partial class FrmResponsableClasse
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
            this.dgResponsableClasse = new System.Windows.Forms.DataGridView();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.cbbClasse = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgResponsableClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgResponsableClasse
            // 
            this.dgResponsableClasse.AllowUserToAddRows = false;
            this.dgResponsableClasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgResponsableClasse.Location = new System.Drawing.Point(260, 40);
            this.dgResponsableClasse.Name = "dgResponsableClasse";
            this.dgResponsableClasse.ReadOnly = true;
            this.dgResponsableClasse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgResponsableClasse.Size = new System.Drawing.Size(580, 400);
            this.dgResponsableClasse.TabIndex = 0;
            this.dgResponsableClasse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgResponsableClasse_CellClick);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(20, 40);
            this.txtNom.Size = new System.Drawing.Size(200, 20);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(20, 85);
            this.txtPrenom.Size = new System.Drawing.Size(200, 20);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(20, 130);
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(20, 175);
            this.txtTelephone.Size = new System.Drawing.Size(200, 20);
            // 
            // cbbClasse
            // 
            this.cbbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClasse.Location = new System.Drawing.Point(20, 225);
            this.cbbClasse.Size = new System.Drawing.Size(200, 21);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 270);
            this.btnAdd.Size = new System.Drawing.Size(95, 35);
            this.btnAdd.Text = "Enregistrer";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(125, 270);
            this.btnM.Size = new System.Drawing.Size(95, 35);
            this.btnM.Text = "Modifier";
            this.btnM.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // Labels
            // 
            this.label1.Text = "Nom :"; this.label1.Location = new System.Drawing.Point(20, 25);
            this.label2.Text = "Prénom :"; this.label2.Location = new System.Drawing.Point(20, 70);
            this.label3.Text = "Email :"; this.label3.Location = new System.Drawing.Point(20, 115);
            this.label4.Text = "Téléphone :"; this.label4.Location = new System.Drawing.Point(20, 160);
            this.label5.Text = "Classe :"; this.label5.Location = new System.Drawing.Point(20, 210);
            // 
            // FrmResponsableClasse
            // 
            this.ClientSize = new System.Drawing.Size(860, 460);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgResponsableClasse, this.txtNom, this.txtPrenom, this.txtEmail,
                this.txtTelephone, this.cbbClasse, this.btnAdd, this.btnM,
                this.label1, this.label2, this.label3, this.label4, this.label5
            });
            this.Name = "FrmResponsableClasse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Responsables";
            this.Load += new System.EventHandler(this.FrmResponsableClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResponsableClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgResponsableClasse;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.ComboBox cbbClasse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}