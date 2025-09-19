using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Configuration;

namespace ASKBOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.BeginInvoke((MethodInvoker)delegate
            {
                Prompt_TextBox.Focus(); 
            });
        }

        private readonly HttpClient client = new HttpClient();

        //private readonly string apiKey = "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";
        string apiKey = ConfigurationManager.AppSettings["OpenAI_API_Key"];
        private readonly string apiUrl = "https://api.openai.com/v1/chat/completions";

        private async void submit_btn_Click(object sender, EventArgs e)
        {
            string questionprompt = (Prompt_TextBox.Text.Trim());

            if (string.IsNullOrEmpty(questionprompt))
            {
                MessageBox.Show("Please enter a question.");
                return;
            }
            else
            {
                string prompt = $"Explain the following questions clearly and separately giving more than one answer  : {questionprompt}";
                string result = await GetresponseFromAPI(prompt);
                GenAnswer_TextBox.Text = result ;
            }
        }
        /*
        private async Task<string> GetresponseFromAPI(string prompt )
        {
            var url =  "https://api.openai.com/v1/chat/completions";

            var requestbody = new
            {
                model = "gpt-3.5-turbo",
                messages = new[] {new { role = "user", content = prompt } } 

            };

               //converts the C# object to a JSON string ------ open ai API expects JSON format only 
            var requestJson = JsonConvert.SerializeObject(requestbody);

                    // Create the HttpRequestMessage with the specified URL and method
            var requesthttp = new HttpRequestMessage(HttpMethod.Post, url);

            requesthttp.Headers.Add("Authorization", $"Bearer {apiKey}");

            requesthttp.Content = new StringContent(requestJson, Encoding.UTF8, "application/json");

            //send the request and get the response
            var response = await client.SendAsync(requesthttp);
            var responseJson = await response.Content.ReadAsStringAsync();

            //extract the content from the response JSON
            dynamic responseObject = JsonConvert.DeserializeObject(responseJson);
            return responseObject.choices[0].message.content;



            /*var answer = responseObject?.choices?[0]?.message?.content;

            if (answer == null)
            {
                MessageBox.Show("No answer returned. Check the API response or request format.");
                
            }
            return answer?.ToString() ?? "No answer returned.";
        }
        */

        private async Task<string> GetresponseFromAPI(string prompt)
        {
            var requestBody = new
            {
                model = "gpt-3.5-turbo",
                messages = new[] {
                    new { role = "system", content = "You are a helpful assistsnt " },
                    new { role = "user", content = prompt }
                } ,
                n=2
            };

            var requestJson = JsonConvert.SerializeObject(requestBody);
            var requestHttp = new HttpRequestMessage(HttpMethod.Post, apiUrl);
            requestHttp.Headers.Add("Authorization", $"Bearer {apiKey}"); // ✅ Fixed space
            requestHttp.Content = new StringContent(requestJson, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.SendAsync(requestHttp);

                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"API Error: {response.StatusCode}\n{error}");
                    return "API call failed.";
                }

                var responseJson = await response.Content.ReadAsStringAsync();
                dynamic responseObject = JsonConvert.DeserializeObject(responseJson);

                if (responseObject?.choices == null || responseObject.choices.Count == 0)
                {
                    MessageBox.Show("No choices returned in API response.");
                    return "AI response is empty.";
                }

                return responseObject.choices[0].message.content.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
                return "Error during API request.";
            }
        }


    }
}
