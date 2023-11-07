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
    public class DepartamentosController : ApiController
    {
        // GET api/<controller>
        public List<Departamentos> Get()
        {
            return DepartamentosData.Listar();
        }

    
    }
}