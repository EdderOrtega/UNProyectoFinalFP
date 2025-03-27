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
            picLogo = new PictureBox();
            btnEmpezar = new Button();
            btnSalir = new Button();
            gbQuizz = new GroupBox();
            progressBarQuizz = new ProgressBar();
            lblProgreso = new Label();
            btnSiguiente = new Button();
            lblTeoria = new Label();
            lblPregunta = new Label();
            gbRespuestas = new GroupBox();
            rbdRes3 = new RadioButton();
            rbdRes2 = new RadioButton();
            rbdRes1 = new RadioButton();
            picBienvenida = new PictureBox();
            picMontano = new PictureBox();
            btnNuevo = new Button();
            lblDialogo = new Label();
            picInicio = new PictureBox();
            btnNuevoo = new Button();
            btnEmpezarr = new Button();
            btnSalirr = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            gbQuizz.SuspendLayout();
            gbRespuestas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBienvenida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMontano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInicio).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(11, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(400, 400);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // btnEmpezar
            // 
            btnEmpezar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEmpezar.BackColor = Color.FromArgb(193, 255, 114);
            btnEmpezar.Cursor = Cursors.Hand;
            btnEmpezar.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpezar.ForeColor = Color.Navy;
            btnEmpezar.Location = new Point(2477, 2148);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(261, 63);
            btnEmpezar.TabIndex = 1;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.UseVisualStyleBackColor = false;
            btnEmpezar.UseWaitCursor = true;
            btnEmpezar.Click += btnEmpezar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(193, 255, 114);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.MidnightBlue;
            btnSalir.Location = new Point(2797, 2148);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(261, 63);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // gbQuizz
            // 
            gbQuizz.BackColor = Color.FromArgb(36, 37, 66);
            gbQuizz.Controls.Add(progressBarQuizz);
            gbQuizz.Controls.Add(lblProgreso);
            gbQuizz.Controls.Add(btnSiguiente);
            gbQuizz.Controls.Add(lblTeoria);
            gbQuizz.Controls.Add(lblPregunta);
            gbQuizz.Controls.Add(gbRespuestas);
            gbQuizz.ForeColor = Color.WhiteSmoke;
            gbQuizz.Location = new Point(809, 208);
            gbQuizz.Name = "gbQuizz";
            gbQuizz.Size = new Size(1630, 1112);
            gbQuizz.TabIndex = 6;
            gbQuizz.TabStop = false;
            // 
            // progressBarQuizz
            // 
            progressBarQuizz.Location = new Point(221, 1022);
            progressBarQuizz.Name = "progressBarQuizz";
            progressBarQuizz.Size = new Size(674, 60);
            progressBarQuizz.TabIndex = 15;
            // 
            // lblProgreso
            // 
            lblProgreso.AutoSize = true;
            lblProgreso.Font = new Font("Century", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProgreso.Location = new Point(34, 1023);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(163, 57);
            lblProgreso.TabIndex = 14;
            lblProgreso.Text = "1 de 1";
            // 
            // btnSiguiente
            // 
            btnSiguiente.AutoEllipsis = true;
            btnSiguiente.BackColor = Color.FromArgb(193, 255, 114);
            btnSiguiente.Cursor = Cursors.Hand;
            btnSiguiente.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = Color.Navy;
            btnSiguiente.Location = new Point(1141, 1015);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(280, 63);
            btnSiguiente.TabIndex = 2;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblTeoria
            // 
            lblTeoria.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTeoria.AutoSize = true;
            lblTeoria.BorderStyle = BorderStyle.Fixed3D;
            lblTeoria.Font = new Font("Century", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeoria.ForeColor = Color.WhiteSmoke;
            lblTeoria.Location = new Point(216, 98);
            lblTeoria.MaximumSize = new Size(1201, 902);
            lblTeoria.MinimumSize = new Size(1200, 800);
            lblTeoria.Name = "lblTeoria";
            lblTeoria.Size = new Size(1200, 800);
            lblTeoria.TabIndex = 14;
            lblTeoria.Text = "teoria";
            lblTeoria.TextAlign = ContentAlignment.MiddleCenter;
            lblTeoria.Click += lblTeoria_Click;
            // 
            // lblPregunta
            // 
            lblPregunta.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblPregunta.AutoSize = true;
            lblPregunta.BorderStyle = BorderStyle.Fixed3D;
            lblPregunta.Font = new Font("Century", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.ForeColor = Color.WhiteSmoke;
            lblPregunta.Location = new Point(221, 98);
            lblPregunta.MaximumSize = new Size(1201, 170);
            lblPregunta.MinimumSize = new Size(1200, 160);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(1200, 160);
            lblPregunta.TabIndex = 13;
            lblPregunta.Text = "Preguntas";
            lblPregunta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbRespuestas
            // 
            gbRespuestas.Controls.Add(rbdRes3);
            gbRespuestas.Controls.Add(rbdRes2);
            gbRespuestas.Controls.Add(rbdRes1);
            gbRespuestas.Location = new Point(227, 375);
            gbRespuestas.Name = "gbRespuestas";
            gbRespuestas.Size = new Size(1194, 397);
            gbRespuestas.TabIndex = 10;
            gbRespuestas.TabStop = false;
            gbRespuestas.Visible = false;
            // 
            // rbdRes3
            // 
            rbdRes3.Appearance = Appearance.Button;
            rbdRes3.BackColor = Color.FromArgb(193, 255, 114);
            rbdRes3.Cursor = Cursors.Hand;
            rbdRes3.Font = new Font("Century", 16F, FontStyle.Bold);
            rbdRes3.ForeColor = Color.Navy;
            rbdRes3.Location = new Point(19, 277);
            rbdRes3.Name = "rbdRes3";
            rbdRes3.Size = new Size(1151, 100);
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
            rbdRes2.Cursor = Cursors.Hand;
            rbdRes2.Font = new Font("Century", 16F, FontStyle.Bold);
            rbdRes2.ForeColor = Color.Navy;
            rbdRes2.Location = new Point(19, 153);
            rbdRes2.Name = "rbdRes2";
            rbdRes2.Size = new Size(1151, 100);
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
            rbdRes1.Cursor = Cursors.Hand;
            rbdRes1.Font = new Font("Century", 16F, FontStyle.Bold);
            rbdRes1.ForeColor = Color.Navy;
            rbdRes1.Location = new Point(19, 30);
            rbdRes1.Name = "rbdRes1";
            rbdRes1.Size = new Size(1151, 100);
            rbdRes1.TabIndex = 13;
            rbdRes1.TabStop = true;
            rbdRes1.Text = "???";
            rbdRes1.TextAlign = ContentAlignment.MiddleCenter;
            rbdRes1.UseVisualStyleBackColor = false;
            rbdRes1.Visible = false;
            // 
            // picBienvenida
            // 
            picBienvenida.Image = (Image)resources.GetObject("picBienvenida.Image");
            picBienvenida.Location = new Point(929, 35);
            picBienvenida.Name = "picBienvenida";
            picBienvenida.Size = new Size(1000, 100);
            picBienvenida.SizeMode = PictureBoxSizeMode.StretchImage;
            picBienvenida.TabIndex = 0;
            picBienvenida.TabStop = false;
            // 
            // picMontano
            // 
            picMontano.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picMontano.Image = (Image)resources.GetObject("picMontano.Image");
            picMontano.Location = new Point(26, 1052);
            picMontano.Name = "picMontano";
            picMontano.Size = new Size(500, 500);
            picMontano.SizeMode = PictureBoxSizeMode.StretchImage;
            picMontano.TabIndex = 7;
            picMontano.TabStop = false;
            picMontano.Click += picMontano_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevo.BackColor = Color.FromArgb(193, 255, 114);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.Navy;
            btnNuevo.Location = new Point(2146, 2148);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(261, 63);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // lblDialogo
            // 
            lblDialogo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblDialogo.AutoSize = true;
            lblDialogo.BorderStyle = BorderStyle.Fixed3D;
            lblDialogo.Font = new Font("Century", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDialogo.ForeColor = Color.WhiteSmoke;
            lblDialogo.Location = new Point(26, 689);
            lblDialogo.MaximumSize = new Size(580, 900);
            lblDialogo.Name = "lblDialogo";
            lblDialogo.Size = new Size(580, 230);
            lblDialogo.TabIndex = 11;
            lblDialogo.Text = "¡Hola! Mi nombre es AireMontano \r\ny hoy te enseñaré la importancia \r\nde cuidar la calidad del aire.\r\nPrimero te daré la teoría y después \r\ncontestarás las preguntas a la derecha.";
            // 
            // picInicio
            // 
            picInicio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            picInicio.Location = new Point(319, 753);
            picInicio.Name = "picInicio";
            picInicio.Size = new Size(227, 75);
            picInicio.TabIndex = 12;
            picInicio.TabStop = false;
            // 
            // btnNuevoo
            // 
            btnNuevoo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevoo.BackColor = Color.FromArgb(193, 255, 114);
            btnNuevoo.Cursor = Cursors.Hand;
            btnNuevoo.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoo.ForeColor = Color.Navy;
            btnNuevoo.Location = new Point(1489, 1464);
            btnNuevoo.Name = "btnNuevoo";
            btnNuevoo.Size = new Size(261, 63);
            btnNuevoo.TabIndex = 14;
            btnNuevoo.Text = "Nuevo";
            btnNuevoo.UseVisualStyleBackColor = false;
            btnNuevoo.Click += btnNuevoo_Click;
            // 
            // btnEmpezarr
            // 
            btnEmpezarr.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEmpezarr.BackColor = Color.FromArgb(193, 255, 114);
            btnEmpezarr.Cursor = Cursors.Hand;
            btnEmpezarr.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpezarr.ForeColor = Color.Navy;
            btnEmpezarr.Location = new Point(1837, 1464);
            btnEmpezarr.Name = "btnEmpezarr";
            btnEmpezarr.Size = new Size(261, 63);
            btnEmpezarr.TabIndex = 13;
            btnEmpezarr.Text = "Empezar";
            btnEmpezarr.UseVisualStyleBackColor = false;
            btnEmpezarr.UseWaitCursor = true;
            btnEmpezarr.Click += btnEmpezarr_Click;
            // 
            // btnSalirr
            // 
            btnSalirr.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalirr.BackColor = Color.FromArgb(193, 255, 114);
            btnSalirr.Cursor = Cursors.Hand;
            btnSalirr.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalirr.ForeColor = Color.Navy;
            btnSalirr.Location = new Point(2178, 1464);
            btnSalirr.Name = "btnSalirr";
            btnSalirr.Size = new Size(261, 63);
            btnSalirr.TabIndex = 15;
            btnSalirr.Text = "Salir";
            btnSalirr.UseVisualStyleBackColor = false;
            btnSalirr.Click += btnSalirr_Click;
            // 
            // EstudiAire
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 37, 66);
            ClientSize = new Size(2493, 1570);
            ControlBox = false;
            Controls.Add(btnSalirr);
            Controls.Add(btnNuevoo);
            Controls.Add(btnEmpezarr);
            Controls.Add(picInicio);
            Controls.Add(lblDialogo);
            Controls.Add(btnNuevo);
            Controls.Add(picMontano);
            Controls.Add(picBienvenida);
            Controls.Add(btnSalir);
            Controls.Add(btnEmpezar);
            Controls.Add(picLogo);
            Controls.Add(gbQuizz);
            Name = "EstudiAire";
            Text = "EstudiAire";
            WindowState = FormWindowState.Maximized;
            Load += EstudiAire_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            gbQuizz.ResumeLayout(false);
            gbQuizz.PerformLayout();
            gbRespuestas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBienvenida).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMontano).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Button btnEmpezar;
        private Button btnSalir;
        private GroupBox gbQuizz;
        private PictureBox picBienvenida;
        private PictureBox picMontano;
        private Button btnSiguiente;
        private Button btnNuevo;
        private GroupBox gbRespuestas;
        private RadioButton rbdRes3;
        private RadioButton rbdRes2;
        private RadioButton rbdRes1;
        private Label lblDialogo;
        private PictureBox picInicio;
        private Label lblPregunta;
        private Label lblTeoria;
        private ProgressBar progressBarQuizz;
        private Label lblProgreso;
        private Button btnNuevoo;
        private Button btnEmpezarr;
        private Button btnSalirr;
    }
}