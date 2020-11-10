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
    public partial class FormDemo : Form
    {
        int etapeDemo = 0;
        string prodTab;

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

        public void Demo()
        {
            switch(etapeDemo)
            {
                //Nombre de clients
                case 1:
                    labelTitre.Text = "Nombre de clients : \n" + Requete("select count(numTelClient) from Client;");
                    break;
                //Nombre de Cdr, et pour chacun son nom et nombre de recettes créées
                case 2:
                    labelTitre.Text = "Nombre de Cdr :\n" + Requete("select distinct count(nomClient) from client c join cdr on cdr.numTelClientCdr = c.numTelClient;") + "\n\nPour chaque Cdr le nombre de recette qu'il à crée : \n" + Requete("select nomClient, count(r.nomRecette) from client c, recette r, cdr cd where cd.numTelClientCdr=r.numTelClientCdr and c.numTelClient=cd.numTelClientCdr group by nomClient;");
                    break;
                //Nombre de recettes
                case 3:
                    labelTitre.Text = "Nombre de recettes :\n" + Requete("select count(nomRecette) from Recette;");
                    break;
                //Les produits ayant une quantité en stock <= 2 * leur quantité minimale
                case 4:
                    textBoxSaisie.Visible = false;
                    prodTab = Requete("select nomProduit from produit where stockActuel < 2*stockMin;");
                    labelTitre.Text = "Les produits ayant une quantité en stock inférieur ou égale \nà 2 fois leur quantité minimale :\n\n" + prodTab;
                    break;
                //Saisie au clavier de l'un des produit de la liste
                case 5:
                    textBoxSaisie.Visible = true;
                    textBoxSaisie.Clear();
                    labelTitre.Text = "Saisissez dans la case apparue un de ces produits afin de voir la liste \ndes recettes dans lesquelles il est utilisé. Un fois le produit saisie, \nappuyer sur Suivant.\n\n" + prodTab;
                    break;
                //Affichage de toutes les recettes utilisant le produit et la quantité utilisée
                case 6:
                    AfficheRecette();
                    break;
            }

            //Si le bouton précédent à été préssé trop de fois
            if(etapeDemo < 1)
            {
                etapeDemo = 0; //Remet le compteur au début
                labelTitre.Text = "Il n'y a plus de requete de ce côté la ! Appuyer plutôt sur Suivant...";
            }
            if (etapeDemo > 6)
            {
                etapeDemo = 6; //Remet le compteur au début
                labelTitre.Text = "Il n'y a plus de requete de ce côté la ! Appuyer plutôt sur Précédent...";
                textBoxSaisie.Visible = false;
            }

        }

        public void AfficheRecette()
        {
            string produit = textBoxSaisie.Text;
            string[] prodTabSep = prodTab.Split('\n');
            bool trouve = false;
            if (produit == "")
            {
                etapeDemo = 5; //Revient en arriere car l'utilisateur recommence la saisie
                labelTitre.Text = "Vous devez saisir un des produits avant d'appuyer sur Suivant.\n\n" + prodTab;
            }
            else
            {
                for (int i = 0; !trouve & i < prodTabSep.Length; i++)
                {
                    if (produit == prodTabSep[i])
                    {
                        labelTitre.Text = "Toutes les recettes utilisant le " + produit + " et la quantité utilisée :\n\n" + Requete("select nomRecette,nombre from Article where nomProduit = \"" + produit + "\";");
                        trouve = true;
                    }
                }
                if (!trouve)
                {
                    textBoxSaisie.Clear();
                    etapeDemo = 5; //Revient en arriere car l'utilisateur recommence la saisie
                    labelTitre.Text = "Vous avez noté " + produit + ", ce n'est pas un des produits de la liste ci-dessous. \nVeuillez réessayer, puis appuyer sur Suivant pour continuer.\n\n" + prodTab;
                }
            }
        }

        public FormDemo()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void FormDemo_Load(object sender, EventArgs e)
        {
            //Au début les resultats et la saisie au clavier ne sont pas visible
            textBoxSaisie.Visible = false;

            labelTitre.Text = "Appuyer sur Suivant pour passer chaque requete";
        }

        private void textBoxSaisie_TextChanged(object sender, EventArgs e)
        {
            //AfficheRecette();
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            etapeDemo += 1;
            Demo();
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            etapeDemo -= 1;
            Demo();
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
