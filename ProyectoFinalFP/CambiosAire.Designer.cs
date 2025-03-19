namespace ProyectoFinalFP
{
    partial class CambiosAire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiosAire));
            btnSalir = new Button();
            btnEmpezar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.Info;
            btnSalir.Location = new Point(1239, 619);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(262, 63);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnEmpezar
            // 
            btnEmpezar.BackColor = Color.FromArgb(65, 150, 216);
            btnEmpezar.Font = new Font("Century", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpezar.ForeColor = SystemColors.Info;
            btnEmpezar.Location = new Point(215, 619);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(262, 63);
            btnEmpezar.TabIndex = 3;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(500, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(891, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // CambiosAire
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 37, 66);
            ClientSize = new Size(1695, 773);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnEmpezar);
            Name = "CambiosAire";
            Text = "CambiosAire";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnEmpezar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}