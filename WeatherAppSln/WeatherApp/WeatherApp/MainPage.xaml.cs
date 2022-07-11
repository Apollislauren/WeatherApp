using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;

namespace weatherApp
{
    public partial class MainPage : ContentPage 
    {
        private double _temperature;

        public double Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;

                OnPropertyChanged();
            }
        }


        private MainPage _weather;

        public MainPage WeatherInformation
        {
            get { return _weather; }
            set
            {
                _weather = value;

                OnPropertyChanged();
            }
        }

        public openWeatherData AllWeather
        {
            get;
            set;
        }




        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = AllWeather;
        }


        public class Weather
        {
            public string Temp { get; set; }
            public string Date { get; set; }
            public string Icon { get; set; }
        }
        private async Task GetWeatherData()


        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");


            string response = await client.GetStringAsync("https://api.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid=6db90c3aad6452a161801bb3bca1d9b1");


           
            var weatherData = Newtonsoft.Json.JsonConvert.DeserializeObject<openWeatherData>(response);

 

            if (weatherData != null)
            {
                AllWeather = weatherData;

                

                


            }
      
            
        }

        protected async  override void OnAppearing()
        {
            base.OnAppearing();

            await GetWeatherData();
        }
    }
    

}