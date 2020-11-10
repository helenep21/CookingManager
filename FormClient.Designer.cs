namespace DMCooking
{
    partial class FormClient
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
            this.labelErreurIden = new System.Windows.Forms.Label();
            this.buttonIdenValider = new System.Windows.Forms.Button();
            this.labelIdenNum = new System.Windows.Forms.Label();
            this.labelIdenNom = new System.Windows.Forms.Label();
            this.textBoxIdenNum = new System.Windows.Forms.TextBox();
            this.textBoxIdenNom = new System.Windows.Forms.TextBox();
            this.labelIndenTitle = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelErreurIden
            // 
            this.labelErreurIden.AutoSize = true;
            this.labelErreurIden.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurIden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreurIden.Location = new System.Drawing.Point(72, 305);
            this.labelErreurIden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErreurIden.Name = "labelErreurIden";
            this.labelErreurIden.Size = new System.Drawing.Size(112, 16);
            this.labelErreurIden.TabIndex = 17;
            this.labelErreurIden.Text = "Erreur connection";
            this.labelErreurIden.Visible = false;
            // 
            // buttonIdenValider
            // 
            this.buttonIdenValider.BackColor = System.Drawing.Color.White;
            this.buttonIdenValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIdenValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIdenValider.Location = new System.Drawing.Point(254, 258);
            this.buttonIdenValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIdenValider.Name = "buttonIdenValider";
            this.buttonIdenValider.Size = new System.Drawing.Size(85, 42);
            this.buttonIdenValider.TabIndex = 16;
            this.buttonIdenValider.Text = "Valider";
            this.buttonIdenValider.UseVisualStyleBackColor = false;
            this.buttonIdenValider.Click += new System.EventHandler(this.buttonIdenValider_Click_1);
            // 
            // labelIdenNum
            // 
            this.labelIdenNum.AutoSize = true;
            this.labelIdenNum.BackColor = System.Drawing.Color.Transparent;
            this.labelIdenNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdenNum.Location = new System.Drawing.Point(111, 171);
            this.labelIdenNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdenNum.Name = "labelIdenNum";
            this.labelIdenNum.Size = new System.Drawing.Size(258, 20);
            this.labelIdenNum.TabIndex = 15;
            this.labelIdenNum.Text = "Entrez votre numéro de téléphone :";
            // 
            // labelIdenNom
            // 
            this.labelIdenNom.AutoSize = true;
            this.labelIdenNom.BackColor = System.Drawing.Color.Transparent;
            this.labelIdenNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdenNom.Location = new System.Drawing.Point(112, 121);
            this.labelIdenNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdenNom.Name = "labelIdenNom";
            this.labelIdenNom.Size = new System.Drawing.Size(138, 20);
            this.labelIdenNom.TabIndex = 14;
            this.labelIdenNom.Text = "Entrez votre nom :";
            // 
            // textBoxIdenNum
            // 
            this.textBoxIdenNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdenNum.Location = new System.Drawing.Point(373, 168);
            this.textBoxIdenNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIdenNum.Name = "textBoxIdenNum";
            this.textBoxIdenNum.Size = new System.Drawing.Size(138, 26);
            this.textBoxIdenNum.TabIndex = 13;
            // 
            // textBoxIdenNom
            // 
            this.textBoxIdenNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdenNom.Location = new System.Drawing.Point(254, 118);
            this.textBoxIdenNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIdenNom.Name = "textBoxIdenNom";
            this.textBoxIdenNom.Size = new System.Drawing.Size(169, 26);
            this.textBoxIdenNom.TabIndex = 12;
            // 
            // labelIndenTitle
            // 
            this.labelIndenTitle.AutoSize = true;
            this.labelIndenTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelIndenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndenTitle.Location = new System.Drawing.Point(224, 32);
            this.labelIndenTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIndenTitle.Name = "labelIndenTitle";
            this.labelIndenTitle.Size = new System.Drawing.Size(127, 26);
            this.labelIndenTitle.TabIndex = 11;
            this.labelIndenTitle.Text = "Bienvenue !";
            this.labelIndenTitle.Click += new System.EventHandler(this.labelIndenTitle_Click);
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.White;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRetour.Location = new System.Drawing.Point(9, 10);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(48, 31);
            this.buttonRetour.TabIndex = 27;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 364);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.labelErreurIden);
            this.Controls.Add(this.buttonIdenValider);
            this.Controls.Add(this.labelIdenNum);
            this.Controls.Add(this.labelIdenNom);
            this.Controls.Add(this.textBoxIdenNum);
            this.Controls.Add(this.textBoxIdenNom);
            this.Controls.Add(this.labelIndenTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErreurIden;
        private System.Windows.Forms.Button buttonIdenValider;
        private System.Windows.Forms.Label labelIdenNum;
        private System.Windows.Forms.Label labelIdenNom;
        private System.Windows.Forms.TextBox textBoxIdenNum;
        private System.Windows.Forms.TextBox textBoxIdenNom;
        private System.Windows.Forms.Label labelIndenTitle;
        private System.Windows.Forms.Button buttonRetour;
    }
}