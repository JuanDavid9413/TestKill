using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmMain : Form
    {
        #region Instances
        ConfirmImage vConfirmImage = new ConfirmImage();
        #endregion

        #region Attributes
        public int Contador;
        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        #region Event Buttom
        private void button5_Click(object sender, EventArgs e)
        {
            //class Random
            Random r = new Random();

            #region Attributes
            int As = r.Next(1, 6);
            int Siete = r.Next(1, 6);
            int Ocho = r.Next(1, 6);
            int J = r.Next(1, 6);
            int Q = r.Next(1, 6);
            int K = r.Next(1, 6);
            #endregion


            #region Validation Pictures to show in checkbox
            if (Contador < 4)
            {
                if (cboxDiceOne.Checked)
                {
                    PictureBoxOne.Enabled = false;
                }
                else
                {
                    PictureBoxOne.Image = Image.FromFile(vConfirmImage.SelectImagen(As));

                }

                if (cboxDiceTwo.Checked)
                {
                    PictureBoxTwo.Enabled = false;
                }
                else
                {
                    PictureBoxTwo.Image = Image.FromFile(vConfirmImage.SelectImagen(Siete));
                }


                if (cboxDiceThree.Checked)
                {
                    PictureBoxThree.Enabled = false;
                }
                else
                {
                    PictureBoxThree.Image = Image.FromFile(vConfirmImage.SelectImagen(Ocho));
                }


                if (cboxDiceFour.Checked)
                {
                    PictureBoxFour.Enabled = false;
                }
                else
                {
                    PictureBoxFour.Image = Image.FromFile(vConfirmImage.SelectImagen(J));
                }


                if (cboxDiceFive.Checked)
                {
                    PictureBoxFive.Enabled = false;
                }
                else
                {
                    PictureBoxFive.Image = Image.FromFile(vConfirmImage.SelectImagen(Q));
                }


                if (cboxDiceSix.Checked)
                {
                    PictureBoxSix.Enabled = false;
                }
                else
                {
                    PictureBoxSix.Image = Image.FromFile(vConfirmImage.SelectImagen(K));
                }
            }
            else
            {

                MessageBox.Show("Siga con el siguiente turno");
                Contador = 0;
                MethodsClear();
            }
            
            #endregion
            Contador++;
        }

        private void btnAddgamer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNameGamer.Text))
            {
                lstgamers.Items.Add(txtNameGamer.Text);
                MessageBox.Show("Jugador agregado");
                txtNameGamer.Clear();
            }
            else
            {
                MessageBox.Show("Debe escribir un nombre de jugador", "Aviso");
            }

        }

        private void btnDeleteGamer_Click(object sender, EventArgs e)
        {
            if (lstgamers.Items.Count > 0)
            {
                lstgamers.Items.Remove(lstgamers.SelectedItem);
            }
            else
            {
                MessageBox.Show("No existen jugadores para borrar", "Aviso");
            }
        }
        private void reiniciarJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea continuar con el cierre del juego?", "Cerrar juego",
             MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (lstgamers.Items.Count >= 2)
            {
                cboxDiceOne.Enabled = true;
                cboxDiceTwo.Enabled = true;
                cboxDiceThree.Enabled = true;
                cboxDiceFour.Enabled = true;
                cboxDiceFive.Enabled = true;
                cboxDiceSix.Enabled = true;
                PictureBoxOne.Enabled = true;
                PictureBoxTwo.Enabled = true;
                PictureBoxThree.Enabled = true;
                PictureBoxFour.Enabled = true;
                PictureBoxFive.Enabled = true;
                PictureBoxSix.Enabled = true;
                btnNextTurn.Enabled = true;
                btnThrow.Enabled = true;
            }
            else
                MessageBox.Show("Digite minimo 2 jugadores para empezar el juego");

        }
        #endregion

        #region Methods
        public void MethodsClear()
        {
            cboxDiceOne.Checked = false;
            cboxDiceTwo.Checked = false;
            cboxDiceThree.Checked = false;
            cboxDiceFour.Checked = false;
            cboxDiceFive.Checked = false;
            cboxDiceSix.Checked = false;
        }

        //public void CompletDataGrid()
        //{
        //    dataGridView1.DataSource = ;
        //}
        #endregion
    }
}
