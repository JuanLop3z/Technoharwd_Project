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
    
    public partial class provedores
    {
        public int prove_cod { get; set; }
        public string prove_nombre { get; set; }
        public Nullable<int> prove_contacto { get; set; }
        public string prove_email { get; set; }
    
        public virtual inventario inventario { get; set; }
    }
}