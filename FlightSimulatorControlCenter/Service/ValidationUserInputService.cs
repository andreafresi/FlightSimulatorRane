using FlightSimulatorControlCenter.Model.Validation;
using FlightSimulatorControlCenter.Service.Int;
using System.Text.RegularExpressions;

namespace FlightSimulatorControlCenter.Service
{
    public class ValidationUserInputService : IValidationUserInputService
    {
        public ValidationForUserAirplaneCreationResponse ValidateUserInputForAirplaneCreation(string codice, string colore, string numeroDiPosti)
        {
            var errorResult = new List<string>();
            // cose da fare noi, controlli in più:
            var formCodice = Regex.Replace(codice, @"[^a-zA-Z]", "");
            // X Ragazzi aggiungere controllo sul formato del codice per flotta
            if (string.IsNullOrWhiteSpace(formCodice)) {
                errorResult.Add("Valorizzare il campo codice");
            }

            var formColore = Regex.Replace(colore, @"[^a-zA-Z]", "");
            // X Ragazzi aggiungere controlli sui colori
            /*
            enum sceltaC
            { giallo, blu, verde }; */

            if (string.IsNullOrWhiteSpace(colore))
            {
                errorResult.Add("Valorizzare il campo colore");
            }

            long formNumeroDiPosti = 0;
            // X Ragazzi aggiungere controlli sul numero minimo e massimo di posti
            if (string.IsNullOrWhiteSpace(numeroDiPosti))
            {
                errorResult.Add("Valorizzare il campo numeroDiPosti");
            }
            else {
                var conversioneNumPosti = long.TryParse(numeroDiPosti, out formNumeroDiPosti);
                if (!conversioneNumPosti)
                {
                    errorResult.Add("Il campo numero di posti deve essere un intero");
                }
            }                    
           
            if (errorResult.Any()) {
                return ValidationForUserAirplaneCreationResponse.ValidationForUserAirplaneCreationResponseNotValidFactory(errorResult);
            } else {
                return ValidationForUserAirplaneCreationResponse.ValidationForUserAirplaneCreationResponseValidFactory(formCodice, formColore, formNumeroDiPosti);
            }          
        }
    }
}
