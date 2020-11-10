namespace DMCooking
{
    partial class FormCommande
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
            this.dataGridViewRecette = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitre = new System.Windows.Forms.Label();
            this.buttonContinuer = new System.Windows.Forms.Button();
            this.labelCook = new System.Windows.Forms.Label();
            this.labelSolde = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecette)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRecette
            // 
            this.dataGridViewRecette.AllowUserToAddRows = false;
            this.dataGridViewRecette.AllowUserToDeleteRows = false;
            this.dataGridViewRecette.AllowUserToOrderColumns = true;
            this.dataGridViewRecette.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecette.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRecette.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecette.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Type,
            this.Prix});
            this.dataGridViewRecette.Location = new System.Drawing.Point(91, 80);
            this.dataGridViewRecette.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewRecette.Name = "dataGridViewRecette";
            this.dataGridViewRecette.ReadOnly = true;
            this.dataGridViewRecette.RowHeadersWidth = 51;
            this.dataGridViewRecette.RowTemplate.Height = 24;
            this.dataGridViewRecette.Size = new System.Drawing.Size(428, 317);
            this.dataGridViewRecette.TabIndex = 0;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.BackColor = System.Drawing.Color.Transparent;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(122, 28);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(382, 25);
            this.labelTitre.TabIndex = 2;
            this.labelTitre.Text = "Choisissez les recettes à commander :";
            // 
            // buttonContinuer
            // 
            this.buttonContinuer.BackColor = System.Drawing.Color.White;
            this.buttonContinuer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonContinuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinuer.Location = new System.Drawing.Point(495, 435);
            this.buttonContinuer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContinuer.Name = "buttonContinuer";
            this.buttonContinuer.Size = new System.Drawing.Size(127, 47);
            this.buttonContinuer.TabIndex = 19;
            this.buttonContinuer.Text = "Continuer...";
            this.buttonContinuer.UseVisualStyleBackColor = false;
            this.buttonContinuer.Click += new System.EventHandler(this.buttonContinuer_Click);
            // 
            // labelCook
            // 
            this.labelCook.AutoSize = true;
            this.labelCook.BackColor = System.Drawing.Color.Transparent;
            this.labelCook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCook.Location = new System.Drawing.Point(207, 448);
            this.labelCook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCook.Name = "labelCook";
            this.labelCook.Size = new System.Drawing.Size(56, 20);
            this.labelCook.TabIndex = 21;
            this.labelCook.Text = "0 cook";
            // 
            // labelSolde
            // 
            this.labelSolde.AutoSize = true;
            this.labelSolde.BackColor = System.Drawing.Color.Transparent;
            this.labelSolde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolde.Location = new System.Drawing.Point(18, 448);
            this.labelSolde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSolde.Name = "labelSolde";
            this.labelSolde.Size = new System.Drawing.Size(185, 20);
            this.labelSolde.TabIndex = 20;
            this.labelSolde.Text = "Vous avez  un solde de : ";
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.White;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRetour.Location = new System.Drawing.Point(9, 10);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(48, 31);
            this.buttonRetour.TabIndex = 22;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // FormCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 496);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.labelCook);
            this.Controls.Add(this.labelSolde);
            this.Controls.Add(this.buttonContinuer);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.dataGridViewRecette);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCommande";
            this.Text = "FormCommande";
            this.Load += new System.EventHandler(this.FormCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRecette;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button buttonContinuer;
        private System.Windows.Forms.Label labelCook;
        private System.Windows.Forms.Label labelSolde;
        private System.Windows.Forms.Button buttonRetour;
    }
}