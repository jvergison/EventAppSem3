using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ITEvents;
using ITEvents.View;

namespace ITEvents
{
    public partial class MainForm : Form
    {
        Controller controller;

        bool bLoggedIn;


        static string LOGINMESSAGE = "Successfully logged in";
        static string LOGOUTMESSAGE = "Successfully logged out";
        static string LOGINFAILMESSAGE = "Failed to login";
        static string AUTHENTICATIONREQUIRED = "Authentication required. Please log in first.";
        static string TITLE = "Event system";
        string userName;

        public MainForm()
        {
            userName = "";
            bLoggedIn = false;
            InitializeComponent();

            this.Text = TITLE;

            //disable the user-only options
            ToggleUserOnlyOptions(false);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            controller = new Controller();

            VoorbijeEventsView.MouseDoubleClick += new MouseEventHandler(VoorbijeEventsView_MouseDoubleClick);
            VolzetteEventsView.MouseDoubleClick += new MouseEventHandler(VolzetteEventsView_MouseDoubleClick);
            NietVolzetteEventsView.MouseDoubleClick += new MouseEventHandler(NietVolzetteEventsView_MouseDoubleClick);

            VulListBoxes();


        }

        private void NietVolzetteEventsView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = NietVolzetteEventsView.HitTest(e.X, e.Y);

            ListViewItem item = info.Item;

            if (item != null)
            {
                ShowSubInfo(item);
            }
        }

        private void VolzetteEventsView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = VolzetteEventsView.HitTest(e.X, e.Y);

            ListViewItem item = info.Item;

            if (item != null)
            {
                ShowSubInfo(item);
            }
        }

        private void VoorbijeEventsView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = VoorbijeEventsView.HitTest(e.X, e.Y);

            ListViewItem item = info.Item;

            if (item != null)
            {
                ShowSubInfo(item);
            }
        }


        private void ToggleUserOnlyOptions(bool enabled)
        {
            eventAanmakenToolStripMenuItem.Enabled = enabled;
            inschrijvenVoorEventToolStripMenuItem.Enabled = enabled;
            overzichtEnRapportVoorGebruikersEnEventsToolStripMenuItem.Enabled = enabled;
        }


        private void VulListBoxes()
        {
            //vul de main listboxes
            try
            {
                VoorbijeEventsView.Clear();
                VolzetteEventsView.Clear();
                NietVolzetteEventsView.Clear();

                List<Event> verledenEventLijst = controller.LeesVerledenEvents();
                VulListBox(VoorbijeEventsView, verledenEventLijst);

                List<Event> toekomstNietVolzetLijst = controller.LeesNietVolleEvents();
                VulListBox(NietVolzetteEventsView, toekomstNietVolzetLijst);

                List<Event> toekomstVolzetLijst = controller.LeesVolleEvents();
                VulListBox(VolzetteEventsView, toekomstVolzetLijst);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void VulListBox(ListView view, List<Event> le)
        {
            view.Items.Clear();
            for (int i = 0; i < le.Count; i++)
            {
                ListViewItem item = new ListViewItem(le[i].EventNaam, 0);
                item.SubItems.Add(le[i].Beschrijving);
                item.SubItems.Add(le[i].Start.ToString());
                item.SubItems.Add(le[i].Eind.ToString());
                item.SubItems.Add(le[i].MaxInschrijvingen.ToString());
                item.SubItems.Add(le[i].AantalInschrijvingen.ToString());
                item.SubItems.Add(le[i].EventId.ToString());

                view.Items.Add(item);
            }
        }


        private void ShowSubInfo(ListViewItem item)
        {
            string text = String.Format("Naam: {0}\nBeschrijving: {1}\nStartdatum: {2}\nEinddatum: {3}\nInschrijvingen: {4}/{5}", item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[5].Text, item.SubItems[4].Text);
            string caption = item.Text;

            MessageBox.Show(text, caption, MessageBoxButtons.OK);
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            //open loginform
            if (bLoggedIn)
            {
                //log out
                userName = "";
                lblStatus.Text = LOGOUTMESSAGE;
                bLoggedIn = false;
                btnConnect.Text = "Log In";
                ToggleUserOnlyOptions(false);
            }
            else
            {
                LoginForm form = new LoginForm();
                form.ShowDialog();
                if (form.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    userName = form.ReturnValue;
                    //succesfully logged in
                    lblStatus.Text = LOGINMESSAGE;
                    bLoggedIn = true;
                    btnConnect.Text = "Log Out";
                    ToggleUserOnlyOptions(true);
                }
                else
                {
                    lblStatus.Text = LOGINFAILMESSAGE;
                }

            }

            statusStrip.Update();

        }

        private void eventAanmakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bLoggedIn)
            {
                Form12 form = new Form12();
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    VulListBoxes();
            }
            else
            {
                lblStatus.Text = AUTHENTICATIONREQUIRED;
                statusStrip.Update();
            }
        }

        private void uitschrijvenVoorEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bLoggedIn)
            {
                Form13 form = new Form13(userName);
                form.ShowDialog();
                VulListBoxes();
            }
            else
            {
                lblStatus.Text = AUTHENTICATIONREQUIRED;
                statusStrip.Update();
            }

        }

        private void overzichtEnRapportVoorGebruikersEnEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bLoggedIn)
            {
                GebruikerEventForm form = new GebruikerEventForm(userName);
                form.Show();
            }
            else
            {
                lblStatus.Text = AUTHENTICATIONREQUIRED;
                statusStrip.Update();
            }
        }

        private void btnNotFullReports_Click(object sender, EventArgs e)
        {
            ToekomstnietvolForm form = new ToekomstnietvolForm();
            form.Show();
        }

        private void btnEventInfo_Click(object sender, EventArgs e)
        {
            EventMetAantalForm form = new EventMetAantalForm();
            form.Show();
        }
    }
}
