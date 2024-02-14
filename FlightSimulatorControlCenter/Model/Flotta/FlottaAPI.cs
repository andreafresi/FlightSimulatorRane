using FlightSimulatorControlCenter.Model.Aereo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Model.Flotta
{
    public class FlottaAPI
    {
        public long IdFlotta { get; set; }
        public List<AereoBl> Aerei { get; set; }

        public FlottaAPI(long idFlotta, List<AereoBl> aerei)
        {
            IdFlotta = idFlotta;
            Aerei = aerei;
        }

        public static FlottaAPI FlottaApiFactory(long idFlotta, List<AereoBl> aerei)
        {
            return new FlottaAPI(idFlotta, aerei);
        }


    }

}
