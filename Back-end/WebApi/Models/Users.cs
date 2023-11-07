using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Users
    {
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public int idDepartamento { get; set; }
        public int idCargo { get; set; }
    }
}