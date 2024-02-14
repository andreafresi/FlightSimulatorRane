using FlightSimulatorControlCenter.Model.Aereo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorControlCenter.Model.Flotta
{
    internal class Flottabl :FlottaAPI
    {
      

        protected string nomeFlotta {  get; set; }
        protected int numeriAerei { get; set; }
        protected string stato { get; set; }

        public Flottabl(long idFlotta, List<AereoBl> aerei, string nomeFlotta, int numeriAerei, string stato) : base(idFlotta,aerei) 
        {
            this.nomeFlotta = nomeFlotta;
            this.numeriAerei = numeriAerei;
            this.stato = stato; 
        }
    }
}
