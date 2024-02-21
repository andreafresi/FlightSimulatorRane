using FlightSimulatorControlCenter.Model.Event;
using FlightSimulatorControlCenter.Service;
using FlightSimulatorControlCenter.Service.Int;

namespace FlightSimulatorControlCenter
{
    public partial class ServiceManager : Form
    {
        public event UpdateService updateService;
        public ServiceManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IConversionModelService conversionService = new ConversionModelService();
            IExternalServicesService service = new ExternalServicesFakeDBService(conversionService);
            this.updateService(service);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IExternalServicesService service = new ExternalServicesMockedService();
            this.updateService(service);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IExternalServicesService service = new ExternalServicesRemoteService();
            this.updateService(service);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
