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
    public partial class FormVoirRecettes : Form
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

        public FormVoirRecettes(string numPara)
        {
            InitializeComponent();
            this.num = numPara;
        }

        private void FormVoirRecettes_Load(object sender, EventArgs e)
        {
            //Chercher le nom de toutes les recettes créées par ce Cdr

            //Chercher le nombre de commande pour chacune de ses recettes

            // Recupere pour chaque recette son nom
            string requeteNoms = Requete("select nomRecette from Recette where numTelClientCdr = \"" + num + "\";");

            //Separe la requete par ligne
            string[] noms = requeteNoms.Split('\n');

            // Recupere pour chaque recette son nombre de commande
            int nombre = 0;
            for (int i = 0; i < noms.Length; i++)
            {
                nombre = Convert.ToInt32(Requete("select COALESCE(sum(quantite), 0) from Contenu where nomRecette = \"" + noms[i] + "\";"));
                //Met les donnees dans le tableau
                dataGridViewCdr.Rows.Add(noms[i], nombre);
            }

            // Mettre les tailles à jour
            dataGridViewCdr.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            dataGridViewCdr.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dataGridViewCdr.Height = dataGridViewCdr.ColumnHeadersHeight + dataGridViewCdr.Rows[1].Height * (dataGridViewCdr.RowCount + 1);
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //retour au form précédent
            FormCdrChoix formCdrChoix = new FormCdrChoix(num);
            formCdrChoix.Show();

            this.Close();
        }

        private void dataGridViewCdr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
