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
    public partial class FormEnrRecetteValidee : Form
    {
        public string num = "defaultValue";
        public FormEnrRecetteValidee(string numPara)
        {
            InitializeComponent();
            this.num = numPara;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //Envoyer des infos necessaires au nouveau form, puis l'ouvrir
            FormCdrChoix formCdrChoix = new FormCdrChoix(num);
            formCdrChoix.Show();

            this.Close();
        }
    }
}
