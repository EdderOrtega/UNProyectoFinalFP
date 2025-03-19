namespace ProyectoFinalFP
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Rao : Form
    {
        private PictureBox pictureBox, pbMontano;
        private System.Windows.Forms.Timer timer;

        public Rao()
        {
            InitializeComponent();
            this.Text = "App Principal";
            this.Load += (s, e) => MostrarGif(); // ✅ Llamar a MostrarGif() en Load
        }

        private void MostrarGif()
        {
            PictureBox pictureBox = new PictureBox
            {

                Size = new Size(this.Width + 200, this.Height + 50), // 🔹 Cubrir todo el formulario
                Location = new Point(-100, -50), // 🔹 Subir la imagen 50px
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Image.FromFile("gif.gif") // Cambia por tu archivo real


            };

            this.Controls.Add(pictureBox);
            pictureBox.BringToFront(); // ✅ Asegurar que esté al fondo

            // 🔹 GIF de Montano limpiando (Primero: Derecha) - Cubriendo todo el Form
            PictureBox pbMontano = new PictureBox
            {
                Size = new Size(400, 400), // 🔹 Si necesitas otro tamaño, cámbialo aquí
                Location = new Point((this.Width - 400) / 2, this.Height - 650), // 🔹 Ajusta su posición si es necesario
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Image.FromFile("montanoder.gif") // Cambia por tu archivo real
            };

            this.Controls.Add(pbMontano);
            pbMontano.BringToFront(); // ✅ Asegurar que esté al frente

            // 🔹 Timer 1 (Cambia a `montanoizq.gif` después de 3 seg)
            Timer timer1 = new Timer { Interval = 3100 };
            Timer timer2 = new Timer { Interval = 1500 };
            Timer timer3 = new Timer { Interval = 6000 };

            timer1.Tick += (s, e) =>
            {
                timer1.Stop();
                pbMontano.Image = Image.FromFile("montanoIzq.gif"); // Cambia la imagen a la izquierda
                timer2.Start(); // Inicia el siguiente Timer
            };

            // 🔹 Timer 2 (Oculta todo después de 2 seg)
            timer2.Tick += (s, e) =>
            {
                timer2.Stop();  // Oculta la niebla

                pbMontano.Hide();  // Oculta Montano
            };
            timer3.Tick += (s, e) =>
            {
                timer2.Stop();
                pictureBox.Hide(); // Oculta la niebla

            };
            // 🔹 Iniciar el primer Timer
            timer1.Start();
            timer3.Start();

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new CambiosAire().Show();
            this.Hide();
        }
        private void picEstudiAire_Click(object sender, EventArgs e)
        {
            new EstudiAire().Show();
            this.Hide();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new MonitorAire().Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar nuestra aplicación");
            Application.Exit();
        }

        private void Rao_Load(object sender, EventArgs e)
        {

        }


    }
}
