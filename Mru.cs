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
    public partial class Mru : Form
    {

        public int t;
        public double v;
        public double d;
        public double r;

        public Mru()
        {
            InitializeComponent();
        }


        private void BtnMru_Click(object sender, EventArgs e)
        {
            pictureBoxcar.Left = 0;
            // timer1.Enabled = true;



            try
            {
                t = int.Parse(txtBoxtiempo.Text);
                //txtBoxtiempo.Text = null;
                //MessageBox.Show("introducir parametros");

                v = Convert.ToDouble(txtBoxvelocidad.Text);
                //  txtBoxvelocidad.Text = null;
                //MessageBox.Show("introducir parametros");
                //d = Convert.ToDouble(txtBoxdistancia.Text);
                //if (t == 0 || v == 0)
                //{
                // timer1.Enabled = false;
                //  MessageBox.Show("introducir parametros");






                if (t != 0 && v != 0)
                {
                    d = v * t;
                    textBoxrpta.Text = Convert.ToString(d);
                    Timer1.Enabled = true;

                }
                else


                {
                    // d = v * t;
                    //textBoxrpta.Text = Convert.ToString(d);
                    Timer1.Enabled = false;
                }
                //timer1.Enabled = true;
                //   if (t != 0 && v != 0)
                // {
                //   d = v * t;
                // textBoxrpta.Text = Convert.ToString(d); 
                //}
                //else
                //{
                //   timer1.Enabled = false;
                // MessageBox.Show("introducir parametros");




            }

            catch (Exception)
            {
                MessageBox.Show("introducir parametros");
            }

        }
    

        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (pictureBoxcar.Left = 0; pictureBoxcar.Left < 622; pictureBoxcar.Left++)


                if (pictureBoxcar.Left == 621)
                {
                    Timer1.Enabled = false;
                    MessageBox.Show("FINALIZO EL EXPERIMENTO");
                }




        }

        private void BtnsgtDinamica_Click(object sender, EventArgs e)
        {
            Dinamica tema2 = new Dinamica();
            tema2.Show();
        }

       
    }
}