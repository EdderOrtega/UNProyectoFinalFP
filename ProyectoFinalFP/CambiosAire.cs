using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalFP
{
    public partial class CambiosAire : Form
    {
        private int imeca = 100; // Valor inicial del IMECA
        private int situacionActual = 0;
        // Lista para las preguntas restantes (no respondidas)
        List<Situacion> situacionesRestantes = new List<Situacion>();

        // Para guardar las respuestas del usuario, si es necesario
        List<int> respuestasUsuario = new List<int>();

        // Variable de puntuación si deseas llevar un conteo
        int puntuacion = 0;
        List<Situacion> situaciones = new List<Situacion>
{
    new Situacion(
        "Un nuevo transporte llega a la ciudad. ¿Cuál eliges?",
        new[] { "Tranvía eléctrico", "Autos eléctricos compartidos", "Más autos de gasolina", "Camiones diésel baratos" },
        new[] { -20, -10, +15, +25 },
        "img1.png"
    ),

    new Situacion(
        "Se plantea una nueva política ambiental. ¿Cuál apoyas?",
        new[] { "Plantar más árboles en la ciudad", "Incentivar bicicletas con ciclovías", "Reducir impuestos a fábricas", "Aumentar tierras para ganadería" },
        new[] { -15, -10, +20, +12 },
        "img2.png"
    ),

    new Situacion(
        "Un día de alto tráfico, ¿qué decisión tomas?",
        new[] { "Usar transporte público", "Ir caminando o en bici", "Usar tu coche particular", "Elegir un SUV o camioneta grande" },
        new[] { -10, -15, +10, +20 },
        "img3.jpg"
    ),

    new Situacion(
        "Se propone un nuevo reglamento de residuos. ¿Cuál apoyas?",
        new[] { "Reciclaje obligatorio", "Reducir plásticos en tiendas", "Permitir quema de basura", "No hacer cambios" },
        new[] { -10, -8, +25, +10 },
        "img4.jpg"
    ),

    new Situacion(
        "Se construirá una nueva zona industrial. ¿Dónde la ubicas?",
        new[] { "Lejos de la ciudad y con regulaciones", "En las afueras, sin restricciones", "En una zona urbana", "Cerca de un cuerpo de agua" },
        new[] { -10, +10, +20, +25 },
        "img12.png"
    ),

    new Situacion(
        "Tu gobierno debe invertir en energía. ¿Qué elige?",
        new[] { "Paneles solares en toda la ciudad", "Parques eólicos", "Más plantas de carbón", "Incrementar energía a base de petróleo" },
        new[] { -15, -10, +20, +25 },
        "img5.png"
    ),

    new Situacion(
        "Nueva forma de movilidad en la ciudad. ¿Cuál apoyas?",
        new[] { "Tren subterráneo eléctrico", "Bicicletas públicas gratuitas", "Más autopistas para coches", "Carriles exclusivos para camiones diésel" },
        new[] { -20, -10, +15, +25 },
        "img6.png"
    ),

    new Situacion(
        "¿Cómo incentivarás a las empresas a ser más ecológicas?",
        new[] { "Subsidios por usar energías limpias", "Reducción de impuestos por reciclar", "Permitirles contaminar más por dinero", "Eliminar todas las restricciones ambientales" },
        new[] { -15, -10, +20, +30 },
        "img7.jpg"
    ),

    new Situacion(
        "Se planea una gran deforestación. ¿Cómo reaccionas?",
        new[] { "Prohíbes y promueves reforestación", "Solo permites talas controladas", "Permites talas para construir", "Apruebas la tala y quema de bosques" },
        new[] { -20, -10, +15, +30 },
        "img9.jpg"
    ),

    new Situacion(
        "Crisis de residuos en la ciudad. ¿Qué solución aplicas?",
        new[] { "Mayor reciclaje y composta", "Planta de tratamiento de residuos", "Enterrar toda la basura en rellenos sanitarios", "Quemar la basura sin regulación" },
        new[] { -15, -10, +15, +25 },
        "img10.jpg"
    ),

    new Situacion(
        "Se puede mejorar el aire en los hogares. ¿Qué fomentas?",
        new[] { "Incentivos para plantas purificadoras", "Filtros de aire en hogares y oficinas", "Prohibir filtros para reducir costos", "No restringir el humo en interiores" },
        new[] { -10, -5, +10, +15 },
        "img11.jpg"
    ),

    new Situacion(
        "Unos inversionistas buscan construir un nuevo parque. ¿Qué decides?",
        new[] { "Parque con muchas áreas verdes", "Un parque con mezcla de áreas verdes y cemento", "Construcción de centros comerciales", "Aprobar rascacielos sin áreas verdes" },
        new[] { -15, -10, +20, +30 },
        "img12.jpg"
    ),

    new Situacion(
        "Nueva ley sobre emisiones vehiculares. ¿Qué regulas?",
        new[] { "Limitar autos con más de 10 años de antigüedad", "Incentivar autos híbridos y eléctricos", "Bajar impuestos a la gasolina", "Eliminar verificaciones vehiculares" },
        new[] { -15, -10, +20, +25 },
        "img13.jpg"
    ),

    new Situacion(
        "Hay una sequía en la ciudad. ¿Cómo respondes?",
        new[] { "Uso eficiente del agua en industrias y hogares", "Campaña de concienciación para la gente", "Permitir que fábricas usen más agua sin control", "Extraer agua sin límites de lagos y ríos" },
        new[] { -10, -5, +15, +20 },
        "img14.jpg"
    ),

    new Situacion(
        "Se quiere prohibir las bolsas de plástico. ¿Qué haces?",
        new[] { "Fomentar el uso de bolsas reutilizables", "Cobrar un impuesto por uso de plásticos", "Permitir el uso libre de plásticos", "Eliminar regulaciones sobre la producción de plástico" },
        new[] { -10, -5, +10, +20 },
        "img15.jpg"
    ),

    new Situacion(
        "Se detecta contaminación en el río de la ciudad. ¿Qué acción tomas?",
        new[] { "Programa de limpieza y sanciones", "Planta de tratamiento de agua", "Permitir construcciones cerca del río", "Permitir que las fábricas sigan contaminando" },
        new[] { -15, -10, +15, +30 },
        "img16.jpg"
    ),

    new Situacion(
        "Un nuevo centro comercial se está construyendo. ¿Dónde lo ubicas?",
        new[] { "Lejos de zonas naturales", "En el centro de la ciudad", "Cerca de zonas residenciales", "Cerca de espacios verdes" },
        new[] { +15, +20, +10, -10 },
        "img17.jpg"
    ),

    new Situacion(
        "Un río es contaminado por una fábrica. ¿Cómo reaccionas?",
        new[] { "Multar a la fábrica y limpiar el río", "Permitir que la fábrica siga operando", "Cerrar la fábrica temporalmente", "Solo sancionar económicamente a la fábrica" },
        new[] { -20, +30, -15, +10 },
        "img16.jpg"
    ),

    new Situacion(
        "Tu ciudad tiene una alta tasa de contaminación. ¿Qué medidas tomas?",
        new[] { "Cerrar fábricas más contaminantes", "Crear más espacios verdes", "Fomentar el uso del automóvil", "No hacer cambios significativos" },
        new[] { -20, -10, +15, +30 },
        "mtyMedio.png"
    ),

    new Situacion(
        "Una gran empresa quiere expandir su planta. ¿Cómo reaccionas?",
        new[] { "Imponer regulaciones ambientales estrictas", "Permitir la expansión sin restricciones", "Hacerla más ecológica con tecnologías limpias", "No permitir la expansión" },
        new[] { -10, +25, -5, -20 },
        "img12.jpg"
    ),

    new Situacion(
        "Tu ciudad necesita mejorar la calidad del aire. ¿Qué propuesta eliges?",
        new[] { "Crear más zonas peatonales", "Implementar transporte eléctrico", "Permitir más fábricas", "Aumentar el número de vehículos" },
        new[] { -15, -10, +25, +30 },
        "img12.png"
    )
};


        public class Situacion
        {
            public string SituacionTexto { get; set; }
            public string[] Opciones { get; set; }
            public int[] Afectacion { get; set; }
            public string Imagen { get; set; }

            public Situacion(string situacionTexto, string[] opciones, int[] afectacion, string imagen)
            {
                SituacionTexto = situacionTexto;
                Opciones = opciones;
                Afectacion = afectacion;
                Imagen = imagen;
            }
        }

        public CambiosAire()
        {
            InitializeComponent();
            gbSemaforo.Visible = false;
            groupBox1.Visible = false;
            lblDialogo.Text = "¡Bienvenido a CambiosAIre!\n" +
                "Has aprendido sobre la calidad del aire en Estudiaire.\n" +
                "Has monitoreado la calidad del aire en Monitoraire.\n" +
                "Y ahora es momento de tomar decisiones.\n" +
                "Cada elección que hagas afectará el índice IMECA " +
                "y cambiará el semáforo ambiental.\n" +
                "🌿 ¿Podrás mantener el aire limpio o  " +
                "contribuirás a su contaminación? 🚦💨\n" +
                "¡El futuro del aire está en tus manos!";
            lblIMECA.Visible = false;
            picLogo.Visible = false;
            picInicio.Image = Image.FromFile("cambiosAireLogoRedondo.png"); // Cambia por la ruta de tu imagen
            picInicio.Size = new Size(900, 900);
            picInicio.Location = new Point(1200, 300); // Esto lo moverá a la posición deseada
            picInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            picInicio.BringToFront();
            lblPregunta.Visible = false;
            // En el evento InitializeComponent o en el diseñador
            this.btnOp1.Click += new System.EventHandler(this.btnOp1_Click);
            this.btnOp2.Click += new System.EventHandler(this.btnOp2_Click);
            this.btnOp3.Click += new System.EventHandler(this.btnOp3_Click);
            this.btnOp4.Click += new System.EventHandler(this.btnOp4_Click);
        }

        List<Situacion> situacionesSeleccionadas = new List<Situacion>();

        private void IniciarJuego()
        {
            // Mezclamos las situaciones y seleccionamos 5 de ellas
            situacionesSeleccionadas = situaciones.OrderBy(x => random.Next()).Take(5).ToList();

            // Iniciar con la primera situación
            situacionActual = 0;
            CargarSituacion();
            picImgSituacion.Visible = true;
            groupBox1.Visible = true;
            picInicio.Visible = false;
            picLogo.Visible = true;
            // Habilitar los botones de opciones
            btnOp1.Visible = true;
            btnOp2.Visible = true;
            btnOp3.Visible = true;
            btnOp4.Visible = true;
            lblIMECA.Visible = true;
            lblIMECA.Text = "IMECA: " + imeca;
            lblDialogo.Visible = false;
            btnEmpezar.Visible = false;
            lblPregunta.Visible = true;
        }
        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            IniciarJuego();

        }
        Random random = new Random();


        private void CargarSituacion()
        {
            if (situacionActual < situacionesSeleccionadas.Count)
            {
                var situacion = situacionesSeleccionadas[situacionActual];
                lblPregunta.Text = situacion.SituacionTexto;
                btnOp1.Text = situacion.Opciones[0];
                btnOp2.Text = situacion.Opciones[1];
                btnOp3.Text = situacion.Opciones[2];
                btnOp4.Text = situacion.Opciones[3];

                string rutaImagen = Path.Combine(Application.StartupPath, "Resources", situacion.Imagen);
                if (File.Exists(rutaImagen))
                {
                    picImgSituacion.Image = Image.FromFile(rutaImagen);
                }
                else
                {
                    MessageBox.Show("La imagen no fue encontrada: " + rutaImagen);
                }
                lblPregunta.Visible = true;
                lblDialogo.Visible = false;
            }
            else
            {
                MessageBox.Show("Has completado todas las situaciones.", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí puedes ocultar los botones o hacer otras acciones
                btnOp1.Visible = false;
                btnOp2.Visible = false;
                btnOp3.Visible = false;
                btnOp4.Visible = false;
            }
        }
        private void ActualizarIMECA(int cambio)
        {
            imeca += cambio;
            lblIMECA.Text = "IMECA: " + imeca;
            MostrarSemaforoIMECA(imeca);
            situacionActual++; // Avanzar a la siguiente situación

            if (situacionActual < situacionesSeleccionadas.Count)
            {
                CargarSituacion(); // Cargar la siguiente situación
            }
            else
            {
                MessageBox.Show("Has completado todas las situaciones.", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Fin del juego: ocultar los controles
                btnOp1.Visible = false;
                btnOp2.Visible = false;
                btnOp3.Visible = false;
                btnOp4.Visible = false;
                lblPregunta.Visible = false;
                lblDialogo.Visible = true;
                picImgSituacion.Visible = false;
                btnEmpezar.Visible = false;
                picInicio.Size = new Size(1000, 600);
                picInicio.Location = new Point(800, 220); // Esto lo moverá a la posición deseada
                picInicio.BringToFront();
                // Determinar el mensaje basado en el IMECA
                if (imeca <= 100)
                {
                    lblDialogo.Text = "¡Felicidades! Has mantenido \n el aire limpio." +
                        "Tu IMECA final es de " + imeca + ".\n" +
                        "¡Sigue cuidando el aire!";
                    picMontano.Image = Image.FromFile("montanogifderecha.gif");
                    picInicio.Visible = true;
                    picInicio.Size = new Size(1200, 900);
                    picInicio.Location = new Point(1000, 400); // Esto lo moverá a la posición deseada
                    picInicio.Image = Image.FromFile("mtyLimpia.png"); // Cambia por la ruta de tu imagen

                }
                else if (imeca > 100 && imeca <= 150)
                {
                    lblDialogo.Text = "No mejoraste la calidad, \n pero no contaminaste más.\n" +
                        "Tu IMECA final es de " + imeca + ".\n" +
                        "¡Haz lo posible por reducir \n la contaminación!";
                    picMontano.Image = Image.FromFile("montanopreocupado.png"); // Puedes poner una imagen relacionada al nivel intermedio.
                    picInicio.Visible = true;
                    picInicio.Size = new Size(1200, 900);
                    picInicio.Location = new Point(1000, 400); // Esto lo moverá a la posición deseada
                    picInicio.Image = Image.FromFile("mtyMedia.png"); // Cambia por la ruta de tu imagen
                }
                else
                {
                    lblDialogo.Text = "¡Ups! Has contribuido a la \n contaminación del aire.\n" +
                        "Tu IMECA final es de " + imeca + ".\n" +
                        "¡Cuida el aire para un \n futuro más limpio!";
                    picMontano.Image = Image.FromFile("montanotriste.png");
                    picInicio.Visible = true;
                    picInicio.Size = new Size(1200, 900);
                    picInicio.Location = new Point(1000, 400); // Esto lo moverá a la posición deseada
                    picInicio.Image = Image.FromFile("mtySucia.png"); // Cambia por la ruta de tu imagen
                }
            }
        }

        private void MostrarSemaforoIMECA(int imeca)
        {
            gbSemaforo.Visible = true;

            // 🔹 Lista de PictureBox en orden de menor a mayor contaminación
            PictureBox[] semaforos = { picSemVerde, picSemAmarillo, picSemNaranja, picSemRojo, picSemMorado };
            foreach (var pic in semaforos)
            {
                pic.Visible = false;
            }

            if (imeca <= 50)
            {
                picSemVerde.Visible = true;
            }
            else if (imeca <= 100)
            {
                picSemVerde.Visible = true;
                picSemAmarillo.Visible = true;
            }
            else if (imeca <= 150)
            {
                picSemVerde.Visible = true;
                picSemAmarillo.Visible = true;
                picSemNaranja.Visible = true;
            }
            else if (imeca <= 200)
            {
                picSemVerde.Visible = true;
                picSemAmarillo.Visible = true;
                picSemNaranja.Visible = true;
                picSemRojo.Visible = true;
            }
            else
            {
                picSemVerde.Visible = true;
                picSemAmarillo.Visible = true;
                picSemNaranja.Visible = true;
                picSemRojo.Visible = true;
                picSemMorado.Visible = true;
            }
        }
        private void btnOp1_Click(object sender, EventArgs e)
        {
            ActualizarIMECA(situaciones[situacionActual].Afectacion[0]);
        }

        private void btnOp2_Click(object sender, EventArgs e)
        {
            ActualizarIMECA(situaciones[situacionActual].Afectacion[1]);
        }

        private void btnOp3_Click(object sender, EventArgs e)
        {
            ActualizarIMECA(situaciones[situacionActual].Afectacion[2]);
        }

        private void btnOp4_Click(object sender, EventArgs e)
        {
            ActualizarIMECA(situaciones[situacionActual].Afectacion[3]);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Rao rao = new Rao();
            rao.Show();
            this.Close();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Resetear las variables
            situacionActual = 0;
            situacionesSeleccionadas.Clear();

            // Limpiar la interfaz
            picImgSituacion.Image = null;
            lblPregunta.Visible = false;
            gbSemaforo.Visible = false;


            // Hacer visibles los botones de opciones solo cuando se inicie el juego
            btnOp1.Visible = false;
            btnOp2.Visible = false;
            btnOp3.Visible = false;
            btnOp4.Visible = false;
            imeca = 100;
            // Habilitar el botón "Empezar" para reiniciar el juego
            btnEmpezar.Enabled = true;
            btnEmpezar.Visible = true;
            lblIMECA.Visible = false;
            picLogo.Visible = false;
            groupBox1.Visible = false;
            picMontano.Image = Image.FromFile("montanohablando.png");
            picInicio.Image = Image.FromFile("cambiosAireLogoRedondo.png"); // Cambia por la ruta de tu imagen
            picInicio.Size = new Size(900, 900);
            picInicio.Location = new Point(1200, 300); // Esto lo moverá a la posición deseada
            picInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            picInicio.BringToFront();
            lblDialogo.Text = "¡Bienvenido a CambiosAIre!\n" +
                "Has aprendido sobre la calidad del aire en Estudiaire.\n" +
                "Has monitoreado la calidad del aire en Monitoraire.\n" +
                "Y ahora es momento de tomar decisiones.\n" +
                "Cada elección que hagas afectará el índice IMECA " +
                "y cambiará el semáforo ambiental.\n" +
                "🌿 ¿Podrás mantener el aire limpio o  " +
                "contribuirás a su contaminación? 🚦💨\n" +
                "¡El futuro del aire está en tus manos!";
        }
    }
}
