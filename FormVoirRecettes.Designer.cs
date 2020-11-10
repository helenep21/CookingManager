namespace DMCooking
{
    partial class FormVoirRecettes
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
            this.buttonRetour = new System.Windows.Forms.Button();
            this.dataGridViewCdr = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCdr)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.White;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRetour.Location = new System.Drawing.Point(9, 10);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(48, 31);
            this.buttonRetour.TabIndex = 28;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // dataGridViewCdr
            // 
            this.dataGridViewCdr.AllowUserToAddRows = false;
            this.dataGridViewCdr.AllowUserToDeleteRows = false;
            this.dataGridViewCdr.AllowUserToOrderColumns = true;
            this.dataGridViewCdr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCdr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCdr.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCdr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCdr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Nombre});
            this.dataGridViewCdr.Location = new System.Drawing.Point(80, 79);
            this.dataGridViewCdr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCdr.Name = "dataGridViewCdr";
            this.dataGridViewCdr.ReadOnly = true;
            this.dataGridViewCdr.RowHeadersWidth = 51;
            this.dataGridViewCdr.RowTemplate.Height = 24;
            this.dataGridViewCdr.Size = new System.Drawing.Size(327, 307);
            this.dataGridViewCdr.TabIndex = 29;
            this.dataGridViewCdr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCdr_CellContentClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre de commande(s)";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.BackColor = System.Drawing.Color.Transparent;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(171, 32);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(144, 25);
            this.labelTitre.TabIndex = 30;
            this.labelTitre.Text = "Vos recettes :";
            // 
            // FormVoirRecettes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 422);
            this.Controls.Add(this.labelTitre);
            this.Controls.Add(this.dataGridViewCdr);
            this.Controls.Add(this.buttonRetour);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormVoirRecettes";
            this.Text = "FormVoirRecettes";
            this.Load += new System.EventHandler(this.FormVoirRecettes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCdr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.DataGridView dataGridViewCdr;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}