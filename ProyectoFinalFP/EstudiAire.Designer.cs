namespace ProyectoFinalFP
{
    partial class EstudiAire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstudiAire));
            pictureBox1 = new PictureBox();
            btnEmpezar = new Button();
            btnSalir = new Button();
            gbResultado = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblDialogo = new Label();
            button1 = new Button();
            button2 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEmpezar
            // 
            btnEmpezar.BackColor = Color.FromArgb(193, 255, 114);
            btnEmpezar.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpezar.ForeColor = Color.Navy;
            btnEmpezar.Location = new Point(1034, 828);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(262, 63);
            btnEmpezar.TabIndex = 1;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(193, 255, 114);
            btnSalir.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.MidnightBlue;
            btnSalir.Location = new Point(1354, 828);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(262, 63);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // gbResultado
            // 
            gbResultado.Controls.Add(radioButton3);
            gbResultado.Controls.Add(radioButton2);
            gbResultado.Controls.Add(radioButton1);
            gbResultado.Controls.Add(button1);
            gbResultado.Location = new Point(607, 129);
            gbResultado.Name = "gbResultado";
            gbResultado.Size = new Size(1043, 566);
            gbResultado.TabIndex = 6;
            gbResultado.TabStop = false;
            gbResultado.Text = "groupBox1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(515, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(736, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 430);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(247, 242);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // lblDialogo
            // 
            lblDialogo.AutoSize = true;
            lblDialogo.BorderStyle = BorderStyle.Fixed3D;
            lblDialogo.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDialogo.ForeColor = Color.WhiteSmoke;
            lblDialogo.Location = new Point(12, 290);
            lblDialogo.Name = "lblDialogo";
            lblDialogo.Size = new Size(483, 134);
            lblDialogo.TabIndex = 8;
            lblDialogo.Text = "Hola bienvenido, \r\nMi nombre es Aire Montano\r\ny hoy te enseñare la importancia \r\nde cuidar la calidad del aire";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(193, 255, 114);
            button1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(713, 468);
            button1.Name = "button1";
            button1.Size = new Size(262, 63);
            button1.TabIndex = 2;
            button1.Text = "Siguiente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(193, 255, 114);
            button2.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(703, 828);
            button2.Name = "button2";
            button2.Size = new Size(262, 63);
            button2.TabIndex = 9;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.FromArgb(193, 255, 114);
            radioButton1.Cursor = Cursors.Hand;
            radioButton1.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(81, 383);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(277, 46);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.FromArgb(193, 255, 114);
            radioButton2.Cursor = Cursors.Hand;
            radioButton2.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(427, 383);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(277, 46);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.FromArgb(193, 255, 114);
            radioButton3.Cursor = Cursors.Hand;
            radioButton3.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(737, 383);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(277, 46);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // EstudiAire
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 37, 66);
            ClientSize = new Size(1695, 916);
            Controls.Add(button2);
            Controls.Add(lblDialogo);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(gbResultado);
            Controls.Add(btnSalir);
            Controls.Add(btnEmpezar);
            Controls.Add(pictureBox1);
            Name = "EstudiAire";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbResultado.ResumeLayout(false);
            gbResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEmpezar;
        private Button btnSalir;
        private GroupBox gbResultado;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblDialogo;
        private Button button1;
        private Button button2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
    }
}