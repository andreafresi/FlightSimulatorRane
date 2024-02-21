using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Event;

namespace FlightSimulatorControlCenter
{
    public partial class CancellaManager : Form
    {

        public event AirplaneDeletedEvent AirplaneDeleteReq;
        private AereoBl aereiTableSelezionata { get; set; }
        public CancellaManager(AereoBl aereitableselezionata)
        {
            aereiTableSelezionata = aereitableselezionata;
            InitializeComponent();
        }

        private void CancellaManager_Load(object sender, EventArgs e)
        {

        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            this.AirplaneDeleteReq(aereiTableSelezionata);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
