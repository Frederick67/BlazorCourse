using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webView21.CreationProperties = new CoreWebView2CreationProperties()
            {
                UserDataFolder = "data"
            };
            webView21.CoreWebView2InitializationCompleted += WebView21_CoreWebView2InitializationCompleted;
            Load += Form1_Load;
        }



        private async void WebView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            await webView21.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("console.log('WebView2 is ready');");
        }

        private void webView21_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://localhost:7237/");
        }

    }
}
