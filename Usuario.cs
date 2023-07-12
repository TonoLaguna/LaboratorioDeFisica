using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioDeFisica
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
           
        
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Mru tema1 = new Mru();
            tema1.Show();
        }
    }
}
