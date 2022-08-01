using System.Net;
using System.Text.Json;

namespace Waluty
{
    public partial class Form1 : Form
    {
        public NBPJson[] NBPJsons { get; set; }
        public Form1()
        {
            InitializeComponent();
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    string json = webClient.DownloadString("http://api.nbp.pl/api/exchangerates/tables/c/today/");
                    NBPJsons = JsonSerializer.Deserialize(json, typeof(NBPJson[])) as NBPJson[];
                }
            }
            catch (System.Net.WebException)
            {
                rTB_bidAskOutput.Text = "Oops! Nie mo¿na po³¹czyæ siê ze Ÿród³em!";
            }
            catch (Exception)
            {
                rTB_bidAskOutput.Text = "Nieobs³u¿ony wyj¹tek.";
            }
            lB_isoCurrencies.Items.AddRange(NBPJsons[0].rates.Select(x => x.code).ToArray());
        }

        private void lB_isoCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            rTB_bidAskOutput.Text = $"Kupno: {NBPJsons[0].rates[lB_isoCurrencies.SelectedIndex].bid.ToString("c")} PLN,{Environment.NewLine}Sprzeda¿: {NBPJsons[0].rates[lB_isoCurrencies.SelectedIndex].ask.ToString("c")} PLN";
        }
    }
}