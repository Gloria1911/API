using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows;
using System.Windows.Threading;

namespace ClientWebApi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnGetSum_Click(object sender, RoutedEventArgs e)
        {
            double ris = 0;
            int a = Convert.ToInt32(txtas.Text);
            int b = Convert.ToInt32(txtbs.Text);
            // Creo un oggetto di tipo HTTP CLIENT

            HttpClient client = new HttpClient();

            string uri = $"https://localhost:44396/api/Api/GetSum?a={a}&b={b}";
            HttpResponseMessage response = await client.GetAsync(uri);
            string content = await response.Content.ReadAsStringAsync();
            ris = JsonConvert.DeserializeObject<int>(content);
            Dispatcher.Invoke(() => lblris.Content = ris);
        
        }

        private async void btnGetProduct_Click(object sender, RoutedEventArgs e)
        {
            double ris = 0;
            int a = Convert.ToInt32(txtas.Text);
            int b = Convert.ToInt32(txtbs.Text);
            // Creo un oggetto di tipo HTTP CLIENT

            HttpClient client = new HttpClient();

            string uri = $"https://localhost:44396/api/Api/GetProduct?a={a}&b={b}";
            HttpResponseMessage response = await client.GetAsync(uri);
            string content = await response.Content.ReadAsStringAsync();
            ris = JsonConvert.DeserializeObject<int>(content);
            Dispatcher.Invoke(() => lblris.Content = ris);
        }

        private async void btnGetSubtraction_Click(object sender, RoutedEventArgs e)
        {
            double ris = 0;
            int a = Convert.ToInt32(txtas.Text);
            int b = Convert.ToInt32(txtbs.Text);
            // Creo un oggetto di tipo HTTP CLIENT

            HttpClient client = new HttpClient();

            string uri = $"https://localhost:44396/api/Api/GetSubtraction?a={a}&b={b}";
            HttpResponseMessage response = await client.GetAsync(uri);
            string content = await response.Content.ReadAsStringAsync();
            ris = JsonConvert.DeserializeObject<int>(content);
            Dispatcher.Invoke(() => lblris.Content = ris);

        }

        private async void btnGetDiv_Click(object sender, RoutedEventArgs e)
        {
            double ris = 0;
            int a = Convert.ToInt32(txtas.Text);
            int b = Convert.ToInt32(txtbs.Text);
            // Creo un oggetto di tipo HTTP CLIENT

            HttpClient client = new HttpClient();

            string uri = $"https://localhost:44396/api/Api/GetDiv?a={a}&b={b}";
            HttpResponseMessage response = await client.GetAsync(uri);
            string content = await response.Content.ReadAsStringAsync();
            ris = JsonConvert.DeserializeObject<int>(content);
            Dispatcher.Invoke(() => lblris.Content = ris);
        }

        private async void btnGetResto_Click(object sender, RoutedEventArgs e)
        {
            double ris = 0;
            int a = Convert.ToInt32(txtas.Text);
            int b = Convert.ToInt32(txtbs.Text);
            // Creo un oggetto di tipo HTTP CLIENT

            HttpClient client = new HttpClient();

            string uri = $"https://localhost:44396/api/Api/GetResto?a={a}&b={b}";
            HttpResponseMessage response = await client.GetAsync(uri);
            string content = await response.Content.ReadAsStringAsync();
            ris = JsonConvert.DeserializeObject<double>(content);
            Dispatcher.Invoke(() => lblris.Content = ris);

        }

       

        private async void btnGetAverage_Click(object sender, RoutedEventArgs e)
        {
            double ris = 0;
            int a = Convert.ToInt32(txtas.Text);
            int b = Convert.ToInt32(txtbs.Text);
            // Creo un oggetto di tipo HTTP CLIENT

            HttpClient client = new HttpClient();

            string uri = $"https://localhost:44396/api/Api/GetAverage?a={a}&b={b}";
            HttpResponseMessage response = await client.GetAsync(uri);
            string content = await response.Content.ReadAsStringAsync();
            ris = JsonConvert.DeserializeObject<double>(content);
            Dispatcher.Invoke(() => lblris.Content = ris);
        }
    }
}
