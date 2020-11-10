using System;
using System.IO;
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
    public partial class FormCdrChoix : Form
    {
        string num = "default value";

        public void ReadFileAll(string path)
        {
            try
            {
                string line = "";
                StreamReader lecteur = new StreamReader(path);
                while (lecteur.Peek() > 0)
                {
                    line = lecteur.ReadLine();
                    Console.WriteLine("ligne lu " + line);
                }
                lecteur.Close();
            }
            catch
            {
                Console.WriteLine("Impossible de lire le fichier");
            }
        }
        public void ReadFileSeparate(string path)
        {
            try
            {
                string line = "";
                char[] sep = new char[1] { ';' };
                string[] datas = new string[6];

                StreamReader lecteur = new StreamReader(path);
                while (lecteur.Peek() > 0)
                {
                    line = lecteur.ReadLine();
                    datas = line.Split(sep);
                    Console.Write("ligne lu 2 ");
                    for (int i = 0; i < datas.Length; i++)
                    {
                        Console.Write(datas[i] + " - ");
                    }
                    Console.WriteLine();
                }
                lecteur.Close();
            }
            catch
            {
                Console.WriteLine("Impossible de lire le fichier");
            }
        }
        public void WriteFile(string newClient, string path, bool append)
        {
            StreamWriter ecriteur = new StreamWriter(path, append);
            ecriteur.WriteLine(newClient);
            ecriteur.Close();
        }
        public string ConvertClientToString(string nom, string prenom, int age, string numPermis, string adresse, string ville)
        {
            char sep = ';';
            return (nom + sep + prenom + sep + Convert.ToString(age) + sep + numPermis + sep + adresse + sep + ville);
        }
        public void ReadFile()
        {
            string path = "clients.csv";
            ReadFileSeparate(path);
            string newClient = "Mahieu;Juliette;20;55555;rue val Brisemiche;Chaville";
            bool append = true;
            WriteFile(newClient, path, append);
            Console.WriteLine("\nApres modification : \n");
            ReadFileSeparate(path);
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

        public FormCdrChoix(string numPara)
        {
            InitializeComponent();
            this.num = numPara;
            labelCook.Text = Requete("select compte from Cdr where numTelClientCdr = \"" + num + "\";");
        }



        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnrRecette_Click(object sender, EventArgs e)
        {
            //Envoyer des infos necessaires au prochain form (le form pour enregistrer une nouvelle recette), puis l'ouvrir
            FormEnrRecette formEnrRecette = new FormEnrRecette(num);
            formEnrRecette.Show();

            this.Close();
        }

        private void buttonVoirRecettes_Click(object sender, EventArgs e)
        {
            //Envoyer des infos necessaires au prochain form (le form affichant la list des recettes), puis l'ouvrir
            FormVoirRecettes formVoirRecettes = new FormVoirRecettes(num);
            formVoirRecettes.Show();

            this.Close();
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
