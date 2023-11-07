using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebApi.Models;

namespace WebApi.Data
{
    public class CargosData
    {

        public static List<Cargos> Listar()
        {
            List<Cargos> oListaCargos = new List<Cargos>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("listar_cargos", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListaCargos.Add(new Cargos()
                            {
                                idCargos = (int)dr["idCargo"],
                                codigo = dr["codigo"].ToString(),
                                nombre = dr["nombre"].ToString(),
                                activo = dr["activo"].ToString(),
                                idUsuarioCreacion = (int)dr["idUsuarioCreacion"]
                            });
                        }

                    }



                    return oListaCargos;
                }
                catch (Exception ex)
                {
                    return oListaCargos;
                }
            }
        }

    }  

}