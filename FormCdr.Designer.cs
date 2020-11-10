namespace DMCooking
{
    partial class FormCdr
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
            this.labelIdenCode = new System.Windows.Forms.Label();
            this.textBoxIdenNum = new System.Windows.Forms.TextBox();
            this.textBoxIdenCode = new System.Windows.Forms.TextBox();
            this.labelIndenTitle = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelErreurIden
            // 
            this.labelErreurIden.AutoSize = true;
            this.labelErreurIden.BackColor = System.Drawing.Color.Transparent;
            this.labelErreurIden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreurIden.Location = new System.Drawing.Point(44, 305);
            this.labelErreurIden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErreurIden.Name = "labelErreurIden";
            this.labelErreurIden.Size = new System.Drawing.Size(112, 16);
            this.labelErreurIden.TabIndex = 25;
            this.labelErreurIden.Text = "Erreur connection";
            this.labelErreurIden.Visible = false;
            // 
            // buttonIdenValider
            // 
            this.buttonIdenValider.BackColor = System.Drawing.Color.White;
            this.buttonIdenValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonIdenValider.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIdenValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIdenValider.Location = new System.Drawing.Point(253, 255);
            this.buttonIdenValider.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIdenValider.Name = "buttonIdenValider";
            this.buttonIdenValider.Size = new System.Drawing.Size(83, 38);
            this.buttonIdenValider.TabIndex = 24;
            this.buttonIdenValider.Text = "Valider";
            this.buttonIdenValider.UseVisualStyleBackColor = false;
            this.buttonIdenValider.Click += new System.EventHandler(this.buttonIdenValider_Click);
            // 
            // labelIdenNum
            // 
            this.labelIdenNum.AutoSize = true;
            this.labelIdenNum.BackColor = System.Drawing.Color.Transparent;
            this.labelIdenNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdenNum.Location = new System.Drawing.Point(55, 135);
            this.labelIdenNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdenNum.Name = "labelIdenNum";
            this.labelIdenNum.Size = new System.Drawing.Size(258, 20);
            this.labelIdenNum.TabIndex = 23;
            this.labelIdenNum.Text = "Entrez votre numéro de téléphone :";
            // 
            // labelIdenCode
            // 
            this.labelIdenCode.AutoSize = true;
            this.labelIdenCode.BackColor = System.Drawing.Color.Transparent;
            this.labelIdenCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdenCode.Location = new System.Drawing.Point(55, 183);
            this.labelIdenCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdenCode.Name = "labelIdenCode";
            this.labelIdenCode.Size = new System.Drawing.Size(281, 20);
            this.labelIdenCode.TabIndex = 22;
            this.labelIdenCode.Text = "Entrez votre code créateur de recette :";
            // 
            // textBoxIdenNum
            // 
            this.textBoxIdenNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdenNum.Location = new System.Drawing.Point(317, 132);
            this.textBoxIdenNum.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdenNum.Name = "textBoxIdenNum";
            this.textBoxIdenNum.Size = new System.Drawing.Size(126, 26);
            this.textBoxIdenNum.TabIndex = 21;
            // 
            // textBoxIdenCode
            // 
            this.textBoxIdenCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdenCode.Location = new System.Drawing.Point(340, 180);
            this.textBoxIdenCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdenCode.Name = "textBoxIdenCode";
            this.textBoxIdenCode.Size = new System.Drawing.Size(77, 26);
            this.textBoxIdenCode.TabIndex = 20;
            // 
            // labelIndenTitle
            // 
            this.labelIndenTitle.AutoSize = true;
            this.labelIndenTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelIndenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndenTitle.Location = new System.Drawing.Point(218, 54);
            this.labelIndenTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIndenTitle.Name = "labelIndenTitle";
            this.labelIndenTitle.Size = new System.Drawing.Size(174, 25);
            this.labelIndenTitle.TabIndex = 19;
            this.labelIndenTitle.Text = "Indentifiez vous :";
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.White;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRetour.Location = new System.Drawing.Point(9, 10);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(48, 31);
            this.buttonRetour.TabIndex = 26;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // FormCdr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.labelErreurIden);
            this.Controls.Add(this.buttonIdenValider);
            this.Controls.Add(this.labelIdenNum);
            this.Controls.Add(this.labelIdenCode);
            this.Controls.Add(this.textBoxIdenNum);
            this.Controls.Add(this.textBoxIdenCode);
            this.Controls.Add(this.labelIndenTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCdr";
            this.Text = "FormCdr";
            this.Load += new System.EventHandler(this.FormCdr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelErreurIden;
        private System.Windows.Forms.Button buttonIdenValider;
        private System.Windows.Forms.Label labelIdenNum;
        private System.Windows.Forms.Label labelIdenCode;
        private System.Windows.Forms.TextBox textBoxIdenNum;
        private System.Windows.Forms.TextBox textBoxIdenCode;
        private System.Windows.Forms.Label labelIndenTitle;
        private System.Windows.Forms.Button buttonRetour;
    }
}