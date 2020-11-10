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
    public partial class FormCdr : Form
    {
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

        public FormCdr()
        {
            InitializeComponent();
            labelErreurIden.Visible = false;
        }

        private void FormCdr_Load(object sender, EventArgs e)
        {

        }

        private void buttonIdenValider_Click(object sender, EventArgs e)
        {
            //juste pour debug, ne serait pas dans le site final
            if (textBoxIdenNum.Text == "")
                textBoxIdenNum.Text = "06 00 00 00 01";
            if (textBoxIdenCode.Text == "")
                textBoxIdenCode.Text = "0001";

            //Recuperer les donnes entrees
            string num = textBoxIdenNum.Text;
            string code = textBoxIdenCode.Text;

            //Si num existe pas, le Cdr n'est pas un client, donc affiche un message d'erreur
            bool connecte = false;
            string requeteClient = Requete("select numTelClient from Client where numTelClient = \"" + num + "\";");
            if (requeteClient == "")
            {
                labelErreurIden.Text = "Vous devez vous inscrire en tant que client avant de vous inscrire en tant que\ncréateur de recette. Votre numéro ne correspond à aucun client enregistré.";
                labelErreurIden.Visible = true;
            }
            //Si le num est bien enregistré
            else
            {
                //Si num existe pas dans la table Cdr, l'ajoute
                string requeteCdr = Requete("select numTelClientCdr from Cdr where numTelClientCdr = \"" + num + "\";");
                if (requeteCdr == "")
                {
                    Requete("insert into Cdr(numTelClientCdr, codeCdr, compte) values (\"" + num + "\", \"" + code + "\", \"0\");");
                    connecte = true;
                }
                //Si il existe verifie que identifiant (num) correspond bien au mot de passe (code)
                else
                {
                    if (code == Requete("select codeCdr from Cdr where numTelClientCdr = \"" + num + "\";"))
                    {
                        //L'identifiant est vrai
                        labelErreurIden.Visible = false;
                        connecte = true;
                    }
                    else
                    {
                        //L'identifiant est faux
                        labelErreurIden.Text = "Votre code ne correspond pas à celui enregistré pour le compte associé au numéro\nde téléphone que vous avez saisi.";
                        labelErreurIden.Visible = true;
                    }
                }
            }

            //Si la connection est bonne on charge le formulaire de commande
            if (connecte)
            {
                //Envoyer des infos necessaires au prochain form (le menu Cdr), puis l'ouvrir
                FormCdrChoix formCdrChoix = new FormCdrChoix(num);
                formCdrChoix.Show();

                this.Close();
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
