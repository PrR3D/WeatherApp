using System;
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
using System.ComponentModel.Design.Serialization;

namespace WindowsFormsApp1
{
    public partial class WeatherReport : Form
    {
        string APIkey = "a1cfbc3e3942dd9348c07b3c8b416266";
        public WeatherReport()
        {
            InitializeComponent();
        }

        private void WeatherReport_Load(object sender, EventArgs e)
        {

        }
        private void search_box_TextChanged(object sender, EventArgs e)
        {
            
        }
        public string text_in_box = "";
        private void search_btn_Click(object sender, EventArgs e)
        {
            if (text_in_box == search_box.Text)
            {     
                MessageBox.Show("You've already searched this country!", "Error");
            }
            else
            {
                pairnei_kairo();
            }
        }

        void pairnei_kairo()
        {
            using (WebClient web = new WebClient())
            {
                string API_URL = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", search_box.Text, APIkey);
                var jon = web.DownloadString(API_URL);
                
                weather_data.root plirofories = JsonConvert.DeserializeObject<weather_data.root>(jon);

                pictureBox1.ImageLocation = "http://openweathermap.org/img/w/" + plirofories.weather[0].icon + ".png";
                contition_lbl.Text = plirofories.weather[0].main;
                periliptika.Text = plirofories.weather[0].description;
                metritis_taxititas.Text = plirofories.wind.speed.ToString();
                metritis_piesis.Text = plirofories.main.pressure.ToString();
                metritis_therm.Text = (plirofories.main.temp - 273.15).ToString() + "°C";

                metritis_ygrasia.Text = (plirofories.main.humidity).ToString() + "%";
                metritis_country.Text = plirofories.sys.country.ToString();
            }
            text_in_box = search_box.Text;
        }

    }
}
