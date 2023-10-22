using CotacaoDolarWF.DTOs;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net.Http;
using System.Windows.Forms;
namespace CotacaoDolarWF
{
    public partial class FmCotacaoDolar : Form
    {
        public FmCotacaoDolar()
        {
            InitializeComponent();
        }


        private async void Search_Click(object sender, EventArgs e)
        {
            string strURL = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=cfe54107";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(strURL).Result;
                try
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string result = response.Content.ReadAsStringAsync().Result;
                        Market market = JsonConvert.DeserializeObject<Market>(result);
                        lblBuy.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Buy);
                        lblSell.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", market.Currency.Sell);
                        lblVariation.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", market.Currency.Variation / 100);

                    }
                    else
                    {
                        lblBuy.Text = "-";
                        lblSell.Text = "-";
                        lblVariation.Text = "-";

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Text, ex.Message);
                }
            }
        }




    }
}
