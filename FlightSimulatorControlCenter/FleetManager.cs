using ClientFlightSimula;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.DB;
using FlightSimulatorControlCenter.Model.Event;
using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Service.Int;
using System.ComponentModel;

namespace FlightSimulatorControlCenter
{
    public partial class FleetManager : Form
    {
        // Eventi esposti dalla Form
        public event FleetSelectedEvent FleetSelected;
        public event FleetUpdatedEvent FleetUpdated;
        public event FleetCreatedEvent FleetCreated;

        private IValidationUserInputService _validationService;
        private BindingList<FlottaTableModel> flotte = new BindingList<FlottaTableModel>();
        public List<FlottaApi> ListaFlotte { get; set; }

        public MainWindow FormPrincipale { get; set; }

        public FleetManager(IValidationUserInputService validationService)
        {
            InitializeComponent();
            _validationService = validationService;

            AggiornaDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Aggiorno la flotta selezionata sul db
            int row = tabellaFlotte.CurrentRow.Index;
            var flottaTableSelezionata = flotte[row];
            var fleetApi = ListaFlotte.Single(x => x.IdFlotta == flottaTableSelezionata.Id);

            var flottaBlSelezionata = FlottaBl.FlottaBlFactory(fleetApi.IdFlotta, fleetApi.Nome, "Attivo", new List<AereoBl>());

            // Mando l'evento
            this.FleetSelected(flottaBlSelezionata);
        }

        public void RequestUpdateData()
        {
            InitalizeAereiDataGridFromDBModel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AggiornaDataGridView();
        }

        private List<FlottaApi> CreazioneListaFlotte()
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5093/");
            Client clientImpianto = new(client);
            var t = clientImpianto.GetElencoFlotteAsync();
            t.Wait();

            var a = t.Result;


            return a.ToList();
        }

        private void InitalizeAereiDataGridFromDBModel()
        {
            flotte = new BindingList<FlottaTableModel>();

            foreach (var f in ListaFlotte)
            {
                var temp = FlottaTableModel.FlottaTableModelFactory(f.IdFlotta, f.Nome, f.Aerei.Count, "Attiva");
                flotte.Add(temp);
            }

            var source = new BindingSource(flotte, null);

            // Binding data source
            tabellaFlotte.DataSource = source;

            // Fit colonne a size tabella
            tabellaFlotte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabellaFlotte.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameFlotta = textboxnameflotte.Text;
            var request = new CreateFlottaRequest();
            request.Nome = nameFlotta;


            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5093/");
            Client clientImpianto = new(client);
            var t = clientImpianto.FlottaPOSTAsync(request);
            t.Wait();

            var a = t.Result;

            AggiornaDataGridView();
        }

        private void AggiornaDataGridView()
        {
            ListaFlotte = CreazioneListaFlotte();
            InitalizeAereiDataGridFromDBModel();
        }
    }
}
