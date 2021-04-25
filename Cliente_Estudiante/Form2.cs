using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Estudiante
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExamen_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 frmPantalla = new Form1(txtnombre.Text);

                frmPantalla.Show();
                //this.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
