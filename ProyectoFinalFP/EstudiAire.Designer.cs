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
            btnSiguiente = new Button();
            txtPregunta = new TextBox();
            gbRespuestas = new GroupBox();
            rbdRes3 = new RadioButton();
            rbdRes2 = new RadioButton();
            rbdRes1 = new RadioButton();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            txtDialogo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbResultado.SuspendLayout();
            gbRespuestas.SuspendLayout();
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
            btnEmpezar.Click += btnEmpezar_Click;
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
            gbResultado.Controls.Add(btnSiguiente);
            gbResultado.Controls.Add(txtPregunta);
            gbResultado.Controls.Add(gbRespuestas);
            gbResultado.ForeColor = Color.WhiteSmoke;
            gbResultado.Location = new Point(607, 128);
            gbResultado.Name = "gbResultado";
            gbResultado.Size = new Size(1077, 636);
            gbResultado.TabIndex = 6;
            gbResultado.TabStop = false;
            gbResultado.Text = "Quizz";
            // 
            // btnSiguiente
            // 
            btnSiguiente.AutoEllipsis = true;
            btnSiguiente.BackColor = Color.FromArgb(193, 255, 114);
            btnSiguiente.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = Color.Navy;
            btnSiguiente.Location = new Point(729, 542);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(280, 63);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Visible = false;
            // 
            // txtPregunta
            // 
            txtPregunta.BackColor = Color.FromArgb(36, 37, 66);
            txtPregunta.Font = new Font("Century", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPregunta.ForeColor = Color.WhiteSmoke;
            txtPregunta.Location = new Point(41, 43);
            txtPregunta.Multiline = true;
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new Size(998, 161);
            txtPregunta.TabIndex = 9;
            txtPregunta.TextAlign = HorizontalAlignment.Center;
            // 
            // gbRespuestas
            // 
            gbRespuestas.Controls.Add(rbdRes3);
            gbRespuestas.Controls.Add(rbdRes2);
            gbRespuestas.Controls.Add(rbdRes1);
            gbRespuestas.Location = new Point(41, 231);
            gbRespuestas.Name = "gbRespuestas";
            gbRespuestas.Size = new Size(998, 280);
            gbRespuestas.TabIndex = 10;
            gbRespuestas.TabStop = false;
            gbRespuestas.Text = "groupBox1";
            // 
            // rbdRes3
            // 
            rbdRes3.Appearance = Appearance.Button;
            rbdRes3.BackColor = Color.FromArgb(193, 255, 114);
            rbdRes3.Font = new Font("Century", 16F, FontStyle.Bold);
            rbdRes3.ForeColor = Color.Navy;
            rbdRes3.Location = new Point(667, 53);
            rbdRes3.MaximumSize = new Size(300, 200);
            rbdRes3.Name = "rbdRes3";
            rbdRes3.Size = new Size(300, 180);
            rbdRes3.TabIndex = 15;
            rbdRes3.TabStop = true;
            rbdRes3.Text = "???";
            rbdRes3.TextAlign = ContentAlignment.MiddleCenter;
            rbdRes3.UseVisualStyleBackColor = false;
            rbdRes3.Visible = false;
            // 
            // rbdRes2
            // 
            rbdRes2.Appearance = Appearance.Button;
            rbdRes2.BackColor = Color.FromArgb(193, 255, 114);
            rbdRes2.Font = new Font("Century", 16F, FontStyle.Bold);
            rbdRes2.ForeColor = Color.Navy;
            rbdRes2.Location = new Point(345, 53);
            rbdRes2.MaximumSize = new Size(300, 200);
            rbdRes2.Name = "rbdRes2";
            rbdRes2.Size = new Size(300, 180);
            rbdRes2.TabIndex = 14;
            rbdRes2.TabStop = true;
            rbdRes2.Text = "???";
            rbdRes2.TextAlign = ContentAlignment.MiddleCenter;
            rbdRes2.UseVisualStyleBackColor = false;
            rbdRes2.Visible = false;
            // 
            // rbdRes1
            // 
            rbdRes1.Appearance = Appearance.Button;
            rbdRes1.BackColor = Color.FromArgb(193, 255, 114);
            rbdRes1.Font = new Font("Century", 16F, FontStyle.Bold);
            rbdRes1.ForeColor = Color.Navy;
            rbdRes1.Location = new Point(26, 53);
            rbdRes1.MaximumSize = new Size(300, 200);
            rbdRes1.Name = "rbdRes1";
            rbdRes1.Size = new Size(300, 180);
            rbdRes1.TabIndex = 13;
            rbdRes1.TabStop = true;
            rbdRes1.Text = "???";
            rbdRes1.TextAlign = ContentAlignment.MiddleCenter;
            rbdRes1.UseVisualStyleBackColor = false;
            rbdRes1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(516, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(736, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 522);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(247, 242);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
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
            // txtDialogo
            // 
            txtDialogo.BackColor = Color.FromArgb(36, 37, 66);
            txtDialogo.Font = new Font("Century", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDialogo.ForeColor = Color.WhiteSmoke;
            txtDialogo.Location = new Point(12, 236);
            txtDialogo.Multiline = true;
            txtDialogo.Name = "txtDialogo";
            txtDialogo.Size = new Size(580, 280);
            txtDialogo.TabIndex = 10;
            txtDialogo.Text = "Hola bienvenido, \r\nMi nombre es Aire Montano\r\ny hoy te enseñare la importancia \r\nde cuidar la calidad del aire\r\n\r\n";
            // 
            // EstudiAire
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 37, 66);
            ClientSize = new Size(1696, 917);
            Controls.Add(txtDialogo);
            Controls.Add(button2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(gbResultado);
            Controls.Add(btnSalir);
            Controls.Add(btnEmpezar);
            Controls.Add(pictureBox1);
            Name = "EstudiAire";
            Text = " Hola bienvenido, ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbResultado.ResumeLayout(false);
            gbResultado.PerformLayout();
            gbRespuestas.ResumeLayout(false);
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
        private Button btnSiguiente;
        private Button button2;
        private TextBox txtDialogo;
        private TextBox txtPregunta;
        private GroupBox gbRespuestas;
        private RadioButton rbdRes3;
        private RadioButton rbdRes2;
        private RadioButton rbdRes1;
    }
}