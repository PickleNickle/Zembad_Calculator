using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjzwombat
{
    public partial class Form1 : Form
    {
        Zwembad gatmetwaterin = new Zwembad();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if(txtDiepte.Text != "")
            {
                gatmetwaterin.Diepte = Convert.ToDouble(txtDiepte.Text);
            }
            if(txtLengte.Text != "")
            {
                gatmetwaterin.Lengte = Convert.ToDouble(txtLengte.Text);
            }
            if(txtBreedte.Text != "")
            {
                gatmetwaterin.Breedte = Convert.ToDouble(txtBreedte.Text);
            }
            if(txtRandafstand.Text != "")
            {
                gatmetwaterin.Randafstand = Convert.ToDouble(txtRandafstand.Text);
            }

            lblOutput.Text = $"Diepte: {gatmetwaterin.Diepte}\nBreedte: {gatmetwaterin.Breedte}\nLengte: {gatmetwaterin.Lengte}\nRandafstand: {gatmetwaterin.Randafstand}\n\n{gatmetwaterin.Details()}";
        }
    }
}
