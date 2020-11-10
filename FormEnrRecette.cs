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
    public partial class FormEnrRecette : Form
    {
        string num = "default value";
        //Besoin d'un variables globale comptant le nombre d'ingrédients que l'utilisateur veut entrer
        int compteurIng = 1;
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

        public FormEnrRecette(string numPara)
        {
            InitializeComponent();
            this.num = numPara;

            //Remplir la comboBoxIng des ingrédients de la bdd
            //Récuperer tous les noms d'ingrédients de la bdd
            string RequeteNomProd = Requete("select nomProduit from Produit;");

            //Separe la requete par ligne
            string[] nomProd = RequeteNomProd.Split('\n');

            //Enregistrer ces nom de produit comme proposition pour la combo box
            comboBox0.Items.AddRange(nomProd);
        }

        private void FormEnrRecette_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnr_Click(object sender, EventArgs e)
        {
            //Récuperer les données entrées par l'utilisateur
            string nom = textBoxNom.Text;
            string type = "";
            if (comboBoxType.SelectedItem != null)
            {
                type = comboBoxType.SelectedItem.ToString();
            }
            string desc = textBoxDesc.Text;
            int prix = Convert.ToInt32(numericUpDownPrix.Value);

            //Enregistrer la recette dans la bdd
            Requete("INSERT INTO Recette(nomRecette, typeRecette, descRecette, prix, remuCuisinier, remuCdr, compteur, numTelClientCdr) VALUES (\"" + nom + "\", \"" + type + "\", \"" + desc + "\", \"" + prix + "\", 2, 2, 0, \"" + num + "\");");

            //Recuperer tous les produits et leur quantité et les enregistrer dans la bdd
            string nomProduit = "";
            int nombreProduit = 0;
            for (int i = 0; i < compteurIng; i++)
            {
                ComboBox comboBoxi = (ComboBox)Controls.Find("comboBox" + Convert.ToString(i), false)[0];
                if (comboBoxi.SelectedItem != null)
                {
                    nomProduit = comboBoxi.SelectedItem.ToString();
                }
                NumericUpDown numericUpDowni = (NumericUpDown)Controls.Find("numericUpDown" + Convert.ToString(i), false)[0];
                nombreProduit = Convert.ToInt32(numericUpDowni.Value);
                Requete("INSERT INTO Article(nomRecette, nomProduit, nombre) VALUES (\"" + nom + "\", \"" + nomProduit + "\", \"" + nombreProduit + "\");");
            }

            //charge le form de recette enregistrée
            FormEnrRecetteValidee formEnrRecetteValidee = new FormEnrRecetteValidee(num);
            formEnrRecetteValidee.Show();

            this.Close();
        }


        public Label CopyLabel(Label label)
        {
            Label l = new Label();
            l.Location = label.Location;
            l.Text = label.Text;
            l.Size = label.Size;
            l.Font = label.Font;
            l.BackColor = label.BackColor;
            return l;
        }
        public ComboBox CopyComboBox(ComboBox comboBox)
        {
            ComboBox c = new ComboBox();
            c.Location = comboBox.Location;
            string[] collection = new string[comboBox.Items.Count];
            for (int i = 0; i < comboBox0.Items.Count; i++)
            {
                collection[i] = Convert.ToString(comboBox.Items[i]);
            }
            c.Items.AddRange(collection);
            c.Size = comboBox.Size;
            c.Font = comboBox.Font;
            return c;
        }
        public NumericUpDown CopyNumericUpDown(NumericUpDown numericUpDown)
        {
            NumericUpDown n = new NumericUpDown();
            n.Location = numericUpDown.Location;
            n.Value = numericUpDown.Value;
            n.Size = numericUpDown.Size;
            n.Font = numericUpDown.Font;
            return n;
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            int labelPosY = label0.Top;

            //Dupliquer labelIng
            Label newLabel = CopyLabel(label0);
            newLabel.Name = "label" + Convert.ToString(compteurIng);
            newLabel.Location = new Point(newLabel.Left, labelPosY + 40* compteurIng);
            Controls.Add(newLabel);

            //Dupliquer comboBoxIng
            ComboBox newcomboBoxIng = CopyComboBox(comboBox0);
            newcomboBoxIng.Name = "comboBox" + Convert.ToString(compteurIng);
            newcomboBoxIng.Location = new Point(newcomboBoxIng.Left, labelPosY + 40 * compteurIng);
            Controls.Add(newcomboBoxIng);

            //Dupliquer numericUpDownIng
            NumericUpDown newNumericUpDown = CopyNumericUpDown(numericUpDown0);
            newNumericUpDown.Name = "numericUpDown" + Convert.ToString(compteurIng);
            newNumericUpDown.Location = new Point(newNumericUpDown.Left, labelPosY + 40 * compteurIng);
            Controls.Add(newNumericUpDown);

            //Deplace les boutons + et -
            buttonPlus.Location = new Point(buttonPlus.Left, buttonPlus.Top + 40);
            buttonMoins.Location = new Point(buttonMoins.Left, buttonMoins.Top + 40);
            compteurIng += 1;
        }

        private void buttonMoins_Click(object sender, EventArgs e)
        {
            //Supprime le dernier labelIng
            Label labeli = (Label)Controls.Find("label" + Convert.ToString(compteurIng - 1), false)[0];
            Controls.Remove(labeli);

            //Supprime le dernier comboBoxIng
            ComboBox comboBoxi = (ComboBox)Controls.Find("comboBox" + Convert.ToString(compteurIng - 1), false)[0];
            Controls.Remove(comboBoxi);

            //Supprime le dernier numericUpDownIng
            NumericUpDown numericUpDowni = (NumericUpDown)Controls.Find("numericUpDown" + Convert.ToString(compteurIng - 1), false)[0];
            Controls.Remove(numericUpDowni);

            compteurIng -= 1;

            //Deplace les boutons + et -
            buttonPlus.Location = new Point(buttonPlus.Left, buttonPlus.Top - 40);
            buttonMoins.Location = new Point(buttonMoins.Left, buttonMoins.Top - 40);
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //retour au form précédent
            FormCdrChoix formCdrChoix = new FormCdrChoix(num);
            formCdrChoix.Show();

            this.Close();
        }
    }
}
