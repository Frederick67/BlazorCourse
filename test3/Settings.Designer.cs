using FontAwesome.Sharp;
using MetroSet_UI.Controls;

namespace test3
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            metroSetControlBox1 = new MetroSetControlBox();
            iconButton3 = new IconButton();
            metroSetTextBox1 = new MetroSetTextBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            metroSetListBox1 = new MetroSetListBox();
            richTextBox4 = new RichTextBox();
            SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox1.CloseHoverForeColor = Color.White;
            metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            metroSetControlBox1.DisabledForeColor = Color.DimGray;
            metroSetControlBox1.IsDerivedStyle = true;
            metroSetControlBox1.Location = new Point(853, 5);
            metroSetControlBox1.MaximizeBox = true;
            metroSetControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroSetControlBox1.MinimizeBox = true;
            metroSetControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroSetControlBox1.Name = "metroSetControlBox1";
            metroSetControlBox1.Size = new Size(100, 25);
            metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetControlBox1.StyleManager = null;
            metroSetControlBox1.TabIndex = 1;
            metroSetControlBox1.Text = "metroSetControlBox1";
            metroSetControlBox1.ThemeAuthor = "Narwin";
            metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.Black;
            iconButton3.FlatAppearance.BorderColor = Color.Black;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = IconChar.Gear;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = IconFont.Auto;
            iconButton3.IconSize = 16;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(1, 5);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(113, 35);
            iconButton3.TabIndex = 7;
            iconButton3.Text = "Impostazioni";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // metroSetTextBox1
            // 
            metroSetTextBox1.AutoCompleteCustomSource = null;
            metroSetTextBox1.AutoCompleteMode = AutoCompleteMode.None;
            metroSetTextBox1.AutoCompleteSource = AutoCompleteSource.None;
            metroSetTextBox1.BorderColor = Color.FromArgb(110, 110, 110);
            metroSetTextBox1.DisabledBackColor = Color.FromArgb(80, 80, 80);
            metroSetTextBox1.DisabledBorderColor = Color.FromArgb(109, 109, 109);
            metroSetTextBox1.DisabledForeColor = Color.FromArgb(109, 109, 109);
            metroSetTextBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetTextBox1.HoverColor = Color.FromArgb(65, 177, 225);
            metroSetTextBox1.Image = null;
            metroSetTextBox1.IsDerivedStyle = true;
            metroSetTextBox1.Lines = null;
            metroSetTextBox1.Location = new Point(181, 73);
            metroSetTextBox1.MaxLength = 32767;
            metroSetTextBox1.Multiline = false;
            metroSetTextBox1.Name = "metroSetTextBox1";
            metroSetTextBox1.ReadOnly = false;
            metroSetTextBox1.Size = new Size(205, 23);
            metroSetTextBox1.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetTextBox1.StyleManager = null;
            metroSetTextBox1.TabIndex = 8;
            metroSetTextBox1.Text = "Download Path";
            metroSetTextBox1.TextAlign = HorizontalAlignment.Left;
            metroSetTextBox1.ThemeAuthor = "Narwin";
            metroSetTextBox1.ThemeName = "MetroDark";
            metroSetTextBox1.UseSystemPasswordChar = false;
            metroSetTextBox1.WatermarkText = "";
            metroSetTextBox1.TextChanged += downloadPathChange;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Black;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(181, 46);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(204, 21);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "Download Path";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.Black;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.ForeColor = Color.Black;
            richTextBox2.Location = new Point(181, 102);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox2.Size = new Size(204, 21);
            richTextBox2.TabIndex = 10;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.Black;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.ForeColor = Color.White;
            richTextBox3.Location = new Point(491, 46);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox3.Size = new Size(204, 21);
            richTextBox3.TabIndex = 12;
            richTextBox3.Text = "Default Printer";
            // 
            // metroSetListBox1
            // 
            metroSetListBox1.BackColor = Color.FromArgb(30, 30, 30);
            metroSetListBox1.BorderColor = Color.FromArgb(64, 64, 64);
            metroSetListBox1.DisabledBackColor = Color.FromArgb(80, 80, 80);
            metroSetListBox1.DisabledForeColor = Color.FromArgb(109, 109, 109);
            metroSetListBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            metroSetListBox1.HoveredItemBackColor = Color.LightGray;
            metroSetListBox1.HoveredItemColor = Color.DimGray;
            metroSetListBox1.IsDerivedStyle = true;
            metroSetListBox1.ItemHeight = 30;
            metroSetListBox1.Location = new Point(491, 73);
            metroSetListBox1.MultiSelect = false;
            metroSetListBox1.Name = "metroSetListBox1";
            metroSetListBox1.SelectedIndex = -1;
            metroSetListBox1.SelectedItem = null;
            metroSetListBox1.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            metroSetListBox1.SelectedItemColor = Color.White;
            metroSetListBox1.SelectedText = null;
            metroSetListBox1.SelectedValue = null;
            metroSetListBox1.ShowBorder = false;
            metroSetListBox1.ShowScrollBar = false;
            metroSetListBox1.Size = new Size(204, 23);
            metroSetListBox1.Style = MetroSet_UI.Enums.Style.Dark;
            metroSetListBox1.StyleManager = null;
            metroSetListBox1.TabIndex = 13;
            metroSetListBox1.ThemeAuthor = "Narwin";
            metroSetListBox1.ThemeName = "MetroDark";
            //when the selected item change run the function defaultPrinterChange
            metroSetListBox1.SelectedIndexChanged += DefaultPrinterChange;
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.Black;
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.ForeColor = Color.Black;
            richTextBox4.Location = new Point(491, 102);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox4.Size = new Size(204, 21);
            richTextBox4.TabIndex = 14;
            richTextBox4.Text = "";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundColor = Color.Black;
            BorderColor = Color.White;
            ClientSize = new Size(952, 438);
            Controls.Add(richTextBox4);
            Controls.Add(metroSetListBox1);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(metroSetTextBox1);
            Controls.Add(iconButton3);
            Controls.Add(metroSetControlBox1);
            HeaderColor = Color.Black;
            Name = "Settings";
            SmallLineColor1 = Color.Black;
            SmallLineColor2 = Color.Black;
            ResumeLayout(false);
        }

        private void metroSetListBox1_SelectedIndexChanged(object sender)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private IconButton iconButton3;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBox1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private MetroSetListBox metroSetListBox1;
        private RichTextBox richTextBox4;
        //private Button button1;
        //private Button button2;
    }
}