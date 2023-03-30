using MetroSet_UI.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreWebView2CreationProperties = Microsoft.Web.WebView2.WinForms.CoreWebView2CreationProperties;

namespace test3
{

    public partial class Form1 : MetroSetForm
    {

        public string downloadPath { get; set; }
        public string defaultPrinter { get; set; }

        public Form1()
        {
            InitializeComponent();
            InitializeWebView();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            downloadPath = @"C:\Users\Kap\Desktop";
            defaultPrinter = PrinterSettings.InstalledPrinters.Cast<string>().ToArray().First();

            //add title
            this.Text = "Fattutto";

        }

        private async void InitializeWebView()
        {
            webView21.CreationProperties = new CoreWebView2CreationProperties()
            {
                UserDataFolder = "data"
            };
            await webView21.EnsureCoreWebView2Async();
            await webView21.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("console.log('WebView2 is ready');");
            //webView21.Source = new Uri("https://developer.microsoft.com/en-us/microsoft-edge/webview2/");
            webView21.Source = new Uri("https://app.fattutto.com/");
            webView21.CoreWebView2.Profile.DefaultDownloadFolderPath = downloadPath;
            changeColor();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://app.fattutto.com/");
            changeColor();
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://app.fattutto.com/");
            changeColor();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://support.fattutto.com/");
            changeColor();
        }

        private void changeColor()
        {
            Color active = Color.FromArgb(75, 187, 188);
            if (iconButton1.ForeColor == active)
            {
                iconButton1.ForeColor = Color.White;
                iconButton1.IconColor = Color.White;
                iconButton2.IconColor = active;
                iconButton2.ForeColor = active;
            }
            else
            {
                iconButton2.ForeColor = Color.White;
                iconButton2.IconColor = Color.White;
                iconButton1.IconColor = active;
                iconButton1.ForeColor = active;
            }
        }

        private void CoreWebView2_DownloadStarting(object sender, CoreWebView2DownloadStartingEventArgs e)
        {
            var downloadOperation = e.DownloadOperation;
            e.ResultFilePath = @"C:\Users\Kap\Desktop\mydownloadedfile.zip";
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void iconButton3_Click(object sender, EventArgs e)
        {
            //open form Settings
            Settings settings = new Settings(downloadPath, defaultPrinter);
            settings.Show();

            //when settings close call the function updateSettings(this)
            settings.FormClosed += new FormClosedEventHandler((sender, e) => updateSettings(sender, e, settings));
        }

        private void updateSettings(object sender, FormClosedEventArgs e, Settings settings)
        {
            Console.WriteLine("Ciao");
            settings.updateSettings(this);

        }
    }
}



