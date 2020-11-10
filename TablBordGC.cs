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
    public partial class TablBordGC : Form
    {
        public TablBordGC()
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

        private void button3_Click(object sender, EventArgs e)
        {
            CdrOr cs = new CdrOr();
            cs.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CdRSemaine cs = new CdRSemaine();
            cs.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Top5 f9 = new Top5();
            f9.Show();

            this.Close();
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
