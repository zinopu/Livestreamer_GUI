namespace Livestreamer_GUI
{
    partial class Livestreamer_GUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livestreamer_GUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_twitchTV = new System.Windows.Forms.Label();
            this.but_start = new System.Windows.Forms.Button();
            this.lbl_pfad_mediaplayer = new System.Windows.Forms.Label();
            this.txt_pfad_mediaplayer = new System.Windows.Forms.TextBox();
            this.dropdown_quality = new System.Windows.Forms.ComboBox();
            this.but_mediaplayer = new System.Windows.Forms.Button();
            this.lbl_quality = new System.Windows.Forms.Label();
            this.txt_twitchURL = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitungToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.dateiToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bearbeitungToolStripMenuItem
            // 
            this.bearbeitungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einstellungenToolStripMenuItem});
            this.bearbeitungToolStripMenuItem.Name = "bearbeitungToolStripMenuItem";
            this.bearbeitungToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.bearbeitungToolStripMenuItem.Text = "Edit";
            this.bearbeitungToolStripMenuItem.Visible = false;
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.einstellungenToolStripMenuItem.Text = "Settings";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // lbl_twitchTV
            // 
            this.lbl_twitchTV.AutoSize = true;
            this.lbl_twitchTV.Location = new System.Drawing.Point(45, 45);
            this.lbl_twitchTV.Name = "lbl_twitchTV";
            this.lbl_twitchTV.Size = new System.Drawing.Size(67, 13);
            this.lbl_twitchTV.TabIndex = 1;
            this.lbl_twitchTV.Text = "Twitch.tv Url";
            // 
            // but_start
            // 
            this.but_start.Location = new System.Drawing.Point(356, 193);
            this.but_start.Name = "but_start";
            this.but_start.Size = new System.Drawing.Size(75, 23);
            this.but_start.TabIndex = 2;
            this.but_start.Text = "Start";
            this.but_start.UseVisualStyleBackColor = true;
            this.but_start.Click += new System.EventHandler(this.but_start_Click);
            // 
            // lbl_pfad_mediaplayer
            // 
            this.lbl_pfad_mediaplayer.AutoSize = true;
            this.lbl_pfad_mediaplayer.Location = new System.Drawing.Point(45, 89);
            this.lbl_pfad_mediaplayer.Name = "lbl_pfad_mediaplayer";
            this.lbl_pfad_mediaplayer.Size = new System.Drawing.Size(97, 13);
            this.lbl_pfad_mediaplayer.TabIndex = 4;
            this.lbl_pfad_mediaplayer.Text = "Select Mediaplayer";
            // 
            // txt_pfad_mediaplayer
            // 
            this.txt_pfad_mediaplayer.Location = new System.Drawing.Point(48, 105);
            this.txt_pfad_mediaplayer.Name = "txt_pfad_mediaplayer";
            this.txt_pfad_mediaplayer.ReadOnly = true;
            this.txt_pfad_mediaplayer.Size = new System.Drawing.Size(350, 20);
            this.txt_pfad_mediaplayer.TabIndex = 5;
            this.txt_pfad_mediaplayer.TextChanged += new System.EventHandler(this.txt_pfad_mediaplayer_TextChanged);
            // 
            // dropdown_quality
            // 
            this.dropdown_quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown_quality.FormattingEnabled = true;
            this.dropdown_quality.Items.AddRange(new object[] {
            "Source",
            "High",
            "Medium",
            "Low",
            "Mobile",
            "Best",
            "Low"});
            this.dropdown_quality.Location = new System.Drawing.Point(48, 149);
            this.dropdown_quality.Name = "dropdown_quality";
            this.dropdown_quality.Size = new System.Drawing.Size(80, 21);
            this.dropdown_quality.TabIndex = 6;
            // 
            // but_mediaplayer
            // 
            this.but_mediaplayer.Location = new System.Drawing.Point(404, 105);
            this.but_mediaplayer.Name = "but_mediaplayer";
            this.but_mediaplayer.Size = new System.Drawing.Size(27, 20);
            this.but_mediaplayer.TabIndex = 7;
            this.but_mediaplayer.Text = "...";
            this.but_mediaplayer.UseVisualStyleBackColor = true;
            this.but_mediaplayer.Click += new System.EventHandler(this.but_mediaplayer_Click);
            // 
            // lbl_quality
            // 
            this.lbl_quality.AutoSize = true;
            this.lbl_quality.Location = new System.Drawing.Point(45, 133);
            this.lbl_quality.Name = "lbl_quality";
            this.lbl_quality.Size = new System.Drawing.Size(70, 13);
            this.lbl_quality.TabIndex = 8;
            this.lbl_quality.Text = "Streamquality";
            // 
            // txt_twitchURL
            // 
            this.txt_twitchURL.FormattingEnabled = true;
            this.txt_twitchURL.Location = new System.Drawing.Point(48, 61);
            this.txt_twitchURL.Name = "txt_twitchURL";
            this.txt_twitchURL.Size = new System.Drawing.Size(350, 21);
            this.txt_twitchURL.TabIndex = 9;
            this.txt_twitchURL.SelectedIndexChanged += new System.EventHandler(this.txt_twitchURL_SelectedIndexChanged);
            this.txt_twitchURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_twitchURL_KeyDown);
            // 
            // Livestreamer_GUI
            // 
            this.AcceptButton = this.but_start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 228);
            this.Controls.Add(this.txt_twitchURL);
            this.Controls.Add(this.lbl_quality);
            this.Controls.Add(this.but_mediaplayer);
            this.Controls.Add(this.dropdown_quality);
            this.Controls.Add(this.txt_pfad_mediaplayer);
            this.Controls.Add(this.lbl_pfad_mediaplayer);
            this.Controls.Add(this.but_start);
            this.Controls.Add(this.lbl_twitchTV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Livestreamer_GUI";
            this.Text = "Livestreamer GUI";
            this.Load += new System.EventHandler(this.Livestreamer_GUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeitungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.Label lbl_twitchTV;
        private System.Windows.Forms.Button but_start;
        private System.Windows.Forms.Label lbl_pfad_mediaplayer;
        private System.Windows.Forms.TextBox txt_pfad_mediaplayer;
        private System.Windows.Forms.ComboBox dropdown_quality;
        private System.Windows.Forms.Button but_mediaplayer;
        private System.Windows.Forms.Label lbl_quality;
        private System.Windows.Forms.ComboBox txt_twitchURL;
    }
}

