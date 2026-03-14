namespace AppCahierText.Views.Parametre
{
    partial class FrmDetailsSyllabus
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

            // lblSyllabus
            this.lblSyllabus.AutoSize = true;
            this.lblSyllabus.Location = new System.Drawing.Point(18, 15);
            this.lblSyllabus.Name = "lblSyllabus";
            this.lblSyllabus.TabIndex = 0;
            this.lblSyllabus.Text = "Syllabus";

            // cbbSyllabus
            this.cbbSyllabus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSyllabus.FormattingEnabled = true;
            this.cbbSyllabus.Location = new System.Drawing.Point(18, 33);
            this.cbbSyllabus.Name = "cbbSyllabus";
            this.cbbSyllabus.Size = new System.Drawing.Size(200, 21);
            this.cbbSyllabus.TabIndex = 1;

            // lblSeance
            this.lblSeance.AutoSize = true;
            this.lblSeance.Location = new System.Drawing.Point(18, 70);
            this.lblSeance.Name = "lblSeance";
            this.lblSeance.TabIndex = 2;
            this.lblSeance.Text = "Séance";

            // txtSeance
            this.txtSeance.Location = new System.Drawing.Point(18, 88);
            this.txtSeance.Name = "txtSeance";
            this.txtSeance.Size = new System.Drawing.Size(200, 20);
            this.txtSeance.TabIndex = 3;
            this.txtSeance.MaxLength = 10;

            // lblContenu
            this.lblContenu.AutoSize = true;
            this.lblContenu.Location = new System.Drawing.Point(18, 120);
            this.lblContenu.Name = "lblContenu";
            this.lblContenu.TabIndex = 4;
            this.lblContenu.Text = "Contenu";

            // txtContenu
            this.txtContenu.Location = new System.Drawing.Point(18, 138);
            this.txtContenu.Name = "txtContenu";
            this.txtContenu.Size = new System.Drawing.Size(200, 80);
            this.txtContenu.TabIndex = 5;
            this.txtContenu.MaxLength = 500;
            this.txtContenu.Multiline = true;

            // btnAjouter
            this.btnAjouter.Location = new System.Drawing.Point(18, 240);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(200, 28);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);

            // btnModifier
            this.btnModifier.Location = new System.Drawing.Point(18, 278);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(200, 28);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);

            // btnSupprimer
            this.btnSupprimer.Location = new System.Drawing.Point(18, 316);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(200, 28);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);

            // btnEffacer
            this.btnEffacer.Location = new System.Drawing.Point(18, 354);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(200, 28);
            this.btnEffacer.TabIndex = 9;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);

            // dgDetailsSyllabus
            this.dgDetailsSyllabus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetailsSyllabus.Location = new System.Drawing.Point(240, 15);
            this.dgDetailsSyllabus.Name = "dgDetailsSyllabus";
            this.dgDetailsSyllabus.Size = new System.Drawing.Size(740, 400);
            this.dgDetailsSyllabus.TabIndex = 10;
            this.dgDetailsSyllabus.ReadOnly = true;
            this.dgDetailsSyllabus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetailsSyllabus.MultiSelect = false;
            this.dgDetailsSyllabus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetailsSyllabus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetailsSyllabus_CellClick);

            // FrmDetailsSyllabus
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.ControlBox = false;
            this.Name = "FrmDetailsSyllabus";
            this.Text = "Gestion des Détails Syllabus";
            this.Load += new System.EventHandler(this.FrmDetailsSyllabus_Load);

            this.Controls.Add(this.lblSyllabus);
            this.Controls.Add(this.cbbSyllabus);
            this.Controls.Add(this.lblSeance);
            this.Controls.Add(this.txtSeance);
            this.Controls.Add(this.lblContenu);
            this.Controls.Add(this.txtContenu);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.dgDetailsSyllabus);

            ((System.ComponentModel.ISupportInitialize)(this.dgDetailsSyllabus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

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