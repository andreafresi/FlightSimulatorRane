using FlightSimulatorControlCenter.Helper;
using FlightSimulatorControlCenter.Service.Int;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSimulatorControlCenter
{
    public partial class MainWindow : Form // partial: significa che non è l'unico file che contiene la main window, così si può spezzare in file diversi, poi li unisce lui
    {
        private IValidationUserInputService _validationService;

        private string NomeFlottaSelezionata = "Flotta Rayanair"; // property istanziate 
        private long IdFlottaSelezionata = 0;
        private ToolStripLabel LabelFlottaSelezionata;

        public MainWindow(IValidationUserInputService validationService) // parametro d'ingresso: validationService - costruttore: MainWindow
        {
            InitializeComponent(); 
            _validationService = validationService; // gli si passa il validationService e lo utilizza

            LabelFlottaSelezionata = new ToolStripLabel(NomeFlottaSelezionata); // property
            LabelFlottaSelezionata.Alignment = ToolStripItemAlignment.Right;
            LabelFlottaSelezionata.Padding = new Padding(0,0,20,0);

            menuStrip1.Items.Add(LabelFlottaSelezionata);           
        }

        private void airplaneManager_Click(object sender, EventArgs e)
        {
            if (!FormUtils.FormIsOpen("AirplaneManager")) {
                var airm = new AirplaneManager(_validationService, NomeFlottaSelezionata, IdFlottaSelezionata);
                airm.MdiParent = this;
                airm.Show();
            }       
        }
    }
}
