namespace WindowsFormsApplication1
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.cboxDiceTwo = new System.Windows.Forms.CheckBox();
            this.cboxDiceFour = new System.Windows.Forms.CheckBox();
            this.cboxDiceThree = new System.Windows.Forms.CheckBox();
            this.cboxDiceSix = new System.Windows.Forms.CheckBox();
            this.cboxDiceFive = new System.Windows.Forms.CheckBox();
            this.PictureBoxTwo = new System.Windows.Forms.PictureBox();
            this.PictureBoxSix = new System.Windows.Forms.PictureBox();
            this.PictureBoxFour = new System.Windows.Forms.PictureBox();
            this.PictureBoxFive = new System.Windows.Forms.PictureBox();
            this.PictureBoxThree = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Jugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstgamers = new System.Windows.Forms.ListBox();
            this.btnAddgamer = new System.Windows.Forms.Button();
            this.btnDeleteGamer = new System.Windows.Forms.Button();
            this.txtNameGamer = new System.Windows.Forms.TextBox();
            this.btnNextTurn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThrow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBoxOne = new System.Windows.Forms.PictureBox();
            this.cboxDiceOne = new System.Windows.Forms.CheckBox();
            this.btnBegin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOne)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxDiceTwo
            // 
            this.cboxDiceTwo.AutoSize = true;
            this.cboxDiceTwo.BackColor = System.Drawing.Color.Transparent;
            this.cboxDiceTwo.Enabled = false;
            this.cboxDiceTwo.Location = new System.Drawing.Point(228, 38);
            this.cboxDiceTwo.Name = "cboxDiceTwo";
            this.cboxDiceTwo.Size = new System.Drawing.Size(15, 14);
            this.cboxDiceTwo.TabIndex = 0;
            this.cboxDiceTwo.UseVisualStyleBackColor = false;
            // 
            // cboxDiceFour
            // 
            this.cboxDiceFour.AutoSize = true;
            this.cboxDiceFour.BackColor = System.Drawing.Color.Transparent;
            this.cboxDiceFour.Enabled = false;
            this.cboxDiceFour.Location = new System.Drawing.Point(128, 165);
            this.cboxDiceFour.Name = "cboxDiceFour";
            this.cboxDiceFour.Size = new System.Drawing.Size(15, 14);
            this.cboxDiceFour.TabIndex = 1;
            this.cboxDiceFour.UseVisualStyleBackColor = false;
            // 
            // cboxDiceThree
            // 
            this.cboxDiceThree.AutoSize = true;
            this.cboxDiceThree.BackColor = System.Drawing.Color.Transparent;
            this.cboxDiceThree.Enabled = false;
            this.cboxDiceThree.Location = new System.Drawing.Point(335, 38);
            this.cboxDiceThree.Name = "cboxDiceThree";
            this.cboxDiceThree.Size = new System.Drawing.Size(15, 14);
            this.cboxDiceThree.TabIndex = 2;
            this.cboxDiceThree.UseVisualStyleBackColor = false;
            // 
            // cboxDiceSix
            // 
            this.cboxDiceSix.AutoSize = true;
            this.cboxDiceSix.BackColor = System.Drawing.Color.Transparent;
            this.cboxDiceSix.Enabled = false;
            this.cboxDiceSix.Location = new System.Drawing.Point(335, 165);
            this.cboxDiceSix.Name = "cboxDiceSix";
            this.cboxDiceSix.Size = new System.Drawing.Size(15, 14);
            this.cboxDiceSix.TabIndex = 3;
            this.cboxDiceSix.UseVisualStyleBackColor = false;
            // 
            // cboxDiceFive
            // 
            this.cboxDiceFive.AutoSize = true;
            this.cboxDiceFive.BackColor = System.Drawing.Color.Transparent;
            this.cboxDiceFive.Enabled = false;
            this.cboxDiceFive.Location = new System.Drawing.Point(228, 165);
            this.cboxDiceFive.Name = "cboxDiceFive";
            this.cboxDiceFive.Size = new System.Drawing.Size(15, 14);
            this.cboxDiceFive.TabIndex = 4;
            this.cboxDiceFive.UseVisualStyleBackColor = false;
            // 
            // PictureBoxTwo
            // 
            this.PictureBoxTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxTwo.Enabled = false;
            this.PictureBoxTwo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxTwo.Image")));
            this.PictureBoxTwo.Location = new System.Drawing.Point(203, 68);
            this.PictureBoxTwo.Name = "PictureBoxTwo";
            this.PictureBoxTwo.Size = new System.Drawing.Size(58, 59);
            this.PictureBoxTwo.TabIndex = 5;
            this.PictureBoxTwo.TabStop = false;
            // 
            // PictureBoxSix
            // 
            this.PictureBoxSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxSix.Enabled = false;
            this.PictureBoxSix.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxSix.Image")));
            this.PictureBoxSix.Location = new System.Drawing.Point(313, 185);
            this.PictureBoxSix.Name = "PictureBoxSix";
            this.PictureBoxSix.Size = new System.Drawing.Size(57, 59);
            this.PictureBoxSix.TabIndex = 6;
            this.PictureBoxSix.TabStop = false;
            // 
            // PictureBoxFour
            // 
            this.PictureBoxFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxFour.Enabled = false;
            this.PictureBoxFour.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxFour.Image")));
            this.PictureBoxFour.Location = new System.Drawing.Point(100, 185);
            this.PictureBoxFour.Name = "PictureBoxFour";
            this.PictureBoxFour.Size = new System.Drawing.Size(58, 59);
            this.PictureBoxFour.TabIndex = 7;
            this.PictureBoxFour.TabStop = false;
            // 
            // PictureBoxFive
            // 
            this.PictureBoxFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxFive.Enabled = false;
            this.PictureBoxFive.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxFive.Image")));
            this.PictureBoxFive.Location = new System.Drawing.Point(205, 185);
            this.PictureBoxFive.Name = "PictureBoxFive";
            this.PictureBoxFive.Size = new System.Drawing.Size(56, 59);
            this.PictureBoxFive.TabIndex = 8;
            this.PictureBoxFive.TabStop = false;
            // 
            // PictureBoxThree
            // 
            this.PictureBoxThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxThree.Enabled = false;
            this.PictureBoxThree.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxThree.Image")));
            this.PictureBoxThree.Location = new System.Drawing.Point(313, 68);
            this.PictureBoxThree.Name = "PictureBoxThree";
            this.PictureBoxThree.Size = new System.Drawing.Size(57, 59);
            this.PictureBoxThree.TabIndex = 9;
            this.PictureBoxThree.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Blue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jugador,
            this.Puntaje,
            this.Puntaje1,
            this.Puntaje2});
            this.dataGridView1.Location = new System.Drawing.Point(45, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 160);
            this.dataGridView1.TabIndex = 10;
            // 
            // Jugador
            // 
            this.Jugador.HeaderText = "Jugador";
            this.Jugador.Name = "Jugador";
            // 
            // Puntaje
            // 
            this.Puntaje.HeaderText = "Turno";
            this.Puntaje.Name = "Puntaje";
            // 
            // Puntaje1
            // 
            this.Puntaje1.HeaderText = "Puntaje turno";
            this.Puntaje1.Name = "Puntaje1";
            // 
            // Puntaje2
            // 
            this.Puntaje2.HeaderText = "Puntaje acumulado";
            this.Puntaje2.Name = "Puntaje2";
            // 
            // lstgamers
            // 
            this.lstgamers.BackColor = System.Drawing.Color.Blue;
            this.lstgamers.FormattingEnabled = true;
            this.lstgamers.Location = new System.Drawing.Point(528, 308);
            this.lstgamers.Name = "lstgamers";
            this.lstgamers.Size = new System.Drawing.Size(157, 160);
            this.lstgamers.TabIndex = 11;
            // 
            // btnAddgamer
            // 
            this.btnAddgamer.Location = new System.Drawing.Point(721, 308);
            this.btnAddgamer.Name = "btnAddgamer";
            this.btnAddgamer.Size = new System.Drawing.Size(72, 23);
            this.btnAddgamer.TabIndex = 12;
            this.btnAddgamer.Text = "Añadir";
            this.btnAddgamer.UseVisualStyleBackColor = true;
            this.btnAddgamer.Click += new System.EventHandler(this.btnAddgamer_Click);
            // 
            // btnDeleteGamer
            // 
            this.btnDeleteGamer.Location = new System.Drawing.Point(721, 337);
            this.btnDeleteGamer.Name = "btnDeleteGamer";
            this.btnDeleteGamer.Size = new System.Drawing.Size(72, 23);
            this.btnDeleteGamer.TabIndex = 13;
            this.btnDeleteGamer.Text = "Borrar";
            this.btnDeleteGamer.UseVisualStyleBackColor = true;
            this.btnDeleteGamer.Click += new System.EventHandler(this.btnDeleteGamer_Click);
            // 
            // txtNameGamer
            // 
            this.txtNameGamer.BackColor = System.Drawing.Color.SeaShell;
            this.txtNameGamer.Location = new System.Drawing.Point(528, 237);
            this.txtNameGamer.Name = "txtNameGamer";
            this.txtNameGamer.Size = new System.Drawing.Size(265, 20);
            this.txtNameGamer.TabIndex = 14;
            // 
            // btnNextTurn
            // 
            this.btnNextTurn.Enabled = false;
            this.btnNextTurn.Location = new System.Drawing.Point(688, 80);
            this.btnNextTurn.Name = "btnNextTurn";
            this.btnNextTurn.Size = new System.Drawing.Size(105, 23);
            this.btnNextTurn.TabIndex = 16;
            this.btnNextTurn.Text = "Siguiente turno";
            this.btnNextTurn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juegoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // juegoToolStripMenuItem
            // 
            this.juegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reiniciarJuegoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            this.juegoToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.juegoToolStripMenuItem.Text = "Juego";
            // 
            // reiniciarJuegoToolStripMenuItem
            // 
            this.reiniciarJuegoToolStripMenuItem.Name = "reiniciarJuegoToolStripMenuItem";
            this.reiniciarJuegoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.reiniciarJuegoToolStripMenuItem.Text = "Reiniciar Juego";
            this.reiniciarJuegoToolStripMenuItem.Click += new System.EventHandler(this.reiniciarJuegoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnThrow
            // 
            this.btnThrow.Enabled = false;
            this.btnThrow.Location = new System.Drawing.Point(589, 145);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(96, 34);
            this.btnThrow.TabIndex = 18;
            this.btnThrow.Text = "Lanzar dados";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(525, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre de jugador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Jugadores añadidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(42, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tabla de resultados";
            // 
            // PictureBoxOne
            // 
            this.PictureBoxOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBoxOne.Enabled = false;
            this.PictureBoxOne.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxOne.ErrorImage")));
            this.PictureBoxOne.ImageLocation = "imgs\\as.jpg";
            this.PictureBoxOne.Location = new System.Drawing.Point(100, 68);
            this.PictureBoxOne.Name = "PictureBoxOne";
            this.PictureBoxOne.Size = new System.Drawing.Size(58, 59);
            this.PictureBoxOne.TabIndex = 22;
            this.PictureBoxOne.TabStop = false;
            // 
            // cboxDiceOne
            // 
            this.cboxDiceOne.AutoSize = true;
            this.cboxDiceOne.BackColor = System.Drawing.Color.Transparent;
            this.cboxDiceOne.Location = new System.Drawing.Point(128, 40);
            this.cboxDiceOne.Name = "cboxDiceOne";
            this.cboxDiceOne.Size = new System.Drawing.Size(15, 14);
            this.cboxDiceOne.TabIndex = 23;
            this.cboxDiceOne.UseVisualStyleBackColor = false;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(493, 80);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(105, 23);
            this.btnBegin.TabIndex = 15;
            this.btnBegin.Text = "Comenzar Juego";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 501);
            this.Controls.Add(this.cboxDiceOne);
            this.Controls.Add(this.PictureBoxOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.btnNextTurn);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.txtNameGamer);
            this.Controls.Add(this.btnDeleteGamer);
            this.Controls.Add(this.btnAddgamer);
            this.Controls.Add(this.lstgamers);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PictureBoxThree);
            this.Controls.Add(this.PictureBoxFive);
            this.Controls.Add(this.PictureBoxFour);
            this.Controls.Add(this.PictureBoxSix);
            this.Controls.Add(this.PictureBoxTwo);
            this.Controls.Add(this.cboxDiceFive);
            this.Controls.Add(this.cboxDiceSix);
            this.Controls.Add(this.cboxDiceThree);
            this.Controls.Add(this.cboxDiceFour);
            this.Controls.Add(this.cboxDiceTwo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Cubilete";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cboxDiceTwo;
        private System.Windows.Forms.CheckBox cboxDiceFour;
        private System.Windows.Forms.CheckBox cboxDiceThree;
        private System.Windows.Forms.CheckBox cboxDiceSix;
        private System.Windows.Forms.CheckBox cboxDiceFive;
        private System.Windows.Forms.PictureBox PictureBoxTwo;
        private System.Windows.Forms.PictureBox PictureBoxSix;
        private System.Windows.Forms.PictureBox PictureBoxFour;
        private System.Windows.Forms.PictureBox PictureBoxFive;
        private System.Windows.Forms.PictureBox PictureBoxThree;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstgamers;
        private System.Windows.Forms.Button btnAddgamer;
        private System.Windows.Forms.Button btnDeleteGamer;
        private System.Windows.Forms.TextBox txtNameGamer;
        private System.Windows.Forms.Button btnNextTurn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juegoToolStripMenuItem;
        private System.Windows.Forms.Button btnThrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem reiniciarJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox PictureBoxOne;
        private System.Windows.Forms.CheckBox cboxDiceOne;
        private System.Windows.Forms.Button btnBegin;
    }
}

