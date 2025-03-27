namespace ProyectoFinalFP
{
    partial class MonitorAire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorAire));
            btnSalir = new Button();
            btnEmpezar = new Button();
            pictureBox2 = new PictureBox();
            lblAqi = new Label();
            lblPM10 = new Label();
            lblPM25 = new Label();
            lblCO = new Label();
            lblNO2 = new Label();
            lblO3 = new Label();
            lblSO2 = new Label();
            gbSemaforo = new GroupBox();
            picSemMorado = new PictureBox();
            picSemRojo = new PictureBox();
            picSemNaranja = new PictureBox();
            picSemAmarillo = new PictureBox();
            picSemVerde = new PictureBox();
            pictureBox3 = new PictureBox();
            picLogo = new PictureBox();
            gbRutina = new GroupBox();
            rbdRes5 = new RadioButton();
            rbdRes4 = new RadioButton();
            lblPregunta = new Label();
            rbdRes3 = new RadioButton();
            rbdRes2 = new RadioButton();
            rbdRes1 = new RadioButton();
            btnSiguiente = new Button();
            lblRecomendacionesUsuario = new Label();
            lblRecomendaciones = new Label();
            gbDatosApi = new GroupBox();
            lblDialogo = new Label();
            picInicio = new PictureBox();
            btnRecomendacionesUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gbSemaforo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSemMorado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSemRojo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSemNaranja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSemAmarillo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSemVerde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            gbRutina.SuspendLayout();
            gbDatosApi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picInicio).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.FromArgb(255, 239, 92);
            btnSalir.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.MidnightBlue;
            btnSalir.Location = new Point(-9, 184);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(340, 110);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEmpezar
            // 
            btnEmpezar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEmpezar.BackColor = Color.FromArgb(255, 239, 92);
            btnEmpezar.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpezar.ForeColor = Color.MidnightBlue;
            btnEmpezar.Location = new Point(-459, 184);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(340, 110);
            btnEmpezar.TabIndex = 10;
            btnEmpezar.Text = "Ver calidad del aire";
            btnEmpezar.UseVisualStyleBackColor = false;
            btnEmpezar.Click += btnEmpezar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(761, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1200, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // lblAqi
            // 
            lblAqi.AutoSize = true;
            lblAqi.Font = new Font("Century", 14F, FontStyle.Bold);
            lblAqi.ForeColor = Color.WhiteSmoke;
            lblAqi.Location = new Point(42, 31);
            lblAqi.Name = "lblAqi";
            lblAqi.Size = new Size(101, 33);
            lblAqi.TabIndex = 14;
            lblAqi.Text = "label1";
            // 
            // lblPM10
            // 
            lblPM10.AutoSize = true;
            lblPM10.Font = new Font("Century", 14F, FontStyle.Bold);
            lblPM10.ForeColor = Color.WhiteSmoke;
            lblPM10.Location = new Point(42, 94);
            lblPM10.Name = "lblPM10";
            lblPM10.Size = new Size(101, 33);
            lblPM10.TabIndex = 15;
            lblPM10.Text = "label2";
            // 
            // lblPM25
            // 
            lblPM25.AutoSize = true;
            lblPM25.Font = new Font("Century", 14F, FontStyle.Bold);
            lblPM25.ForeColor = Color.WhiteSmoke;
            lblPM25.Location = new Point(42, 157);
            lblPM25.Name = "lblPM25";
            lblPM25.Size = new Size(101, 33);
            lblPM25.TabIndex = 16;
            lblPM25.Text = "label3";
            // 
            // lblCO
            // 
            lblCO.AutoSize = true;
            lblCO.Font = new Font("Century", 14F, FontStyle.Bold);
            lblCO.ForeColor = Color.WhiteSmoke;
            lblCO.Location = new Point(42, 220);
            lblCO.Name = "lblCO";
            lblCO.Size = new Size(101, 33);
            lblCO.TabIndex = 17;
            lblCO.Text = "label4";
            // 
            // lblNO2
            // 
            lblNO2.AutoSize = true;
            lblNO2.Font = new Font("Century", 14F, FontStyle.Bold);
            lblNO2.ForeColor = Color.WhiteSmoke;
            lblNO2.Location = new Point(42, 283);
            lblNO2.Name = "lblNO2";
            lblNO2.Size = new Size(101, 33);
            lblNO2.TabIndex = 18;
            lblNO2.Text = "label5";
            // 
            // lblO3
            // 
            lblO3.AutoSize = true;
            lblO3.Font = new Font("Century", 14F, FontStyle.Bold);
            lblO3.ForeColor = Color.WhiteSmoke;
            lblO3.Location = new Point(42, 345);
            lblO3.Name = "lblO3";
            lblO3.Size = new Size(101, 33);
            lblO3.TabIndex = 19;
            lblO3.Text = "label6";
            // 
            // lblSO2
            // 
            lblSO2.AutoSize = true;
            lblSO2.Font = new Font("Century", 14F, FontStyle.Bold);
            lblSO2.ForeColor = Color.WhiteSmoke;
            lblSO2.Location = new Point(42, 408);
            lblSO2.Name = "lblSO2";
            lblSO2.Size = new Size(101, 33);
            lblSO2.TabIndex = 20;
            lblSO2.Text = "label7";
            // 
            // gbSemaforo
            // 
            gbSemaforo.Controls.Add(picSemMorado);
            gbSemaforo.Controls.Add(picSemRojo);
            gbSemaforo.Controls.Add(picSemNaranja);
            gbSemaforo.Controls.Add(picSemAmarillo);
            gbSemaforo.Controls.Add(picSemVerde);
            gbSemaforo.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbSemaforo.ForeColor = Color.WhiteSmoke;
            gbSemaforo.Location = new Point(886, 180);
            gbSemaforo.Name = "gbSemaforo";
            gbSemaforo.Size = new Size(1478, 95);
            gbSemaforo.TabIndex = 22;
            gbSemaforo.TabStop = false;
            gbSemaforo.Text = "Semaforo Calidad del aire";
            gbSemaforo.Visible = false;
            // 
            // picSemMorado
            // 
            picSemMorado.Image = (Image)resources.GetObject("picSemMorado.Image");
            picSemMorado.Location = new Point(1140, 28);
            picSemMorado.Name = "picSemMorado";
            picSemMorado.Size = new Size(270, 50);
            picSemMorado.SizeMode = PictureBoxSizeMode.StretchImage;
            picSemMorado.TabIndex = 27;
            picSemMorado.TabStop = false;
            // 
            // picSemRojo
            // 
            picSemRojo.Image = (Image)resources.GetObject("picSemRojo.Image");
            picSemRojo.Location = new Point(871, 28);
            picSemRojo.Name = "picSemRojo";
            picSemRojo.Size = new Size(270, 50);
            picSemRojo.SizeMode = PictureBoxSizeMode.StretchImage;
            picSemRojo.TabIndex = 26;
            picSemRojo.TabStop = false;
            // 
            // picSemNaranja
            // 
            picSemNaranja.Image = (Image)resources.GetObject("picSemNaranja.Image");
            picSemNaranja.Location = new Point(602, 28);
            picSemNaranja.Name = "picSemNaranja";
            picSemNaranja.Size = new Size(270, 50);
            picSemNaranja.SizeMode = PictureBoxSizeMode.StretchImage;
            picSemNaranja.TabIndex = 25;
            picSemNaranja.TabStop = false;
            // 
            // picSemAmarillo
            // 
            picSemAmarillo.Image = (Image)resources.GetObject("picSemAmarillo.Image");
            picSemAmarillo.Location = new Point(333, 28);
            picSemAmarillo.Name = "picSemAmarillo";
            picSemAmarillo.Size = new Size(270, 50);
            picSemAmarillo.SizeMode = PictureBoxSizeMode.StretchImage;
            picSemAmarillo.TabIndex = 24;
            picSemAmarillo.TabStop = false;
            // 
            // picSemVerde
            // 
            picSemVerde.Image = (Image)resources.GetObject("picSemVerde.Image");
            picSemVerde.Location = new Point(64, 28);
            picSemVerde.Name = "picSemVerde";
            picSemVerde.Size = new Size(270, 50);
            picSemVerde.SizeMode = PictureBoxSizeMode.StretchImage;
            picSemVerde.TabIndex = 23;
            picSemVerde.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(47, -65);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(400, 400);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(0, 27);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(200, 200);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 12;
            picLogo.TabStop = false;
            // 
            // gbRutina
            // 
            gbRutina.Controls.Add(rbdRes5);
            gbRutina.Controls.Add(rbdRes4);
            gbRutina.Controls.Add(lblPregunta);
            gbRutina.Controls.Add(rbdRes3);
            gbRutina.Controls.Add(rbdRes2);
            gbRutina.Controls.Add(rbdRes1);
            gbRutina.Controls.Add(btnSiguiente);
            gbRutina.Location = new Point(202, 94);
            gbRutina.Name = "gbRutina";
            gbRutina.Size = new Size(1333, 771);
            gbRutina.TabIndex = 26;
            gbRutina.TabStop = false;
            // 
            // rbdRes5
            // 
            rbdRes5.BackColor = Color.FromArgb(255, 239, 92);
            rbdRes5.Cursor = Cursors.Hand;
            rbdRes5.Font = new Font("Century", 14F, FontStyle.Bold);
            rbdRes5.ForeColor = Color.Navy;
            rbdRes5.Location = new Point(72, 564);
            rbdRes5.Name = "rbdRes5";
            rbdRes5.Padding = new Padding(30, 0, 0, 0);
            rbdRes5.Size = new Size(900, 100);
            rbdRes5.TabIndex = 21;
            rbdRes5.TabStop = true;
            rbdRes5.Text = "???";
            rbdRes5.UseVisualStyleBackColor = false;
            // 
            // rbdRes4
            // 
            rbdRes4.BackColor = Color.FromArgb(255, 239, 92);
            rbdRes4.Cursor = Cursors.Hand;
            rbdRes4.Font = new Font("Century", 14F, FontStyle.Bold);
            rbdRes4.ForeColor = Color.Navy;
            rbdRes4.Location = new Point(72, 442);
            rbdRes4.Name = "rbdRes4";
            rbdRes4.Padding = new Padding(30, 0, 0, 0);
            rbdRes4.Size = new Size(900, 100);
            rbdRes4.TabIndex = 20;
            rbdRes4.TabStop = true;
            rbdRes4.Text = "???";
            rbdRes4.UseVisualStyleBackColor = false;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.ForeColor = SystemColors.Info;
            lblPregunta.Location = new Point(256, 16);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(101, 33);
            lblPregunta.TabIndex = 19;
            lblPregunta.Text = "label1";
            // 
            // rbdRes3
            // 
            rbdRes3.BackColor = Color.FromArgb(255, 239, 92);
            rbdRes3.Cursor = Cursors.Hand;
            rbdRes3.Font = new Font("Century", 14F, FontStyle.Bold);
            rbdRes3.ForeColor = Color.Navy;
            rbdRes3.Location = new Point(72, 318);
            rbdRes3.Name = "rbdRes3";
            rbdRes3.Padding = new Padding(30, 0, 0, 0);
            rbdRes3.Size = new Size(900, 100);
            rbdRes3.TabIndex = 18;
            rbdRes3.TabStop = true;
            rbdRes3.Text = "???";
            rbdRes3.UseVisualStyleBackColor = false;
            rbdRes3.CheckedChanged += rbdRes3_CheckedChanged;
            // 
            // rbdRes2
            // 
            rbdRes2.BackColor = Color.FromArgb(255, 239, 92);
            rbdRes2.Cursor = Cursors.Hand;
            rbdRes2.Font = new Font("Century", 14F, FontStyle.Bold);
            rbdRes2.ForeColor = Color.Navy;
            rbdRes2.Location = new Point(72, 194);
            rbdRes2.Name = "rbdRes2";
            rbdRes2.Padding = new Padding(30, 0, 0, 0);
            rbdRes2.Size = new Size(900, 100);
            rbdRes2.TabIndex = 17;
            rbdRes2.TabStop = true;
            rbdRes2.Text = "???";
            rbdRes2.UseVisualStyleBackColor = false;
            // 
            // rbdRes1
            // 
            rbdRes1.BackColor = Color.FromArgb(255, 239, 92);
            rbdRes1.Cursor = Cursors.Hand;
            rbdRes1.Font = new Font("Century", 14F, FontStyle.Bold);
            rbdRes1.ForeColor = Color.Navy;
            rbdRes1.Location = new Point(72, 68);
            rbdRes1.Name = "rbdRes1";
            rbdRes1.Padding = new Padding(30, 0, 0, 0);
            rbdRes1.Size = new Size(900, 100);
            rbdRes1.TabIndex = 16;
            rbdRes1.TabStop = true;
            rbdRes1.Text = "???";
            rbdRes1.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(255, 239, 92);
            btnSiguiente.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = Color.MidnightBlue;
            btnSiguiente.Location = new Point(1034, 675);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(262, 63);
            btnSiguiente.TabIndex = 11;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // lblRecomendacionesUsuario
            // 
            lblRecomendacionesUsuario.AutoSize = true;
            lblRecomendacionesUsuario.BackColor = Color.FromArgb(255, 239, 92);
            lblRecomendacionesUsuario.BorderStyle = BorderStyle.Fixed3D;
            lblRecomendacionesUsuario.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecomendacionesUsuario.ForeColor = Color.MidnightBlue;
            lblRecomendacionesUsuario.Location = new Point(47, 508);
            lblRecomendacionesUsuario.MaximumSize = new Size(1201, 601);
            lblRecomendacionesUsuario.MinimumSize = new Size(590, 580);
            lblRecomendacionesUsuario.Name = "lblRecomendacionesUsuario";
            lblRecomendacionesUsuario.Size = new Size(590, 580);
            lblRecomendacionesUsuario.TabIndex = 32;
            lblRecomendacionesUsuario.Text = "label1";
            // 
            // lblRecomendaciones
            // 
            lblRecomendaciones.AutoSize = true;
            lblRecomendaciones.BackColor = Color.FromArgb(255, 239, 92);
            lblRecomendaciones.BorderStyle = BorderStyle.Fixed3D;
            lblRecomendaciones.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecomendaciones.ForeColor = Color.MidnightBlue;
            lblRecomendaciones.Location = new Point(645, 203);
            lblRecomendaciones.MaximumSize = new Size(900, 500);
            lblRecomendaciones.MinimumSize = new Size(890, 490);
            lblRecomendaciones.Name = "lblRecomendaciones";
            lblRecomendaciones.Size = new Size(890, 490);
            lblRecomendaciones.TabIndex = 27;
            lblRecomendaciones.Text = "label1";
            // 
            // gbDatosApi
            // 
            gbDatosApi.Controls.Add(lblAqi);
            gbDatosApi.Controls.Add(lblSO2);
            gbDatosApi.Controls.Add(lblO3);
            gbDatosApi.Controls.Add(lblPM10);
            gbDatosApi.Controls.Add(lblNO2);
            gbDatosApi.Controls.Add(lblPM25);
            gbDatosApi.Controls.Add(lblCO);
            gbDatosApi.Controls.Add(gbRutina);
            gbDatosApi.Controls.Add(lblRecomendaciones);
            gbDatosApi.Location = new Point(761, 381);
            gbDatosApi.Name = "gbDatosApi";
            gbDatosApi.Size = new Size(1603, 940);
            gbDatosApi.TabIndex = 28;
            gbDatosApi.TabStop = false;
            // 
            // lblDialogo
            // 
            lblDialogo.AutoSize = true;
            lblDialogo.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDialogo.ForeColor = Color.WhiteSmoke;
            lblDialogo.Location = new Point(15, 680);
            lblDialogo.MaximumSize = new Size(701, 451);
            lblDialogo.MinimumSize = new Size(400, 450);
            lblDialogo.Name = "lblDialogo";
            lblDialogo.Size = new Size(400, 450);
            lblDialogo.TabIndex = 29;
            // 
            // picInicio
            // 
            picInicio.Image = (Image)resources.GetObject("picInicio.Image");
            picInicio.Location = new Point(1311, 180);
            picInicio.Name = "picInicio";
            picInicio.Size = new Size(600, 600);
            picInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            picInicio.TabIndex = 30;
            picInicio.TabStop = false;
            // 
            // btnRecomendacionesUsuario
            // 
            btnRecomendacionesUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRecomendacionesUsuario.BackColor = Color.FromArgb(255, 239, 92);
            btnRecomendacionesUsuario.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecomendacionesUsuario.ForeColor = Color.MidnightBlue;
            btnRecomendacionesUsuario.Location = new Point(-915, 184);
            btnRecomendacionesUsuario.Name = "btnRecomendacionesUsuario";
            btnRecomendacionesUsuario.Size = new Size(340, 110);
            btnRecomendacionesUsuario.TabIndex = 31;
            btnRecomendacionesUsuario.Text = "Recomendaciones\r\nPersonalizadas";
            btnRecomendacionesUsuario.UseVisualStyleBackColor = false;
            btnRecomendacionesUsuario.Click += btnRecomendacionesUsuario_Click;
            // 
            // MonitorAire
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 37, 66);
            ClientSize = new Size(378, 344);
            ControlBox = false;
            Controls.Add(lblRecomendacionesUsuario);
            Controls.Add(btnRecomendacionesUsuario);
            Controls.Add(picInicio);
            Controls.Add(lblDialogo);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(picLogo);
            Controls.Add(btnSalir);
            Controls.Add(btnEmpezar);
            Controls.Add(gbSemaforo);
            Controls.Add(gbDatosApi);
            Name = "MonitorAire";
            Text = "MonitorAire";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gbSemaforo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSemMorado).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSemRojo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSemNaranja).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSemAmarillo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSemVerde).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            gbRutina.ResumeLayout(false);
            gbRutina.PerformLayout();
            gbDatosApi.ResumeLayout(false);
            gbDatosApi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picInicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalir;
        private Button btnEmpezar;
        private PictureBox pictureBox2;
        private Label lblAqi;
        private Label lblPM10;
        private Label lblPM25;
        private Label lblCO;
        private Label lblNO2;
        private Label lblO3;
        private Label lblSO2;
        private SplitContainer splitContainer1;
        private GroupBox gbSemaforo;
        private PictureBox picSemMorado;
        private PictureBox picSemRojo;
        private PictureBox picSemNaranja;
        private PictureBox picSemAmarillo;
        private PictureBox picSemVerde;
        private PictureBox pictureBox3;
        private PictureBox picLogo;
        private GroupBox gbRutina;
        private Button btnSiguiente;
        private RadioButton rbdRes3;
        private RadioButton rbdRes2;
        private RadioButton rbdRes1;
        private Label lblPregunta;
        private Label lblRecomendaciones;
        private GroupBox gbDatosApi;
        private Label lblDialogo;
        private PictureBox picInicio;
        private Button btnRecomendacionesUsuario;
        private RadioButton rbdRes5;
        private RadioButton rbdRes4;
        private Label lblRecomendacionesUsuario;
    }
}