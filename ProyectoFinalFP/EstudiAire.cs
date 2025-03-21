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
    public partial class EstudiAire : Form
    {
        static Teoria[] contenido =
        {
        new Teoria(
            "La contaminación del aire es causada por sustancias dañinas en la atmósfera, como el dióxido de carbono (CO₂) y las partículas finas.",
            new Pregunta[]
            {
                new Pregunta("¿Cuál de los siguientes es un contaminante del aire?",
                    new string[] { "Oxígeno (O₂)", "Dióxido de carbono (CO₂)", "Nitrógeno (N₂)" },
                    1, "El CO₂ es un gas de efecto invernadero."),

                new Pregunta("¿Qué tipo de partículas son las más peligrosas para la salud?",
                    new string[] { "PM2.5", "PM10", "PM50" },
                    0, "Las PM2.5 pueden entrar en los pulmones.")
            }
        ),
        new Teoria(
            "El Índice de Calidad del Aire (AQI) mide la contaminación del aire y se divide en categorías de bueno a peligroso.",
            new Pregunta[]
            {
                new Pregunta("¿Qué significa AQI?",
                    new string[] { "Aire Químicamente Inofensivo", "Índice de Calidad del Aire", "Análisis de Química Industrial" },
                    1, "El AQI indica la calidad del aire."),

                new Pregunta("¿Qué color representa un AQI peligroso?",
                    new string[] { "Verde", "Rojo", "Azul" },
                    1, "El color rojo indica una calidad del aire dañina.")
            }
        ),
        new Teoria(
            "El smog se forma cuando contaminantes del aire reaccionan con la luz solar, creando una niebla tóxica.",
            new Pregunta[]
            {
                new Pregunta("¿Qué condición contribuye más a la formación del smog?",
                    new string[] { "Lluvias constantes", "Radiación solar", "Viento fuerte" },
                    1, "El sol reacciona con contaminantes para formar smog."),

                new Pregunta("¿Qué gas es un componente principal del smog?",
                    new string[] { "Ozono (O₃)", "Oxígeno (O₂)", "Helio (He)" },
                    0, "El ozono a nivel del suelo es dañino para la salud.")
            }
        ),
        new Teoria(
            "Los árboles ayudan a mejorar la calidad del aire al absorber CO₂ y filtrar partículas contaminantes.",
            new Pregunta[]
            {
                new Pregunta("¿Cómo ayudan los árboles a reducir la contaminación?",
                    new string[] { "Liberan más CO₂", "Absorben contaminantes", "Generan calor" },
                    1, "Los árboles actúan como filtros naturales."),

                new Pregunta("¿Cuál de estos árboles es más efectivo para limpiar el aire?",
                    new string[] { "Pino", "Encino", "Sauce" },
                    0, "Los pinos pueden filtrar partículas del aire.")
            }
        ),
        new Teoria(
            "El transporte público y el uso de bicicletas reducen la cantidad de emisiones contaminantes en las ciudades.",
            new Pregunta[]
            {
                new Pregunta("¿Qué beneficio tiene usar el transporte público?",
                    new string[] { "Aumenta el tráfico", "Reduce emisiones de CO₂", "Daña la economía" },
                    1, "Menos autos en la calle significa menos contaminación."),

                new Pregunta("¿Cuál de estos transportes es más ecológico?",
                    new string[] { "Coche de gasolina", "Bicicleta", "Motocicleta" },
                    1, "Las bicicletas no generan emisiones contaminantes.")
            }
        ),
        new Teoria(
            "Las fábricas deben usar filtros y regulaciones para evitar contaminar el aire.",
            new Pregunta[]
            {
                new Pregunta("¿Qué tecnología reduce la contaminación de las fábricas?",
                    new string[] { "Filtros de aire", "Chimeneas sin filtro", "Más producción" },
                    0, "Los filtros atrapan partículas dañinas."),

                new Pregunta("¿Por qué es importante regular las emisiones industriales?",
                    new string[] { "Para contaminar más", "Para reducir gases tóxicos", "Para hacer más fábricas" },
                    1, "Menos emisiones mejoran la calidad del aire.")
            }
        ),
        new Teoria(
            "Los incendios forestales liberan grandes cantidades de CO₂ y partículas tóxicas al aire.",
            new Pregunta[]
            {
                new Pregunta("¿Qué efecto tienen los incendios en la calidad del aire?",
                    new string[] { "La mejoran", "La empeoran", "No tienen efecto" },
                    1, "Los incendios generan partículas peligrosas."),

                new Pregunta("¿Qué se puede hacer para evitar incendios forestales?",
                    new string[] { "Apagar fogatas", "Tirar basura", "Encender más fuego" },
                    0, "Evitar fogatas reduce el riesgo de incendios.")
            }
        ),
        new Teoria(
            "Los vehículos eléctricos son una alternativa ecológica para reducir la contaminación del aire.",
            new Pregunta[]
            {
                new Pregunta("¿Qué ventaja tienen los autos eléctricos?",
                    new string[] { "No emiten CO₂", "Son más ruidosos", "Contaminan más" },
                    0, "No producen gases contaminantes."),

                new Pregunta("¿Cuál es un reto de los autos eléctricos?",
                    new string[] { "Falta de estaciones de carga", "Usan más gasolina", "Son ilegales" },
                    0, "La infraestructura aún está en desarrollo.")
            }
        ),
        new Teoria(
            "El uso de energías renovables, como la solar y la eólica, reduce la contaminación del aire.",
            new Pregunta[]
            {
                new Pregunta("¿Cuál es una fuente de energía limpia?",
                    new string[] { "Carbón", "Petróleo", "Solar" },
                    2, "La energía solar no contamina."),

                new Pregunta("¿Por qué la energía eólica es ecológica?",
                    new string[] { "No usa combustibles fósiles", "Emite CO₂", "Genera humo" },
                    0, "No libera gases contaminantes.")
            }
        ),
        new Teoria(
            "Cada persona puede contribuir a mejorar la calidad del aire con acciones simples como reciclar y usar menos plástico.",
            new Pregunta[]
            {
                new Pregunta("¿Cómo puedes reducir la contaminación?",
                    new string[] { "Usando menos plástico", "Tirando basura", "Quemandolo todo" },
                    0, "Reciclar ayuda a reducir residuos."),

                new Pregunta("¿Cuál de estas acciones ayuda al aire limpio?",
                    new string[] { "Plantar árboles", "Quemar hojas", "Usar más autos" },
                    0, "Plantar árboles mejora la calidad del aire.")
            }
        )
    };

        
            private List<Pregunta> preguntasDisponibles = new List<Pregunta>();
            private List<Pregunta> preguntasUsadas = new List<Pregunta>();
            private Random random = new Random();
            private Pregunta preguntaActual;
            private Teoria teoriaActual;

            public EstudiAire()
            {
                InitializeComponent();
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
                    // Si ya se usaron todas, reiniciar preguntas para el nuevo ciclo
                    preguntasDisponibles = preguntasUsadas.ToList();
                    preguntasUsadas.Clear();
                }

                int indice = random.Next(preguntasDisponibles.Count);
                Pregunta pregunta = preguntasDisponibles[indice];
                preguntasDisponibles.RemoveAt(indice);
                preguntasUsadas.Add(pregunta);

                return pregunta;
            }

        private void CargarPregunta()
        {
            preguntaActual = ObtenerPreguntaAleatoria();

            // Buscar la teoría correspondiente a la pregunta actual
            teoriaActual = contenido.FirstOrDefault(t => t.Preguntas.Contains(preguntaActual));

            // Asignar valores a los controles
            txtPregunta.Text = preguntaActual.Enunciado;
            txtDialogo.Text = teoriaActual != null ? teoriaActual.Explicacion : "Sin teoría disponible";

            rbdRes1.Text = preguntaActual.Opciones[0];
            rbdRes2.Text = preguntaActual.Opciones[1];
            rbdRes3.Text = preguntaActual.Opciones[2];

            rbdRes1.Visible = true;
            rbdRes2.Visible = true;
            rbdRes3.Visible = true;

            // Desmarcar los radio buttons
            rbdRes1.Checked = false;
            rbdRes2.Checked = false;
            rbdRes3.Checked = false;

            // Asignar eventos para evaluar la respuesta
            rbdRes1.CheckedChanged += new EventHandler(ValidarRespuesta);
            rbdRes2.CheckedChanged += new EventHandler(ValidarRespuesta);
            rbdRes3.CheckedChanged += new EventHandler(ValidarRespuesta);

            btnSiguiente.Visible = true;
        }
        // Método para validar la respuesta
        private void ValidarRespuesta(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                int indiceSeleccionado = -1;

                if (rbdRes1.Checked) indiceSeleccionado = 0;
                else if (rbdRes2.Checked) indiceSeleccionado = 1;
                else if (rbdRes3.Checked) indiceSeleccionado = 2;

                if (indiceSeleccionado == preguntaActual.RespuestaCorrecta)
                {
                    txtPregunta.ForeColor = Color.Green;
                    txtPregunta.Text = "✅  ¡Correcto!";
                }
                else
                {
                    txtPregunta.ForeColor = Color.Red;
                    txtPregunta.Text = "❌ Incorrecto. La respuesta correcta es: "
                    + preguntaActual.Opciones[preguntaActual.RespuestaCorrecta];
                }
            }
        }
        private void btnEmpezar_Click(object sender, EventArgs e)
            {
                // Llenar la lista de preguntas disponibles solo si es la primera vez
                if (preguntasDisponibles.Count == 0 && preguntasUsadas.Count == 0)
                {
                    foreach (var teoria in contenido)
                    {
                        preguntasDisponibles.AddRange(teoria.Preguntas);
                    }
                }
                CargarPregunta();
            }
        }
    }

