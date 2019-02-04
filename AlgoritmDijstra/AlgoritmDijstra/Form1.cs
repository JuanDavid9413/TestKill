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
    public partial class Form1 : Form
    {

        #region Instances
        Form2 frm2 = new Form2();
        #endregion

        #region Attributes
        public int vNodo1 { get; set; }
        public int vNodo2 { get; set; }
        public int vNodo3 { get; set; }
        public int vNodo4 { get; set; }
        public int vNodo5 { get; set; }
        public int vNodo6 { get; set; }
        #endregion


        #region Methods

        public void ClearImagen()
        {
            imgNodo1.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_blanco.png");
            imgNodo2.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_blanco.png");
            imgNodo3.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_blanco.png");
            imgNodo4.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_blanco.png");
            imgNodo5.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_blanco.png");
            imgNodo6.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_blanco.png");
        }

        public void ImagenSearch(string NameImg)
        {
            switch (NameImg)
            {
                case "imgNodo1":
                    imgNodo1.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_blanco.png");
                    break;
                case "imgNodo2":
                    imgNodo2.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_blanco.png");
                    break;
                case "imgNodo3":
                    imgNodo3.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_blanco.png");
                    break;
                case "imgNodo4":
                    imgNodo4.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_blanco.png");
                    break;
                case "imgNodo5":
                    imgNodo5.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_blanco.png");
                    break;
                case "imgNodo6":
                    imgNodo6.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_blanco.png");
                    break;
            }
        }

        public void ImagenSucces(string NameImg)
        {
            switch (NameImg)
            {
                case "imgNodo1":
                    imgNodo1.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_Rojo.png");
                    break;
                case "imgNodo2":
                    imgNodo2.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_Rojo.png");
                    break;
                case "imgNodo3":
                    imgNodo3.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_Rojo.png");
                    break;
                case "imgNodo4":
                    imgNodo4.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_Rojo.png");
                    break;
                case "imgNodo5":
                    imgNodo5.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_Rojo.png");
                    break;
                case "imgNodo6":
                    imgNodo6.Image = Image.FromFile(@"D:\GitHub\TestKill\AlgoritmDijstra\AlgoritmDijstra\img\Circulo_Rojo.png");
                    break;
            }
        }

        public void GetValueslabels()
        {

            lblValorVertice1.Visible = true;
            lblValorVertice1.Text = Convert.ToString(vNodo1);

            lblValorVertice2.Visible = true;
            lblValorVertice2.Text = Convert.ToString(vNodo2);

            lblValorVertice3.Visible = true;
            lblValorVertice3.Text = Convert.ToString(vNodo3);

            lblValorVertice4.Visible = true;
            lblValorVertice4.Text = Convert.ToString(vNodo4);

            lblValorVertice5.Visible = true;
            lblValorVertice5.Text = Convert.ToString(vNodo5);

            lblValorVertice6.Visible = true;
            lblValorVertice6.Text = Convert.ToString(vNodo6);
        }

        #endregion

        #region Events
        private void lblIngresarValor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm2.Show();
            this.Hide();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (lblValorVertice1.Text == null || lblValorVertice1.Text == "" || lblValorVertice2.Text == null || lblValorVertice2.Text == "" ||
                lblValorVertice3.Text == null || lblValorVertice3.Text == "" || lblValorVertice4.Text == null || lblValorVertice4.Text == "" ||
                lblValorVertice5.Text == null || lblValorVertice5.Text == "" || lblValorVertice6.Text == null || lblValorVertice6.Text == "")
                MessageBox.Show("Digite valores en el vertice para iniciar con el programa");
            else
                timerDijstra.Start();

        }

        private void timerDijstra_Tick(object sender, EventArgs e)
        {
            string vValueNodo1 = lblNodo1.Text + "|" + lblValorVertice1.Text + "|" + Convert.ToString(chkActivateNodo1.Checked);
            string vValueNodo2 = lblNodo2.Text + "|" + lblValorVertice2.Text + "|" + Convert.ToString(chkActivateNodo2.Checked);
            string vValueNodo3 = lblNodo3.Text + "|" + lblValorVertice3.Text + "|" + Convert.ToString(chkActivateNodo3.Checked);
            string vValueNodo4 = lblNodo4.Text + "|" + lblValorVertice4.Text + "|" + Convert.ToString(chkActivateNodo4.Checked);
            string vValueNodo5 = lblNodo5.Text + "|" + lblValorVertice5.Text + "|" + Convert.ToString(chkActivateNodo5.Checked);
            string vValueNodo6 = lblNodo6.Text + "|" + lblValorVertice6.Text + "|" + Convert.ToString(chkActivateNodo6.Checked);

            List<string> vList = new List<string>();
            vList.Add(vValueNodo1);
            vList.Add(vValueNodo2);
            vList.Add(vValueNodo3);
            vList.Add(vValueNodo4);
            vList.Add(vValueNodo5);
            vList.Add(vValueNodo6);

            CalcularCaminoCorto(vList);

            MessageBox.Show("Ha terminado de calcular el algoritmo");
        }

        #endregion

        #region Methods
        public void CalcularCaminoCorto(List<string> oList)
        {
            string vCadenaList;
            for (int i = 0; i <= 5; i++)
            {
                vCadenaList = oList[1];
                if (!chkActivateNodo1.Checked)
                {
                    ImagenSucces("imgNodo1");
                    chkActivateNodo1.Checked = true;
                    if (Convert.ToInt16(lblValorVertice2.Text) < Convert.ToInt16(lblValorVertice3.Text))
                    {
                        chkActivateNodo2.Checked = true;
                        ImagenSucces("imgNodo2");
                    }
                    else if (Convert.ToInt16(lblValorVertice3.Text) < Convert.ToInt16(lblValorVertice2.Text))
                    {
                        chkActivateNodo2.Checked = true;
                        chkActivateNodo3.Checked = true;
                        ImagenSucces("imgNodo3");
                    }
                }
                else if (!chkActivateNodo2.Checked)
                {
                    chkActivateNodo2.Checked = true;
                    if (Convert.ToInt16(lblValorVertice3.Text) < Convert.ToInt16(lblValorVertice4.Text))
                    {
                        chkActivateNodo3.Checked = true;
                        ImagenSucces("imgNodo3");
                    }
                    else if (Convert.ToInt16(lblValorVertice4.Text) < Convert.ToInt16(lblValorVertice3.Text))
                    {
                        chkActivateNodo3.Checked = true;
                        chkActivateNodo4.Checked = true;
                        ImagenSucces("imgNodo4");
                    }
                }
                else if (!chkActivateNodo3.Checked)
                {
                    chkActivateNodo3.Checked = true;
                    if (Convert.ToInt16(lblValorVertice3.Text) < Convert.ToInt16(lblValorVertice4.Text))
                    {
                        ImagenSucces("imgNodo3");
                    }
                    else if (Convert.ToInt16(lblValorVertice4.Text) < Convert.ToInt16(lblValorVertice3.Text))
                    {
                        chkActivateNodo3.Checked = true;
                        chkActivateNodo4.Checked = true;
                        ImagenSucces("imgNodo4");
                    }
                }
                else if (!chkActivateNodo4.Checked)
                {
                    chkActivateNodo4.Checked = true;
                    if (Convert.ToInt16(lblValorVertice4.Text) < Convert.ToInt16(lblValorVertice5.Text))
                    {
                        ImagenSucces("imgNodo4");
                    }
                    else if (Convert.ToInt16(lblValorVertice5.Text) < Convert.ToInt16(lblValorVertice4.Text))
                    {
                        chkActivateNodo4.Checked = true;
                        chkActivateNodo5.Checked = true;
                        ImagenSucces("imgNodo5");
                    }
                }
                else if (!chkActivateNodo5.Checked)
                {
                    chkActivateNodo5.Checked = true;
                    if (Convert.ToInt16(lblValorVertice5.Text) < Convert.ToInt16(lblValorVertice6.Text))
                    {
                        ImagenSucces("imgNodo5");
                    }
                    else if (Convert.ToInt16(lblValorVertice6.Text) < Convert.ToInt16(lblValorVertice5.Text))
                    {
                        chkActivateNodo5.Checked = true;
                        chkActivateNodo6.Checked = true;
                        ImagenSucces("imgNodo6");
                    }
                }
                else if (!chkActivateNodo6.Checked)
                {
                    chkActivateNodo6.Checked = true;
                    ImagenSucces("imgNodo6");
                }
            }
            timerDijstra.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearImagen();
            chkActivateNodo1.Checked = false;
            chkActivateNodo2.Checked = false;
            chkActivateNodo3.Checked = false;
            chkActivateNodo4.Checked = false;
            chkActivateNodo5.Checked = false;
            chkActivateNodo6.Checked = false;
        }
        #endregion

    }
}
