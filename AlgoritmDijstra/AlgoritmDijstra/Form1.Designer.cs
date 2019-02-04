namespace AlgoritmDijstra
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgNodo1 = new System.Windows.Forms.PictureBox();
            this.imgNodo2 = new System.Windows.Forms.PictureBox();
            this.imgNodo4 = new System.Windows.Forms.PictureBox();
            this.imgNodo3 = new System.Windows.Forms.PictureBox();
            this.imgNodo5 = new System.Windows.Forms.PictureBox();
            this.imgNodo6 = new System.Windows.Forms.PictureBox();
            this.lblNodo1 = new System.Windows.Forms.Label();
            this.lblNodo2 = new System.Windows.Forms.Label();
            this.lblNodo3 = new System.Windows.Forms.Label();
            this.lblNodo4 = new System.Windows.Forms.Label();
            this.lblNodo5 = new System.Windows.Forms.Label();
            this.lblNodo6 = new System.Windows.Forms.Label();
            this.lblIngresarValor = new System.Windows.Forms.LinkLabel();
            this.chkActivateNodo1 = new System.Windows.Forms.CheckBox();
            this.chkActivateNodo2 = new System.Windows.Forms.CheckBox();
            this.chkActivateNodo3 = new System.Windows.Forms.CheckBox();
            this.chkActivateNodo4 = new System.Windows.Forms.CheckBox();
            this.chkActivateNodo5 = new System.Windows.Forms.CheckBox();
            this.chkActivateNodo6 = new System.Windows.Forms.CheckBox();
            this.lblValorVertice1 = new System.Windows.Forms.Label();
            this.lblValorVertice2 = new System.Windows.Forms.Label();
            this.lblValorVertice3 = new System.Windows.Forms.Label();
            this.lblValorVertice4 = new System.Windows.Forms.Label();
            this.lblValorVertice5 = new System.Windows.Forms.Label();
            this.lblValorVertice6 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.timerDijstra = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgNodo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNodo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNodo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNodo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNodo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNodo6)).BeginInit();
            this.SuspendLayout();
            // 
            // imgNodo1
            // 
            this.imgNodo1.Image = ((System.Drawing.Image)(resources.GetObject("imgNodo1.Image")));
            this.imgNodo1.Location = new System.Drawing.Point(24, 208);
            this.imgNodo1.Name = "imgNodo1";
            this.imgNodo1.Size = new System.Drawing.Size(102, 104);
            this.imgNodo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNodo1.TabIndex = 0;
            this.imgNodo1.TabStop = false;
            // 
            // imgNodo2
            // 
            this.imgNodo2.Image = ((System.Drawing.Image)(resources.GetObject("imgNodo2.Image")));
            this.imgNodo2.Location = new System.Drawing.Point(223, 33);
            this.imgNodo2.Name = "imgNodo2";
            this.imgNodo2.Size = new System.Drawing.Size(102, 104);
            this.imgNodo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNodo2.TabIndex = 1;
            this.imgNodo2.TabStop = false;
            // 
            // imgNodo4
            // 
            this.imgNodo4.Image = ((System.Drawing.Image)(resources.GetObject("imgNodo4.Image")));
            this.imgNodo4.Location = new System.Drawing.Point(454, 208);
            this.imgNodo4.Name = "imgNodo4";
            this.imgNodo4.Size = new System.Drawing.Size(102, 104);
            this.imgNodo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNodo4.TabIndex = 2;
            this.imgNodo4.TabStop = false;
            // 
            // imgNodo3
            // 
            this.imgNodo3.Image = ((System.Drawing.Image)(resources.GetObject("imgNodo3.Image")));
            this.imgNodo3.Location = new System.Drawing.Point(223, 342);
            this.imgNodo3.Name = "imgNodo3";
            this.imgNodo3.Size = new System.Drawing.Size(102, 104);
            this.imgNodo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNodo3.TabIndex = 3;
            this.imgNodo3.TabStop = false;
            // 
            // imgNodo5
            // 
            this.imgNodo5.Image = ((System.Drawing.Image)(resources.GetObject("imgNodo5.Image")));
            this.imgNodo5.Location = new System.Drawing.Point(676, 33);
            this.imgNodo5.Name = "imgNodo5";
            this.imgNodo5.Size = new System.Drawing.Size(102, 104);
            this.imgNodo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNodo5.TabIndex = 4;
            this.imgNodo5.TabStop = false;
            // 
            // imgNodo6
            // 
            this.imgNodo6.Image = ((System.Drawing.Image)(resources.GetObject("imgNodo6.Image")));
            this.imgNodo6.Location = new System.Drawing.Point(676, 342);
            this.imgNodo6.Name = "imgNodo6";
            this.imgNodo6.Size = new System.Drawing.Size(102, 104);
            this.imgNodo6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNodo6.TabIndex = 6;
            this.imgNodo6.TabStop = false;
            // 
            // lblNodo1
            // 
            this.lblNodo1.AutoSize = true;
            this.lblNodo1.Location = new System.Drawing.Point(57, 326);
            this.lblNodo1.Name = "lblNodo1";
            this.lblNodo1.Size = new System.Drawing.Size(42, 13);
            this.lblNodo1.TabIndex = 9;
            this.lblNodo1.Text = "Nodo 1";
            // 
            // lblNodo2
            // 
            this.lblNodo2.AutoSize = true;
            this.lblNodo2.Location = new System.Drawing.Point(256, 158);
            this.lblNodo2.Name = "lblNodo2";
            this.lblNodo2.Size = new System.Drawing.Size(42, 13);
            this.lblNodo2.TabIndex = 10;
            this.lblNodo2.Text = "Nodo 2";
            // 
            // lblNodo3
            // 
            this.lblNodo3.AutoSize = true;
            this.lblNodo3.Location = new System.Drawing.Point(256, 462);
            this.lblNodo3.Name = "lblNodo3";
            this.lblNodo3.Size = new System.Drawing.Size(42, 13);
            this.lblNodo3.TabIndex = 11;
            this.lblNodo3.Text = "Nodo 3";
            // 
            // lblNodo4
            // 
            this.lblNodo4.AutoSize = true;
            this.lblNodo4.Location = new System.Drawing.Point(485, 326);
            this.lblNodo4.Name = "lblNodo4";
            this.lblNodo4.Size = new System.Drawing.Size(42, 13);
            this.lblNodo4.TabIndex = 12;
            this.lblNodo4.Text = "Nodo 4";
            // 
            // lblNodo5
            // 
            this.lblNodo5.AutoSize = true;
            this.lblNodo5.Location = new System.Drawing.Point(708, 158);
            this.lblNodo5.Name = "lblNodo5";
            this.lblNodo5.Size = new System.Drawing.Size(42, 13);
            this.lblNodo5.TabIndex = 13;
            this.lblNodo5.Text = "Nodo 5";
            // 
            // lblNodo6
            // 
            this.lblNodo6.AutoSize = true;
            this.lblNodo6.Location = new System.Drawing.Point(708, 462);
            this.lblNodo6.Name = "lblNodo6";
            this.lblNodo6.Size = new System.Drawing.Size(42, 13);
            this.lblNodo6.TabIndex = 14;
            this.lblNodo6.Text = "Nodo 6";
            // 
            // lblIngresarValor
            // 
            this.lblIngresarValor.AutoSize = true;
            this.lblIngresarValor.Location = new System.Drawing.Point(9, 51);
            this.lblIngresarValor.Name = "lblIngresarValor";
            this.lblIngresarValor.Size = new System.Drawing.Size(108, 13);
            this.lblIngresarValor.TabIndex = 18;
            this.lblIngresarValor.TabStop = true;
            this.lblIngresarValor.Text = "Ingresar Valor Vertice";
            this.lblIngresarValor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblIngresarValor_LinkClicked);
            // 
            // chkActivateNodo1
            // 
            this.chkActivateNodo1.AutoSize = true;
            this.chkActivateNodo1.Location = new System.Drawing.Point(24, 185);
            this.chkActivateNodo1.Name = "chkActivateNodo1";
            this.chkActivateNodo1.Size = new System.Drawing.Size(103, 17);
            this.chkActivateNodo1.TabIndex = 19;
            this.chkActivateNodo1.Text = "Activate Nodo 1";
            this.chkActivateNodo1.UseVisualStyleBackColor = true;
            this.chkActivateNodo1.Visible = false;
            // 
            // chkActivateNodo2
            // 
            this.chkActivateNodo2.AutoSize = true;
            this.chkActivateNodo2.Location = new System.Drawing.Point(223, 10);
            this.chkActivateNodo2.Name = "chkActivateNodo2";
            this.chkActivateNodo2.Size = new System.Drawing.Size(103, 17);
            this.chkActivateNodo2.TabIndex = 20;
            this.chkActivateNodo2.Text = "Activate Nodo 2";
            this.chkActivateNodo2.UseVisualStyleBackColor = true;
            // 
            // chkActivateNodo3
            // 
            this.chkActivateNodo3.AutoSize = true;
            this.chkActivateNodo3.Location = new System.Drawing.Point(223, 319);
            this.chkActivateNodo3.Name = "chkActivateNodo3";
            this.chkActivateNodo3.Size = new System.Drawing.Size(103, 17);
            this.chkActivateNodo3.TabIndex = 21;
            this.chkActivateNodo3.Text = "Activate Nodo 3";
            this.chkActivateNodo3.UseVisualStyleBackColor = true;
            // 
            // chkActivateNodo4
            // 
            this.chkActivateNodo4.AutoSize = true;
            this.chkActivateNodo4.Location = new System.Drawing.Point(454, 185);
            this.chkActivateNodo4.Name = "chkActivateNodo4";
            this.chkActivateNodo4.Size = new System.Drawing.Size(103, 17);
            this.chkActivateNodo4.TabIndex = 22;
            this.chkActivateNodo4.Text = "Activate Nodo 4";
            this.chkActivateNodo4.UseVisualStyleBackColor = true;
            // 
            // chkActivateNodo5
            // 
            this.chkActivateNodo5.AutoSize = true;
            this.chkActivateNodo5.Location = new System.Drawing.Point(676, 12);
            this.chkActivateNodo5.Name = "chkActivateNodo5";
            this.chkActivateNodo5.Size = new System.Drawing.Size(103, 17);
            this.chkActivateNodo5.TabIndex = 23;
            this.chkActivateNodo5.Text = "Activate Nodo 5";
            this.chkActivateNodo5.UseVisualStyleBackColor = true;
            // 
            // chkActivateNodo6
            // 
            this.chkActivateNodo6.AutoSize = true;
            this.chkActivateNodo6.Location = new System.Drawing.Point(676, 319);
            this.chkActivateNodo6.Name = "chkActivateNodo6";
            this.chkActivateNodo6.Size = new System.Drawing.Size(103, 17);
            this.chkActivateNodo6.TabIndex = 24;
            this.chkActivateNodo6.Text = "Activate Nodo 6";
            this.chkActivateNodo6.UseVisualStyleBackColor = true;
            // 
            // lblValorVertice1
            // 
            this.lblValorVertice1.AutoSize = true;
            this.lblValorVertice1.Location = new System.Drawing.Point(74, 142);
            this.lblValorVertice1.Name = "lblValorVertice1";
            this.lblValorVertice1.Size = new System.Drawing.Size(0, 13);
            this.lblValorVertice1.TabIndex = 25;
            // 
            // lblValorVertice2
            // 
            this.lblValorVertice2.AutoSize = true;
            this.lblValorVertice2.Location = new System.Drawing.Point(267, 289);
            this.lblValorVertice2.Name = "lblValorVertice2";
            this.lblValorVertice2.Size = new System.Drawing.Size(0, 13);
            this.lblValorVertice2.TabIndex = 26;
            // 
            // lblValorVertice3
            // 
            this.lblValorVertice3.AutoSize = true;
            this.lblValorVertice3.Location = new System.Drawing.Point(267, 185);
            this.lblValorVertice3.Name = "lblValorVertice3";
            this.lblValorVertice3.Size = new System.Drawing.Size(0, 13);
            this.lblValorVertice3.TabIndex = 27;
            // 
            // lblValorVertice4
            // 
            this.lblValorVertice4.AutoSize = true;
            this.lblValorVertice4.Location = new System.Drawing.Point(507, 158);
            this.lblValorVertice4.Name = "lblValorVertice4";
            this.lblValorVertice4.Size = new System.Drawing.Size(0, 13);
            this.lblValorVertice4.TabIndex = 28;
            // 
            // lblValorVertice5
            // 
            this.lblValorVertice5.AutoSize = true;
            this.lblValorVertice5.Location = new System.Drawing.Point(723, 185);
            this.lblValorVertice5.Name = "lblValorVertice5";
            this.lblValorVertice5.Size = new System.Drawing.Size(0, 13);
            this.lblValorVertice5.TabIndex = 29;
            // 
            // lblValorVertice6
            // 
            this.lblValorVertice6.AutoSize = true;
            this.lblValorVertice6.Location = new System.Drawing.Point(723, 289);
            this.lblValorVertice6.Name = "lblValorVertice6";
            this.lblValorVertice6.Size = new System.Drawing.Size(0, 13);
            this.lblValorVertice6.TabIndex = 30;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(24, 449);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 31;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // timerDijstra
            // 
            this.timerDijstra.Tick += new System.EventHandler(this.timerDijstra_Tick);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(123, 449);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 484);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblValorVertice6);
            this.Controls.Add(this.lblValorVertice5);
            this.Controls.Add(this.lblValorVertice4);
            this.Controls.Add(this.lblValorVertice3);
            this.Controls.Add(this.lblValorVertice2);
            this.Controls.Add(this.lblValorVertice1);
            this.Controls.Add(this.chkActivateNodo6);
            this.Controls.Add(this.chkActivateNodo5);
            this.Controls.Add(this.chkActivateNodo4);
            this.Controls.Add(this.chkActivateNodo3);
            this.Controls.Add(this.chkActivateNodo2);
            this.Controls.Add(this.chkActivateNodo1);
            this.Controls.Add(this.lblIngresarValor);
            this.Controls.Add(this.lblNodo6);
            this.Controls.Add(this.lblNodo5);
            this.Controls.Add(this.lblNodo4);
            this.Controls.Add(this.lblNodo3);
            this.Controls.Add(this.lblNodo2);
            this.Controls.Add(this.lblNodo1);
            this.Controls.Add(this.imgNodo6);
            this.Controls.Add(this.imgNodo5);
            this.Controls.Add(this.imgNodo3);
            this.Controls.Add(this.imgNodo4);
            this.Controls.Add(this.imgNodo2);
            this.Controls.Add(this.imgNodo1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgNodo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNodo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNodo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNodo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNodo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNodo6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgNodo1;
        private System.Windows.Forms.PictureBox imgNodo2;
        private System.Windows.Forms.PictureBox imgNodo4;
        private System.Windows.Forms.PictureBox imgNodo3;
        private System.Windows.Forms.PictureBox imgNodo5;
        private System.Windows.Forms.PictureBox imgNodo6;
        private System.Windows.Forms.Label lblNodo1;
        private System.Windows.Forms.Label lblNodo2;
        private System.Windows.Forms.Label lblNodo3;
        private System.Windows.Forms.Label lblNodo4;
        private System.Windows.Forms.Label lblNodo5;
        private System.Windows.Forms.Label lblNodo6;
        private System.Windows.Forms.LinkLabel lblIngresarValor;
        private System.Windows.Forms.CheckBox chkActivateNodo1;
        private System.Windows.Forms.CheckBox chkActivateNodo2;
        private System.Windows.Forms.CheckBox chkActivateNodo3;
        private System.Windows.Forms.CheckBox chkActivateNodo4;
        private System.Windows.Forms.CheckBox chkActivateNodo5;
        private System.Windows.Forms.CheckBox chkActivateNodo6;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Timer timerDijstra;
        public System.Windows.Forms.Label lblValorVertice1;
        public System.Windows.Forms.Label lblValorVertice2;
        public System.Windows.Forms.Label lblValorVertice3;
        public System.Windows.Forms.Label lblValorVertice4;
        public System.Windows.Forms.Label lblValorVertice5;
        public System.Windows.Forms.Label lblValorVertice6;
        private System.Windows.Forms.Button btnReset;
    }
}

