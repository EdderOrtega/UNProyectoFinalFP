using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalFP
{
    public partial class EstudiAire : Form
    {
        Teoria[] contenido = new Teoria[]
   {
    new Teoria(
        "El Índice de Calidad del Aire (AQI) mide qué tan limpio o contaminado está el aire en una escala de 0 a 500. Un AQI bajo indica aire limpio, mientras que un AQI alto significa peligro para la salud.",
        new Pregunta[]
        {
            new Pregunta("¿Qué mide el AQI?", new string[] { "La humedad del aire", "La calidad del aire", "La temperatura" }, 1, "El AQI mide qué tan limpio o contaminado está el aire."),
            new Pregunta("¿Un AQI de 200 es...?", new string[] { "Bueno", "Peligroso", "Moderado" }, 1, "Un AQI de 200 es peligroso para la salud."),
            new Pregunta("¿Qué número indica aire limpio?", new string[] { "50", "200", "500" }, 0, "Un AQI de 50 o menos indica buena calidad del aire.")
        }
    ),
    new Teoria(
        "PM10 son partículas en el aire menores a 10 micrómetros. Provienen de polvo, cenizas y humo, y pueden irritar la nariz y los pulmones.",
        new Pregunta[]
        {
            new Pregunta("¿Qué es PM10?", new string[] { "Partículas en el aire", "Un gas contaminante", "Ozono" }, 0, "PM10 son partículas de polvo y cenizas en el aire."),
            new Pregunta("¿Qué efectos tiene PM10?", new string[] { "Mejora la salud", "Irrita la nariz y pulmones", "No afecta" }, 1, "Las partículas PM10 pueden causar problemas respiratorios."),
            new Pregunta("¿Qué reduce PM10?", new string[] { "Más tráfico", "Menos fábricas", "Quemar basura" }, 1, "Reducir fábricas y tráfico ayuda a disminuir PM10.")
        }
    ),
    new Teoria(
        "PM2.5 son partículas más pequeñas que PM10, con menos de 2.5 micrómetros. Provienen del humo de autos y fábricas y pueden entrar en el torrente sanguíneo.",
        new Pregunta[]
        {
            new Pregunta("¿Qué tan grandes son PM2.5?", new string[] { "Menos de 2.5 micrómetros", "10 micrómetros", "5 milímetros" }, 0, "Las PM2.5 son más pequeñas que 2.5 micrómetros."),
            new Pregunta("¿De dónde provienen PM2.5?", new string[] { "Fábricas y autos", "Árboles", "Ríos" }, 0, "PM2.5 provienen del humo de autos y fábricas."),
            new Pregunta("¿Por qué son peligrosas PM2.5?", new string[] { "Son grandes", "Pueden entrar a los pulmones y sangre", "No afectan la salud" }, 1, "Las PM2.5 pueden ingresar a los pulmones y torrente sanguíneo.")
        }
    ),
    new Teoria(
        "El ozono troposférico (O₃) es un contaminante que se forma cuando la luz solar reacciona con gases de autos y fábricas. Puede causar problemas respiratorios.",
        new Pregunta[]
        {
            new Pregunta("¿Cómo se forma el ozono troposférico?", new string[] { "Por la luz solar y gases contaminantes", "Por árboles", "Por el agua" }, 0, "El ozono troposférico se forma con la luz solar y contaminantes."),
            new Pregunta("¿Dónde afecta el ozono troposférico?", new string[] { "En la estratósfera", "En la troposfera", "En el océano" }, 1, "El ozono troposférico afecta el aire que respiramos."),
            new Pregunta("¿Qué problema causa?", new string[] { "Mejora la salud", "Irrita los pulmones", "Aumenta oxígeno" }, 1, "El ozono troposférico puede causar problemas respiratorios.")
        }
    ),
    new Teoria(
        "El monóxido de carbono (CO) es un gas tóxico sin color ni olor. Se produce en autos y calentadores de gas. Puede causar mareos y hasta la muerte en altas concentraciones.",
        new Pregunta[]
        {
            new Pregunta("¿Qué es el CO?", new string[] { "Un gas tóxico", "Un mineral", "Un metal" }, 0, "El monóxido de carbono es un gas tóxico."),
            new Pregunta("¿De dónde proviene el CO?", new string[] { "De autos y calentadores", "Del agua", "De los árboles" }, 0, "El CO proviene de la combustión de autos y calentadores."),
            new Pregunta("¿Qué efecto tiene el CO?", new string[] { "Es inofensivo", "Puede causar mareos y la muerte", "Aumenta oxígeno" }, 1, "El CO en grandes cantidades es mortal.")
        }
    ),
    new Teoria(
        "El dióxido de nitrógeno (NO₂) es un gas contaminante que proviene de autos y fábricas. Puede irritar los pulmones y contribuir a la lluvia ácida.",
        new Pregunta[]
        {
            new Pregunta("¿Qué es NO₂?", new string[] { "Un gas contaminante", "Un mineral", "Un metal" }, 0, "El dióxido de nitrógeno es un gas contaminante."),
            new Pregunta("¿De dónde proviene el NO₂?", new string[] { "De autos y fábricas", "Del océano", "De plantas" }, 0, "El NO₂ proviene de la quema de combustibles en autos y fábricas."),
            new Pregunta("¿Qué efecto tiene el NO₂?", new string[] { "Es inofensivo", "Irrita los pulmones", "Aumenta la calidad del aire" }, 1, "El NO₂ puede causar problemas respiratorios y lluvia ácida.")
        }
    ),
    new Teoria(
        "El dióxido de azufre (SO₂) proviene de la quema de carbón y petróleo. Contribuye a la lluvia ácida y puede causar problemas respiratorios.",
        new Pregunta[]
        {
            new Pregunta("¿Qué es SO₂?", new string[] { "Un gas contaminante", "Un metal", "Un tipo de oxígeno" }, 0, "El dióxido de azufre es un gas contaminante."),
            new Pregunta("¿Cómo se produce SO₂?", new string[] { "Por la quema de carbón y petróleo", "Por la evaporación del agua", "Por plantas y árboles" }, 0, "El SO₂ se libera al quemar carbón y petróleo."),
            new Pregunta("¿Qué daño causa?", new string[] { "Es beneficioso", "Causa lluvia ácida y problemas respiratorios", "Aumenta el oxígeno" }, 1, "El SO₂ contribuye a la lluvia ácida y afecta la salud.")
        }
    ),
    new Teoria(
        "Para mejorar la calidad del aire, es importante usar menos el auto, promover energías limpias y plantar árboles, ya que estos absorben CO₂ y mejoran el ambiente.",
        new Pregunta[]
        {
            new Pregunta("¿Cómo mejorar la calidad del aire?", new string[] { "Usando energías limpias", "Quemando más carbón", "Aumentando autos" }, 0, "Las energías limpias reducen la contaminación."),
            new Pregunta("¿Qué ayuda a limpiar el aire?", new string[] { "Árboles", "Fábricas", "Humo de autos" }, 0, "Los árboles absorben CO₂ y mejoran el aire."),
            new Pregunta("¿Qué transporte contamina menos?", new string[] { "Bicicleta", "Auto a gasolina", "Avión" }, 0, "Las bicicletas no generan contaminación del aire.")
        }
    )
   };


        private List<Pregunta> preguntasDisponibles = new List<Pregunta>();
        private List<Pregunta> preguntasUsadas = new List<Pregunta>();
        private Random random = new Random();
        private Pregunta preguntaActual;
        private Teoria teoriaActual;
        private List<Teoria> teoriasDisponibles;
        private List<Teoria> teoriasUsadas = new List<Teoria>();
        private int preguntasContestadas = 0;
        int aciertos = 0;

        public EstudiAire()
        {
            InitializeComponent();
            rbdRes1.CheckedChanged += ValidarRespuesta;
            rbdRes2.CheckedChanged += ValidarRespuesta;
            rbdRes3.CheckedChanged += ValidarRespuesta;
            lblPregunta.Visible = false;
            picLogo.Visible = false;
            gbQuizz.Visible = false;
            lblTeoria.Visible = false;
            // Establecer la imagen del PictureBox
            picInicio.Image = Image.FromFile("estudiaireLogoRedondo.png"); // Cambia por la ruta de tu imagen

            // Ajustar posición y tamaño
            picInicio.Size = new Size(900, 900);
            picInicio.Location = new Point(1200, 400); // Esto lo moverá a la posición deseada
            picInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            // Asegurar que esté al frente
            picInicio.BringToFront();
            teoriasDisponibles = new List<Teoria>(contenido);

        }

        class Pregunta
        {
            public string Enunciado { get; }
            public string[] Opciones { get; }
            public int RespuestaCorrecta { get; }
            public string Explicacion { get; }

            public Pregunta(string enunciado, string[] opciones, int respuestaCorrecta, string explicacion)
            {
                Enunciado = enunciado;
                Opciones = opciones;
                RespuestaCorrecta = respuestaCorrecta;
                Explicacion = explicacion;
            }
        }

        class Teoria
        {
            public string Explicacion { get; }
            public Pregunta[] Preguntas { get; }

            public Teoria(string explicacion, Pregunta[] preguntas)
            {
                Explicacion = explicacion;
                Preguntas = preguntas;
            }
        }

        private Pregunta ObtenerPreguntaAleatoria()
        {
            if (preguntasDisponibles.Count == 0)
            {
                MessageBox.Show("No hay más preguntas para esta teoría.");
                return null;
            }

            int indice = random.Next(preguntasDisponibles.Count);
            Pregunta preguntaAleatoria = preguntasDisponibles[indice];
            preguntasDisponibles.RemoveAt(indice); // Eliminar la pregunta una vez seleccionada
            return preguntaAleatoria;
        }


        // Método para validar la respuesta

        private void btnEmpezar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Rao rao = new Rao();
            rao.Show();
            this.Close();
        }

        // Método para validar la respuesta inmediatamente al seleccionar una opción
        private void ValidarRespuesta(object sender, EventArgs e)
        {
            int indiceSeleccionado = -1;

            if (rbdRes1.Checked) indiceSeleccionado = 0;
            else if (rbdRes2.Checked) indiceSeleccionado = 1;
            else if (rbdRes3.Checked) indiceSeleccionado = 2;

            if (indiceSeleccionado == preguntaActual.RespuestaCorrecta)
            {
                lblPregunta.ForeColor = Color.Green;
                lblPregunta.Text = "✅ ¡Correcto!";
                aciertos++;
            }
            else
            {
                lblPregunta.ForeColor = Color.Red;
                lblPregunta.Text = $"❌ Incorrecto. La respuesta correcta es: {preguntaActual.Opciones[preguntaActual.RespuestaCorrecta]}";

            }

            // Deshabilitar los radio buttons para que no pueda cambiar la respuesta
            rbdRes1.Enabled = false;
            rbdRes2.Enabled = false;
            rbdRes3.Enabled = false;

            // Mostrar botón "Siguiente" para pasar a la siguiente pregunta
            btnSiguiente.Visible = true;
        }

        // Método para pasar a la siguiente pregunta
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Si ya estamos en la fase de responder preguntas, verificar si el usuario ha seleccionado una opción
            if (lblPregunta.Visible && !rbdRes1.Checked && !rbdRes2.Checked && !rbdRes3.Checked)
            {
                MessageBox.Show("Por favor, selecciona una respuesta antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // No avanza a la siguiente pregunta
            }

            if (preguntasContestadas >= 8)
            {
                string mensajeFinal = ObtenerMensajeFinal();
                lblTeoria.Text = $"Juego terminado.\nObtuviste {aciertos} respuestas correctas.\n{mensajeFinal}";
                lblTeoria.Visible = false;
                lblPregunta.Visible = false;
                gbRespuestas.Visible = false;

                // Desactivar y ocultar el botón Siguiente
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
                progressBarQuizz.Visible = false;
                lblTeoria.Visible = true;
                lblProgreso.Visible = false;
                lblDialogo.Font = new Font("Century", 14, FontStyle.Bold);
                lblDialogo.Text = "¡Felicidades! 🎉 Has completado el quiz.\r\n"
                                + "Espero que hayas aprendido mucho sobre la calidad del aire y cómo podemos mejorarlo juntos. 🌱💨\r\n\r\n"
                                + "Pero esto no termina aquí... Ahora puedes seguir a MonitorAire,\r\n"
                                + "donde te diremos la calidad del aire en este momento 🌎 y te daremos recomendaciones personalizadas según tu rutina. 🚀\r\n"
                                + "¡Nos vemos allá! 😉";
                return; // Evitar que siga cargando nuevas preguntas
            }

            if (!lblTeoria.Visible) // Si la teoría no está visible, mostrarla
            {
                lblTeoria.Visible = true;
                lblPregunta.Visible = false;
                gbRespuestas.Visible = false;
                CargarTeoria(); // Carga la teoría antes de la pregunta
            }
            else // Si ya se mostró la teoría, ahora mostrar la pregunta
            {
                lblTeoria.Visible = false;
                lblPregunta.Visible = true;
                gbRespuestas.Visible = true;
                lblProgreso.Visible = true;
                progressBarQuizz.Visible = true;
                ActualizarProgreso();
                CargarPregunta();
            }
        }


        private string ObtenerMensajeFinal()
        {
            if (aciertos == 8) return "¡Excelente! Eres un experto. 🎉";
            if (aciertos >= 6) return "Muy bien, casi perfecto. 😊";
            if (aciertos >= 4) return "Bien, pero puedes mejorar. 👍";
            if (aciertos >= 1) return "Sigue practicando, puedes hacerlo mejor. 💪";
            return "¡Ánimo! Inténtalo de nuevo. 😅";
        }
        private void ActualizarProgreso()
        {
            preguntasContestadas++;
            lblProgreso.Text = $"{preguntasContestadas}/8"; // Mostrar "X/8"
            // Ajustar la barra de progreso
            progressBarQuizz.Value = Math.Min((preguntasContestadas * 100) / 8, 100);

        }


        // Método para cargar una nueva teoría
        private void CargarTeoria()
        {
            if (teoriasDisponibles.Count == 0)
            {
                MessageBox.Show("¡Has terminado todas las teorías!", "Fin del Quizz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Selecciona una teoría aleatoria
            int indice = random.Next(teoriasDisponibles.Count);
            teoriaActual = teoriasDisponibles[indice];
            teoriasDisponibles.RemoveAt(indice);
            teoriasUsadas.Add(teoriaActual);

            // Asigna las preguntas disponibles de la teoría actual
            preguntasDisponibles.Clear(); // Asegurarse de que no haya preguntas de otras teorías
            preguntasDisponibles.AddRange(teoriaActual.Preguntas);

            // Mostrar la teoría
            lblTeoria.Text = teoriaActual.Explicacion;
            lblTeoria.Refresh();
            Point posicionOriginal = lblTeoria.Location;
            lblTeoria.Parent = gbQuizz;
            lblTeoria.Location = gbQuizz.PointToClient(lblTeoria.Parent.PointToScreen(posicionOriginal));
            btnSiguiente.Visible = true;

            // Cargar la primera pregunta después de mostrar la teoría
            CargarPregunta();
        }

        // Método para cargar una nueva pregunta
        private void CargarPregunta()
        {
            if (preguntasDisponibles.Count == 0)
            {
                // Si no hay más preguntas disponibles, cargar una nueva teoría
                CargarTeoria();
                return;
            }

            // Obtener una pregunta aleatoria de las preguntas disponibles
            preguntaActual = ObtenerPreguntaAleatoria();
            // Restaurar color de la lblPregunta a su color original
            lblPregunta.ForeColor = Color.WhiteSmoke; // O el color que prefieras
            // Mostrar la pregunta y sus opciones
            lblPregunta.Text = preguntaActual.Enunciado;

            // Desconectar eventos para evitar validación automática al cambiar texto
            rbdRes1.CheckedChanged -= ValidarRespuesta;
            rbdRes2.CheckedChanged -= ValidarRespuesta;
            rbdRes3.CheckedChanged -= ValidarRespuesta;

            rbdRes1.Text = preguntaActual.Opciones[0];
            rbdRes2.Text = preguntaActual.Opciones[1];
            rbdRes3.Text = preguntaActual.Opciones[2];

            // Restaurar estado de los radio buttons
            rbdRes1.Checked = false;
            rbdRes2.Checked = false;
            rbdRes3.Checked = false;

            rbdRes1.Visible = true;
            rbdRes2.Visible = true;
            rbdRes3.Visible = true;

            rbdRes1.Enabled = true;
            rbdRes2.Enabled = true;
            rbdRes3.Enabled = true;

            // Volver a conectar los eventos después de cambiar los textos
            rbdRes1.CheckedChanged += ValidarRespuesta;
            rbdRes2.CheckedChanged += ValidarRespuesta;
            rbdRes3.CheckedChanged += ValidarRespuesta;
            picLogo.Focus();
        }

        private void ReiniciarQuiz()
        {
            // Restaurar todas las teorías disponibles
            teoriasDisponibles = new List<Teoria>(contenido);
            teoriasUsadas.Clear();

            // Restaurar preguntas
            preguntasDisponibles.Clear();
            preguntasUsadas.Clear();

            // Restablecer la interfaz
            lblPregunta.Visible = false;
            lblTeoria.Visible = false;
            gbQuizz.Visible = false;
            picInicio.Visible = true;
            picLogo.Visible = false;
            btnSiguiente.Visible = false;
        }

        private void Limpiar()
        {
            lblPregunta.Text = "";
            rbdRes1.Visible = false;
            rbdRes2.Visible = false;
            rbdRes3.Visible = false;
            lblDialogo.Text = "¡Hola! Mi nombre es Aire Montano \r\ny hoy te enseñaré la importancia \r\nde cuidar la calidad del aire.\r\nPrimero te daré la teoría y después \r\ncontestarás las preguntas a la derecha.";
            btnSiguiente.Visible = false;
            lblTeoria.Visible = false;
            gbRespuestas.Visible = false;
            gbQuizz.Visible = false;
            picInicio.Visible = true;
            picLogo.Visible = false;
            lblProgreso.Visible = false;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
        }

        private void EstudiAire_Load(object sender, EventArgs e)
        {
        }

        private void lblTeoria_Click(object sender, EventArgs e)
        {
        }

        private void picMontano_Click(object sender, EventArgs e)
        {
        }

        private void btnNuevoo_Click(object sender, EventArgs e)
        {
            // Limpiar interfaz y reiniciar el quiz
            Limpiar();
            ReiniciarQuiz();

            // Restablecer progreso
            preguntasContestadas = 0;
            aciertos = 0;
            lblProgreso.Text = "0/8";
            progressBarQuizz.Value = 0;

            // Reactivar btnSiguiente para iniciar nuevamente
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
        }

        private void btnEmpezarr_Click(object sender, EventArgs e)
        {
            if (lblPregunta.Visible || lblTeoria.Visible)
            {
                MessageBox.Show("Ya has iniciado el quizz. ¡Buena suerte!");
            }
            else
            {
                // Llenar la lista de preguntas disponibles solo si es la primera vez
                if (preguntasDisponibles.Count == 0 && preguntasUsadas.Count == 0)
                {
                    teoriasDisponibles = new List<Teoria>(contenido);

                    foreach (var teoria in contenido)
                    {
                        preguntasDisponibles.AddRange(teoria.Preguntas);
                    }
                }
                gbQuizz.Visible = true;
                lblTeoria.Visible = true;
                picInicio.Visible = false;
                picLogo.Visible = true;
                CargarTeoria(); // Carga la teoría antes de comenzar las preguntas
            }
        }

        private void btnSalirr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por usar nuestra aplicación");
            Rao rao = new Rao();
            rao.Show();
            this.Close();
        }
    }
}

