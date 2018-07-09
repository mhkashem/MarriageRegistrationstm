using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarriageRegistration.ViewModel
{
    public class MarrigeRegisterView
    {
        public int Id { get; set; }
        public DateTime Dat { get; set; }
        public string BridegroomName { get; set; }
        public string BridegroomNID { get; set; }
        public string BrideName { get; set; }
        public string BrideNID { get; set; }
        public Nullable<double> Mohor { get; set; }
        public Nullable<double> Moajjal { get; set; }
        public Nullable<double> NonMoajjal { get; set; }
        public Nullable<double> PaidAmount { get; set; }
        public string NikhaReaderName { get; set; }
        public string NikhaReaderNameNID { get; set; }
        public string Witness1Name { get; set; }
        public string Witness2Name { get; set; }
        public string Witness3Name { get; set; }
        public string BrideAttorneyName { get; set; }
        public Nullable<int> BrideAttorneyNID { get; set; }
        public string BridegroomAttorneyName { get; set; }
        public Nullable<int> BridegroomAttorneyNID { get; set; }
        public Nullable<int> KaziId { get; set; }
    }
}
