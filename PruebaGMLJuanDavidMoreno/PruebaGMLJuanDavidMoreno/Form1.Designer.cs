namespace PruebaGMLJuanDavidMoreno
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
            this.btnCincuenta = new System.Windows.Forms.Button();
            this.btnCien = new System.Windows.Forms.Button();
            this.btnDocientos = new System.Windows.Forms.Button();
            this.btnQuinientos = new System.Windows.Forms.Button();
            this.btnMil = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCantidadDeMonedas = new System.Windows.Forms.Label();
            this.txtCantidadTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoneda50 = new System.Windows.Forms.TextBox();
            this.txtMonedas100 = new System.Windows.Forms.TextBox();
            this.txtMonedas200 = new System.Windows.Forms.TextBox();
            this.txtMonedas1000 = new System.Windows.Forms.TextBox();
            this.txtMonedas500 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCincuenta
            // 
            this.btnCincuenta.Location = new System.Drawing.Point(44, 184);
            this.btnCincuenta.Name = "btnCincuenta";
            this.btnCincuenta.Size = new System.Drawing.Size(75, 23);
            this.btnCincuenta.TabIndex = 0;
            this.btnCincuenta.Text = "50";
            this.btnCincuenta.UseVisualStyleBackColor = true;
            this.btnCincuenta.Click += new System.EventHandler(this.btnCincuenta_Click);
            // 
            // btnCien
            // 
            this.btnCien.Location = new System.Drawing.Point(157, 184);
            this.btnCien.Name = "btnCien";
            this.btnCien.Size = new System.Drawing.Size(75, 23);
            this.btnCien.TabIndex = 1;
            this.btnCien.Text = "100";
            this.btnCien.UseVisualStyleBackColor = true;
            this.btnCien.Click += new System.EventHandler(this.btnCien_Click);
            // 
            // btnDocientos
            // 
            this.btnDocientos.Location = new System.Drawing.Point(280, 184);
            this.btnDocientos.Name = "btnDocientos";
            this.btnDocientos.Size = new System.Drawing.Size(75, 23);
            this.btnDocientos.TabIndex = 2;
            this.btnDocientos.Text = "200";
            this.btnDocientos.UseVisualStyleBackColor = true;
            this.btnDocientos.Click += new System.EventHandler(this.btnDocientos_Click);
            // 
            // btnQuinientos
            // 
            this.btnQuinientos.Location = new System.Drawing.Point(392, 184);
            this.btnQuinientos.Name = "btnQuinientos";
            this.btnQuinientos.Size = new System.Drawing.Size(75, 23);
            this.btnQuinientos.TabIndex = 3;
            this.btnQuinientos.Text = "500";
            this.btnQuinientos.UseVisualStyleBackColor = true;
            this.btnQuinientos.Click += new System.EventHandler(this.btnQuinientos_Click);
            // 
            // btnMil
            // 
            this.btnMil.Location = new System.Drawing.Point(508, 184);
            this.btnMil.Name = "btnMil";
            this.btnMil.Size = new System.Drawing.Size(75, 23);
            this.btnMil.TabIndex = 4;
            this.btnMil.Text = "1000";
            this.btnMil.UseVisualStyleBackColor = true;
            this.btnMil.Click += new System.EventHandler(this.btnMil_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PruebaGMLJuanDavidMoreno.Properties.Resources.Alcancia;
            this.pictureBox2.Location = new System.Drawing.Point(25, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(392, 299);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PruebaGMLJuanDavidMoreno.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(46, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 111);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblCantidadDeMonedas
            // 
            this.lblCantidadDeMonedas.AutoSize = true;
            this.lblCantidadDeMonedas.Location = new System.Drawing.Point(453, 239);
            this.lblCantidadDeMonedas.Name = "lblCantidadDeMonedas";
            this.lblCantidadDeMonedas.Size = new System.Drawing.Size(111, 13);
            this.lblCantidadDeMonedas.TabIndex = 7;
            this.lblCantidadDeMonedas.Text = "Cantidad de Monedas";
            // 
            // txtCantidadTotal
            // 
            this.txtCantidadTotal.Location = new System.Drawing.Point(456, 269);
            this.txtCantidadTotal.Name = "txtCantidadTotal";
            this.txtCantidadTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadTotal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Monedas 50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Monedas 100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Monedas 200";
            // 
            // txtMoneda50
            // 
            this.txtMoneda50.Location = new System.Drawing.Point(449, 346);
            this.txtMoneda50.Name = "txtMoneda50";
            this.txtMoneda50.Size = new System.Drawing.Size(32, 20);
            this.txtMoneda50.TabIndex = 12;
            // 
            // txtMonedas100
            // 
            this.txtMonedas100.Location = new System.Drawing.Point(508, 346);
            this.txtMonedas100.Name = "txtMonedas100";
            this.txtMonedas100.Size = new System.Drawing.Size(32, 20);
            this.txtMonedas100.TabIndex = 13;
            // 
            // txtMonedas200
            // 
            this.txtMonedas200.Location = new System.Drawing.Point(583, 346);
            this.txtMonedas200.Name = "txtMonedas200";
            this.txtMonedas200.Size = new System.Drawing.Size(32, 20);
            this.txtMonedas200.TabIndex = 14;
            // 
            // txtMonedas1000
            // 
            this.txtMonedas1000.Location = new System.Drawing.Point(551, 416);
            this.txtMonedas1000.Name = "txtMonedas1000";
            this.txtMonedas1000.Size = new System.Drawing.Size(32, 20);
            this.txtMonedas1000.TabIndex = 18;
            // 
            // txtMonedas500
            // 
            this.txtMonedas500.Location = new System.Drawing.Point(477, 416);
            this.txtMonedas500.Name = "txtMonedas500";
            this.txtMonedas500.Size = new System.Drawing.Size(32, 20);
            this.txtMonedas500.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Monedas 1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Monedas 500";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 567);
            this.Controls.Add(this.txtMonedas1000);
            this.Controls.Add(this.txtMonedas500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMonedas200);
            this.Controls.Add(this.txtMonedas100);
            this.Controls.Add(this.txtMoneda50);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidadTotal);
            this.Controls.Add(this.lblCantidadDeMonedas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMil);
            this.Controls.Add(this.btnQuinientos);
            this.Controls.Add(this.btnDocientos);
            this.Controls.Add(this.btnCien);
            this.Controls.Add(this.btnCincuenta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCincuenta;
        private System.Windows.Forms.Button btnCien;
        private System.Windows.Forms.Button btnDocientos;
        private System.Windows.Forms.Button btnQuinientos;
        private System.Windows.Forms.Button btnMil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCantidadDeMonedas;
        private System.Windows.Forms.TextBox txtCantidadTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoneda50;
        private System.Windows.Forms.TextBox txtMonedas100;
        private System.Windows.Forms.TextBox txtMonedas200;
        private System.Windows.Forms.TextBox txtMonedas1000;
        private System.Windows.Forms.TextBox txtMonedas500;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

