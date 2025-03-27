namespace ProyectoFinalFP
{
    partial class Rao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rao));
            btnSalir = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            picMonitorAire = new PictureBox();
            picCambiosAire = new PictureBox();
            picEstudiAire = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMonitorAire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCambiosAire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEstudiAire).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.DarkTurquoise;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.Desktop;
            btnSalir.Location = new Point(2096, 1358);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(400, 100);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(2154, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(376, 375);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(11, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(429, 500);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(601, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1446, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // picMonitorAire
            // 
            picMonitorAire.Anchor = AnchorStyles.None;
            picMonitorAire.Cursor = Cursors.Hand;
            picMonitorAire.Image = (Image)resources.GetObject("picMonitorAire.Image");
            picMonitorAire.Location = new Point(759, 109);
            picMonitorAire.Margin = new Padding(3, 3, 3, 500);
            picMonitorAire.Name = "picMonitorAire";
            picMonitorAire.Size = new Size(600, 600);
            picMonitorAire.SizeMode = PictureBoxSizeMode.StretchImage;
            picMonitorAire.TabIndex = 7;
            picMonitorAire.TabStop = false;
            picMonitorAire.Click += pictureBox3_Click;
            // 
            // picCambiosAire
            // 
            picCambiosAire.Anchor = AnchorStyles.Right;
            picCambiosAire.Cursor = Cursors.Hand;
            picCambiosAire.Image = (Image)resources.GetObject("picCambiosAire.Image");
            picCambiosAire.Location = new Point(1446, 109);
            picCambiosAire.Margin = new Padding(3, 3, 3, 500);
            picCambiosAire.Name = "picCambiosAire";
            picCambiosAire.Size = new Size(600, 600);
            picCambiosAire.SizeMode = PictureBoxSizeMode.StretchImage;
            picCambiosAire.TabIndex = 6;
            picCambiosAire.TabStop = false;
            picCambiosAire.Click += pictureBox2_Click;
            // 
            // picEstudiAire
            // 
            picEstudiAire.Anchor = AnchorStyles.Left;
            picEstudiAire.Cursor = Cursors.Hand;
            picEstudiAire.Image = (Image)resources.GetObject("picEstudiAire.Image");
            picEstudiAire.Location = new Point(74, 109);
            picEstudiAire.Margin = new Padding(3, 3, 3, 500);
            picEstudiAire.Name = "picEstudiAire";
            picEstudiAire.Size = new Size(600, 600);
            picEstudiAire.SizeMode = PictureBoxSizeMode.StretchImage;
            picEstudiAire.TabIndex = 11;
            picEstudiAire.TabStop = false;
            picEstudiAire.Click += picEstudiAire_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(picCambiosAire);
            panel1.Controls.Add(picEstudiAire);
            panel1.Controls.Add(picMonitorAire);
            panel1.Location = new Point(344, 425);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(2099, 925);
            panel1.TabIndex = 14;
            // 
            // Rao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 37, 66);
            ClientSize = new Size(2531, 1477);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(btnSalir);
            Name = "Rao";
            Text = " RAO";
            WindowState = FormWindowState.Maximized;
            Load += Rao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMonitorAire).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCambiosAire).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEstudiAire).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnSalir;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private PictureBox picMonitorAire;
        private PictureBox picCambiosAire;
        private PictureBox picEstudiAire;
        private Panel panel1;
    }
}
