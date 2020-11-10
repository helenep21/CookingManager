namespace DMCooking
{
    partial class FormDemo
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
            this.labelTitre = new System.Windows.Forms.Label();
            this.textBoxSaisie = new System.Windows.Forms.TextBox();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(26, 74);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(0, 20);
            this.labelTitre.TabIndex = 0;
            // 
            // textBoxSaisie
            // 
            this.textBoxSaisie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSaisie.Location = new System.Drawing.Point(238, 25);
            this.textBoxSaisie.Name = "textBoxSaisie";
            this.textBoxSaisie.Size = new System.Drawing.Size(100, 26);
            this.textBoxSaisie.TabIndex = 2;
            this.textBoxSaisie.TextChanged += new System.EventHandler(this.textBoxSaisie_TextChanged);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.BackColor = System.Drawing.Color.White;
            this.buttonSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuivant.Location = new System.Drawing.Point(299, 334);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(100, 49);
            this.buttonSuivant.TabIndex = 3;
            this.buttonSuivant.Text = "Suivant";
            this.buttonSuivant.UseVisualStyleBackColor = false;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.BackColor = System.Drawing.Color.White;
            this.buttonPrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrecedent.Location = new System.Drawing.Point(173, 334);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(100, 49);
            this.buttonPrecedent.TabIndex = 4;
            this.buttonPrecedent.Text = "Précédent";
            this.buttonPrecedent.UseVisualStyleBackColor = false;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.White;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRetour.Location = new System.Drawing.Point(11, 11);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(48, 31);
            this.buttonRetour.TabIndex = 29;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // FormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 395);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.textBoxSaisie);
            this.Controls.Add(this.labelTitre);
            this.Name = "FormDemo";
            this.Text = "FormDemo";
            this.Load += new System.EventHandler(this.FormDemo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.TextBox textBoxSaisie;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonRetour;
    }
}