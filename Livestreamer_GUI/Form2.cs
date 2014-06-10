using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Livestreamer_GUI
{
    public partial class Einstellungen : Form
    {
        
        public Einstellungen()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void but_abbrechen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_pfad_media_TextChanged(object sender, EventArgs e)
        {

        }

        public void but_speichern_Click(object sender, EventArgs e)
        {
            Livestreamer_GUI frm = new Livestreamer_GUI();
            frm.pfad_mediaplayer = txt_pfad_media.Text;
            frm.Show();
            this.Close();
        }
    }
}
