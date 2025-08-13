namespace Comptabilite
{
    partial class TeleliquidationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeleliquidationForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddSociete = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblMois = new System.Windows.Forms.Label();
            this.cmbMois = new System.Windows.Forms.ComboBox();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.numAnnee = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnnee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(240 , 240 , 240);
            this.dataGridView.Location = new System.Drawing.Point(20, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(984, 340);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(0,122, 204);
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(20, 450);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Actualiser";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddSociete
            // 
            this.btnAddSociete.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnAddSociete.FlatAppearance.BorderSize = 0;
            this.btnAddSociete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSociete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSociete.ForeColor = System.Drawing.Color.White;
            this.btnAddSociete.Location = new System.Drawing.Point(130, 450);
            this.btnAddSociete.Name = "btnAddSociete";
            this.btnAddSociete.Size = new System.Drawing.Size(150, 30);
            this.btnAddSociete.TabIndex = 2;
            this.btnAddSociete.Text = "Ajouter Société";
            this.btnAddSociete.UseVisualStyleBackColor = false;
            this.btnAddSociete.Click += new System.EventHandler(this.btnAddSociete_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnRetour.FlatAppearance.BorderSize = 0;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(904, 450);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(100, 30);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 21);
            this.lblWelcome.TabIndex = 4;
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMois.Location = new System.Drawing.Point(20, 60);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(36, 15);
            this.lblMois.TabIndex = 5;
            this.lblMois.Text = "Mois:";
            // 
            // cmbMois
            // 
            this.cmbMois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMois.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMois.FormattingEnabled = true;
            this.cmbMois.Location = new System.Drawing.Point(60, 57);
            this.cmbMois.Name = "cmbMois";
            this.cmbMois.Size = new System.Drawing.Size(120, 23);
            this.cmbMois.TabIndex = 6;
            this.cmbMois.SelectedIndexChanged += new System.EventHandler(this.cmbMois_SelectedIndexChanged);
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnee.Location = new System.Drawing.Point(200, 60);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(43, 15);
            this.lblAnnee.TabIndex = 7;
            this.lblAnnee.Text = "Année:";
            // 
            // numAnnee
            // 
            this.numAnnee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAnnee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAnnee.Location = new System.Drawing.Point(250, 58);
            this.numAnnee.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numAnnee.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numAnnee.Name = "numAnnee";
            this.numAnnee.Size = new System.Drawing.Size(80, 23);
            this.numAnnee.TabIndex = 8;
            this.numAnnee.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numAnnee.ValueChanged += new System.EventHandler(this.numAnnee_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 5);
            this.panel1.TabIndex = 9;
            // 
            // TeleliquidationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numAnnee);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.cmbMois);
            this.Controls.Add(this.lblMois);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAddSociete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeleliquidationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tableau de Téléliquidation";
            this.Load += new System.EventHandler(this.TeleliquidationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAnnee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddSociete;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.ComboBox cmbMois;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.NumericUpDown numAnnee;
        private System.Windows.Forms.Panel panel1;
    }
}