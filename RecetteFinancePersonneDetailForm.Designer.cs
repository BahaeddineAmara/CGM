namespace Comptabilite
{
    partial class RecetteFinancePersonneDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPersonneNom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDocumentNonArrive = new System.Windows.Forms.RadioButton();
            this.rbDocumentEnCours = new System.Windows.Forms.RadioButton();
            this.rbDocumentArrive = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSaisieNonFait = new System.Windows.Forms.RadioButton();
            this.rbSaisieEnCours = new System.Windows.Forms.RadioButton();
            this.rbSaisieFait = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDeclarationNonFait = new System.Windows.Forms.RadioButton();
            this.rbDeclarationEnCours = new System.Windows.Forms.RadioButton();
            this.rbDeclarationFait = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numMontant = new System.Windows.Forms.NumericUpDown();
            this.lblMontant = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbPaiementNonFait = new System.Windows.Forms.RadioButton();
            this.rbPaiementEnCours = new System.Windows.Forms.RadioButton();
            this.rbPaiementFait = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkDatePaiement = new System.Windows.Forms.CheckBox();
            this.dtpDatePaiement = new System.Windows.Forms.DateTimePicker();
            this.lblDatePaiement = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtNumeroRecu = new System.Windows.Forms.TextBox();
            this.lblNumeroRecu = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbRecuNonRecu = new System.Windows.Forms.RadioButton();
            this.rbRecuEnAttente = new System.Windows.Forms.RadioButton();
            this.rbRecuRecu = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMontant)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPersonneNom
            // 
            this.lblPersonneNom.AutoSize = true;
            this.lblPersonneNom.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonneNom.Location = new System.Drawing.Point(12, 9);
            this.lblPersonneNom.Name = "lblPersonneNom";
            this.lblPersonneNom.Size = new System.Drawing.Size(150, 25);
            this.lblPersonneNom.TabIndex = 0;
            this.lblPersonneNom.Text = "Nom de la Personne";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDocumentNonArrive);
            this.groupBox1.Controls.Add(this.rbDocumentEnCours);
            this.groupBox1.Controls.Add(this.rbDocumentArrive);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "État Document";
            // 
            // rbDocumentNonArrive
            // 
            this.rbDocumentNonArrive.AutoSize = true;
            this.rbDocumentNonArrive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDocumentNonArrive.Location = new System.Drawing.Point(200, 45);
            this.rbDocumentNonArrive.Name = "rbDocumentNonArrive";
            this.rbDocumentNonArrive.Size = new System.Drawing.Size(85, 19);
            this.rbDocumentNonArrive.TabIndex = 2;
            this.rbDocumentNonArrive.TabStop = true;
            this.rbDocumentNonArrive.Text = "Non Arrivé";
            this.rbDocumentNonArrive.UseVisualStyleBackColor = true;
            // 
            // rbDocumentEnCours
            // 
            this.rbDocumentEnCours.AutoSize = true;
            this.rbDocumentEnCours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDocumentEnCours.Location = new System.Drawing.Point(100, 45);
            this.rbDocumentEnCours.Name = "rbDocumentEnCours";
            this.rbDocumentEnCours.Size = new System.Drawing.Size(80, 19);
            this.rbDocumentEnCours.TabIndex = 1;
            this.rbDocumentEnCours.TabStop = true;
            this.rbDocumentEnCours.Text = "En Cours";
            this.rbDocumentEnCours.UseVisualStyleBackColor = true;
            // 
            // rbDocumentArrive
            // 
            this.rbDocumentArrive.AutoSize = true;
            this.rbDocumentArrive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDocumentArrive.Location = new System.Drawing.Point(20, 45);
            this.rbDocumentArrive.Name = "rbDocumentArrive";
            this.rbDocumentArrive.Size = new System.Drawing.Size(60, 19);
            this.rbDocumentArrive.TabIndex = 0;
            this.rbDocumentArrive.TabStop = true;
            this.rbDocumentArrive.Text = "Arrivé";
            this.rbDocumentArrive.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSaisieNonFait);
            this.groupBox2.Controls.Add(this.rbSaisieEnCours);
            this.groupBox2.Controls.Add(this.rbSaisieFait);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(330, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "État Saisie";
            // 
            // rbSaisieNonFait
            // 
            this.rbSaisieNonFait.AutoSize = true;
            this.rbSaisieNonFait.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSaisieNonFait.Location = new System.Drawing.Point(200, 45);
            this.rbSaisieNonFait.Name = "rbSaisieNonFait";
            this.rbSaisieNonFait.Size = new System.Drawing.Size(75, 19);
            this.rbSaisieNonFait.TabIndex = 2;
            this.rbSaisieNonFait.TabStop = true;
            this.rbSaisieNonFait.Text = "Non Fait";
            this.rbSaisieNonFait.UseVisualStyleBackColor = true;
            // 
            // rbSaisieEnCours
            // 
            this.rbSaisieEnCours.AutoSize = true;
            this.rbSaisieEnCours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSaisieEnCours.Location = new System.Drawing.Point(100, 45);
            this.rbSaisieEnCours.Name = "rbSaisieEnCours";
            this.rbSaisieEnCours.Size = new System.Drawing.Size(80, 19);
            this.rbSaisieEnCours.TabIndex = 1;
            this.rbSaisieEnCours.TabStop = true;
            this.rbSaisieEnCours.Text = "En Cours";
            this.rbSaisieEnCours.UseVisualStyleBackColor = true;
            // 
            // rbSaisieFait
            // 
            this.rbSaisieFait.AutoSize = true;
            this.rbSaisieFait.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSaisieFait.Location = new System.Drawing.Point(20, 45);
            this.rbSaisieFait.Name = "rbSaisieFait";
            this.rbSaisieFait.Size = new System.Drawing.Size(45, 19);
            this.rbSaisieFait.TabIndex = 0;
            this.rbSaisieFait.TabStop = true;
            this.rbSaisieFait.Text = "Fait";
            this.rbSaisieFait.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDeclarationNonFait);
            this.groupBox3.Controls.Add(this.rbDeclarationEnCours);
            this.groupBox3.Controls.Add(this.rbDeclarationFait);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(650, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "État Déclaration";
            // 
            // rbDeclarationNonFait
            // 
            this.rbDeclarationNonFait.AutoSize = true;
            this.rbDeclarationNonFait.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeclarationNonFait.Location = new System.Drawing.Point(200, 45);
            this.rbDeclarationNonFait.Name = "rbDeclarationNonFait";
            this.rbDeclarationNonFait.Size = new System.Drawing.Size(75, 19);
            this.rbDeclarationNonFait.TabIndex = 2;
            this.rbDeclarationNonFait.TabStop = true;
            this.rbDeclarationNonFait.Text = "Non Fait";
            this.rbDeclarationNonFait.UseVisualStyleBackColor = true;
            // 
            // rbDeclarationEnCours
            // 
            this.rbDeclarationEnCours.AutoSize = true;
            this.rbDeclarationEnCours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeclarationEnCours.Location = new System.Drawing.Point(100, 45);
            this.rbDeclarationEnCours.Name = "rbDeclarationEnCours";
            this.rbDeclarationEnCours.Size = new System.Drawing.Size(80, 19);
            this.rbDeclarationEnCours.TabIndex = 1;
            this.rbDeclarationEnCours.TabStop = true;
            this.rbDeclarationEnCours.Text = "En Cours";
            this.rbDeclarationEnCours.UseVisualStyleBackColor = true;
            // 
            // rbDeclarationFait
            // 
            this.rbDeclarationFait.AutoSize = true;
            this.rbDeclarationFait.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDeclarationFait.Location = new System.Drawing.Point(20, 45);
            this.rbDeclarationFait.Name = "rbDeclarationFait";
            this.rbDeclarationFait.Size = new System.Drawing.Size(45, 19);
            this.rbDeclarationFait.TabIndex = 0;
            this.rbDeclarationFait.TabStop = true;
            this.rbDeclarationFait.Text = "Fait";
            this.rbDeclarationFait.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numMontant);
            this.groupBox4.Controls.Add(this.lblMontant);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Montant";
            // 
            // numMontant
            // 
            this.numMontant.DecimalPlaces = 2;
            this.numMontant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMontant.Location = new System.Drawing.Point(20, 45);
            this.numMontant.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numMontant.Name = "numMontant";
            this.numMontant.Size = new System.Drawing.Size(200, 29);
            this.numMontant.TabIndex = 1;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(20, 25);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(55, 15);
            this.lblMontant.TabIndex = 0;
            this.lblMontant.Text = "Montant:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbPaiementNonFait);
            this.groupBox5.Controls.Add(this.rbPaiementEnCours);
            this.groupBox5.Controls.Add(this.rbPaiementFait);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(330, 170);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "État Paiement";
            // 
            // rbPaiementNonFait
            // 
            this.rbPaiementNonFait.AutoSize = true;
            this.rbPaiementNonFait.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaiementNonFait.Location = new System.Drawing.Point(200, 45);
            this.rbPaiementNonFait.Name = "rbPaiementNonFait";
            this.rbPaiementNonFait.Size = new System.Drawing.Size(75, 19);
            this.rbPaiementNonFait.TabIndex = 2;
            this.rbPaiementNonFait.TabStop = true;
            this.rbPaiementNonFait.Text = "Non Fait";
            this.rbPaiementNonFait.UseVisualStyleBackColor = true;
            // 
            // rbPaiementEnCours
            // 
            this.rbPaiementEnCours.AutoSize = true;
            this.rbPaiementEnCours.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaiementEnCours.Location = new System.Drawing.Point(100, 45);
            this.rbPaiementEnCours.Name = "rbPaiementEnCours";
            this.rbPaiementEnCours.Size = new System.Drawing.Size(80, 19);
            this.rbPaiementEnCours.TabIndex = 1;
            this.rbPaiementEnCours.TabStop = true;
            this.rbPaiementEnCours.Text = "En Cours";
            this.rbPaiementEnCours.UseVisualStyleBackColor = true;
            // 
            // rbPaiementFait
            // 
            this.rbPaiementFait.AutoSize = true;
            this.rbPaiementFait.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaiementFait.Location = new System.Drawing.Point(20, 45);
            this.rbPaiementFait.Name = "rbPaiementFait";
            this.rbPaiementFait.Size = new System.Drawing.Size(45, 19);
            this.rbPaiementFait.TabIndex = 0;
            this.rbPaiementFait.TabStop = true;
            this.rbPaiementFait.Text = "Fait";
            this.rbPaiementFait.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkDatePaiement);
            this.groupBox6.Controls.Add(this.dtpDatePaiement);
            this.groupBox6.Controls.Add(this.lblDatePaiement);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(650, 170);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(300, 100);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Date de Paiement";
            // 
            // chkDatePaiement
            // 
            this.chkDatePaiement.AutoSize = true;
            this.chkDatePaiement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDatePaiement.Location = new System.Drawing.Point(20, 25);
            this.chkDatePaiement.Name = "chkDatePaiement";
            this.chkDatePaiement.Size = new System.Drawing.Size(120, 19);
            this.chkDatePaiement.TabIndex = 2;
            this.chkDatePaiement.Text = "Date de paiement";
            this.chkDatePaiement.UseVisualStyleBackColor = true;
            this.chkDatePaiement.CheckedChanged += new System.EventHandler(this.chkDatePaiement_CheckedChanged);
            // 
            // dtpDatePaiement
            // 
            this.dtpDatePaiement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatePaiement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePaiement.Location = new System.Drawing.Point(20, 50);
            this.dtpDatePaiement.Name = "dtpDatePaiement";
            this.dtpDatePaiement.Size = new System.Drawing.Size(200, 29);
            this.dtpDatePaiement.TabIndex = 1;
            // 
            // lblDatePaiement
            // 
            this.lblDatePaiement.AutoSize = true;
            this.lblDatePaiement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePaiement.Location = new System.Drawing.Point(20, 25);
            this.lblDatePaiement.Name = "lblDatePaiement";
            this.lblDatePaiement.Size = new System.Drawing.Size(100, 15);
            this.lblDatePaiement.TabIndex = 0;
            this.lblDatePaiement.Text = "Date de paiement:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtNumeroRecu);
            this.groupBox7.Controls.Add(this.lblNumeroRecu);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(12, 290);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(300, 100);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Numéro Reçu";
            // 
            // txtNumeroRecu
            // 
            this.txtNumeroRecu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroRecu.Location = new System.Drawing.Point(20, 45);
            this.txtNumeroRecu.Name = "txtNumeroRecu";
            this.txtNumeroRecu.Size = new System.Drawing.Size(200, 29);
            this.txtNumeroRecu.TabIndex = 1;
            // 
            // lblNumeroRecu
            // 
            this.lblNumeroRecu.AutoSize = true;
            this.lblNumeroRecu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRecu.Location = new System.Drawing.Point(20, 25);
            this.lblNumeroRecu.Name = "lblNumeroRecu";
            this.lblNumeroRecu.Size = new System.Drawing.Size(85, 15);
            this.lblNumeroRecu.TabIndex = 0;
            this.lblNumeroRecu.Text = "Numéro reçu:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbRecuNonRecu);
            this.groupBox8.Controls.Add(this.rbRecuEnAttente);
            this.groupBox8.Controls.Add(this.rbRecuRecu);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(330, 290);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(300, 100);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "État Reçu";
            // 
            // rbRecuNonRecu
            // 
            this.rbRecuNonRecu.AutoSize = true;
            this.rbRecuNonRecu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecuNonRecu.Location = new System.Drawing.Point(200, 45);
            this.rbRecuNonRecu.Name = "rbRecuNonRecu";
            this.rbRecuNonRecu.Size = new System.Drawing.Size(80, 19);
            this.rbRecuNonRecu.TabIndex = 2;
            this.rbRecuNonRecu.TabStop = true;
            this.rbRecuNonRecu.Text = "Non Reçu";
            this.rbRecuNonRecu.UseVisualStyleBackColor = true;
            // 
            // rbRecuEnAttente
            // 
            this.rbRecuEnAttente.AutoSize = true;
            this.rbRecuEnAttente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecuEnAttente.Location = new System.Drawing.Point(100, 45);
            this.rbRecuEnAttente.Name = "rbRecuEnAttente";
            this.rbRecuEnAttente.Size = new System.Drawing.Size(85, 19);
            this.rbRecuEnAttente.TabIndex = 1;
            this.rbRecuEnAttente.TabStop = true;
            this.rbRecuEnAttente.Text = "En Attente";
            this.rbRecuEnAttente.UseVisualStyleBackColor = true;
            // 
            // rbRecuRecu
            // 
            this.rbRecuRecu.AutoSize = true;
            this.rbRecuRecu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRecuRecu.Location = new System.Drawing.Point(20, 45);
            this.rbRecuRecu.Name = "rbRecuRecu";
            this.rbRecuRecu.Size = new System.Drawing.Size(55, 19);
            this.rbRecuRecu.TabIndex = 0;
            this.rbRecuRecu.TabStop = true;
            this.rbRecuRecu.Text = "Reçu";
            this.rbRecuRecu.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(650, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(790, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RecetteFinancePersonneDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 411);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPersonneNom);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "RecetteFinancePersonneDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Détails Recette Finance - Personne";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMontant)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonneNom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDocumentNonArrive;
        private System.Windows.Forms.RadioButton rbDocumentEnCours;
        private System.Windows.Forms.RadioButton rbDocumentArrive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSaisieNonFait;
        private System.Windows.Forms.RadioButton rbSaisieEnCours;
        private System.Windows.Forms.RadioButton rbSaisieFait;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDeclarationNonFait;
        private System.Windows.Forms.RadioButton rbDeclarationEnCours;
        private System.Windows.Forms.RadioButton rbDeclarationFait;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numMontant;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbPaiementNonFait;
        private System.Windows.Forms.RadioButton rbPaiementEnCours;
        private System.Windows.Forms.RadioButton rbPaiementFait;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkDatePaiement;
        private System.Windows.Forms.DateTimePicker dtpDatePaiement;
        private System.Windows.Forms.Label lblDatePaiement;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtNumeroRecu;
        private System.Windows.Forms.Label lblNumeroRecu;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton rbRecuNonRecu;
        private System.Windows.Forms.RadioButton rbRecuEnAttente;
        private System.Windows.Forms.RadioButton rbRecuRecu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
} 