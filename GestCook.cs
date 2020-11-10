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
    public partial class GestCook : Form
    {
        public GestCook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TablBordGC cs = new TablBordGC();
            cs.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupprRecette cs = new SupprRecette();
            cs.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reapro cs = new Reapro();
            cs.Show();

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SupprCui cs = new SupprCui();
            cs.Show();

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
