﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String APIKey = "OpenWeatherKey";
        

        public void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}",TBCity.Text,APIKey);

                var JSON = web.DownloadString(url);
                
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(JSON);

                picIcon.ImageLocation = "https://openweathermap.org/img/w/"+Info.weather[0].icon+".png";
                labCondition2.Text = Info.weather[0].main;
                labDetails2.Text = Info.weather[0].description;
                labSunset2.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                labSunrise2.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                labWindSpeed2.Text = Info.wind.speed.ToString();
                labPressure2.Text = Info.main.pressure.ToString();
                }
            }    
        
        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0,0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisec).ToLocalTime();

            return day;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labSunrise_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LABsUNRİSE2_Click(object sender, EventArgs e)
        {

        }
    }
}
