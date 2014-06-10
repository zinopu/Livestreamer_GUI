using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Diagnostics;
using System.Collections.Specialized;

// SETTINGS PART ON THE MENUE IS SET TO INVISIBLE ||| EDIT THE FORM1.cs
 
namespace Livestreamer_GUI
{
    public partial class Livestreamer_GUI : Form
    {
        public string pfad_mediaplayer = "";        

        public Livestreamer_GUI()
        {
            InitializeComponent();
        }


        private void Livestreamer_GUI_Load(object sender, EventArgs e)
        {
            txt_twitchURL.Text = Properties.Settings.Default.stream;
            txt_pfad_mediaplayer.Text = Properties.Settings.Default.player;
            dropdown_quality.SelectedIndex = Properties.Settings.Default.quality;        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Einstellungen einstellungen_1 = new Einstellungen();
            einstellungen_1.ShowDialog();
        }

        private void but_start_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "livestreamer.exe";
            p.StartInfo.Arguments = txt_twitchURL.Text + " " + dropdown_quality.SelectedItem + " --player " + txt_pfad_mediaplayer.Text;
            Properties.Settings.Default.stream = txt_twitchURL.Text;
            Properties.Settings.Default.player = txt_pfad_mediaplayer.Text;
            Properties.Settings.Default.quality = dropdown_quality.SelectedIndex;
            Properties.Settings.Default.Save();
            p.Start();       
        }

        private void txt_twitchURL_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.stream = txt_twitchURL.Text;
            Properties.Settings.Default.Save();
        }

        private void but_mediaplayer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = false;
            ofd.InitialDirectory = "C:\"";
            ofd.Filter = ".exe (*.exe)|*.exe";
            ofd.Title = "Choose file to open";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_pfad_mediaplayer.Text = "";
                foreach (string s in ofd.FileNames)
                    txt_pfad_mediaplayer.Text += s;
            }

        }

        private void txt_pfad_mediaplayer_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.player = txt_pfad_mediaplayer.Text;
            Properties.Settings.Default.Save();
        }
        
    }
}
