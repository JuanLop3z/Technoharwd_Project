//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TecnoHawrd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class factura
    {
        public int fact_cod { get; set; }
        public Nullable<System.DateTime> fact_fecha { get; set; }
        public Nullable<int> fact_cantidad { get; set; }
        public Nullable<int> fact_total { get; set; }
    
        public virtual categorias categorias { get; set; }
        public virtual clientes clientes { get; set; }
    }
}
