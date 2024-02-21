using ClientFlightSimula;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.DB;
using FlightSimulatorControlCenter.Model.Event;
using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Service.Int;
using System.ComponentModel;
using System.Text;

namespace FlightSimulatorControlCenter
{
    public partial class AirplaneManager : Form
    {
        // Eventi esposti dalla Form
        public event AirplaneCreatedEvent AirPlaneCreated;
        public event AirplaneUpdatedEvent AirPlaneUpdated;
        public event AirplaneDeletedEvent AirPlaneDeleted;

        private long IdFlottaAttiva;
        private FlottaApi flottalocale{ get; set; }

        private IValidationUserInputService _validationService;       

        public AirplaneManager(IValidationUserInputService validationService)
        {
            InitializeComponent();
            _validationService = validationService;
        }

        private void Step1Init_Load(object sender, EventArgs e)
        {
            // Def data source
            InitalizeAereiDataGridFromDBModel();
            UpdateLabelOfSelectedFleet();           
        }       

        private void creaAereo_Click(object sender, EventArgs e)
        {
            // Recupero campi form
            var formCodice = this.textBox1.Text;
            var formColore = this.textBox2.Text;
            var formNumeroDiPosti = this.textBox3.Text;

            // Valido l'input
            var esistoValidazione = _validationService.ValidateUserInputForAirplaneCreation(formCodice, formColore, formNumeroDiPosti);

            if (esistoValidazione.IsValid())
            {
                // X Ragazzi, perch� non mi faccio ritornare direttamente il modello dell'aereo dall'esito validazione
                // Salvo in locale
                var a1 = AereoBl.AereoBlCreateFactory(esistoValidazione.Codice, esistoValidazione.Colore, esistoValidazione.NumeroDiPosti);
                FakeDB.FlottaSelezionata.Aerei.Add(a1);

                // Mando l'evento
                this.AirPlaneCreated(a1);

                //??
                InitalizeAereiDataGridFromDBModel();

                // Qui faro la mia chiamata in remoto
            }
            else {
                var messaggeToshow = new StringBuilder();
                messaggeToshow.Append("Prima di procedere correggere i seguenti errori:\n\r");

                foreach (var message in esistoValidazione.ValidationErrors)
                {
                    messaggeToshow.Append(message + "\n\r");
                }

                messaggeToshow.Append("Grazie!\n\r");

                MessageBox.Show(messaggeToshow.ToString());
            }
        }
//Aaaaaaaaaa
        public void RequestUpdateData(long idflottaattiva) {
            //flotta
            flottalocale = CreazioneListaAerei(idflottaattiva);
            //datagrid
            InitalizeAereiDataGridFromDBModel(flottalocale);
            //aggiorno label
            UpdateLabelOfSelectedFleet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void InitalizeAereiDataGridFromDBModel(FlottaApi flottalocale)
        {
            var result = new BindingList<AereoBl>();
            
            foreach (var a in flottalocale.Aerei)
            {
                result.Add(AereoBl.AereoBlFactory(a.IdAereo,a.CodiceAereo,a.Colore,a.NumeroDiPosti));
            }
    
            var source = new BindingSource(result, null);

            // Binding data source
            tabellaAerei.DataSource = source;

            // Fit colonne a size tabella
            tabellaAerei.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabellaAerei.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // Cambio label tabella
            tabellaAerei.Columns[0].HeaderText = "Id Aereo";
            tabellaAerei.Columns[0].Name = "IdAereo";

            tabellaAerei.Columns[1].HeaderText = "Cod Aereo";
            tabellaAerei.Columns[1].Name = "Codice";

            tabellaAerei.Columns[2].HeaderText = "Colore";
            tabellaAerei.Columns[2].Name = "Colore";

            tabellaAerei.Columns[3].HeaderText = "Num. Posti";
            tabellaAerei.Columns[3].Name = "NumeroDiPosti";
        }

        private void UpdateLabelOfSelectedFleet()
        {
            label5.Text = FakeDB.FlottaSelezionata.Nome;
        }

        private FlottaApi CreazioneListaAerei(long flottaid)
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5093/");
            Client clientImpianto = new(client);
            var t = clientImpianto.FlottaGETAsync(flottaid);
            t.Wait();

            var a = t.Result;

            return a;
        }
    }
}
