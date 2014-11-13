using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEvents.View
{
    public partial class EventMetAantalForm : Form
    {
        public EventMetAantalForm()
        {
            InitializeComponent();
            this.Text = "Overzicht events met aantal inschrijvingen";
        }

        private void EventMetAantalForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rapporteringDataSet.eventmetaantal' table. You can move, or remove it, as needed.
            this.eventmetaantalTableAdapter.Fill(this.rapporteringDataSet.eventmetaantal);

            this.reportViewer1.RefreshReport();
        }
    }
}
