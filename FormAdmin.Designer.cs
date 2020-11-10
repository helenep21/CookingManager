namespace DMCooking
{
    partial class FormAdmin
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
            this.labelErreurIden = new System.Windows.Forms.Label();
            this.buttonIdenValider = new System.Windows.Forms.Button();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.textBoxAdmin = new System.Windows.Forms.TextBox();
            this.labelIndenTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.White;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRetour.Location = new System.Drawing.Point(11, 11);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(48, 31);
            this.buttonRetour.TabIndex = 34;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // labelErreurIden
            // 
            this.labelErreurIden.AutoSize = true;
            this.labelErreurIden.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurIden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreurIden.Location = new System.Drawing.Point(133, 308);
            this.labelErreurIden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErreurIden.Name = "labelErreurIden";
            this.labelErreurIden.Size = new System.Drawing.Size(112, 16);
            this.labelErreurIden.TabIndex = 33;
            this.labelErreurIden.Text = "Erreur connection";
            this.labelErreurIden.Visible = false;
            // 
            // buttonIdenValider
            // 
            this.buttonIdenValider.BackColor = System.Drawing.Color.White;
            this.buttonIdenValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonIdenValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIdenValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIdenValider.Location = new System.Drawing.Point(255, 256);
            this.buttonIdenValider.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIdenValider.Name = "buttonIdenValider";
            this.buttonIdenValider.Size = new System.Drawing.Size(83, 38);
            this.buttonIdenValider.TabIndex = 32;
            this.buttonIdenValider.Text = "Valider";
            this.buttonIdenValider.UseVisualStyleBackColor = false;
            this.buttonIdenValider.Click += new System.EventHandler(this.buttonIdenValider_Click);
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.BackColor = System.Drawing.Color.Transparent;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(53, 163);
            this.labelAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(285, 20);
            this.labelAdmin.TabIndex = 31;
            this.labelAdmin.Text = "Entrez le mot de passe administrateur :";
            // 
            // textBoxAdmin
            // 
            this.textBoxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdmin.Location = new System.Drawing.Point(342, 160);
            this.textBoxAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAdmin.Name = "textBoxAdmin";
            this.textBoxAdmin.Size = new System.Drawing.Size(126, 26);
            this.textBoxAdmin.TabIndex = 29;
            // 
            // labelIndenTitle
            // 
            this.labelIndenTitle.AutoSize = true;
            this.labelIndenTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelIndenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndenTitle.Location = new System.Drawing.Point(220, 55);
            this.labelIndenTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIndenTitle.Name = "labelIndenTitle";
            this.labelIndenTitle.Size = new System.Drawing.Size(174, 25);
            this.labelIndenTitle.TabIndex = 27;
            this.labelIndenTitle.Text = "Indentifiez vous :";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.labelErreurIden);
            this.Controls.Add(this.buttonIdenValider);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.textBoxAdmin);
            this.Controls.Add(this.labelIndenTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Label labelErreurIden;
        private System.Windows.Forms.Button buttonIdenValider;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.TextBox textBoxAdmin;
        private System.Windows.Forms.Label labelIndenTitle;
    }
}