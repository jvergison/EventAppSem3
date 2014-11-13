namespace ITEvents
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReports = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNotFullReports = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEventInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.actiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventAanmakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inschrijvenVoorEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overzichtEnRapportVoorGebruikersEnEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.VoorbijeEventsView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.VolzetteEventsView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.NietVolzetteEventsView = new System.Windows.Forms.ListView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConnect,
            this.btnReports,
            this.actiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnConnect
            // 
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(52, 20);
            this.btnConnect.Text = "&Log In";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnReports
            // 
            this.btnReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNotFullReports,
            this.btnEventInfo});
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(74, 20);
            this.btnReports.Text = "&Rapporten";
            // 
            // btnNotFullReports
            // 
            this.btnNotFullReports.Name = "btnNotFullReports";
            this.btnNotFullReports.Size = new System.Drawing.Size(249, 22);
            this.btnNotFullReports.Text = "Toekomstige niet-volzette events";
            this.btnNotFullReports.Click += new System.EventHandler(this.btnNotFullReports_Click);
            // 
            // btnEventInfo
            // 
            this.btnEventInfo.Name = "btnEventInfo";
            this.btnEventInfo.Size = new System.Drawing.Size(249, 22);
            this.btnEventInfo.Text = "Informatie per event";
            this.btnEventInfo.Click += new System.EventHandler(this.btnEventInfo_Click);
            // 
            // actiesToolStripMenuItem
            // 
            this.actiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventAanmakenToolStripMenuItem,
            this.inschrijvenVoorEventToolStripMenuItem,
            this.overzichtEnRapportVoorGebruikersEnEventsToolStripMenuItem});
            this.actiesToolStripMenuItem.Name = "actiesToolStripMenuItem";
            this.actiesToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.actiesToolStripMenuItem.Text = "&Gebruikersacties";
            // 
            // eventAanmakenToolStripMenuItem
            // 
            this.eventAanmakenToolStripMenuItem.Name = "eventAanmakenToolStripMenuItem";
            this.eventAanmakenToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.eventAanmakenToolStripMenuItem.Text = "Event aanmaken";
            this.eventAanmakenToolStripMenuItem.Click += new System.EventHandler(this.eventAanmakenToolStripMenuItem_Click);
            // 
            // inschrijvenVoorEventToolStripMenuItem
            // 
            this.inschrijvenVoorEventToolStripMenuItem.Name = "inschrijvenVoorEventToolStripMenuItem";
            this.inschrijvenVoorEventToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.inschrijvenVoorEventToolStripMenuItem.Text = "Inschrijven/uitschrijven voor event";
            this.inschrijvenVoorEventToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.inschrijvenVoorEventToolStripMenuItem.Click += new System.EventHandler(this.uitschrijvenVoorEventToolStripMenuItem_Click);
            // 
            // overzichtEnRapportVoorGebruikersEnEventsToolStripMenuItem
            // 
            this.overzichtEnRapportVoorGebruikersEnEventsToolStripMenuItem.Name = "overzichtEnRapportVoorGebruikersEnEventsToolStripMenuItem";
            this.overzichtEnRapportVoorGebruikersEnEventsToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.overzichtEnRapportVoorGebruikersEnEventsToolStripMenuItem.Text = "Overzicht en rapport voor gebruikers en events";
            this.overzichtEnRapportVoorGebruikersEnEventsToolStripMenuItem.Click += new System.EventHandler(this.overzichtEnRapportVoorGebruikersEnEventsToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 357);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(969, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.VoorbijeEventsView);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.VolzetteEventsView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NietVolzetteEventsView);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 316);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(746, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Voorbije events";
            // 
            // VoorbijeEventsView
            // 
            this.VoorbijeEventsView.GridLines = true;
            this.VoorbijeEventsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.VoorbijeEventsView.Location = new System.Drawing.Point(629, 35);
            this.VoorbijeEventsView.Name = "VoorbijeEventsView";
            this.VoorbijeEventsView.Size = new System.Drawing.Size(308, 278);
            this.VoorbijeEventsView.TabIndex = 4;
            this.VoorbijeEventsView.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Volzette events";
            // 
            // VolzetteEventsView
            // 
            this.VolzetteEventsView.GridLines = true;
            this.VolzetteEventsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.VolzetteEventsView.Location = new System.Drawing.Point(316, 35);
            this.VolzetteEventsView.Name = "VolzetteEventsView";
            this.VolzetteEventsView.Size = new System.Drawing.Size(308, 278);
            this.VolzetteEventsView.TabIndex = 2;
            this.VolzetteEventsView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nog niet volzette events";
            // 
            // NietVolzetteEventsView
            // 
            this.NietVolzetteEventsView.GridLines = true;
            this.NietVolzetteEventsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.NietVolzetteEventsView.Location = new System.Drawing.Point(3, 35);
            this.NietVolzetteEventsView.Name = "NietVolzetteEventsView";
            this.NietVolzetteEventsView.Size = new System.Drawing.Size(308, 278);
            this.NietVolzetteEventsView.TabIndex = 0;
            this.NietVolzetteEventsView.UseCompatibleStateImageBehavior = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(478, 362);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(60, 14);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 3;
            this.progressBar.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 379);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ITEvents";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnConnect;
        private System.Windows.Forms.ToolStripMenuItem btnReports;
        private System.Windows.Forms.ToolStripMenuItem btnNotFullReports;
        private System.Windows.Forms.ToolStripMenuItem btnEventInfo;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem actiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventAanmakenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inschrijvenVoorEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overzichtEnRapportVoorGebruikersEnEventsToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView VoorbijeEventsView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView VolzetteEventsView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView NietVolzetteEventsView;

    }
}

