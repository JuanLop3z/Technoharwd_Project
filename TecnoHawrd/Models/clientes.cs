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
    
    public partial class clientes
    {
        public int cli_cod { get; set; }
        public string cli_nombre { get; set; }
        public string cli_apellido { get; set; }
        public Nullable<int> cli_contacto { get; set; }
        public string cli_email { get; set; }
    
        public virtual factura factura { get; set; }
    }
}
