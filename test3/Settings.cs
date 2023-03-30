using MetroSet_UI.Controls;
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

    public partial class Settings : MetroSetForm
    {
        string downloadPath;
        string defaultPrinter;

        public Settings(string downloadPath, string defaultPrinter)
        {
            this.downloadPath = downloadPath;
            this.defaultPrinter = defaultPrinter;
            InitializeComponent();
            metroSetTextBox1.Text = downloadPath;

            metroSetListBox1.Items.AddRange(PrinterSettings.InstalledPrinters.Cast<string>().ToArray());
            int selectedIndex = metroSetListBox1.Items.IndexOf(defaultPrinter);
            metroSetListBox1.SelectedIndex = selectedIndex;
            richTextBox4.Text = "Stampante " + defaultPrinter + " selezionata";
            richTextBox4.ForeColor = Color.Green;
            Console.WriteLine(defaultPrinter);

            //add title
            this.Text = "Impostazioni";

        }

        public void updateSettings(Form1 form1)
        {
            form1.downloadPath = this.downloadPath;
            form1.defaultPrinter = this.defaultPrinter;
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

        private void downloadPathChange(object sender, EventArgs e)
        {
            Console.WriteLine("downloadPathChange");
            //check if metroSetTextBox1.Text is a valid download location
            //if not create an alert

            if (Directory.Exists(metroSetTextBox1.Text))
            {
                metroSetTextBox1.BorderColor = Color.Green;
                richTextBox2.Text = "Cartella selezionata correttamente";
                richTextBox2.ForeColor = Color.Green;

                downloadPath = metroSetTextBox1.Text;
            }
            else
            {
                metroSetTextBox1.BorderColor = Color.Red;

                //create an alert
                richTextBox2.Text = "Cartella non valida";
                richTextBox2.ForeColor = Color.Red;
            }
        }

        private void DefaultPrinterChange(object sender)
        {
            Console.WriteLine("Stampante cambiata");
            if (metroSetListBox1.SelectedItem != null)
            {
                defaultPrinter = metroSetListBox1.SelectedItem.ToString();
                Console.Write(defaultPrinter);
                richTextBox4.Text = "Stampante " + defaultPrinter + " selezionata";
                richTextBox4.ForeColor = Color.Green;
            }
            else
            {
                richTextBox4.Text = "Stampante non valida";
                richTextBox4.ForeColor = Color.Red;
            }
        }
    }
}



