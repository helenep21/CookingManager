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
using System.Xml;

namespace DMCooking
{
    public partial class Reapro : Form
    {
        public Reapro()
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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ajd = DateTime.Today;
            DateTime unmois = ajd.AddDays(30);
            int annee = unmois.Year;
            int mois = unmois.Month;
            int jour = unmois.Day;
            string dateM = Convert.ToString(annee) + "-" + Convert.ToString(jour) + "-" + Convert.ToString(mois);
            string requete = Requete("select distinct p.nomProduit from produit p, article a where p.nomProduit = a.nomProduit and nomRecette not in (select distinct r.nomRecette from recette r join contenu c on c.nomRecette = r.nomRecette where c.dateCommande >= \""+dateM+"\"); ");
            string[] produits = requete.Split('\n');
            for(int i = 0; i < produits.Length; i++)
            {
                string produit = produits[i];
                string inter1 = Requete("select stockMin from produit where nomProduit=\"" + produit + "\";");
                int fMin = (Convert.ToInt32(Convert.ToInt32(inter1) + 0.5)/2);
                string qtMin = Convert.ToString(fMin);
                if (qtMin != "0") { 
                    string maj = Requete("update produit set stockMin=" + qtMin + " where nomProduit=\"" + produit + "\";");
                }

                string inter2= Requete("select stockMax from produit where nomProduit=\"" + produit + "\";");
                int fMax = (Convert.ToInt32(Convert.ToInt32(inter2) + 0.5) / 2);
                string qtMax = Convert.ToString(fMax);
                if (qtMax != "0") { 
                    string maj2 = Requete("update produit set stockMax=" + qtMax + " where nomProduit=\"" + produit + "\";");
                }
            }
            label2.Visible = true;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            string fourni = Requete("select distinct nomFourn from produit where stockActuel < stockMin;");
            string[] listFourni = fourni.Split('\n');


            XmlDocument doc = new XmlDocument();
            XmlElement racine = doc.CreateElement("ListeCourses");
            doc.AppendChild(racine);
            XmlDeclaration xmldecl = doc.CreateXmlDeclaration("1.0", "UTF-8", "no");
            doc.InsertBefore(xmldecl, racine);

            XmlNode fournis = doc.CreateElement("fournisseurs");
            racine.AppendChild(fournis);
            if(listFourni[0] != "")
            {
                for (int i = 0; i < listFourni.Length; i++)
                {
                    string prods = Requete("select p.nomProduit,p.stockMax,p.stockActuel from produit p where p.stockActuel < p.stockMin and p.nomFourn=\"" + listFourni[i] + "\";");
                    if (prods != "")
                    {
                        string[] listProduits = prods.Split('\n');

                        XmlNode fournisseur = doc.CreateElement("fournisseur");
                        XmlAttribute fournisNom = doc.CreateAttribute("name");
                        fournisNom.Value = listFourni[i];
                        fournisseur.Attributes.Append(fournisNom);
                        //fournisseur.Value = listFourni[i];
                        for (int j = 0; j < listProduits.Length; j++)
                        {
                            string[] temp = listProduits[j].Split(',');
                            XmlNode produit = doc.CreateElement("produit");
                            XmlAttribute prodNom = doc.CreateAttribute("nom");
                            prodNom.Value = temp[0];

                            XmlAttribute prodQt = doc.CreateAttribute("quantite");
                            int calcul = Convert.ToInt32(temp[1]) - Convert.ToInt32(temp[2]);
                            prodQt.Value = Convert.ToString(calcul);

                            produit.Attributes.Append(prodNom);
                            produit.Attributes.Append(prodQt);
                            fournisseur.AppendChild(produit);
                        }
                        fournis.AppendChild(fournisseur);
                    }
                }
                label3.Text = "La liste des commandes à été \ncréée, vous la trouverez à \n'Final\\DMCooking\\bin\\Debug'";
                label3.Visible = true;
            }
            else
            {
                //Il n'y a pas de produit dont la quantité est inférieure à la quantité minimale
                label3.Text = "Il n'y a pas de produit dont \nla quantité est inférieure à \nla quantité minimale";
                label3.Visible = true;
            }
            doc.Save("listeCourse.xml");

        }
        private void Reapro_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
        }

        private void buttonRetour_Click(object sender, EventArgs e)
        {
            //retour au form précédent
            GestCook formGestCook = new GestCook();
            formGestCook.Show();

            this.Close();
        }
    }
}
