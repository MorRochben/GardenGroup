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
        public NewTicket UCNewIncident;
        public UpdateTicket UCUpdateTicket;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewIncident_Click(object sender, EventArgs e)
        {
            if (UCNewIncident != null || UCUpdateTicket != null)
                return;

            HideControllsInTab(tabIncidentManagement);
            UCNewIncident = new NewTicket(this);
            UCNewIncident.Size = tabIncidentManagement.Size;
            tabIncidentManagement.Controls.Add(UCNewIncident);
        }
        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            if (UCNewIncident != null || UCUpdateTicket != null)
                return;

            //FOR TESTING ONLY
            GardenGroupLogic.TicketService ts = new GardenGroupLogic.TicketService();
            GardenGroupModel.Ticket ticket = ts.FindById("5f75feadf05676980529f18c");

            HideControllsInTab(tabIncidentManagement);
            UCUpdateTicket = new UpdateTicket(this, ticket);
            UCUpdateTicket.Size = tabIncidentManagement.Size;
            tabIncidentManagement.Controls.Add(UCUpdateTicket);
        }

        public void TicketCreationFinished()
        {       
            
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
