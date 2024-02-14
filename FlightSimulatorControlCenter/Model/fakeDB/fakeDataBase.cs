using FlightSimulatorControlCenter.Model.Aereo;
using FlightSimulatorControlCenter.Model.Flotta;
using FlightSimulatorControlCenter.Model.FlottaAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Model.fakeDB
{
    public static class fakeDataBase
    {

        public static List<FlottaAPI> Flotte { get; set; }
        public static long IdAereoKey { get; set; }

        static fakeDataBase()
        {
            var aereo1 = AereoBl.AereoBlCreateFactory("ABCDEF1", "Rosso", 120);
            var aereo2 = AereoBl.AereoBlCreateFactory("ABCDEF1", "verde", 120);
            var aereo3 = AereoBl.AereoBlCreateFactory("ABCDEF2", "blu", 120);
            FlottaAPI f1 = new FlottaAPI(10000, [aereo1, aereo2, aereo3]);

            var aereo4 = AereoBl.AereoBlCreateFactory("ABCDEF4", "Rosso", 120);
            var aereo5 = AereoBl.AereoBlCreateFactory("ABCDEF5", "Rosso", 120);
            var aereo6 = AereoBl.AereoBlCreateFactory("ABCDEF6", "Rosso", 120);
            FlottaAPI f2 = new FlottaAPI(10001, [aereo4, aereo5, aereo6]);

            var aereo7 = AereoBl.AereoBlCreateFactory("ABCDEF7", "Rosso", 120);
            var aereo8 = AereoBl.AereoBlCreateFactory("ABCDEF8", "Rosso", 120);
            FlottaAPI f3 = new FlottaAPI(10002, [aereo7, aereo8]);

            Flotte = new List<FlottaAPI>() { f1, f2, f3 };

            IdAereoKey++;
        }

    }
}
