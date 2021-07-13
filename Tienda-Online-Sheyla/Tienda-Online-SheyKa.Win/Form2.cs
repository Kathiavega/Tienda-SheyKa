using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_Online_SheyKa.BL;

namespace Tienda_Online_SheyKa.Win
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var clientesBL = new ClientesBL();
            var listadeClientes = clientesBL.ObtenerClientes();

            foreach (var cliente in listadeClientes)
         {
                MessageBox.Show(cliente.Telefono);
            }

        }
    }
}
