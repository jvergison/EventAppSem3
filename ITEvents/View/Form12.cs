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
    public partial class Form12 : Form
    {
        Controller controller;

        //Actie actie;

        public Form12()
        {
            InitializeComponent();

            controller = new Controller();

            //actie = a;

            Text = "Event toevoegen";

            txtEventID.Enabled = false;

        }

        private Event MaakEvent()
        {

            int enr;
            if (txtEventID.Text != "")
            {
                enr = Int32.Parse(txtEventID.Text);
            }
            else
            {
                enr = 0;
            }

            string naam = txtNaam.Text;
            string beschr = txtBeschrijving.Text;
            int maxInschr = (int)numericUpDownMaxInschrijvingen.Value;
            DateTime start = dateTimePickerStart.Value;
            DateTime eind = dateTimePickerEind.Value;

            Event e = new Event(enr, naam, beschr, start, eind, maxInschr);
            return e;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (dateTimePickerStart.Value > dateTimePickerEind.Value)
            {
                errorProvider.SetError(dateTimePickerStart, "Startdatum moet voor einddatum komen");
                errorProvider.SetError(dateTimePickerEind, "Startdatum moet voor einddatum komen");
            }
            else
            {
                Event _event = MaakEvent();
                controller.MaakEvent(_event);

                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
