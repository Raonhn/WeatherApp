using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private const string OpenWeatherMapApiKey = "Aqui você coloca sua chave de API";


        static async Task Main(string[] args)
        {
            try
            {
                string ip = await GetPublicIpAddress();

                if (!string.IsNullOrEmpty(ip))
                {
                    string city = await GetCityIpAddress(ip);

                    if (!string.IsNullOrEmpty(city))
                    {
                        var weather = await GetWeatherCity(city);

                        if (weather != null)
                        {
                            Application.EnableVisualStyles();
                            Application.SetCompatibleTextRenderingDefault(false);
                            Application.Run(new Form1(city, weather));
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível obter a previsão do tempo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível obter a cidade a partir do IP.");
                    }
                }
                else
                {
                    Console.WriteLine("Não foi possível obter o IP público.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        static async Task<string> GetPublicIpAddress()
        {
            try
            {
                using (HttpClient cliente = new HttpClient())
                {
                    HttpResponseMessage resposta = await cliente.GetAsync("https://api.ipify.org");
                    resposta.EnsureSuccessStatusCode();
                    return await resposta.Content.ReadAsStringAsync();
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro ao obter o IP público: {ex.Message}");
                return null;
            }
        }

        static async Task<string> GetCityIpAddress(string ip)
        {
            try
            {
                using (HttpClient cliente = new HttpClient())
                {
                    string apiUrl = $"https://ipinfo.io/{ip}/json";
                    HttpResponseMessage resposta = await cliente.GetAsync(apiUrl);
                    resposta.EnsureSuccessStatusCode();
                    string respostaBody = await resposta.Content.ReadAsStringAsync();
                    dynamic resultado = JsonConvert.DeserializeObject(respostaBody);
                    return resultado.city;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro ao obter a cidade a partir do IP: {ex.Message}");
                return null;
            }
        }

        static async Task<dynamic> GetWeatherCity(string city)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={OpenWeatherMapApiKey}&units=metric";
                    HttpResponseMessage resposta = await client.GetAsync(apiUrl);
                    resposta.EnsureSuccessStatusCode();
                    string respostaBody = await resposta.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject(respostaBody);
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro ao obter a previsão do tempo: {ex.Message}");
                return null;
            }
        }
    }
}

