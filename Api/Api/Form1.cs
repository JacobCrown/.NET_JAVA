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
        private Chuck_DB db;
        public Form1()
        {

            InitializeComponent();
            db = new Chuck_DB(); // nowy obiekt z bazy danych chakow
            chuck = new Chuck();
            listBox1.Items.Add("Hello there");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getResponseAsync();
            listBox1.Items.Clear();
            //listBox1.Items.Add(chuck.ToString());
            var context = new Chuck_DB();
            context.Chucks.Add(chuck);
            context.SaveChanges();

            var chucks = (from s in context.Chucks select s).ToList<Chuck>();
            foreach (var chuck in chucks)
            {
                listBox1.Items.Add(chuck.ToString());
            }

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