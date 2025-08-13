namespace Comptabilite
{
    partial class TeleliquidationPersonneDetailForm
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
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            rdbDocArrive = new RadioButton();
            rdbDocEnCours = new RadioButton();
            rdbDocNonArrive = new RadioButton();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            rdbSaisieFait = new RadioButton();
            rdbSaisieEnCours = new RadioButton();
            rdbSaisieNonFait = new RadioButton();
            tabPage3 = new TabPage();
            groupBox3 = new GroupBox();
            rdbDeclarationFait = new RadioButton();
            rdbDeclarationEnCours = new RadioButton();
            rdbDeclarationNonFait = new RadioButton();
            tabPage4 = new TabPage();
            groupBox4 = new GroupBox();
            txtMontant = new TextBox();
            label2 = new Label();
            rdbPaiementFait = new RadioButton();
            rdbPaiementEnCours = new RadioButton();
            rdbPaiementNonFait = new RadioButton();
            tabPage5 = new TabPage();
            groupBox5 = new GroupBox();
            txtNumeroRecu = new TextBox();
            label3 = new Label();
            rdbRecu = new RadioButton();
            rdbRecuEnAttente = new RadioButton();
            rdbRecuNonRecu = new RadioButton();
            btnSave = new Button();
            btnCancel = new Button();
            lblPersonneName = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage5.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // tabControl
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Controls.Add(tabPage5);
            tabControl.Location = new Point(16, 62);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(667, 462);
            // tabPage1
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(659, 429);
            tabPage1.Text = "Document";
            tabPage1.UseVisualStyleBackColor = true;
            // groupBox1
            groupBox1.Controls.Add(rdbDocArrive);
            groupBox1.Controls.Add(rdbDocEnCours);
            groupBox1.Controls.Add(rdbDocNonArrive);
            groupBox1.Location = new Point(27, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 169);
            groupBox1.TabStop = false;
            groupBox1.Text = "État du Document";
            // rdbDocArrive
            rdbDocArrive.AutoSize = true;
            rdbDocArrive.Location = new Point(27, 46);
            rdbDocArrive.Name = "rdbDocArrive";
            rdbDocArrive.Size = new Size(69, 24);
            rdbDocArrive.TabIndex = 0;
            rdbDocArrive.TabStop = true;
            rdbDocArrive.Text = "Arrivé";
            rdbDocArrive.UseVisualStyleBackColor = true;
            // rdbDocEnCours
            rdbDocEnCours.AutoSize = true;
            rdbDocEnCours.Location = new Point(27, 92);
            rdbDocEnCours.Name = "rdbDocEnCours";
            rdbDocEnCours.Size = new Size(87, 24);
            rdbDocEnCours.TabIndex = 1;
            rdbDocEnCours.TabStop = true;
            rdbDocEnCours.Text = "En Cours";
            rdbDocEnCours.UseVisualStyleBackColor = true;
            // rdbDocNonArrive
            rdbDocNonArrive.AutoSize = true;
            rdbDocNonArrive.Location = new Point(27, 138);
            rdbDocNonArrive.Name = "rdbDocNonArrive";
            rdbDocNonArrive.Size = new Size(101, 24);
            rdbDocNonArrive.TabIndex = 2;
            rdbDocNonArrive.TabStop = true;
            rdbDocNonArrive.Text = "Non Arrivé";
            rdbDocNonArrive.UseVisualStyleBackColor = true;
            // tabPage2
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(659, 429);
            tabPage2.Text = "Saisie";
            tabPage2.UseVisualStyleBackColor = true;
            // groupBox2
            groupBox2.Controls.Add(rdbSaisieFait);
            groupBox2.Controls.Add(rdbSaisieEnCours);
            groupBox2.Controls.Add(rdbSaisieNonFait);
            groupBox2.Location = new Point(27, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(600, 173);
            groupBox2.TabStop = false;
            groupBox2.Text = "État de la Saisie";
            // rdbSaisieFait
            rdbSaisieFait.AutoSize = true;
            rdbSaisieFait.Location = new Point(27, 46);
            rdbSaisieFait.Name = "rdbSaisieFait";
            rdbSaisieFait.Size = new Size(53, 24);
            rdbSaisieFait.TabIndex = 0;
            rdbSaisieFait.TabStop = true;
            rdbSaisieFait.Text = "Fait";
            rdbSaisieFait.UseVisualStyleBackColor = true;
            // rdbSaisieEnCours
            rdbSaisieEnCours.AutoSize = true;
            rdbSaisieEnCours.Location = new Point(27, 92);
            rdbSaisieEnCours.Name = "rdbSaisieEnCours";
            rdbSaisieEnCours.Size = new Size(87, 24);
            rdbSaisieEnCours.TabIndex = 1;
            rdbSaisieEnCours.TabStop = true;
            rdbSaisieEnCours.Text = "En Cours";
            rdbSaisieEnCours.UseVisualStyleBackColor = true;
            // rdbSaisieNonFait
            rdbSaisieNonFait.AutoSize = true;
            rdbSaisieNonFait.Location = new Point(27, 138);
            rdbSaisieNonFait.Name = "rdbSaisieNonFait";
            rdbSaisieNonFait.Size = new Size(85, 24);
            rdbSaisieNonFait.TabIndex = 2;
            rdbSaisieNonFait.TabStop = true;
            rdbSaisieNonFait.Text = "Non Fait";
            rdbSaisieNonFait.UseVisualStyleBackColor = true;
            // tabPage3
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(659, 429);
            tabPage3.Text = "Déclaration";
            tabPage3.UseVisualStyleBackColor = true;
            // groupBox3
            groupBox3.Controls.Add(rdbDeclarationFait);
            groupBox3.Controls.Add(rdbDeclarationEnCours);
            groupBox3.Controls.Add(rdbDeclarationNonFait);
            groupBox3.Location = new Point(27, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(600, 175);
            groupBox3.TabStop = false;
            groupBox3.Text = "État de la Déclaration";
            // rdbDeclarationFait
            rdbDeclarationFait.AutoSize = true;
            rdbDeclarationFait.Location = new Point(27, 46);
            rdbDeclarationFait.Name = "rdbDeclarationFait";
            rdbDeclarationFait.Size = new Size(53, 24);
            rdbDeclarationFait.TabIndex = 0;
            rdbDeclarationFait.TabStop = true;
            rdbDeclarationFait.Text = "Fait";
            rdbDeclarationFait.UseVisualStyleBackColor = true;
            // rdbDeclarationEnCours
            rdbDeclarationEnCours.AutoSize = true;
            rdbDeclarationEnCours.Location = new Point(27, 92);
            rdbDeclarationEnCours.Name = "rdbDeclarationEnCours";
            rdbDeclarationEnCours.Size = new Size(87, 24);
            rdbDeclarationEnCours.TabIndex = 1;
            rdbDeclarationEnCours.TabStop = true;
            rdbDeclarationEnCours.Text = "En Cours";
            rdbDeclarationEnCours.UseVisualStyleBackColor = true;
            // rdbDeclarationNonFait
            rdbDeclarationNonFait.AutoSize = true;
            rdbDeclarationNonFait.Location = new Point(27, 138);
            rdbDeclarationNonFait.Name = "rdbDeclarationNonFait";
            rdbDeclarationNonFait.Size = new Size(85, 24);
            rdbDeclarationNonFait.TabIndex = 2;
            rdbDeclarationNonFait.TabStop = true;
            rdbDeclarationNonFait.Text = "Non Fait";
            rdbDeclarationNonFait.UseVisualStyleBackColor = true;
            // tabPage4
            tabPage4.Controls.Add(groupBox4);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(659, 429);
            tabPage4.Text = "Paiement";
            tabPage4.UseVisualStyleBackColor = true;
            // groupBox4
            groupBox4.Controls.Add(txtMontant);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(rdbPaiementFait);
            groupBox4.Controls.Add(rdbPaiementEnCours);
            groupBox4.Controls.Add(rdbPaiementNonFait);
            groupBox4.Location = new Point(27, 31);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(600, 220);
            groupBox4.TabStop = false;
            groupBox4.Text = "État du Paiement";
            // txtMontant
            txtMontant.Location = new Point(133, 100);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(199, 27);
            // label2
            label2.AutoSize = true;
            label2.Location = new Point(27, 104);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.Text = "Montant:";
            // rdbPaiementFait
            rdbPaiementFait.AutoSize = true;
            rdbPaiementFait.Location = new Point(27, 46);
            rdbPaiementFait.Name = "rdbPaiementFait";
            rdbPaiementFait.Size = new Size(53, 24);
            rdbPaiementFait.TabIndex = 0;
            rdbPaiementFait.TabStop = true;
            rdbPaiementFait.Text = "Fait";
            rdbPaiementFait.UseVisualStyleBackColor = true;
            // rdbPaiementEnCours
            rdbPaiementEnCours.AutoSize = true;
            rdbPaiementEnCours.Location = new Point(120, 46);
            rdbPaiementEnCours.Name = "rdbPaiementEnCours";
            rdbPaiementEnCours.Size = new Size(87, 24);
            rdbPaiementEnCours.TabIndex = 1;
            rdbPaiementEnCours.TabStop = true;
            rdbPaiementEnCours.Text = "En Cours";
            rdbPaiementEnCours.UseVisualStyleBackColor = true;
            // rdbPaiementNonFait
            rdbPaiementNonFait.AutoSize = true;
            rdbPaiementNonFait.Location = new Point(230, 46);
            rdbPaiementNonFait.Name = "rdbPaiementNonFait";
            rdbPaiementNonFait.Size = new Size(85, 24);
            rdbPaiementNonFait.TabIndex = 2;
            rdbPaiementNonFait.TabStop = true;
            rdbPaiementNonFait.Text = "Non Fait";
            rdbPaiementNonFait.UseVisualStyleBackColor = true;
            // tabPage5
            tabPage5.Controls.Add(groupBox5);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(659, 429);
            tabPage5.Text = "Reçu";
            tabPage5.UseVisualStyleBackColor = true;
            // groupBox5
            groupBox5.Controls.Add(txtNumeroRecu);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(rdbRecu);
            groupBox5.Controls.Add(rdbRecuEnAttente);
            groupBox5.Controls.Add(rdbRecuNonRecu);
            groupBox5.Location = new Point(27, 31);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(600, 231);
            groupBox5.TabStop = false;
            groupBox5.Text = "État du Reçu";
            // txtNumeroRecu
            txtNumeroRecu.Location = new Point(133, 138);
            txtNumeroRecu.Name = "txtNumeroRecu";
            txtNumeroRecu.Size = new Size(265, 27);
            // label3
            label3.AutoSize = true;
            label3.Location = new Point(27, 143);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.Text = "Numéro Reçu:";
            // rdbRecu
            rdbRecu.AutoSize = true;
            rdbRecu.Location = new Point(27, 46);
            rdbRecu.Name = "rdbRecu";
            rdbRecu.Size = new Size(62, 24);
            rdbRecu.TabIndex = 0;
            rdbRecu.TabStop = true;
            rdbRecu.Text = "Reçu";
            rdbRecu.UseVisualStyleBackColor = true;
            // rdbRecuEnAttente
            rdbRecuEnAttente.AutoSize = true;
            rdbRecuEnAttente.Location = new Point(120, 46);
            rdbRecuEnAttente.Name = "rdbRecuEnAttente";
            rdbRecuEnAttente.Size = new Size(99, 24);
            rdbRecuEnAttente.TabIndex = 1;
            rdbRecuEnAttente.TabStop = true;
            rdbRecuEnAttente.Text = "En Attente";
            rdbRecuEnAttente.UseVisualStyleBackColor = true;
            // rdbRecuNonRecu
            rdbRecuNonRecu.AutoSize = true;
            rdbRecuNonRecu.Location = new Point(230, 46);
            rdbRecuNonRecu.Name = "rdbRecuNonRecu";
            rdbRecuNonRecu.Size = new Size(94, 24);
            rdbRecuNonRecu.TabIndex = 2;
            rdbRecuNonRecu.TabStop = true;
            rdbRecuNonRecu.Text = "Non Reçu";
            rdbRecuNonRecu.UseVisualStyleBackColor = true;
            // btnSave
            btnSave.Location = new Point(467, 538);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 46);
            btnSave.TabIndex = 1;
            btnSave.Text = "Enregistrer";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // btnCancel
            btnCancel.Location = new Point(587, 538);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 46);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // lblPersonneName
            lblPersonneName.AutoSize = true;
            lblPersonneName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonneName.Location = new Point(16, 15);
            lblPersonneName.Name = "lblPersonneName";
            lblPersonneName.Size = new Size(0, 20);
            // form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 600);
            Controls.Add(lblPersonneName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TeleliquidationPersonneDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Détails Téléliquidation Personne";
            Load += TeleliquidationPersonneDetailForm_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabPage4.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage5.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDocArrive;
        private System.Windows.Forms.RadioButton rdbDocEnCours;
        private System.Windows.Forms.RadioButton rdbDocNonArrive;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbSaisieFait;
        private System.Windows.Forms.RadioButton rdbSaisieEnCours;
        private System.Windows.Forms.RadioButton rdbSaisieNonFait;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbDeclarationFait;
        private System.Windows.Forms.RadioButton rdbDeclarationEnCours;
        private System.Windows.Forms.RadioButton rdbDeclarationNonFait;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbPaiementFait;
        private System.Windows.Forms.RadioButton rdbPaiementEnCours;
        private System.Windows.Forms.RadioButton rdbPaiementNonFait;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNumeroRecu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbRecu;
        private System.Windows.Forms.RadioButton rdbRecuEnAttente;
        private System.Windows.Forms.RadioButton rdbRecuNonRecu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPersonneName;
    }
}