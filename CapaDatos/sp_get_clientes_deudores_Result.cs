//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    
    public partial class sp_get_clientes_deudores_Result
    {
        public int id { get; set; }
        public int id_cliente { get; set; }
        public string num_documento { get; set; }
        public string CodigoCliente { get; set; }
        public string NombreCompleto { get; set; }
        public System.DateTime fecha { get; set; }
        public decimal valor { get; set; }
        public bool pagado { get; set; }
    }
}
