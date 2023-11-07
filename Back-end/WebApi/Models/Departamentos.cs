using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Departamentos
    {
        public int idDepartamento { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string activo { get; set; }
       
        public int idUsuarioCreacion { get; set; }
    }
}