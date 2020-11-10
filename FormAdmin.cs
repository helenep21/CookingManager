using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMCooking
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void buttonIdenValider_Click(object sender, EventArgs e)
        {
            //juste pour debug, ne serait pas dans le site final
            if (textBoxAdmin.Text == "")
                textBoxAdmin.Text = "admin";

            string mdp = textBoxAdmin.Text;
            if(mdp == "admin")
            {
                //On se connecte (passe au form suivant)
                GestCook formGestCook = new GestCook();
                formGestCook.Show();

                this.Close();
            }
            else
            {
                //Affiche erreur :
                labelErreurIden.Text = "Ce n'est pas le bon mot de passe. Connection impossible.";
                labelErreurIden.Visible = true;
            }

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //retour au form précédent
            FormMenu formMenu = new FormMenu();
            formMenu.Show();

            this.Close();
        }
    }
}
