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
    public partial class CdrOr : Form
    {
        public CdrOr()
        {
            InitializeComponent();
        }

        public string Requete(string requete)
        {
            string textResult = "Erreur dans la commande " + requete;
            try
            {
                string connectionString = "SERVER=localhost;PORT=3306;DATABASE=Cooking;UID=root;PASSWORD="+DataContainer.mdp+";";
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

        private void CdrOr_Load(object sender, EventArgs e)
        {
            string requete = "select distinct r.nomRecette as Top5Recettes, cl.nomClient as CdrDor from recette r, client cl, cdr cd where cl.numTelClient = (select distinct cd.numTelClientCdr from cdr cd join recette r on r.numTelClientCdr = cd.numTelClientCdr where r.numTelClientCdr = (select A.CDR from(select cd.numTelClientCdr as CDR, sum(c.quantite) as Qt from recette r join contenu c on c.nomRecette = r.nomRecette join cdr cd on r.numTelClientCdr = cd.numTelClientCdr group by r.numTelClientCdr order by sum(c.quantite) desc) as A where A.Qt in (select max(A.Qt) from(select cd.numTelClientCdr as CDR, sum(c.quantite) as Qt from recette r join contenu c on c.nomRecette = r.nomRecette join cdr cd on r.numTelClientCdr = cd.numTelClientCdr group by r.numTelClientCdr order by sum(c.quantite) desc) as A))) and r.numTelClientCdr = (select A.CDR from(select cd.numTelClientCdr as CDR, sum(c.quantite) as Qt from recette r join contenu c on c.nomRecette = r.nomRecette join cdr cd on r.numTelClientCdr = cd.numTelClientCdr group by r.numTelClientCdr order by sum(c.quantite) desc) as A where A.Qt in (select max(A.Qt) from(select cd.numTelClientCdr as CDR, sum(c.quantite) as Qt from recette r join contenu c on c.nomRecette = r.nomRecette join cdr cd on r.numTelClientCdr = cd.numTelClientCdr group by r.numTelClientCdr order by sum(c.quantite) desc) as A)) limit 5 ;";
            string cdrOr = Requete(requete);
            string[] splitr = cdrOr.Split('\n');
            string nomCdr = splitr[0].Split(',')[1];
            string[] recettes = new string[5];
            for (int i = 0; i < 5; i++)
            {
                if (i < splitr.GetLength(0))
                {
                    string temp = splitr[i].Split(',')[0];
                    recettes[i] = Convert.ToString(i + 1) + ". " + temp;
                }
                else
                {
                    recettes[i] = " ";
                }
            }

            label2.Text = nomCdr + ":";
            label3.Text = recettes[0];
            label4.Text = recettes[1];
            label5.Text = recettes[2];
            label6.Text = recettes[3];
            label7.Text = recettes[4];
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
