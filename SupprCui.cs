using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DMCooking
{
    public partial class SupprCui : Form
    {
        public SupprCui()
        {
            InitializeComponent();
        }

        public string Requete(string requete)
        {
            string textResult = "Erreur dans la commande " + requete;
            try
            {
                string connectionString = "SERVER=localhost;PORT=3306;DATABASE=Cooking;UID=root;PASSWORD=" + DataContainer.mdp + ";";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                MySqlCommand command = connection.CreateCommand();
                command.CommandText = requete;

                MySqlDataReader reader;
                reader = command.ExecuteReader();
                textResult = "";
                while (reader.Read())
                {
                    string currentRowAsString = "";
                    string valueAsString = "";
                    for (int i = 0; i < reader.FieldCount - 1; i++)
                    {
                        valueAsString = reader.GetValue(i).ToString();
                        currentRowAsString += valueAsString + ", ";
                    }
                    valueAsString = reader.GetValue(reader.FieldCount - 1).ToString();
                    currentRowAsString += valueAsString;
                    textResult += currentRowAsString + "\n";
                }
                //Enlever le dernier \n
                textResult = textResult.Substring(0, textResult.Length - 1);
                connection.Close();
            }
            catch { }
            return textResult;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nomC = textBox2.Text;

            string selecC = Requete("select count(*) from cdr where numTelClientCdr=\"" + nomC + "\";");


            if (selecC == "0")
            {
                textBox3.Text = "CdR n'existe pas";
            }
            else
            {                
                string countR = Requete("select count(*) from recette where numTelClientCdr=\""+nomC+ "\";");
                string rec = Requete("select nomRecette from recette where numTelClientCdr=\"" + nomC+ "\";");
                if (countR != "0")
                {
                    string[] listeR = rec.Split('\n');
                    for(int i=0; i < listeR.Length; i++)
                    {
                        string nomR = listeR[i];
                        string supprC1 = Requete("delete from contenu where nomRecette=\"" + nomR + "\";");
                        string supprC2 = Requete("delete from Article where nomRecette=\"" + nomR + "\";");
                    }
                }
                string supprR = Requete("delete from recette where numTelClientCdr=\"" + nomC + "\";");
                string supprC = Requete("delete from cdr where numTelClientCdr=\"" + nomC + "\";");

                textBox3.Text = "CdR et ses recettes supprimées !";
            }
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //retour au form précédent
            GestCook formGestCook = new GestCook();
            formGestCook.Show();

            this.Close();
        }
    }
}
