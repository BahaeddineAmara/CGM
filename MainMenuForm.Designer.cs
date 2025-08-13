namespace Comptabilite
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.btnPersonnesPhysiques = new System.Windows.Forms.Button();
            this.btnPersonnesMorales = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPersonnesPhysiques
            // 
            this.btnPersonnesPhysiques.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnPersonnesPhysiques.FlatAppearance.BorderSize = 0;
            this.btnPersonnesPhysiques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonnesPhysiques.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonnesPhysiques.ForeColor = System.Drawing.Color.White;
            this.btnPersonnesPhysiques.Location = new System.Drawing.Point(100, 200);
            this.btnPersonnesPhysiques.Name = "btnPersonnesPhysiques";
            this.btnPersonnesPhysiques.Size = new System.Drawing.Size(300, 80);
            this.btnPersonnesPhysiques.TabIndex = 0;
            this.btnPersonnesPhysiques.Text = "Personnes Physiques";
            this.btnPersonnesPhysiques.UseVisualStyleBackColor = false;
            this.btnPersonnesPhysiques.Click += new System.EventHandler(this.btnPersonnesPhysiques_Click);
            // 
            // btnPersonnesMorales
            // 
            this.btnPersonnesMorales.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnPersonnesMorales.FlatAppearance.BorderSize = 0;
            this.btnPersonnesMorales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonnesMorales.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonnesMorales.ForeColor = System.Drawing.Color.White;
            this.btnPersonnesMorales.Location = new System.Drawing.Point(450, 200);
            this.btnPersonnesMorales.Name = "btnPersonnesMorales";
            this.btnPersonnesMorales.Size = new System.Drawing.Size(300, 80);
            this.btnPersonnesMorales.TabIndex = 1;
            this.btnPersonnesMorales.Text = "Personnes Morales";
            this.btnPersonnesMorales.UseVisualStyleBackColor = false;
            this.btnPersonnesMorales.Click += new System.EventHandler(this.btnPersonnesMorales_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 21);
            this.lblWelcome.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(750, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Déconnexion";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 5);
            this.panel1.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.lblTitle.Location = new System.Drawing.Point(250, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 45);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Système de Comptabilité";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnPersonnesMorales);
            this.Controls.Add(this.btnPersonnesPhysiques);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal - Système de Comptabilité";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnPersonnesPhysiques;
        private System.Windows.Forms.Button btnPersonnesMorales;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
    }
} 