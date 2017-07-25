using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Country
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountryService.countrySoapClient service = new CountryService.countrySoapClient();
            string ulkeler = service.GetCountries();

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(ulkeler);
            XmlNode root = xdoc.SelectSingleNode("NewDataSet");
            foreach (XmlNode item in root.SelectNodes("Table/Name"))
            {
                listBox1.Items.Add(item.InnerText);   
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            string ulke = listBox1.SelectedItem.ToString();
            label4.Text = listBox1.SelectedItem.ToString();

            CountryService.countrySoapClient detail = new CountryService.countrySoapClient();
            string countryDetail = detail.GetCurrencyByCountry(ulke);
            XmlDocument xdoc = new XmlDocument();

            xdoc.LoadXml(countryDetail);
            XmlNode root = xdoc.FirstChild.NextSibling;
            textBoxUKod.Text = root.SelectSingleNode("CountryCode").InnerText;
            textBoxPBirim.Text = root.SelectSingleNode("Currency").InnerText;
            textBoxPKod.Text = root.SelectSingleNode("CurrencyCode").InnerText;
        }
    }
}
