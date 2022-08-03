using System.Net;
using System.Text.Json;

namespace Waluty
{
    public partial class Form1 : Form
    {
        private NBPJson[] NBPJsons { get; set; }
        public Form1()
        {
            InitializeComponent();
            // Próba pozyskania obecnej tabli w formacie JSON z NBP API oraz umieszczenie danych w zakresie NBPJsons.
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
            // Dodanie kodów walut do listboxa.
            lB_isoCurrencies.Items.AddRange(NBPJsons[0].rates.Select(x => x.code).ToArray());
        }

        private void lB_isoCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Wypisanie na wyjœcie informacji pozyskanych po zapytaniu do NBP API.
            rTB_bidAskOutput.Text = $"Kupno: {NBPJsons[0].rates[lB_isoCurrencies.SelectedIndex].bid.ToString("c")} PLN,{Environment.NewLine}Sprzeda¿: {NBPJsons[0].rates[lB_isoCurrencies.SelectedIndex].ask.ToString("c")} PLN";
        }
    }
}