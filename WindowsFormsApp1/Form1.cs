using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async Task DownloadSites()
        {
            List<string> sites = new List<string>();
            sites.Add("https://google.com");
            sites.Add("https://yahoo.com");

            var client = new System.Net.WebClient();

            foreach(string site in sites)
            {
                var data = await client.DownloadDataTaskAsync(site);
                listView1.Items.Add($"{site.ToString()} : {data.Length.ToString()}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadSites();
        }
    }
}
