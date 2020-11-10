namespace DMCooking
{
    partial class FormCdrChoix
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
            this.buttonVoirRecettes = new System.Windows.Forms.Button();
            this.buttonEnrRecette = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelSolde = new System.Windows.Forms.Label();
            this.labelCook = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonVoirRecettes
            // 
            this.buttonVoirRecettes.BackColor = System.Drawing.Color.White;
            this.buttonVoirRecettes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVoirRecettes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVoirRecettes.Location = new System.Drawing.Point(168, 198);
            this.buttonVoirRecettes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVoirRecettes.Name = "buttonVoirRecettes";
            this.buttonVoirRecettes.Size = new System.Drawing.Size(261, 83);
            this.buttonVoirRecettes.TabIndex = 10;
            this.buttonVoirRecettes.Text = "Voir mes recettes";
            this.buttonVoirRecettes.UseVisualStyleBackColor = false;
            this.buttonVoirRecettes.Click += new System.EventHandler(this.buttonVoirRecettes_Click);
            // 
            // buttonEnrRecette
            // 
            this.buttonEnrRecette.BackColor = System.Drawing.Color.White;
            this.buttonEnrRecette.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnrRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnrRecette.Location = new System.Drawing.Point(168, 85);
            this.buttonEnrRecette.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEnrRecette.Name = "buttonEnrRecette";
            this.buttonEnrRecette.Size = new System.Drawing.Size(261, 83);
            this.buttonEnrRecette.TabIndex = 8;
            this.buttonEnrRecette.Text = "Enregistrer une nouvelle recette";
            this.buttonEnrRecette.UseVisualStyleBackColor = false;
            this.buttonEnrRecette.Click += new System.EventHandler(this.buttonEnrRecette_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(177, 32);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(239, 25);
            this.labelQuestion.TabIndex = 7;
            this.labelQuestion.Text = "Que voulez vous faire ?";
            // 
            // labelSolde
            // 
            this.labelSolde.AutoSize = true;
            this.labelSolde.BackColor = System.Drawing.Color.Transparent;
            this.labelSolde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolde.Location = new System.Drawing.Point(56, 337);
            this.labelSolde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSolde.Name = "labelSolde";
            this.labelSolde.Size = new System.Drawing.Size(185, 20);
            this.labelSolde.TabIndex = 11;
            this.labelSolde.Text = "Vous avez  un solde de : ";
            // 
            // labelCook
            // 
            this.labelCook.AutoSize = true;
            this.labelCook.BackColor = System.Drawing.Color.Transparent;
            this.labelCook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCook.Location = new System.Drawing.Point(245, 337);
            this.labelCook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCook.Name = "labelCook";
            this.labelCook.Size = new System.Drawing.Size(56, 20);
            this.labelCook.TabIndex = 12;
            this.labelCook.Text = "0 cook";
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.White;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRetour.Location = new System.Drawing.Point(9, 10);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(48, 31);
            this.buttonRetour.TabIndex = 17;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // FormCdrChoix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.labelCook);
            this.Controls.Add(this.labelSolde);
            this.Controls.Add(this.buttonVoirRecettes);
            this.Controls.Add(this.buttonEnrRecette);
            this.Controls.Add(this.labelQuestion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCdrChoix";
            this.Text = "FormCdrChoix";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoirRecettes;
        private System.Windows.Forms.Button buttonEnrRecette;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelSolde;
        private System.Windows.Forms.Label labelCook;
        private System.Windows.Forms.Button buttonRetour;
    }
}