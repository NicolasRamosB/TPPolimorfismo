using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPolimorfismo.Aviones;

namespace WindowsForms.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAvionComercial_Click(object sender, EventArgs e)
        {

            AvionComercial avionComercial = new AvionComercial("Nicolas Ramos", "Samuel", "Martin", "150", "Aereolineas Argentinas");

            MessageBox.Show($"{avionComercial}");

        }

       
    }
}
