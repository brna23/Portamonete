using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bernabe.mattia._4j.portamonete.models;

namespace bernabe.mattia._4j.portamonete
{
    public partial class Form1 : Form
    {

        Portamonete obj = new Portamonete();
        public Form1()
        {
            InitializeComponent();

            money_value.Text = (obj.denaro());
            money_type.Text = (obj.denaroTipo());
        }

        private void btn_inserisci_Click(object sender, EventArgs e)
        {
            string selezione = text_value.Text;
            int valore = Convert.ToInt32(selezione);

            if (String.IsNullOrEmpty(num_value.Text))
            {
                obj.inserisci(valore);
            }
            else
            {
                obj.inserisci(valore, Convert.ToInt32(num_value.Text));
            }

            money_value.Text = (obj.denaro());
            money_type.Text = (obj.denaroTipo());
        }
    }
}
