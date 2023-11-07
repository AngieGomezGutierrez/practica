using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/<controller>
        public List<Users> Get()
        {
            return UsersData.Listar();
        }

        // GET api/<controller>/5
        

        // POST api/<controller>
        public bool Post([FromBody] Users oUsuario)
        {
            return UsersData.Crear(oUsuario);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Users oUsuario)
        {
            return UsersData.Modificar(oUsuario);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return UsersData.Eliminar(id);
        }
    }
}