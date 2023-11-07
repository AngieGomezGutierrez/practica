using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Data
{
    public class DepartamentosData
    {


        public static List<Departamentos> Listar()
        {
            List<Departamentos> oListaDepartamentos = new List<Departamentos>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("departamentos_listar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListaDepartamentos.Add(new Departamentos()
                            {
                                idDepartamento = (int)dr["idDepartamento"],
                                codigo = dr["codigo"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                activo = dr["activo"].ToString(),

                                idUsuarioCreacion = (int)dr["idUsuarioCreacion"]
                            });
                        }

                    }



                    return oListaDepartamentos;
                }
                catch (Exception ex)
                {
                    return oListaDepartamentos;
                }
            }
        }


    }
}