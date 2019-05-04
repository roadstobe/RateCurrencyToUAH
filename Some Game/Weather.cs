using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Net;

namespace Some_Game
{
    class Weather
    {
        public string Date { get; set; }
        public string Temperature { get; set; }
        public Weather() { }
        public void SetToday()
        {
            WebClient wc = new WebClient();
            Stream stream = wc.OpenRead("https://www.eurometeo.ru/ukraina/lvyvska-oblast/lviv/export/xml/data/");
            XmlReader reader = XmlReader.Create(stream);
            XmlDocument document = new XmlDocument();
            document.Load(reader);
            reader.Close();
            string dateToday = DateTime.Now.ToShortDateString();
            string add = dateToday + " 17:00:00";
            XmlNodeList xmlNode = document.SelectNodes("//datetime");
            int i = 0;
            foreach (XmlNode item in xmlNode)
            {
                DateTime tmp =DateTime.Parse(item.InnerText);
                if(tmp.ToString() == add)
                {
                    Date = item.InnerText;
                    break;
                }
                i++;
            }
            XmlNodeList xmlTemperature = document.SelectNodes("//temperature");
            foreach (XmlNode item in xmlTemperature)
            {
                Temperature = item.InnerText;
                if (i == 0)
                    break;
                i--;
            }

            double cutCut;
            double.TryParse(Temperature.Replace('.', ','), out cutCut);
            int cut = (int)cutCut;
            Temperature = cut.ToString();
            Date = DateTime.Now.ToLongDateString();
        }
        public void SetTomorow()
        {
            WebClient wc = new WebClient();
            Stream stream = wc.OpenRead("https://www.eurometeo.ru/ukraina/lvyvska-oblast/lviv/export/xml/data/");
            XmlReader reader = XmlReader.Create(stream);
            XmlDocument document = new XmlDocument();
            document.Load(reader);
            reader.Close();
            DateTime tommorow = DateTime.Now;
            tommorow = tommorow.AddDays(1);
            string dateToday = tommorow.ToShortDateString();
            string add = dateToday + " 17:00:00";
            XmlNodeList xmlNode = document.SelectNodes("//datetime");
            int i = 0;
            foreach (XmlNode item in xmlNode)
            {
                DateTime tmp = DateTime.Parse(item.InnerText);
                if (tmp.ToString() == add)
                {
                    Date = item.InnerText;
                    break;
                }
                i++;
            }
            XmlNodeList xmlTemperature = document.SelectNodes("//temperature");
            foreach (XmlNode item in xmlTemperature)
            {
                Temperature = item.InnerText;
                if (i == 0)
                    break;
                i--;
            }
            double cutCut;
            double.TryParse(Temperature.Replace('.', ','), out cutCut);
            int cut = (int)cutCut;
            Temperature = cut.ToString();
            Date = tommorow.ToLongDateString();
        }
        public void SetNextTomorow()
        {
            WebClient wc = new WebClient();
            Stream stream = wc.OpenRead("https://www.eurometeo.ru/ukraina/lvyvska-oblast/lviv/export/xml/data/");
            XmlReader reader = XmlReader.Create(stream);
            XmlDocument document = new XmlDocument();
            document.Load(reader);
            reader.Close();
            DateTime tommorow = DateTime.Now;
            tommorow = tommorow.AddDays(2);
            string dateToday = tommorow.ToShortDateString();
            string add = dateToday + " 17:00:00";
            XmlNodeList xmlNode = document.SelectNodes("//datetime");
            int i = 0;
            foreach (XmlNode item in xmlNode)
            {
                DateTime tmp = DateTime.Parse(item.InnerText);
                if (tmp.ToString() == add)
                {
                    Date = item.InnerText;
                    break;
                }
                i++;
            }
            XmlNodeList xmlTemperature = document.SelectNodes("//temperature");
            foreach (XmlNode item in xmlTemperature)
            {
                Temperature = item.InnerText;
                if (i == 0)
                    break;
                i--;
            }

            double cutCut;
            double.TryParse(Temperature.Replace('.', ','), out cutCut);
            int cut = (int)cutCut;
            Temperature = cut.ToString();
            Date = tommorow.ToLongDateString();
        }
    }
}
