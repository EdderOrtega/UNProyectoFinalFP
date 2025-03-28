using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyectoFinalFP
{
    public partial class MonitorAire : Form
    {
        private static readonly string apiKey = "6ee041fe81a92aa03aaf568088ad176c"; // 🔹 Reemplaza con tu clave de OpenWeather
        private static readonly string lat = "25.6866"; // 🔹 Latitud de Monterrey
        private static readonly string lon = "-100.3161"; // 🔹 Longitud de Monterrey

        public MonitorAire()
        {
            InitializeComponent();
            lblDialogo.Size = new Size(700, 400);
            lblDialogo.Text = "¡Bienvenido a Monitorire!\n\n" +
                  "Monitoreamos en tiempo real la calidad del aire y te damos recomendaciones para tu salud.\n\n" +
                  "💡 Un aire más limpio es una vida más saludable. Explora los datos y únete al cambio.\n\n" +
                  "¿Listo para monitorear el aire? ¡Comencemos!";
            picLogo.Visible = false;
            picInicio.Image = Image.FromFile("monitorAireLogoRedondo.png"); // Cambia por la ruta de tu imagen
            picInicio.Size = new Size(900, 900);
            picInicio.Location = new Point(1200, 300); // Esto lo moverá a la posición deseada
            picInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            picInicio.BringToFront();
            OcultarPreguntas();
            OcultarDatosApi();
        }
        private void OcultarPreguntas()
        {
            gbRutina.Visible = false;
            lblPregunta.Visible = false;
            btnSiguiente.Visible = false;
            rbdRes1.Visible = false;
            rbdRes2.Visible = false;
            lblRecomendacionesUsuario.Visible = false;
            rbdRes3.Visible = false;
        }
        private void OcultarDatosApi()
        {
            lblRecomendacionesUsuario.Visible = false;
            gbDatosApi.Visible = false;
            lblAqi.Visible = false;
            lblPM10.Visible = false;
            lblPM25.Visible = false;
            lblCO.Visible = false;
            lblNO2.Visible = false;
            lblO3.Visible = false;
            lblSO2.Visible = false;
            gbSemaforo.Visible = false;
            lblRecomendaciones.Visible = false;
        }
        private async void btnEmpezar_Click(object sender, EventArgs e)
        {
            await ObtenerCalidadDelAire();
            picLogo.Visible = true;
            picInicio.Visible = false;
            gbDatosApi.Visible = true;
            lblAqi.Visible = true;
            lblPM10.Visible = true;
            lblPM25.Visible = true;
            lblCO.Visible = true;
            lblNO2.Visible = true;
            lblO3.Visible = true;
            lblSO2.Visible = true;
            gbSemaforo.Visible = true;
            lblRecomendaciones.Visible = true;
            OcultarPreguntas();
            lblDialogo.Visible = true;
            lblDialogo.Text = "Estamos obteniendo la información actual del clima gracias a la API de OpenWeather.\n\n Los datos que ves en pantalla provienen directamente de esa fuente confiable, que nos brinda información en tiempo real sobre el clima y la calidad del aire.";
        }

        private async Task<int> ObtenerCalidadDelAire()
        {
            string url = $"http://api.openweathermap.org/data/2.5/air_pollution?lat={lat}&lon={lon}&appid={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(responseBody);

                    int aqi = json["list"][0]["main"]["aqi"].Value<int>(); // Índice AQI
                    double pm10 = json["list"][0]["components"]["pm10"].Value<double>(); // Partículas PM10
                    double pm25 = json["list"][0]["components"]["pm2_5"].Value<double>(); // Partículas PM2.5
                    double co = json["list"][0]["components"]["co"].Value<double>(); // Monóxido de carbono
                    double no2 = json["list"][0]["components"]["no2"].Value<double>(); // Dióxido de nitrógeno
                    double o3 = json["list"][0]["components"]["o3"].Value<double>(); // Ozono
                    double so2 = json["list"][0]["components"]["so2"].Value<double>(); // Dióxido de azufre

                    // 🔹 Muestra los valores en Labels dentro del Form
                    lblAqi.Text = $"Índice de Calidad del Aire: {aqi} ({ObtenerDescripcionAQI(aqi)})";
                    lblPM10.Text = $"PM10: {pm10} µg/m³";
                    lblPM25.Text = $"PM2.5: {pm25} µg/m³";
                    lblCO.Text = $"CO: {co} µg/m³";
                    lblNO2.Text = $"NO2: {no2} µg/m³";
                    lblO3.Text = $"O3: {o3} µg/m³";
                    lblSO2.Text = $"SO2: {so2} µg/m³";
                    MostrarSemaforoAQI(aqi);
                    lblRecomendaciones.Text = "Recomendaciones: \n\n" + ObtenerRecomendacionesIMECA(aqi);
                   
                    return aqi; // 🔹 Devuelve el AQI obtenido
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1; // 🔹 Devuelve -1 en caso de error
                }
            }
        }
        private string ObtenerDescripcionAQI(int aqi)
        {
            return aqi switch
            {
                1 => "Bueno 😊",
                2 => "Moderado 😐",
                3 => "No saludable para grupos sensibles 😷",
                4 => "No saludable 🚨",
                5 => "Muy Peligroso ⚠️",
                _ => "Desconocido ❓"
            };
        }

        private static List<string[]> recomendacionesIMECA = new List<string[]>
        {
        new string[] { "Buena", "Puedes realizar actividades al aire libre", "Puedes ejercitarte al aire libre", "Sin riesgo para grupos sensibles" },
        new string[] { "Regular", "Puedes realizar actividades al aire libre", "Puedes ejercitarte al aire libre", "Personas extremadamente sensibles limitar actividades al aire libre" },
        new string[] { "Mala", "Limita las actividades al aire libre", "Limita el tiempo para ejercitarte al aire libre", "Grupos sensibles permanecer en interiores" },
        new string[] { "Muy mala", "Evita las actividades al aire libre", "Evita ejercitarte al aire libre", "Mantén cerradas puertas y ventanas",
                      "Grupos sensibles permanecer en interiores", "Acude al médico si presentas síntomas de enfermedades respiratorias o cardiovasculares",
                      "Limita el uso de vehículos automotores", "Evita hacer fogatas y el uso de combustibles sólidos (carbón y leña)",
                      "Si eres fumador, limita el consumo del tabaco", "Permanecer atento a la información de la calidad del aire" },
        new string[] { "Extremadamente mala", "Suspende tus actividades al aire libre", "Suspende todo ejercicio al aire libre", "Mantén cerradas puertas y ventanas",
                      "Grupos sensibles permanecer en interiores", "Acude inmediatamente al médico, o solicita servicio de emergencia si presentas síntomas de enfermedades respiratorias o cardiovasculares",
                      "No uses vehículos automotores a menos que sea necesario", "No hacer fogatas ni usar combustible sólido (carbón y leña)", "No fumar",
                      "Permanecer atento a la información de la calidad del aire" }
    };
        private string ObtenerRecomendacionesIMECA(int aqi)
        {
            int indice = aqi switch
            {
                1 => 0,  // Buena
                2 => 1,  // Regular
                3 => 2,  // Mala
                4 => 3,  // Muy mala
                5 => 4,  // Extremadamente mala
                _ => 0   // Por defecto, Buena
            };

            // Construir mensaje con todas las recomendaciones
            string mensaje = $"Calidad del aire: {recomendacionesIMECA[indice][0]}\n";
            for (int i = 1; i < recomendacionesIMECA[indice].Length; i++)
            {
                mensaje += "- " + recomendacionesIMECA[indice][i] + "\n";
            }
            return mensaje;
        }
        private void MostrarSemaforoAQI(int aqi)
        {
            gbSemaforo.Visible = true;
            // 🔹 Lista de PictureBox en orden de menor a mayor contaminación
            PictureBox[] semaforos = { picSemVerde, picSemAmarillo, picSemNaranja, picSemRojo, picSemMorado };
            // 🔹 Ocultar todas las imágenes antes de mostrar la correcta
            foreach (var pic in semaforos)
            {
                pic.Visible = false;
            }
            // 🔹 Activar todas las luces hasta el nivel de AQI
            for (int i = 0; i < aqi; i++)
            {
                semaforos[i].Visible = true;
            }
        }

        // Lista para almacenar las respuestas seleccionadas por cada página
        private List<int> respuestasUsuario; // Guarda el índice del radio seleccionado (-1 si ninguno)
                                             // Preguntas organizadas en páginas (cada página tiene 5 opciones)
        private List<string[]> preguntasRutina = new List<string[]>
{
    new string[] { "¿Realizas ejercicio al aire libre?" ,"Sí", "No", "No estoy seguro" },
    new string[] { "¿Tienes enfermedades respiratorias como asma?", "Sí", "No", "No estoy seguro" },
    new string[] { "¿Vives cerca de avenidas o calles muy transitadas?", "Sí", "No", "No estoy seguro" },
    new string[] { "¿Tienes plantas en casa?", "Sí", "No", "No estoy seguro" },
    new string[] { "¿Usas purificadores de aire?", "Sí", "No", "No estoy seguro" }
};


        private int paginaActual = 0; // Índice de la página actual

        private async void btnRecomendacionesUsuario_Click(object sender, EventArgs e)
        {
            OcultarDatosApi();
            // Mostrar preguntas y respuestas
            rbdRes1.Visible = true;
            rbdRes2.Visible = true;
            rbdRes3.Visible = true;
            lblPregunta.Visible = true;
            gbRutina.Visible = true;
            gbDatosApi.Visible = true;
            picInicio.Visible = false;
            picLogo.Visible = true;
            btnSiguiente.Visible = true;
            lblDialogo.Visible = true;
            lblDialogo.Text = "Para ofrecerte recomendaciones personalizadas sobre cómo mejorar tu salud y bienestar en función del aire que respiras, necesitamos que respondas algunas preguntas rápidas. ¡No te preocupes, es muy sencillo! Solo selecciona tus respuestas y en seguida te daré las recomendaciones.";
            // Inicializar respuestas con -1 (ninguna opción seleccionada) si es la primera vez que se presiona el botón
            if (respuestasUsuario == null)
            {
                respuestasUsuario = new List<int>(new int[preguntasRutina.Count]);
                for (int i = 0; i < respuestasUsuario.Count; i++)
                    respuestasUsuario[i] = -1;
            }


            if (paginaActual == 0)
            {
                ActualizarPreguntas(); // Actualiza la interfaz con la primera pregunta
            }

            lblPregunta.Text = preguntasRutina[paginaActual][0];

            if (rbdRes1.Checked) respuestasUsuario[paginaActual] = 1; // Si se selecciona "Sí"
            else if (rbdRes2.Checked) respuestasUsuario[paginaActual] = 2; // Si se selecciona "No"
            else if (rbdRes3.Checked) respuestasUsuario[paginaActual] = 3; // Si se selecciona "No estoy seguro"
            else return; // Si no se ha seleccionado ninguna opción, no continuar

            if (paginaActual < preguntasRutina.Count - 1)
            {
                paginaActual++;
                ActualizarPreguntas(); // Muestra la siguiente pregunta
                return;
            }

            // Si se respondieron todas las preguntas, ocultar el grupo de preguntas
            gbRutina.Visible = false;
            lblRecomendacionesUsuario.Visible = true;

            // Obtener la calidad del aire
            int aqi = await ObtenerCalidadDelAire();
            if (aqi == -1)
            {
                lblRecomendaciones.Text = "❌ No se pudo obtener el AQI.";
                return;
            }

            // Generar recomendaciones
            lblRecomendaciones.Text = ObtenerRecomendacionesIMECA(aqi) + "\r\n";

            // Analizar respuestas del usuario y agregar recomendaciones según el AQI
            for (int i = 0; i < respuestasUsuario.Count; i++)
            {
                if (respuestasUsuario[i] == -1) continue; // Ignorar preguntas sin respuesta

                string opcion = preguntasRutina[i][respuestasUsuario[i]]; // Obtener la opción seleccionada

                if (opcion == "Hago ejercicio al aire libre" && aqi >= 3)
                    lblRecomendaciones.Visible = true;
                lblRecomendaciones.Text += "🚴 Evita hacer ejercicio al aire libre hoy.\r\n";

                if (opcion == "Tengo asma o problemas respiratorios" && aqi >= 2)
                    lblRecomendaciones.Visible = true;

                lblRecomendaciones.Text += "😷 Usa mascarilla si necesitas salir.\r\n";

                if (opcion == "Trabajo en exteriores" && aqi >= 4)
                    lblRecomendaciones.Visible = true;

                lblRecomendaciones.Text += "⚠️ Reduce el tiempo en exteriores o usa mascarilla con filtro.\r\n";
            }

            // Si no hubo ninguna recomendación específica
            if (string.IsNullOrWhiteSpace(lblRecomendaciones.Text))
            {
                lblRecomendaciones.Text = "✅ No hay restricciones significativas para tus actividades.";
            }

            // Mostrar el semáforo AQI
            MostrarSemaforoAQI(aqi);
            lblRecomendacionesUsuario.Visible = true;

            // Reiniciar la encuesta para que el usuario pueda volver a intentarlo
            paginaActual = 0;
            

        }

        // Método para actualizar las preguntas en los controles
        private void ActualizarPreguntas()
        {
            // Cargar las preguntas actuales
            lblPregunta.Text = "Responde lo siguiente: "; // Cambiar para mostrar la primera opción de la pregunta

            lblPregunta.Text = preguntasRutina[paginaActual][0];

            // Actualizar las opciones de respuesta
            rbdRes1.Text = preguntasRutina[paginaActual][1];
            rbdRes2.Text = preguntasRutina[paginaActual][2];
            rbdRes3.Text = preguntasRutina[paginaActual][3];

            // Restaurar selección previa
            lblPregunta.Text = preguntasRutina[paginaActual][0];

            rbdRes1.Checked = respuestasUsuario[paginaActual] == 1;
            rbdRes2.Checked = respuestasUsuario[paginaActual] == 2;
            rbdRes3.Checked = respuestasUsuario[paginaActual] == 3;
        }

        private async void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Guardar la respuesta seleccionada de la página actual
            if (rbdRes1.Checked) respuestasUsuario[paginaActual] = 0;
            else if (rbdRes2.Checked) respuestasUsuario[paginaActual] = 1;
            else if (rbdRes3.Checked) respuestasUsuario[paginaActual] = 2;
            else return; // Si no se seleccionó nada, no avanzar

            // Si hay más preguntas, avanzar a la siguiente
            if (paginaActual < preguntasRutina.Count - 1)
            {
                paginaActual++; // Incrementar el índice de la página
                ActualizarPreguntas(); // Actualizar la interfaz con la nueva pregunta
            }
            else
            {
                // Si se respondieron todas las preguntas, ocultar el grupo de preguntas
                gbRutina.Visible = false;
                lblRecomendacionesUsuario.Visible = true;
                lblRecomendacionesUsuario.Text = ""; // Inicializar texto para evitar concatenaciones previas
                lblRecomendacionesUsuario.Size = new Size(1000, 600);
                lblRecomendacionesUsuario.Location = new Point(980, 500); // Esto lo moverá a la posición deseada

                // Obtener la calidad del aire de forma asincrónica
                int aqi = await ObtenerCalidadDelAire();
                if (aqi == -1)
                {
                    lblRecomendacionesUsuario.Text = "❌ No se pudo obtener el AQI.";
                    return;
                }
                // Generar recomendaciones basadas en la calidad del aire
                lblRecomendacionesUsuario.Text = ObtenerRecomendacionesIMECA(aqi) + "\r\n";

                // Analizar respuestas del usuario y agregar recomendaciones personalizadas
                for (int i = 0; i < respuestasUsuario.Count; i++)
                {
                    lblRecomendacionesUsuario.Visible = true;

                    if (respuestasUsuario[i] == -1) continue; // Ignorar preguntas sin respuesta

                    string opcion = preguntasRutina[i][respuestasUsuario[i]]; // Obtener la opción seleccionada

                    // Agregar recomendaciones personalizadas basadas en las respuestas y el AQI
                    if (opcion == "Hago ejercicio al aire libre" && aqi >= 3)
                        lblRecomendacionesUsuario.Text += "🚴 Evita hacer ejercicio al aire libre hoy.\r\n";

                    if (opcion == "Tengo asma o problemas respiratorios" && aqi >= 2)
                        lblRecomendacionesUsuario.Text += "😷 Usa mascarilla si necesitas salir.\r\n";

                    if (opcion == "Trabajo en exteriores" && aqi >= 4)
                        lblRecomendacionesUsuario.Text += "⚠️ Reduce el tiempo en exteriores o usa mascarilla con filtro.\r\n";
                }
                if (string.IsNullOrWhiteSpace(lblRecomendacionesUsuario.Text))
                {
                    lblRecomendacionesUsuario.Visible = true;
                    lblRecomendacionesUsuario.Text = "✅ No hay restricciones significativas para tus actividades.";
                }

                // Mostrar el semáforo AQI
                MostrarSemaforoAQI(aqi);

                // Reiniciar la encuesta para que el usuario pueda volver a intentarlo
                paginaActual = 0;
                lblRecomendacionesUsuario.Visible = true;

                // Mostrar recomendaciones personalizadas
                MostrarRecomendaciones();
            }

        }

        private void MostrarRecomendaciones()
        {
            StringBuilder recomendaciones = new StringBuilder();

            // Comprobar cada respuesta del usuario y generar una recomendación personalizada
            for (int i = 0; i < preguntasRutina.Count; i++)
            {
                int respuesta = respuestasUsuario[i];

                switch (i)
                {
                    case 0: // Pregunta 1: ¿Realizas ejercicio al aire libre?
                        if (respuesta == 0) // Sí
                            recomendaciones.AppendLine("¡Genial! El ejercicio al aire libre es excelente para tu salud mental y física.");
                        else if (respuesta == 1) // No
                            recomendaciones.AppendLine("Intenta incorporar ejercicio al aire libre. Puede mejorar tu bienestar general.");
                        else if (respuesta == 2) // No estoy seguro
                            recomendaciones.AppendLine("Es recomendable practicar ejercicio al aire libre regularmente. ¡Inténtalo!");
                        break;

                    case 1: // Pregunta 2: ¿Tienes enfermedades respiratorias como asma?
                        if (respuesta == 0) // Sí
                            recomendaciones.AppendLine("Si tienes asma, asegúrate de evitar áreas con contaminación o altos niveles de polución.");
                        else if (respuesta == 1) // No
                            recomendaciones.AppendLine("Es importante mantenerse libre de factores que afecten la respiración, como la contaminación.");
                        else if (respuesta == 2) // No estoy seguro
                            recomendaciones.AppendLine("Si tienes dudas sobre tu salud respiratoria, te sugiero hacerte un chequeo para asegurarte.");
                        break;

                    case 2: // Pregunta 3: ¿Vives cerca de avenidas o calles muy transitadas?
                        if (respuesta == 0) // Sí
                            recomendaciones.AppendLine("Vivir cerca de calles transitadas puede afectar la calidad del aire. Usa un purificador de aire para mejorar tu salud.");
                        else if (respuesta == 1) // No
                            recomendaciones.AppendLine("¡Perfecto! Vivir en una zona sin mucha contaminación es excelente para tu salud respiratoria.");
                        else if (respuesta == 2) // No estoy seguro
                            recomendaciones.AppendLine("Es recomendable investigar los niveles de contaminación cerca de tu área para tomar precauciones.");
                        break;

                    case 3: // Pregunta 4: ¿Tienes plantas en casa?
                        if (respuesta == 0) // Sí
                            recomendaciones.AppendLine("Las plantas ayudan a purificar el aire. ¡Continúa con ellas!");
                        else if (respuesta == 1) // No
                            recomendaciones.AppendLine("Si no tienes plantas en casa, considera agregar algunas. Ayudan a mejorar la calidad del aire.");
                        else if (respuesta == 2) // No estoy seguro
                            recomendaciones.AppendLine("Las plantas son una excelente adición a tu hogar, ya que ayudan a purificar el aire.");
                        break;

                    case 4: // Pregunta 5: ¿Usas purificadores de aire?
                        if (respuesta == 0) // Sí
                            recomendaciones.AppendLine("¡Perfecto! Los purificadores de aire son muy efectivos para mantener el aire limpio en tu hogar.");
                        else if (respuesta == 1) // No
                            recomendaciones.AppendLine("Si no usas purificadores de aire, podrías considerar agregar uno, especialmente si vives en una zona con contaminación.");
                        else if (respuesta == 2) // No estoy seguro
                            recomendaciones.AppendLine("Un purificador de aire podría ser útil si tienes problemas respiratorios o vives en una zona con mucha polución.");
                        break;

                    default:
                        break;
                }
            }

            // Mostrar todas las recomendaciones generadas
            lblRecomendacionesUsuario.Text = recomendaciones.ToString();
            lblDialogo.Visible = true;
            lblDialogo.Text = "Gracias por tus respuestas.\n\n Aquí tienes recomendaciones personalizadas para mejorar tu salud. \n\n ¡Recuerda que pequeñas acciones cuentan para respirar mejor!";


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Rao rao = new Rao();
            rao.Show();
            this.Close();
        }

        private void rbdRes3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbRutina_Enter(object sender, EventArgs e)
        {

        }
    }
}
