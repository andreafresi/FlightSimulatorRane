using FlightSimulatorControlCenter.Service;
using FlightSimulatorControlCenter.Service.Int;

namespace FlightSimulatorControlCenter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Sono singleton
            IValidationUserInputService validationService = new ValidationUserInputService(); // servizio respondabile di Validare la form dell utente (normalmente sempre inserito) - viene passato come argomento alla nostra form sotto

            Application.Run(new MainWindow(validationService)); // viene lanciato il MAINWINDOW e lanciato un SERVICE
        }
    
   

    
    }
}