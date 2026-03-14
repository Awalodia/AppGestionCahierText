namespace AppCahierText.Views.Parametre
{
    partial class frmMatiere
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSyllabus = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtNiveau = new System.Windows.Forms.TextBox();
            this.cbbSyllabus = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(212, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(560, 426);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.Text = "Libellé";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(12, 28);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(182, 20);
            this.txtLibelle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.Text = "Volume horaire";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(12, 76);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(182, 20);
            this.txtVolume.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.Text = "Niveau";
            // 
            // txtNiveau
            // 
            this.txtNiveau.Location = new System.Drawing.Point(12, 124);
            this.txtNiveau.Name = "txtNiveau";
            this.txtNiveau.Size = new System.Drawing.Size(182, 20);
            this.txtNiveau.TabIndex = 3;
            // 
            // labelSyllabus
            // 
            this.labelSyllabus.AutoSize = true;
            this.labelSyllabus.Location = new System.Drawing.Point(12, 156);
            this.labelSyllabus.Name = "labelSyllabus";
            this.labelSyllabus.Size = new System.Drawing.Size(46, 13);
            this.labelSyllabus.Text = "Syllabus";
            // 
            // cbbSyllabus
            // 
            this.cbbSyllabus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSyllabus.FormattingEnabled = true;
            this.cbbSyllabus.Location = new System.Drawing.Point(12, 172);
            this.cbbSyllabus.Name = "cbbSyllabus";
            this.cbbSyllabus.Size = new System.Drawing.Size(182, 21);
            this.cbbSyllabus.TabIndex = 4;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 210);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(182, 30);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(12, 246);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(182, 30);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(12, 282);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(182, 30);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(12, 318);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(182, 30);
            this.btnEffacer.TabIndex = 8;
            this.btnEffacer.Text = "Vider / Nouveau";
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click_1);
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(12, 365);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(182, 30);
            this.btnImprimer.TabIndex = 9;
            this.btnImprimer.Text = "Imprimer la liste";
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // frmMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.labelSyllabus);
            this.Controls.Add(this.cbbSyllabus);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNiveau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMatiere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramétrage des Matières";
            this.Load += new System.EventHandler(this.frmMatiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSyllabus;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtNiveau;
        private System.Windows.Forms.ComboBox cbbSyllabus;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnEffacer;
    }
}