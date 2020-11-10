namespace DMCooking
{
    partial class FromCommandePayer
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
            this.numericUpDownRecette = new System.Windows.Forms.NumericUpDown();
            this.labelRecette = new System.Windows.Forms.Label();
            this.labelTotalAp = new System.Windows.Forms.Label();
            this.labelTotalApText = new System.Windows.Forms.Label();
            this.labelTotalAv = new System.Windows.Forms.Label();
            this.labelTotalAvText = new System.Windows.Forms.Label();
            this.buttonPayer = new System.Windows.Forms.Button();
            this.labelCook = new System.Windows.Forms.Label();
            this.labelCookText = new System.Windows.Forms.Label();
            this.labelFinalisez = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecette)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownRecette
            // 
            this.numericUpDownRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownRecette.Location = new System.Drawing.Point(340, 76);
            this.numericUpDownRecette.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownRecette.Name = "numericUpDownRecette";
            this.numericUpDownRecette.Size = new System.Drawing.Size(47, 26);
            this.numericUpDownRecette.TabIndex = 0;
            this.numericUpDownRecette.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRecette.Visible = false;
            this.numericUpDownRecette.ValueChanged += new System.EventHandler(this.numericUpDownRecette_ValueChanged);
            // 
            // labelRecette
            // 
            this.labelRecette.AutoSize = true;
            this.labelRecette.BackColor = System.Drawing.Color.Transparent;
            this.labelRecette.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecette.Location = new System.Drawing.Point(70, 78);
            this.labelRecette.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRecette.Name = "labelRecette";
            this.labelRecette.Size = new System.Drawing.Size(266, 20);
            this.labelRecette.TabIndex = 1;
            this.labelRecette.Text = "Le nom de la premiere de la recette :";
            this.labelRecette.Visible = false;
            // 
            // labelTotalAp
            // 
            this.labelTotalAp.AutoSize = true;
            this.labelTotalAp.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAp.Location = new System.Drawing.Point(420, 354);
            this.labelTotalAp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalAp.Name = "labelTotalAp";
            this.labelTotalAp.Size = new System.Drawing.Size(56, 20);
            this.labelTotalAp.TabIndex = 17;
            this.labelTotalAp.Text = "0 cook";
            // 
            // labelTotalApText
            // 
            this.labelTotalApText.AutoSize = true;
            this.labelTotalApText.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalApText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalApText.Location = new System.Drawing.Point(272, 354);
            this.labelTotalApText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalApText.Name = "labelTotalApText";
            this.labelTotalApText.Size = new System.Drawing.Size(158, 20);
            this.labelTotalApText.TabIndex = 16;
            this.labelTotalApText.Text = "Il vous reste à payer :";
            // 
            // labelTotalAv
            // 
            this.labelTotalAv.AutoSize = true;
            this.labelTotalAv.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAv.Location = new System.Drawing.Point(151, 342);
            this.labelTotalAv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalAv.Name = "labelTotalAv";
            this.labelTotalAv.Size = new System.Drawing.Size(56, 20);
            this.labelTotalAv.TabIndex = 15;
            this.labelTotalAv.Text = "0 cook";
            // 
            // labelTotalAvText
            // 
            this.labelTotalAvText.AutoSize = true;
            this.labelTotalAvText.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalAvText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAvText.Location = new System.Drawing.Point(45, 343);
            this.labelTotalAvText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalAvText.Name = "labelTotalAvText";
            this.labelTotalAvText.Size = new System.Drawing.Size(118, 20);
            this.labelTotalAvText.TabIndex = 14;
            this.labelTotalAvText.Text = "Le total est de :";
            // 
            // buttonPayer
            // 
            this.buttonPayer.BackColor = System.Drawing.Color.White;
            this.buttonPayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayer.Location = new System.Drawing.Point(500, 343);
            this.buttonPayer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPayer.Name = "buttonPayer";
            this.buttonPayer.Size = new System.Drawing.Size(80, 42);
            this.buttonPayer.TabIndex = 13;
            this.buttonPayer.Text = "Payer";
            this.buttonPayer.UseVisualStyleBackColor = false;
            this.buttonPayer.Click += new System.EventHandler(this.buttonPayer_Click);
            // 
            // labelCook
            // 
            this.labelCook.AutoSize = true;
            this.labelCook.BackColor = System.Drawing.Color.Transparent;
            this.labelCook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCook.Location = new System.Drawing.Point(136, 378);
            this.labelCook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCook.Name = "labelCook";
            this.labelCook.Size = new System.Drawing.Size(56, 20);
            this.labelCook.TabIndex = 12;
            this.labelCook.Text = "0 cook";
            // 
            // labelCookText
            // 
            this.labelCookText.AutoSize = true;
            this.labelCookText.BackColor = System.Drawing.Color.Transparent;
            this.labelCookText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCookText.Location = new System.Drawing.Point(45, 378);
            this.labelCookText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCookText.Name = "labelCookText";
            this.labelCookText.Size = new System.Drawing.Size(91, 20);
            this.labelCookText.TabIndex = 11;
            this.labelCookText.Text = "Vous avez :";
            // 
            // labelFinalisez
            // 
            this.labelFinalisez.AutoSize = true;
            this.labelFinalisez.BackColor = System.Drawing.Color.Transparent;
            this.labelFinalisez.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalisez.Location = new System.Drawing.Point(178, 16);
            this.labelFinalisez.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFinalisez.Name = "labelFinalisez";
            this.labelFinalisez.Size = new System.Drawing.Size(275, 25);
            this.labelFinalisez.TabIndex = 18;
            this.labelFinalisez.Text = "Finalisez votre commande :";
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.White;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRetour.Location = new System.Drawing.Point(9, 10);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(48, 31);
            this.buttonRetour.TabIndex = 19;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // FromCommandePayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 405);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.labelFinalisez);
            this.Controls.Add(this.labelTotalAp);
            this.Controls.Add(this.labelTotalApText);
            this.Controls.Add(this.labelTotalAv);
            this.Controls.Add(this.labelTotalAvText);
            this.Controls.Add(this.buttonPayer);
            this.Controls.Add(this.labelCook);
            this.Controls.Add(this.labelCookText);
            this.Controls.Add(this.labelRecette);
            this.Controls.Add(this.numericUpDownRecette);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FromCommandePayer";
            this.Text = "FromCommandePayer";
            this.Load += new System.EventHandler(this.FromCommandePayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownRecette;
        private System.Windows.Forms.Label labelRecette;
        private System.Windows.Forms.Label labelTotalAp;
        private System.Windows.Forms.Label labelTotalApText;
        private System.Windows.Forms.Label labelTotalAv;
        private System.Windows.Forms.Label labelTotalAvText;
        private System.Windows.Forms.Button buttonPayer;
        private System.Windows.Forms.Label labelCook;
        private System.Windows.Forms.Label labelCookText;
        private System.Windows.Forms.Label labelFinalisez;
        private System.Windows.Forms.Button buttonRetour;
    }
}