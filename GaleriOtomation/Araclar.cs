//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GaleriOtomation
{
    using System;
    using System.Collections.Generic;
    
    public partial class Araclar
    {
        public int AracNo { get; set; }
        public Nullable<decimal> AracFiyat { get; set; }
        public Nullable<int> AracAdet { get; set; }
        public string AracMarka { get; set; }
        public string AracModel { get; set; }
        public string AracYil { get; set; }
        public string AracOzellik { get; set; }
        public string AracMotor { get; set; }
        public string AracPaket { get; set; }
        public string AracRenk { get; set; }
        public Nullable<int> SubeNo { get; set; }
    
        public virtual Subeler Subeler { get; set; }
    }
}