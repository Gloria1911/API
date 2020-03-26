﻿using Newtonsoft.Json;
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

    }
}
