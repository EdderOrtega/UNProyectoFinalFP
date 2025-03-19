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
        }

        private async void btnEmpezar_Click(object sender, EventArgs e)
        {
            await ObtenerCalidadDelAire();
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
                    txtBoxRecomendaciones.Text = ObtenerRecomendacionesIMECA(aqi);

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
            string mensaje = $"Categoría: {recomendacionesIMECA[indice][0]}\n";
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

        // Método para actualizar el TextBox con las recomendaciones
        public void MostrarRecomendaciones(int aqi, TextBox txtBoxRecomendaciones)
        {
            txtBoxRecomendaciones.Text = ObtenerRecomendacionesIMECA(aqi);
        }


        private async void btnObtenerRecomendaciones_Click_1(object sender, EventArgs e)
        {
            int aqi = await ObtenerCalidadDelAire(); // 🔹 Ahora sí obtenemos el AQI real

            if (aqi == -1)
            {
                txtBoxRecomendaciones.Text = "❌ No se pudo obtener el AQI.";
                return;
            }

            txtBoxRecomendaciones.Clear(); // Limpiar antes de agregar nuevas recomendaciones

            // Obtener recomendaciones generales según el AQI
            string recomendacionesGenerales = ObtenerRecomendacionesIMECA(aqi);
            txtBoxRecomendaciones.Text += recomendacionesGenerales + "\r\n";

            // Obtener recomendaciones personalizadas según los elementos seleccionados en CheckedListBox
            foreach (var item in checkedListBox1.CheckedItems)
            {
                string opcion = item.ToString();

                if (opcion == "Hago ejercicio al aire libre" && aqi >= 3)
                    txtBoxRecomendaciones.Text += "🚴 Evita hacer ejercicio al aire libre hoy.\r\n";

                if (opcion == "Tengo asma o problemas respiratorios" && aqi >= 2)
                    txtBoxRecomendaciones.Text += "😷 Usa mascarilla si necesitas salir.\r\n";

                if (opcion == "Trabajo en la calle" && aqi >= 4)
                    txtBoxRecomendaciones.Text += "⚠️ Reduce el tiempo en exteriores o usa mascarilla con filtro.\r\n";

                if (opcion == "Solo camino ocasionalmente al aire libre" && aqi >= 5)
                    txtBoxRecomendaciones.Text += "🚶 Evita caminar largas distancias en la calle hoy.\r\n";
            }

            // Si no hay ninguna recomendación personalizada
            if (txtBoxRecomendaciones.Text == "")
            {
                txtBoxRecomendaciones.Text = "✅ No hay restricciones significativas para tus actividades.";
            }

            MostrarSemaforoAQI(aqi); // Método que actualiza el semáforo visualmente
        }

    }
}
