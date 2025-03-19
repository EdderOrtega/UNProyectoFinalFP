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
            picCambiosAire = new PictureBox();
            picMonitorAire = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            picEstudiAire = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCambiosAire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMonitorAire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEstudiAire).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.Gainsboro;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.Desktop;
            btnSalir.Location = new Point(1508, 776);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(239, 81);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // picCambiosAire
            // 
            picCambiosAire.Anchor = AnchorStyles.None;
            picCambiosAire.Cursor = Cursors.Hand;
            picCambiosAire.Image = (Image)resources.GetObject("picCambiosAire.Image");
            picCambiosAire.Location = new Point(1240, 282);
            picCambiosAire.Name = "picCambiosAire";
            picCambiosAire.Size = new Size(400, 400);
            picCambiosAire.SizeMode = PictureBoxSizeMode.StretchImage;
            picCambiosAire.TabIndex = 6;
            picCambiosAire.TabStop = false;
            picCambiosAire.Click += pictureBox2_Click;
            // 
            // picMonitorAire
            // 
            picMonitorAire.Anchor = AnchorStyles.None;
            picMonitorAire.Cursor = Cursors.Hand;
            picMonitorAire.Image = (Image)resources.GetObject("picMonitorAire.Image");
            picMonitorAire.Location = new Point(677, 282);
            picMonitorAire.Name = "picMonitorAire";
            picMonitorAire.Size = new Size(400, 400);
            picMonitorAire.SizeMode = PictureBoxSizeMode.StretchImage;
            picMonitorAire.TabIndex = 7;
            picMonitorAire.TabStop = false;
            picMonitorAire.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1497, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(250, 250);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(273, 10);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(187, 178);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // picEstudiAire
            // 
            picEstudiAire.Anchor = AnchorStyles.None;
            picEstudiAire.Cursor = Cursors.Hand;
            picEstudiAire.Image = (Image)resources.GetObject("picEstudiAire.Image");
            picEstudiAire.Location = new Point(110, 282);
            picEstudiAire.Name = "picEstudiAire";
            picEstudiAire.Size = new Size(400, 400);
            picEstudiAire.SizeMode = PictureBoxSizeMode.StretchImage;
            picEstudiAire.TabIndex = 11;
            picEstudiAire.TabStop = false;
            picEstudiAire.Click += picEstudiAire_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(573, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(725, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Rao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 37, 66);
            ClientSize = new Size(1759, 907);
            Controls.Add(pictureBox1);
            Controls.Add(picEstudiAire);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(picCambiosAire);
            Controls.Add(btnSalir);
            Controls.Add(picMonitorAire);
            Name = "Rao";
            Text = " ";
            Load += Rao_Load;
            ((System.ComponentModel.ISupportInitialize)picCambiosAire).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMonitorAire).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEstudiAire).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalir;
        private PictureBox picEstudiAire;
        private PictureBox picCambiosAire;
        private PictureBox picMonitorAire;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
    }
}
