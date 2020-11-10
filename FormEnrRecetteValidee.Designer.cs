namespace DMCooking
{
    partial class FormEnrRecetteValidee
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelCommandeValidee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.White;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOk.Location = new System.Drawing.Point(117, 96);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(56, 37);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelCommandeValidee
            // 
            this.labelCommandeValidee.AutoSize = true;
            this.labelCommandeValidee.BackColor = System.Drawing.Color.Transparent;
            this.labelCommandeValidee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommandeValidee.Location = new System.Drawing.Point(34, 47);
            this.labelCommandeValidee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommandeValidee.Name = "labelCommandeValidee";
            this.labelCommandeValidee.Size = new System.Drawing.Size(234, 20);
            this.labelCommandeValidee.TabIndex = 2;
            this.labelCommandeValidee.Text = "Votre recette à été enregistrée !";
            // 
            // FormEnrRecetteValidee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(298, 161);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelCommandeValidee);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEnrRecetteValidee";
            this.Text = "FormEnrRecetteValidee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelCommandeValidee;
    }
}