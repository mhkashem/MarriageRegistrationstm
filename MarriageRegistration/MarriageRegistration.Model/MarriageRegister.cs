//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarriageRegistration.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MarriageRegister
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
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
        public Nullable<int> WitnessId { get; set; }
        public Nullable<int> AttorneyId { get; set; }
        public Nullable<int> kaziId { get; set; }
        public string MarriageRegiNo { get; set; }
    
        public virtual Attorney Attorney { get; set; }
        public virtual Kazi Kazi { get; set; }
        public virtual Witness Witness { get; set; }
    }
}
