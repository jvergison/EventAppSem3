using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEvents
{
    public partial class Form13 : Form
    {

        Controller controller;
        string userName;

        public Form13( string userName)
        {
            InitializeComponent();

            controller = new Controller();
            this.userName = userName;

            this.Text = "Schrijf in/uit - " + userName;
            
            vulIngeschrevenBox();
            
            vulNietIngeschrevenBox();

            ingeschrevenListView.MouseDoubleClick += new MouseEventHandler(IngeschrevenEventsView_MouseDoubleClick);
            nietingeschrevenListView.MouseDoubleClick += new MouseEventHandler(NietIngeschrevenEventsView_MouseDoubleClick);
        }

        private void update()
        {
            vulIngeschrevenBox();
            vulNietIngeschrevenBox();
        }

        private void vulIngeschrevenBox()
        {
            ingeschrevenListView.Clear();
            List<Event> le = controller.LeesInschrijvingenVanGebruiker(userName);
            VulListBox(ingeschrevenListView, le);
        }

        private void vulNietIngeschrevenBox()
        {
            nietingeschrevenListView.Clear();
            List<Event> le = controller.LeesNietInschrijvingenVanGebruiker(userName);
            VulListBox(nietingeschrevenListView, le);
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void schrijfInButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nietingeschrevenListView.SelectedItems.Count; ++i)
            {
                controller.SchrijfGebruikerIn(Convert.ToInt32(nietingeschrevenListView.SelectedItems[i].SubItems[6].Text), userName);
            }
            update();
        }

        private void schrijfUitButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ingeschrevenListView.SelectedItems.Count; ++i)
            {
                controller.SchrijfGebruikerUit(Convert.ToInt32(ingeschrevenListView.SelectedItems[i].SubItems[6].Text), userName);
            }
            update();
        }

        private void ShowSubInfo(ListViewItem item)
        {
            string text = String.Format("Naam: {0}\nBeschrijving: {1}\nStartdatum: {2}\nEinddatum: {3}\nInschrijvingen: {4}/{5}", item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[5].Text, item.SubItems[4].Text);
            string caption = item.Text;

            MessageBox.Show(text, caption, MessageBoxButtons.OK);
        }


        private void IngeschrevenEventsView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = ingeschrevenListView.HitTest(e.X, e.Y);

            ListViewItem item = info.Item;

            if (item != null)
            {
                ShowSubInfo(item);
            }
        }

        private void NietIngeschrevenEventsView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = nietingeschrevenListView.HitTest(e.X, e.Y);

            ListViewItem item = info.Item;

            if (item != null)
            {
                ShowSubInfo(item);
            }
        }
    }
}
