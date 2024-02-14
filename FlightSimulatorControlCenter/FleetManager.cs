using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.fakeDB;
using FlightSimulatorControlCenter.Model.Flotta;

namespace FlightSimulatorControlCenter
{
    public partial class FleetManager : Form
    {
        private BindingList<Flottabl> flotta;


        public FleetManager()
        {
            InitializeComponent();
            //tabellaFlotte.CurrentRow da l'indice in base alla tabella che hai passato per la linea selezionata con le parentesi quadre.
        }

        private void FleetManager_Load(object sender, EventArgs e)
        {
            flotta = new BindingList<Flottabl>();
            var source = new BindingSource(flotta, null);
            
            tabellaFlotte.DataSource = source;

            tabellaFlotte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabellaFlotte.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // Cambio label tabella
            tabellaFlotte.Columns[0].HeaderText = "Nome Flotta";
            tabellaFlotte.Columns[0].Name = "NomeFlotta";

            tabellaFlotte.Columns[1].HeaderText = "Numeri Aerei";
            tabellaFlotte.Columns[1].Name = "numeriAerei";

            tabellaFlotte.Columns[2].HeaderText = "stato";
            tabellaFlotte.Columns[2].Name = "stato";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
