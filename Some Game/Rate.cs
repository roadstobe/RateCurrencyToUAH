using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Some_Game
{
    public partial class Rate : Form
    {
        RateExchange rate;
        Weather weather;
        public Rate()
        {
            InitializeComponent();
            rate = new RateExchange();
            weather = new Weather();
            weather.SetToday();
            textBoxWeather.Text = $"місто Львів                   {weather.Date} температура: {weather.Temperature}°";
            weather.SetTomorow();
            textBoxWeatherTomorow.Text = $"місто Львів                   {weather.Date} температура: {weather.Temperature}°";
            weather.SetNextTomorow();
            textBoxWeather2day.Text = $"місто Львів                   {weather.Date} температура: {weather.Temperature}°";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int tmp;
            int.TryParse(textBox.Text, out tmp);
            if(rate.SetRate(tmp) == true)
            textBox.Text = $"Name: {rate.Name} Price:{rate.Price}";
            else
                textBox.Text = $"Введені не коректні дані";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            string empty = "";
            textBox.Text = empty;

        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            textBox.Text = $"USD: 840     GBP: 826     EUR: 978     PLN: 985     CAD: 124";
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void Timer_Date(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void Time_wether(object sender, EventArgs e)
        {
            weather.SetToday();
            textBoxWeather.Text = $"місто Львів                   {weather.Date} температура: {weather.Temperature}°";
            weather.SetTomorow();
            textBoxWeatherTomorow.Text = $"місто Львів                   {weather.Date} температура: {weather.Temperature}°";
            weather.SetNextTomorow();
            textBoxWeather2day.Text = $"місто Львів                   {weather.Date} температура: {weather.Temperature}°";
        }

        private void NoChangeTomorow(object sender, EventArgs e)
        {

        }
    }
}
