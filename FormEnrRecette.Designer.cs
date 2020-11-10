namespace DMCooking
{
    partial class FormEnrRecette
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
            this.labelNom = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.numericUpDownPrix = new System.Windows.Forms.NumericUpDown();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonEnr = new System.Windows.Forms.Button();
            this.label0 = new System.Windows.Forms.Label();
            this.numericUpDown0 = new System.Windows.Forms.NumericUpDown();
            this.comboBox0 = new System.Windows.Forms.ComboBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMoins = new System.Windows.Forms.Button();
            this.buttonRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown0)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.BackColor = System.Drawing.Color.Transparent;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(146, 17);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(573, 25);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Indiquez ici les informations pour enregistrer votre recette :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.BackColor = System.Drawing.Color.Transparent;
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(19, 84);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(142, 20);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom de la recette :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(19, 133);
            this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(55, 20);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type : ";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.BackColor = System.Drawing.Color.Transparent;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(16, 189);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(101, 20);
            this.labelDesc.TabIndex = 3;
            this.labelDesc.Text = "Description : ";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.BackColor = System.Drawing.Color.Transparent;
            this.labelPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrix.Location = new System.Drawing.Point(19, 301);
            this.labelPrix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(107, 20);
            this.labelPrix.TabIndex = 4;
            this.labelPrix.Text = "Prix de vente :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(165, 81);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(200, 26);
            this.textBoxNom.TabIndex = 5;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesc.Location = new System.Drawing.Point(121, 186);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(198, 88);
            this.textBoxDesc.TabIndex = 6;
            // 
            // numericUpDownPrix
            // 
            this.numericUpDownPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPrix.Location = new System.Drawing.Point(130, 301);
            this.numericUpDownPrix.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownPrix.Name = "numericUpDownPrix";
            this.numericUpDownPrix.Size = new System.Drawing.Size(49, 26);
            this.numericUpDownPrix.TabIndex = 7;
            this.numericUpDownPrix.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Aperitif",
            "Entree",
            "Plat",
            "Dessert",
            "Encat"});
            this.comboBoxType.Location = new System.Drawing.Point(78, 130);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(134, 28);
            this.comboBoxType.TabIndex = 8;
            // 
            // buttonEnr
            // 
            this.buttonEnr.BackColor = System.Drawing.Color.White;
            this.buttonEnr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnr.Location = new System.Drawing.Point(318, 356);
            this.buttonEnr.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEnr.Name = "buttonEnr";
            this.buttonEnr.Size = new System.Drawing.Size(173, 55);
            this.buttonEnr.TabIndex = 9;
            this.buttonEnr.Text = "Enregistrer";
            this.buttonEnr.UseVisualStyleBackColor = false;
            this.buttonEnr.Click += new System.EventHandler(this.buttonEnr_Click);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.BackColor = System.Drawing.Color.Transparent;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.Location = new System.Drawing.Point(472, 81);
            this.label0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(89, 20);
            this.label0.TabIndex = 11;
            this.label0.Text = "Ingrédient :";
            // 
            // numericUpDown0
            // 
            this.numericUpDown0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown0.Location = new System.Drawing.Point(738, 78);
            this.numericUpDown0.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown0.Name = "numericUpDown0";
            this.numericUpDown0.Size = new System.Drawing.Size(40, 26);
            this.numericUpDown0.TabIndex = 10;
            this.numericUpDown0.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox0
            // 
            this.comboBox0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox0.FormattingEnabled = true;
            this.comboBox0.Location = new System.Drawing.Point(585, 78);
            this.comboBox0.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox0.Name = "comboBox0";
            this.comboBox0.Size = new System.Drawing.Size(134, 28);
            this.comboBox0.TabIndex = 12;
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.White;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(738, 115);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(32, 29);
            this.buttonPlus.TabIndex = 13;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMoins
            // 
            this.buttonMoins.BackColor = System.Drawing.Color.White;
            this.buttonMoins.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoins.Location = new System.Drawing.Point(702, 115);
            this.buttonMoins.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoins.Name = "buttonMoins";
            this.buttonMoins.Size = new System.Drawing.Size(32, 29);
            this.buttonMoins.TabIndex = 14;
            this.buttonMoins.Text = "-";
            this.buttonMoins.UseVisualStyleBackColor = false;
            this.buttonMoins.Click += new System.EventHandler(this.buttonMoins_Click);
            // 
            // buttonRetour
            // 
            this.buttonRetour.BackColor = System.Drawing.Color.White;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRetour.Location = new System.Drawing.Point(10, 11);
            this.buttonRetour.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(48, 31);
            this.buttonRetour.TabIndex = 16;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // FormEnrRecette
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 431);
            this.Controls.Add(this.buttonRetour);
            this.Controls.Add(this.buttonMoins);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.comboBox0);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.numericUpDown0);
            this.Controls.Add(this.buttonEnr);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.numericUpDownPrix);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.labelTitre);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEnrRecette";
            this.Text = "FormEnrRecette";
            this.Load += new System.EventHandler(this.FormEnrRecette_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.NumericUpDown numericUpDownPrix;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonEnr;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.NumericUpDown numericUpDown0;
        private System.Windows.Forms.ComboBox comboBox0;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMoins;
        private System.Windows.Forms.Button buttonRetour;
    }
}