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
    public partial class ToekomstnietvolForm : Form
    {
        public ToekomstnietvolForm()
        {
            InitializeComponent();
            this.Text = "Niet-volle events in de toekomst";
        }

        private void ToekomstnietvolForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rapporteringDataSet.toekomstnietvolevent' table. You can move, or remove it, as needed.
            this.toekomstnietvoleventTableAdapter.Fill(this.rapporteringDataSet.toekomstnietvolevent);

            this.reportViewer1.RefreshReport();
        }
    }
}
