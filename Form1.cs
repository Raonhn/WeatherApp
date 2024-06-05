namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1(string city, dynamic weather)
        {
            if (string.IsNullOrEmpty(city))
            {
                throw new ArgumentNullException(nameof(city), "O nome da cidade não pode ser nulo ou vazio.");
            }

            InitializeComponent();

            lblCity.Text = city;
            lblTemp.Text = $"{weather.main.temp} °C";
            lblCondition.Text = weather.weather[0].description;
        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void lblCondition_Click(object sender, EventArgs e)
        {

        }

        private void lblTemp_Click(object sender, EventArgs e)
        {

        }
    }
}
