//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPC.TS.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SRV_COMPRA
    {
        public int CODCOM { get; set; }
        public Nullable<System.DateTime> FECCOM { get; set; }
        public Nullable<decimal> MONTO { get; set; }
        public Nullable<int> CODRES { get; set; }
        public Nullable<int> CODCUP { get; set; }
        public string MEDPAGO { get; set; }
        public Nullable<int> CODTARJETA { get; set; }
        public string CODCON { get; set; }
        public Nullable<decimal> SUBTOT { get; set; }
        public Nullable<decimal> VALIGV { get; set; }
        public Nullable<decimal> MONTOT { get; set; }
        public string ESTREG { get; set; }
    
        public virtual SRV_RESERVA SRV_RESERVA { get; set; }
        public virtual SRV_TARJETA SRV_TARJETA { get; set; }
    }
}
