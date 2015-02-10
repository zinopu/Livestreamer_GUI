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

// SETTINGS_BAR ON THE MENUE IS SET TO INVISIBLE ||| EDIT THE FORM1.cs WITH THE SCHEME EDITOR
 
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
            foreach (string i in Properties.Settings.Default.URL_list)
               txt_twitchURL.Items.Add(i);
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings einstellungen_1 = new Settings();
            einstellungen_1.ShowDialog();
        }

        private void txt_twitchURL_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Properties.Settings.Default.stream = txt_twitchURL.Text;
           // Properties.Settings.Default.Save();
        }

        private void txt_twitchURL_KeyDown(object sender, KeyEventArgs e)
        {
            // HINT VAR
            string txt_from_selcted_item = "";

            if (e.KeyCode == Keys.Delete)
            {
                txt_from_selcted_item = txt_twitchURL.GetItemText(txt_twitchURL.SelectedItem);
                if (txt_twitchURL.SelectedIndex != -1)
                {
                    txt_twitchURL.Items.Remove(txt_twitchURL.SelectedItem);
                    Properties.Settings.Default.URL_list.Remove(txt_from_selcted_item);
                    Properties.Settings.Default.Save();
                    // Exception if all entrys got deleted, Add a empty one.
                    if (txt_twitchURL.Items.Count == 0)
                    {
                        Properties.Settings.Default.URL_list.Insert(0, "");
                        txt_twitchURL.Items.Insert(0, "");
                    }
                }
            }
        }

        private void txt_pfad_mediaplayer_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.player = txt_pfad_mediaplayer.Text;
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

        private void but_start_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = "livestreamer.exe";
            p.StartInfo.Arguments = txt_twitchURL.Text + " " + dropdown_quality.SelectedItem + " --player " + txt_pfad_mediaplayer.Text;
            Properties.Settings.Default.stream = txt_twitchURL.Text;
            Properties.Settings.Default.player = txt_pfad_mediaplayer.Text;
            Properties.Settings.Default.quality = dropdown_quality.SelectedIndex;
            //No multiple Streams in Dropdown-Box (bool)
            if (Properties.Settings.Default.URL_list.Contains(txt_twitchURL.Text) == false)
            {
                if (Properties.Settings.Default.URL_list.Count <= txt_twitchURL.MaxDropDownItems)
                {
                    Properties.Settings.Default.URL_list.Insert(0, txt_twitchURL.Text);
                }
                else
                {
                    Properties.Settings.Default.URL_list.RemoveAt(txt_twitchURL.MaxDropDownItems);
                    Properties.Settings.Default.URL_list.Insert(0, txt_twitchURL.Text);
                }
            }
            else
            {   
                Properties.Settings.Default.URL_list.Remove(txt_twitchURL.Text);
                Properties.Settings.Default.URL_list.Insert(0, txt_twitchURL.Text);
            }

           // txt_pfad_mediaplayer.Text = Convert.ToString(txt_twitchURL.SelectedIndex);
           // txt_pfad_mediaplayer.Text = Convert.ToString(Properties.Settings.Default.URL_list.Count);

            Properties.Settings.Default.Save();
            p.Start();       
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
