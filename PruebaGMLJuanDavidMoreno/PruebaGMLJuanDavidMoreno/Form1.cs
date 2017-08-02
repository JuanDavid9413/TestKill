using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaGMLJuanDavidMoreno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Attributes
        string CantidadTotal = null;
        private int ConteoClicks50, ConteoClicks100, ConteoClicks200, ConteoClicks500, ConteoClicks1000, ConteoTotal;
        #endregion

        #region Methods
        private void btnCincuenta_Click(object sender, EventArgs e)
        {
            ConteoClicks50 = ConteoClicks50 + 1;
            txtMoneda50.Text = Convert.ToString(ConteoClicks50);
            ConteoTotal = ConteoTotal + 1;
            txtCantidadTotal.Text = Convert.ToString(ConteoTotal);

        }
        private void btnCien_Click(object sender, EventArgs e)
        {
            ConteoClicks100 = ConteoClicks100 + 1;
            txtMonedas100.Text = Convert.ToString(ConteoClicks100);
            ConteoTotal = ConteoTotal + 1;
            txtCantidadTotal.Text = Convert.ToString(ConteoTotal);

        }

        private void btnDocientos_Click(object sender, EventArgs e)
        {
            ConteoClicks200 = ConteoClicks200 + 1;
            txtMonedas200.Text = Convert.ToString(ConteoClicks200);
            ConteoTotal = ConteoTotal + 1;
            txtCantidadTotal.Text = Convert.ToString(ConteoTotal);
        }

        private void btnQuinientos_Click(object sender, EventArgs e)
        {
            ConteoClicks500 = ConteoClicks500 + 1;
            txtMonedas500.Text = Convert.ToString(ConteoClicks500);
            ConteoTotal = ConteoTotal + 1;
            txtCantidadTotal.Text = Convert.ToString(ConteoTotal);
        }

        private void btnMil_Click(object sender, EventArgs e)
        {
            ConteoClicks1000 = ConteoClicks1000 + 1;
            txtMonedas1000.Text = Convert.ToString(ConteoClicks1000);
            ConteoTotal = ConteoTotal + 1;
            txtCantidadTotal.Text = Convert.ToString(ConteoTotal);
        }


        #endregion


    }
}
