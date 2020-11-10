using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMCooking
{
    public partial class FormCommandeValidee : Form
    {
        public string num = "defaultValue";
        public FormCommandeValidee(string numPara)
        {
            InitializeComponent();
            this.num = numPara;
        }

        private void Form4_Load(object sender, EventArgs e) { }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //Envoyer des infos necessaires au nouveau form, puis l'ouvrir
            FormCommande formCommande = new FormCommande(num);
            formCommande.Show();

            this.Close();
        }
    }
}
