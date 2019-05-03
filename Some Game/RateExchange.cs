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
    class RateExchange
    {
        public string Price { get; set; }
        public string Name { get; set; }
        public RateExchange() {}
        public bool SetRate(int code)
        {
            WebClient wc = new WebClient();
            Stream stream = wc.OpenRead("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange");
            XmlReader reader = XmlReader.Create(stream);
            XmlDocument document = new XmlDocument();
            document.Load(reader);
            reader.Close();
            XmlNode root = document.DocumentElement;
            XmlNodeList list = root.ChildNodes;
            for (int i = 0; i < list.Count; i++)
            {
                int tmp = int.Parse(list[i]["r030"].InnerText);
                if (tmp == code)
                {
                    Name = list[i]["txt"].InnerText;
                    Price = list[i]["rate"].InnerText;
                    return true;
                }
            }
            return false;

        }
    }
}
