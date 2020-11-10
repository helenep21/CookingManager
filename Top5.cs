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
    public partial class Top5 : Form
    {
        public Top5()
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


        private void Top5_Load(object sender, EventArgs e)
        {
            string topfive = "select distinct r.nomRecette as Recette,r.typeRecette as Type,r.descRecette as Description,cl.nomClient as Cdr from recette r, contenu c, cdr cd, client cl where r.numTelClientCdr = cd.numTelClientCdr and r.nomRecette = c.nomRecette and cl.numTelClient = cd.numTelClientCdr group by c.nomRecette order by sum(c.quantite) desc limit 5";
            string top5 = Requete(topfive);
            string[] result = top5.Split('\n');
            string[] recet = new string[5];
            string[] type = new string[5];
            string[] desc = new string[5];
            string[] cdr = new string[5];
            for (int i = 0; i < 5; i++)
            {
                string[] temp = result[i].Split(',');
                recet[i] = temp[0];
                type[i] = temp[1];
                desc[i] = temp[2];
                cdr[i] = temp[3];

            }
            label2.Text = "1. " + recet[0] + " (" + type[0] + "," + desc[0] + ") par" + cdr[0];
            label3.Text = "2. " + recet[1] + " (" + type[1] + "," + desc[1] + ") par" + cdr[1];
            label4.Text = "3. " + recet[2] + " (" + type[2] + "," + desc[2] + ") par" + cdr[2];
            label5.Text = "4. " + recet[3] + " (" + type[3] + "," + desc[3] + ") par" + cdr[3];
            label6.Text = "5. " + recet[4] + " (" + type[4] + "," + desc[4] + ") par" + cdr[4];

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //retour au form précédent
            TablBordGC formTablBord = new TablBordGC();
            formTablBord.Show();

            this.Close();
        }
    }
}
