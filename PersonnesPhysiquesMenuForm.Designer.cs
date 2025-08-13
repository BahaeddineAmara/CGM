namespace Comptabilite
{
    partial class PersonnesPhysiquesMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnesPhysiquesMenuForm));
            this.btnListePersonnes = new System.Windows.Forms.Button();
            this.btnTableTeledeclaration = new System.Windows.Forms.Button();
            this.btnTableTeleliquidation = new System.Windows.Forms.Button();
            this.btnTableReferencesFinancieres = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnListePersonnes
            // 
            this.btnListePersonnes.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnListePersonnes.FlatAppearance.BorderSize = 0;
            this.btnListePersonnes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListePersonnes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListePersonnes.ForeColor = System.Drawing.Color.White;
            this.btnListePersonnes.Location = new System.Drawing.Point(50, 150);
            this.btnListePersonnes.Name = "btnListePersonnes";
            this.btnListePersonnes.Size = new System.Drawing.Size(250, 80);
            this.btnListePersonnes.TabIndex = 0;
            this.btnListePersonnes.Text = "Liste des Personnes";
            this.btnListePersonnes.UseVisualStyleBackColor = false;
            this.btnListePersonnes.Click += new System.EventHandler(this.btnListePersonnes_Click);
            // 
            // btnTableTeledeclaration
            // 
            this.btnTableTeledeclaration.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnTableTeledeclaration.FlatAppearance.BorderSize = 0;
            this.btnTableTeledeclaration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableTeledeclaration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableTeledeclaration.ForeColor = System.Drawing.Color.White;
            this.btnTableTeledeclaration.Location = new System.Drawing.Point(350, 150);
            this.btnTableTeledeclaration.Name = "btnTableTeledeclaration";
            this.btnTableTeledeclaration.Size = new System.Drawing.Size(250, 80);
            this.btnTableTeledeclaration.TabIndex = 1;
            this.btnTableTeledeclaration.Text = "Table de Télédéclaration";
            this.btnTableTeledeclaration.UseVisualStyleBackColor = false;
            this.btnTableTeledeclaration.Click += new System.EventHandler(this.btnTableTeledeclaration_Click);
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
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.lblTitle.Location = new System.Drawing.Point(200, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 37);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Personnes Physiques";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 5);
            this.panel1.TabIndex = 6;
            // 
            // PersonnesPhysiquesMenuForm
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
            this.Controls.Add(this.btnTableTeledeclaration);
            this.Controls.Add(this.btnListePersonnes);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonnesPhysiquesMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personnes Physiques - Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnListePersonnes;
        private System.Windows.Forms.Button btnTableTeledeclaration;
        private System.Windows.Forms.Button btnTableTeleliquidation;
        private System.Windows.Forms.Button btnTableReferencesFinancieres;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
    }
} 