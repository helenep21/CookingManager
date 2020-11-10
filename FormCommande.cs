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
    public partial class FormCommande : Form
    {
        public string num = "defaultValue";
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
        public FormCommande(string numPara)
        {
            InitializeComponent();
            //Recuperer le nom du client connecte
            this.num = numPara;
            //Chercher si le client est un cdr :
            string requeteCdr = Requete("select numTelClientCdr from Cdr where numTelClientCdr = \"" + num + "\";");
            //Si le client est aussi un Cdr affiche son compte :
            if (requeteCdr != "")
            {
                //Afficher le nombre de cook 
                labelCook.Text = Requete("select compte from Cdr where numTelClientCdr = \"" + num + "\";");
            }
            else
            {
                labelCook.Text = "0";
            }

        }

        private void FormCommande_Load(object sender, EventArgs e)
        {
            //Recupere pour chaque recette son nom, type et prix
            string recettes = Requete("select nomRecette, typeRecette, prix from Recette;");


            //Separe la requete par ligne
            string[] recettesLigne = recettes.Split('\n');

            //Pour chaque Recette separe les donnees
            for (int i = 0; i < recettesLigne.Length; i++)
            {
                string[] donnees = recettesLigne[i].Split(',');

                //Met les donnees dans le tableau
                if(donnees.Length > 2)
                {
                    dataGridViewRecette.Rows.Add(donnees[0], donnees[1], donnees[2]);
                }
            }

            // Mettre la taille à jour
            dataGridViewRecette.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            dataGridViewRecette.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewRecette.Height = dataGridViewRecette.ColumnHeadersHeight + dataGridViewRecette.Rows[1].Height * (dataGridViewRecette.RowCount + 1);
        }

        private void buttonContinuer_Click(object sender, EventArgs e)
        {
            //Recuperer tous les prix des recettes selectionnees
            int[] prix = new int[dataGridViewRecette.SelectedRows.Count];
            for (int i = 0; i < dataGridViewRecette.SelectedRows.Count; i++)
            {
                DataGridViewRow row = dataGridViewRecette.SelectedRows[i];
                prix[i] = Convert.ToInt32(row.Cells[2].Value.ToString());
            }

            //Recuperer tous les noms des recettes selectionnees
            string[] noms = new string[dataGridViewRecette.SelectedRows.Count];
            for (int i = 0; i < dataGridViewRecette.SelectedRows.Count; i++)
            {
                DataGridViewRow row = dataGridViewRecette.SelectedRows[i];
                noms[i] = row.Cells[0].Value.ToString();
            }

            //Ouvrir le formulaire de payement
            FromCommandePayer formPayer = new FromCommandePayer(noms, prix, num);
            formPayer.Show();

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
