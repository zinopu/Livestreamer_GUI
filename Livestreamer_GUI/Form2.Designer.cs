namespace Livestreamer_GUI
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.twitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.but_speichern = new System.Windows.Forms.Button();
            this.but_abbrechen = new System.Windows.Forms.Button();
            this.lbl_mediaplayer = new System.Windows.Forms.Label();
            this.txt_pfad_media = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twitchToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 26);
            // 
            // twitchToolStripMenuItem
            // 
            this.twitchToolStripMenuItem.Name = "twitchToolStripMenuItem";
            this.twitchToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.twitchToolStripMenuItem.Text = "Twitch";
            // 
            // but_speichern
            // 
            this.but_speichern.Location = new System.Drawing.Point(340, 320);
            this.but_speichern.Name = "but_speichern";
            this.but_speichern.Size = new System.Drawing.Size(75, 23);
            this.but_speichern.TabIndex = 1;
            this.but_speichern.Text = "Speichern";
            this.but_speichern.UseVisualStyleBackColor = true;
            this.but_speichern.Click += new System.EventHandler(this.but_speichern_Click);
            // 
            // but_abbrechen
            // 
            this.but_abbrechen.Location = new System.Drawing.Point(259, 320);
            this.but_abbrechen.Name = "but_abbrechen";
            this.but_abbrechen.Size = new System.Drawing.Size(75, 23);
            this.but_abbrechen.TabIndex = 2;
            this.but_abbrechen.Text = "Abbrechen";
            this.but_abbrechen.UseVisualStyleBackColor = true;
            this.but_abbrechen.Click += new System.EventHandler(this.but_abbrechen_Click);
            // 
            // lbl_mediaplayer
            // 
            this.lbl_mediaplayer.AutoSize = true;
            this.lbl_mediaplayer.Location = new System.Drawing.Point(13, 19);
            this.lbl_mediaplayer.Name = "lbl_mediaplayer";
            this.lbl_mediaplayer.Size = new System.Drawing.Size(114, 13);
            this.lbl_mediaplayer.TabIndex = 3;
            this.lbl_mediaplayer.Text = "Pfad zum Mediaplayer:";
            this.lbl_mediaplayer.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_pfad_media
            // 
            this.txt_pfad_media.Location = new System.Drawing.Point(16, 35);
            this.txt_pfad_media.Name = "txt_pfad_media";
            this.txt_pfad_media.Size = new System.Drawing.Size(399, 20);
            this.txt_pfad_media.TabIndex = 4;
            this.txt_pfad_media.TextChanged += new System.EventHandler(this.txt_pfad_media_TextChanged);
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 358);
            this.Controls.Add(this.txt_pfad_media);
            this.Controls.Add(this.lbl_mediaplayer);
            this.Controls.Add(this.but_abbrechen);
            this.Controls.Add(this.but_speichern);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Einstellungen";
            this.ShowIcon = false;
            this.Text = "Einstellungen";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem twitchToolStripMenuItem;
        private System.Windows.Forms.Button but_speichern;
        private System.Windows.Forms.Button but_abbrechen;
        private System.Windows.Forms.Label lbl_mediaplayer;
        private System.Windows.Forms.TextBox txt_pfad_media;

    }
}