using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Data
{
    public class UsersData
    {
        public static bool Crear(Users oUsuario)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("users_crear", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", oUsuario.idUsuario);
                cmd.Parameters.AddWithValue("@usuario", oUsuario.usuario);
                cmd.Parameters.AddWithValue("@primerNombre", oUsuario.primerNombre);
                cmd.Parameters.AddWithValue("@segundoNombre", oUsuario.segundoNombre);
                cmd.Parameters.AddWithValue("@primerApellido", oUsuario.primerApellido);
                cmd.Parameters.AddWithValue("@segundoApellido", oUsuario.segundoApellido);
                cmd.Parameters.AddWithValue("@idDepartamento", oUsuario.idDepartamento);
                cmd.Parameters.AddWithValue("@idCargo", oUsuario.idCargo);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool Modificar(Users oUsuario)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("users_modificar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", oUsuario.idUsuario);
                cmd.Parameters.AddWithValue("@usuario", oUsuario.usuario);
                cmd.Parameters.AddWithValue("@primerNombre", oUsuario.primerNombre);
                cmd.Parameters.AddWithValue("@segundoNombre", oUsuario.segundoNombre);
                cmd.Parameters.AddWithValue("@primerApellido", oUsuario.primerApellido);
                cmd.Parameters.AddWithValue("@segundoApellido", oUsuario.segundoApellido);
                cmd.Parameters.AddWithValue("@idDepartamento", oUsuario.idDepartamento);
                cmd.Parameters.AddWithValue("@idCargo", oUsuario.idCargo);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static List<Users> Listar()
        {
            List<Users> oListaUsuario = new List<Users>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("users_listar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader()) {
                        
                        while (dr.Read())
                        {
                            oListaUsuario.Add(new Users() {
                                idUsuario = (int)dr["idUsuario"],
                                usuario = dr["usuario"].ToString(),
                                primerNombre = dr["primerNombre"].ToString(),
                                segundoNombre = dr["segundoNombre"].ToString(),
                                primerApellido = dr["primerApellido"].ToString(),
                                segundoApellido = dr["segundoApellido"].ToString(),
                                idDepartamento = (int)dr["idDepartamento"],
                                idCargo = (int)dr["idCargo"]
                            });
                        }

                    }



                    return oListaUsuario;
                }
                catch (Exception ex)
                {
                    return oListaUsuario;
                }
            }
        }

        

        public static bool Eliminar(int id)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("users_eliminar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", id);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

    }
}