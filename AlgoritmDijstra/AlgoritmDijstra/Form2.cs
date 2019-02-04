using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmDijstra
{
    public partial class Form2 : Form
    {

        #region Events

        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Form1 iForm1 = new Form1();

            iForm1.lblValorVertice1.Text = txtNodoOne.Text;
            iForm1.lblValorVertice2.Text = txtNodoTwo.Text;
            iForm1.lblValorVertice3.Text = txtNodoThree.Text;
            iForm1.lblValorVertice4.Text = txtNodoFour.Text;
            iForm1.lblValorVertice5.Text = txtNodoFive.Text;
            iForm1.lblValorVertice6.Text = txtNodoSix.Text;
                        
            iForm1.Show();
            this.Hide();

        }

        #endregion
    }
}
