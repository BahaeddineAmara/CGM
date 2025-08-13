namespace Comptabilite
{
    partial class PersonnesMoralesMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnesMoralesMenuForm));
            this.btnListeSocietes = new System.Windows.Forms.Button();
            this.btnTableTeledeclarations = new System.Windows.Forms.Button();
            this.btnTableTeleliquidation = new System.Windows.Forms.Button();
            this.btnTableReferencesFinancieres = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnListeSocietes
            // 
            this.btnListeSocietes.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnListeSocietes.FlatAppearance.BorderSize = 0;
            this.btnListeSocietes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeSocietes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeSocietes.ForeColor = System.Drawing.Color.White;
            this.btnListeSocietes.Location = new System.Drawing.Point(50, 150);
            this.btnListeSocietes.Name = "btnListeSocietes";
            this.btnListeSocietes.Size = new System.Drawing.Size(250, 80);
            this.btnListeSocietes.TabIndex = 0;
            this.btnListeSocietes.Text = "Liste des Sociétés";
            this.btnListeSocietes.UseVisualStyleBackColor = false;
            this.btnListeSocietes.Click += new System.EventHandler(this.btnListeSocietes_Click);
            // 
            // btnTableTeledeclarations
            // 
            this.btnTableTeledeclarations.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnTableTeledeclarations.FlatAppearance.BorderSize = 0;
            this.btnTableTeledeclarations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableTeledeclarations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableTeledeclarations.ForeColor = System.Drawing.Color.White;
            this.btnTableTeledeclarations.Location = new System.Drawing.Point(350, 150);
            this.btnTableTeledeclarations.Name = "btnTableTeledeclarations";
            this.btnTableTeledeclarations.Size = new System.Drawing.Size(250, 80);
            this.btnTableTeledeclarations.TabIndex = 1;
            this.btnTableTeledeclarations.Text = "Table de Télédéclarations";
            this.btnTableTeledeclarations.UseVisualStyleBackColor = false;
            this.btnTableTeledeclarations.Click += new System.EventHandler(this.btnTableTeledeclarations_Click);
            // 
            // btnTableTeleliquidation
            // 
            this.btnTableTeleliquidation.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnTableTeleliquidation.FlatAppearance.BorderSize = 0;
            this.btnTableTeleliquidation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableTeleliquidation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableTeleliquidation.ForeColor = System.Drawing.Color.White;
            this.btnTableTeleliquidation.Location = new System.Drawing.Point(50, 250);
            this.btnTableTeleliquidation.Name = "btnTableTeleliquidation";
            this.btnTableTeleliquidation.Size = new System.Drawing.Size(250, 80);
            this.btnTableTeleliquidation.TabIndex = 2;
            this.btnTableTeleliquidation.Text = "Table de Téléliquidation";
            this.btnTableTeleliquidation.UseVisualStyleBackColor = false;
            this.btnTableTeleliquidation.Click += new System.EventHandler(this.btnTableTeleliquidation_Click);
            // 
            // btnTableReferencesFinancieres
            // 
            this.btnTableReferencesFinancieres.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnTableReferencesFinancieres.FlatAppearance.BorderSize = 0;
            this.btnTableReferencesFinancieres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableReferencesFinancieres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableReferencesFinancieres.ForeColor = System.Drawing.Color.White;
            this.btnTableReferencesFinancieres.Location = new System.Drawing.Point(350, 250);
            this.btnTableReferencesFinancieres.Name = "btnTableReferencesFinancieres";
            this.btnTableReferencesFinancieres.Size = new System.Drawing.Size(250, 80);
            this.btnTableReferencesFinancieres.TabIndex = 3;
            this.btnTableReferencesFinancieres.Text = "Table de Recette Finance";
            this.btnTableReferencesFinancieres.UseVisualStyleBackColor = false;
            this.btnTableReferencesFinancieres.Click += new System.EventHandler(this.btnTableReferencesFinancieres_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(50, 350);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Retour";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblTitle.Location = new System.Drawing.Point(200, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 37);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Personnes Morales";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 5);
            this.panel1.TabIndex = 6;
            // 
            // PersonnesMoralesMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTableReferencesFinancieres);
            this.Controls.Add(this.btnTableTeleliquidation);
            this.Controls.Add(this.btnTableTeledeclarations);
            this.Controls.Add(this.btnListeSocietes);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonnesMoralesMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personnes Morales - Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnListeSocietes;
        private System.Windows.Forms.Button btnTableTeledeclarations;
        private System.Windows.Forms.Button btnTableTeleliquidation;
        private System.Windows.Forms.Button btnTableReferencesFinancieres;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
    }
} 