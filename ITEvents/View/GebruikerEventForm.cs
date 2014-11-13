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
    public partial class GebruikerEventForm : Form
    {
        private string userName;
        public GebruikerEventForm(String userName)
        {
            this.userName = userName;
            InitializeComponent();

            this.Text = "Inschrijvingen van " + userName;
        }

        private void GebruikerEventForm_Load(object sender, EventArgs e)
        {
            this.gebruikereventTableAdapter.Fill(this.rapporteringDataSet.gebruikerevent, userName);
            this.reportViewer1.RefreshReport();
        }
    }
}
