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
    public partial class FromCommandePayer : Form
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


        //noms : tableau contenant chaque nom de recette, prix : tableau contenant chaque prix de recette et num le numTelClient du client connecté
        string[] noms;
        int[] prix;
        string num;
        public FromCommandePayer(string[] nomsPara, int[] prixPara, string numPara)
        {
            this.noms = nomsPara;
            this.prix = prixPara;
            this.num = numPara;
            InitializeComponent();
        }

        private void FromCommandePayer_Load(object sender, EventArgs e)
        {
            //Dupliquer labelRecette, et numericUpDownRecette pour chaque recette 
            int labelPosY = labelRecette.Top;
            for (int i = 0; i < noms.Length; i++)
            {
                Label newLabel = CopyLabel(labelRecette);
                newLabel.Name = "label" + Convert.ToString(i);
                newLabel.Location = new Point(newLabel.Left, labelPosY);
                newLabel.Text = noms[i];
                Controls.Add(newLabel);

                NumericUpDown newNumericUpDown = CopyNumericUpDown(numericUpDownRecette);
                newNumericUpDown.Name = "numericUpDown" + Convert.ToString(i);
                newNumericUpDown.Location = new Point(newNumericUpDown.Left, labelPosY);
                newNumericUpDown.ValueChanged += new System.EventHandler(numericUpDownRecette_ValueChanged);
                Controls.Add(newNumericUpDown);

                labelPosY += 40;
            }

            //afficher le nomrbe de cook du client
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

            //Faire le total de tout les prix (avant deduction du compte cook du client)
            int totalAv = 0;
            for (int i = 0; i < prix.Length; i++)
            {
                NumericUpDown numericUpDowni = (NumericUpDown)Controls.Find("numericUpDown" + Convert.ToString(i), false)[0];
                totalAv += Convert.ToInt32(prix[i] * numericUpDowni.Value);
            }
            labelTotalAv.Text = Convert.ToString(totalAv);

            //Faire le total deduit du montant du compte cook du client
            //Recuperer son compte
            int compte = Convert.ToInt32(labelCook.Text);
            int TotalAp = totalAv - compte;
            if (totalAv - compte >= 0)
            {
                labelTotalAp.Text = Convert.ToString(TotalAp);
            }
            else
            {
                labelTotalAp.Text = "0";
            }
        }
        public Label CopyLabel(Label label)
        {
            Label l = new Label();
            l.Location = label.Location;
            l.AutoSize = true;
            l.Text = label.Text;
            l.BackColor = label.BackColor;
            l.Font = label.Font;
            return l;
        }

        public NumericUpDown CopyNumericUpDown(NumericUpDown numericUpDown)
        {
            NumericUpDown n = new NumericUpDown();
            n.Location = numericUpDown.Location;
            n.Value = numericUpDown.Value;
            n.Font = numericUpDown.Font;
            return n;
        }

        private void numericUpDownRecette_ValueChanged(object sender, EventArgs e)
        {
            //Faire le total de tout les prix (avant deduction du compte cook du client)
            int totalAv = 0;
            for (int i = 0; i < prix.Length; i++)
            {
                NumericUpDown numericUpDowni = (NumericUpDown)Controls.Find("numericUpDown" + Convert.ToString(i), false)[0];
                totalAv += Convert.ToInt32(prix[i] * numericUpDowni.Value);
            }
            labelTotalAv.Text = Convert.ToString(totalAv);

            //Faire le total deduit du montant du compte cook du client
            //Recuperer son compte
            int compte = Convert.ToInt32(labelCook.Text);
            int TotalAp = totalAv - compte;
            if (totalAv - compte >= 0)
            {
                labelTotalAp.Text = Convert.ToString(TotalAp);
            }
            else
            {
                labelTotalAp.Text = "0";
            }
        }

        private void buttonPayer_Click(object sender, EventArgs e)
        {
            //Deduire le compte du client
            //Recuperer l'ancienne valeur du compte
            int compte = Convert.ToInt32(labelCook.Text);

            //Calcul la nouvelle valeur du compte
            string totalAvString = labelTotalAv.Text;
            int totalAv = Convert.ToInt32(totalAvString);
            string nvCompte = "";
            if (compte - totalAv <= 0)
            {
                nvCompte = "0";
            }
            else
            {
                nvCompte = Convert.ToString(compte - totalAv);
            }

            //Mofidifier puis afficher le nomrbe de cook du client
            Requete("update Cdr set compte = " + nvCompte + " where numTelClientCdr = \"" + num + "\";");
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

            //Ajouter à chaque compte Cdr concerné sa rémunération
            int compteCdr = 0;
            int remuCdr = 0;
            //Pour chaque requete update le compte
            for (int i = 0; i < noms.Length; i++)
            {
                compteCdr = Convert.ToInt32(Requete("select compte from Cdr where numTelClientCdr = (select numTelClientCdr from Recette where nomRecette = \"" + noms[i] + "\");"));
                remuCdr = Convert.ToInt32(Requete("select remuCdr from Recette where nomRecette = \"" + noms[i] + "\";"));
                Requete("update Cdr set compte = " + Convert.ToString(compteCdr + remuCdr) + " where numTelClientCdr = (select numTelClientCdr from Recette where nomRecette = \"" + noms[i] + "\");");
            }

            //Au cas ou le client est un Cdr et a acheter une de ses recettes, on update son compte
            if (requeteCdr != "")
            {
                //Afficher le nombre de cook 
                labelCook.Text = Requete("select compte from Cdr where numTelClientCdr = \"" + num + "\";");
            }
            else
            {
                labelCook.Text = "0";
            }

            //Augmenter le compteur des recettes commandees
            int compteurAv = 0;
            int compteurAp = 0;
            for (int i = 0; i < noms.Length; i++)
            {
                prix[i] = Convert.ToInt32(Requete("select prix from Recette where nomRecette = \"" + noms[i] + "\";"));
                NumericUpDown numericUpDowni = (NumericUpDown)Controls.Find("numericUpDown" + Convert.ToString(i), false)[0];
                compteurAv = Convert.ToInt32(Requete("select compteur from Recette where nomRecette = \"" + noms[i] + "\";"));
                compteurAp = compteurAv + Convert.ToInt32(numericUpDowni.Value);
                Requete("update Recette set compteur = " + Convert.ToString(compteurAp) + " where nomRecette = \"" + noms[i] + "\";");
                //Si le compteur > 50, le prix de vente augmente de 5 cook et la remuCdr = 4. On ne veut pas que ca augmente à chaque fois mais juste quand ca depasse le palier la premiere fois
                if (compteurAv <= 50 && compteurAp > 50)
                {
                    //Si ca a aussi dépassé le palier de 10 en meme temps (ex: fait 53 commandes)
                    if (compteurAv <= 10 && compteurAp > 10)
                    {
                        Requete("update Recette set prix = " + Convert.ToString(prix[i] + 5 + 2) + " where nomRecette = \"" + noms[i] + "\";");
                    }
                    else
                    {
                        Requete("update Recette set prix = " + Convert.ToString(prix[i] + 5) + " where nomRecette = \"" + noms[i] + "\";");
                        Requete("update Recette set remuCdr = " + Convert.ToString(4) + " where nomRecette = \"" + noms[i] + "\";");
                    }
                }
                //Si le compteur > 10, le prix de vente augmente de 2 cook
                else if (compteurAv <= 10 && compteurAp > 10)
                {
                    Requete("update Recette set prix = " + Convert.ToString(prix[i] + 2) + " where nomRecette = \"" + noms[i] + "\";");
                }
            }

            //Decrémenter le stockActuel des produits utilisés pour faire les recettes dans la commande
            string quantiteUtiliseeStr = "";
            string[] quantiteUtiliseeTab;
            int quantiteUtilisee = 0;
            string requeteProdStr = "";
            string[] requeteProdTab;
            string[] stockActuelrefFournTab;
            int stockActuel = 0;
            string refFourn = "";
            for (int i = 0; i < noms.Length; i++)
            {
                //Cherche pour chaque article, de chaque recette, la quantité utilisé et l'enlève à son stockActuel
                quantiteUtiliseeStr = Requete("select nombre from Article where nomRecette = \"" + noms[i] + "\";");
                quantiteUtiliseeTab = quantiteUtiliseeStr.Split('\n');
                requeteProdStr = Requete("select refFourn, stockActuel from Produit where refFourn in (select refFourn from Article where nomRecette = \"" + noms[i] + "\");");
                requeteProdTab = requeteProdStr.Split('\n');
                for (int j = 0; j < quantiteUtiliseeTab.Length; j++)
                {
                    quantiteUtilisee = Convert.ToInt32(quantiteUtiliseeTab[j]);

                    stockActuelrefFournTab = requeteProdTab[j].Split(',');
                    refFourn = stockActuelrefFournTab[0];
                    stockActuel = Convert.ToInt32(stockActuelrefFournTab[1]);

                    Requete("update Produit set stockActuel = " + Convert.ToString(stockActuel - quantiteUtilisee) + " where refFourn = \"" + refFourn + "\";");
                }
            }

            DateTime dateD = DateTime.Now;
            string date = Convert.ToString(dateD.Year) + "-" + Convert.ToString(dateD.Month) + "-" + Convert.ToString(dateD.Day) + " " + Convert.ToString(dateD.Hour) + ":" + Convert.ToString(dateD.Minute) + ":" + Convert.ToString(dateD.Second);
            int quantite = 0;
            //Enregistrer la commande :
            Requete("INSERT INTO Commande (dateCommande, total, numTelClient) VALUES (\"" + date + "\", \"" + totalAv + "\", \"" + num + "\");");
            for(int i = 0; i < noms.Length; i++)
            {
                NumericUpDown numericUpDowni = (NumericUpDown)Controls.Find("numericUpDown" + Convert.ToString(i), false)[0];
                quantite = Convert.ToInt32(numericUpDowni.Value);
                Requete("INSERT INTO Contenu (nomRecette, dateCommande, quantite) VALUES (\"" + noms[i] + "\", \"" + date + "\", \"" + quantite + "\");");
            }


            //Ouvrir le formulaire de validation
            FormCommandeValidee formCommandeValidee = new FormCommandeValidee(num);
            formCommandeValidee.Show();

            this.Close();

        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //retour au form précédent
            FormCommande formCommande = new FormCommande(num);
            formCommande.Show();

            this.Close();
        }

    }
}
