namespace DMCooking
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelVousEtes = new System.Windows.Forms.Label();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonCdr = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonDemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVousEtes
            // 
            this.labelVousEtes.AutoSize = true;
            this.labelVousEtes.BackColor = System.Drawing.Color.Transparent;
            this.labelVousEtes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVousEtes.Location = new System.Drawing.Point(219, 34);
            this.labelVousEtes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVousEtes.Name = "labelVousEtes";
            this.labelVousEtes.Size = new System.Drawing.Size(126, 25);
            this.labelVousEtes.TabIndex = 3;
            this.labelVousEtes.Text = "Vous êtes...";
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.White;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.Location = new System.Drawing.Point(196, 95);
            this.buttonClient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(176, 61);
            this.buttonClient.TabIndex = 4;
            this.buttonClient.Text = "Un client";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonCdr
            // 
            this.buttonCdr.BackColor = System.Drawing.Color.White;
            this.buttonCdr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCdr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCdr.Location = new System.Drawing.Point(196, 179);
            this.buttonCdr.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCdr.Name = "buttonCdr";
            this.buttonCdr.Size = new System.Drawing.Size(176, 63);
            this.buttonCdr.TabIndex = 5;
            this.buttonCdr.Text = "Un créateur de recette";
            this.buttonCdr.UseVisualStyleBackColor = false;
            this.buttonCdr.Click += new System.EventHandler(this.buttonCdr_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.White;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.Location = new System.Drawing.Point(155, 291);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(259, 35);
            this.buttonAdmin.TabIndex = 6;
            this.buttonAdmin.Text = "Un administeur de cooking";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonDemo
            // 
            this.buttonDemo.BackColor = System.Drawing.Color.White;
            this.buttonDemo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDemo.Location = new System.Drawing.Point(513, 331);
            this.buttonDemo.Name = "buttonDemo";
            this.buttonDemo.Size = new System.Drawing.Size(75, 23);
            this.buttonDemo.TabIndex = 7;
            this.buttonDemo.Text = "Mode démo";
            this.buttonDemo.UseVisualStyleBackColor = false;
            this.buttonDemo.Click += new System.EventHandler(this.buttonDemo_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonDemo);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonCdr);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.labelVousEtes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelVousEtes;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonCdr;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonDemo;
    }
}

