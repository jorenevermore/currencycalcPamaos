using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FinalCurrency
{
    public partial class Form1 : Form
    {
        private Dictionary<string, decimal> exchangeRates;
        private Dictionary<string, Image> flagImages;
        private Dictionary<string, string> currencyCodeMapping;
        private HashSet<string> relevantCurrencies = new HashSet<string>
        {
            "USD", "EUR", "JPY", "GBP", "AUD", "CAD", "CHF", "CNY", "SEK", "NZD",
            "KRW", "SGD", "NOK", "MXN", "INR", "RUB", "ZAR", "HKD", "BRL", "TRY",
            "TWD", "DKK", "PLN", "THB", "IDR", "HUF", "CZK", "ILS", "CLP", "PHP"
        };

        public Form1()
        {
            InitializeComponent();

            fromCurrencyComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            fromCurrencyComboBox.DrawItem += new DrawItemEventHandler(currencyComboBox_DrawItem);

            toCurrencyComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            toCurrencyComboBox.DrawItem += new DrawItemEventHandler(currencyComboBox_DrawItem);

            LoadCountryCodes();
            InitializeCurrencyCodeMapping();
        }

        private void LoadCountryCodes()
        {
            string url = "https://flagcdn.com/en/codes.json";
            using (var webClient = new WebClient())
            {
                try
                {
                    var json = webClient.DownloadString(url);
                    currencyCodeMapping = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading country codes: {ex.Message}");
                }
            }
        }

        private void InitializeCurrencyCodeMapping()
        {
            currencyCodeMapping = new Dictionary<string, string>
            {
                {"USD", "US Dollar"},
                {"EUR", "Euro"},
                {"JPY", "Japanese Yen"},
                {"GBP", "British Pound"},
                {"AUD", "Australian Dollar"},
                {"CAD", "Canadian Dollar"},
                {"CHF", "Swiss Franc"},
                {"CNY", "Chinese Yuan"},
                {"SEK", "Swedish Krona"},
                {"NZD", "New Zealand Dollar"},
                {"KRW", "South Korean Won"},
                {"SGD", "Singapore Dollar"},
                {"NOK", "Norwegian Krone"},
                {"MXN", "Mexican Peso"},
                {"INR", "Indian Rupee"},
                {"RUB", "Russian Ruble"},
                {"ZAR", "South African Rand"},
                {"HKD", "Hong Kong Dollar"},
                {"BRL", "Brazilian Real"},
                {"TRY", "Turkish Lira"},
                {"TWD", "Taiwan Dollar"},
                {"DKK", "Danish Krone"},
                {"PLN", "Polish Zloty"},
                {"THB", "Thai Baht"},
                {"IDR", "Indonesian Rupiah"},
                {"HUF", "Hungarian Forint"},
                {"CZK", "Czech Koruna"},
                {"ILS", "Israeli Shekel"},
                {"CLP", "Chilean Peso"},
                {"PHP", "Philippine Peso"}
               
            };
        }

        private void LoadFlagImages()
        {
            flagImages = new Dictionary<string, Image>();
            string baseUrl = "https://flagcdn.com/32x24/";

            foreach (var currency in exchangeRates.Keys)
            {
               
                string countryCode = currency.Substring(0, 2).ToLower();
                string imageUrl = $"{baseUrl}{countryCode}.png";

                try
                {
                    var request = WebRequest.Create(imageUrl);
                    using (var response = request.GetResponse())
                    using (var stream = response.GetResponseStream())
                    {
                        flagImages[currency] = Image.FromStream(stream);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading image for {currency}: {ex.Message}");
                }
            }
        }

        private string GetLatestCurrencies()
        {
            var client = new RestClient("https://api.currencyapi.com/v3/latest");
            var request = new RestRequest(Method.GET);
            request.AddHeader("apikey", "cur_live_jNGtlj3nFfgDbw60hnacHZYiIatTmwtghRgQkK3Y");

            IRestResponse response = null;
            try
            {
                response = client.Execute(request);
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show($"Error fetching data: {response.ErrorMessage}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
                return null;
            }

            return response?.Content;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var response = GetLatestCurrencies();
            if (response == null)
                return;

            var jsonResponse = JObject.Parse(response);
            var data = jsonResponse["data"];

            exchangeRates = new Dictionary<string, decimal>();

            foreach (var currency in data)
            {
                var currencyName = currency.Path.Split('.').Last();
                var rate = currency.First["value"].ToObject<decimal>();
                if (relevantCurrencies.Contains(currencyName))
                {
                    exchangeRates[currencyName] = rate;
                }
            }

            LoadFlagImages();

            fromCurrencyComboBox.Items.Clear();
            toCurrencyComboBox.Items.Clear();

            fromCurrencyComboBox.Items.Add("--Select Currency--");
            toCurrencyComboBox.Items.Add("--Select Currency--");

            foreach (var currency in exchangeRates.Keys)
            {
                fromCurrencyComboBox.Items.Add(currency);
                toCurrencyComboBox.Items.Add(currency);
            }

            fromCurrencyComboBox.SelectedIndex = 0;
            toCurrencyComboBox.SelectedIndex = 0;
        }

        private void currencyComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (e.Index < 0) return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
            }

            string currency = comboBox.Items[e.Index].ToString();
            if (flagImages.ContainsKey(currency))
            {
               
                e.Graphics.DrawImage(flagImages[currency], e.Bounds.Left, e.Bounds.Top, 32, 24);
                
                e.Graphics.DrawString(currency, e.Font, ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? SystemBrushes.HighlightText : SystemBrushes.WindowText, e.Bounds.Left + 36, e.Bounds.Top + (e.Bounds.Height / 2) - (e.Font.Height / 2));
            }
            else
            {
              
                e.Graphics.DrawString(currency, e.Font, ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ? SystemBrushes.HighlightText : SystemBrushes.WindowText, e.Bounds.Left, e.Bounds.Top);
            }

            e.DrawFocusRectangle();
        }


        private void convertButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(amountInput.Text, out decimal amount))
            {
                string fromCurrencyDisplay = fromCurrencyComboBox.SelectedItem?.ToString();
                string toCurrencyDisplay = toCurrencyComboBox.SelectedItem?.ToString();

               
                string fromCurrency = fromCurrencyDisplay?.Split(new[] { " - " }, StringSplitOptions.None)[0];
                string toCurrency = toCurrencyDisplay?.Split(new[] { " - " }, StringSplitOptions.None)[0];

                if (fromCurrency != null && toCurrency != null &&
                    exchangeRates.TryGetValue(fromCurrency, out decimal fromRate) &&
                    exchangeRates.TryGetValue(toCurrency, out decimal toRate) &&
                    currencyCodeMapping.TryGetValue(fromCurrency, out string fromCurrencyName) &&
                    currencyCodeMapping.TryGetValue(toCurrency, out string toCurrencyName))
                {
                    decimal convertedAmount = (amount / fromRate) * toRate;
                    decimal conversionRate = toRate / fromRate;

                    string conversionRateString = (Math.Abs(conversionRate - 1) < 0.0001m) ? "1" : $"{conversionRate:F4}";
                    string convertedAmountString = $"{convertedAmount:F2}";

                    
                    string formattedConvertedAmount = $"{convertedAmount:0,0.00}";

                    convertedResult.Text = $"{amount} {fromCurrency} - {fromCurrencyName} = {formattedConvertedAmount} {toCurrency} - {toCurrencyName}" +
                                           Environment.NewLine +
                                           $"1 {fromCurrency} - {fromCurrencyName} = {conversionRateString} {toCurrency} - {toCurrencyName}";
                }
                else
                {
                    MessageBox.Show("Error in retrieving exchange rates or currency names.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid amount.");
            }
        }

        private void amountInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fromCurrencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void responseTxtBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void amountLabel_Click(object sender, EventArgs e)
        {

        }

        private void convertedResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toCurrencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fromLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
