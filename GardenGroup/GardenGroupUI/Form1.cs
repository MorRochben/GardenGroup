using GardenGroupUI.UserControlls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenGroupUI
{
    public partial class Form1: Form
    {
        public NewIncident UCNewIncident;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewIncident_Click(object sender, EventArgs e)
        {
            if (UCNewIncident != null)
                return;

            HideControllsInTab(tabIncidentManagement);
            UCNewIncident = new NewIncident(this);
            UCNewIncident.Size = tabIncidentManagement.Size;
            tabIncidentManagement.Controls.Add(UCNewIncident);
        }

        public void TicketCreationFinished()
        {            
            Controls.Remove(UCNewIncident);
            UCNewIncident.Dispose();
            UCNewIncident = null;
            ShowControllsInTab(tabIncidentManagement);
        }

        private void HideControllsInTab(TabPage tab)
        {
            foreach (Control control in tab.Controls)
            {
                control.Hide();
            }
        }

        private void ShowControllsInTab(TabPage tab)
        {
            foreach (Control control in tab.Controls)
            {
                control.Show();
            }
        }
    }
}
