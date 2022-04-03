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
using System.Net.Http;

namespace Api
{
    public partial class Form1 : Form
    {
        public Chuck chuck;
        public Form1()
        {
            InitializeComponent();
            chuck = new Chuck();
            listBox1.Items.Add("Hello there");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getResponseAsync();
            listBox1.Items.Clear();
            listBox1.Items.Add(chuck.ToString());
        }

        private async Task<string> getResponseAsync()
        {
            HttpClient client = new HttpClient();
            string call = "https://api.chucknorris.io/jokes/random";
            string response = await client.GetStringAsync(call);
            chuck = JsonConvert.DeserializeObject<Chuck>(response);
            return response;
        }
    }
}
