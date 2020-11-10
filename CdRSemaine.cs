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
    public partial class CdRSemaine : Form
    {
        public CdRSemaine()
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

        

        private void CdRSemaine_Load(object sender, EventArgs e)
        {
            DateTime ajd = DateTime.Today;
            DateTime dateD = DateTime.Today;
            int nrjour = Convert.ToInt32(dateD.DayOfWeek);
            nrjour -= 1;
            for (int i = 0; i < nrjour; i++)
            {
                dateD = dateD.AddDays(-1);
            }
            int annee = dateD.Year;
            int mois = dateD.Month;
            int jour = dateD.Day;
            string stdate = Convert.ToString(annee) + "-" + Convert.ToString(mois) + "-" + Convert.ToString(jour);
            string requete = "select distinct cl.nomClient from recette r, contenu c, cdr cd, client cl, commande cm  where r.numTelClientCdr = cd.numTelClientCdr and r.nomRecette = c.nomRecette and cl.numTelClient = cd.numTelClientCdr and cm.dateCommande = c.dateCommande and cm.dateCommande >=\"" + stdate + "\" group by cl.nomClient order by sum(c.quantite) desc limit 1;";

            string cdr = Requete(requete);
            if (cdr == "")
            {
                label2.Text = "Pas de commande passée cette semaine";
            }
            else { 
                label2.Text = cdr;
            }
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
