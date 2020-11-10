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
    public partial class SupprRecette : Form
    {
        public SupprRecette()
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
            string nomR = textBox2.Text;

            string selecR = Requete("select count(*) from Recette r where nomRecette = \""+nomR+"\";");
            

            if (selecR == "0")
            {
                textBox3.Text = "Recette n'existe pas";
            }
            else
            {
                Requete("delete from Contenu where nomRecette = \"" + nomR + "\";");
                Requete("delete from Article where nomRecette = \"" + nomR + "\";");
                Requete("delete from Recette where nomRecette = \""+nomR+"\";");
                               
                textBox3.Text = "Recette supprimée !";
            }
        }

        private void SupprRecette_Load(object sender, EventArgs e)
        {

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
