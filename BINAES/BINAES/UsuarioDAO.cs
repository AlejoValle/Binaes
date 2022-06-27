using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BINAES.Properties;

namespace BINAES
{
    public static class UsuarioDAO
    {
        public static Usuario listar  (int id)
        {
            Usuario cat1 = new Usuario();
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "select nombre_usuario,Contraseña from CLIENTE";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cat1.nombreusuario = reader["usuario"].ToString();
                        cat1.contraseña = reader["contrasena"].ToString();
                    }
                }
                connection.Close();
            }
            return cat1;
        }
        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "select nombre_usuario,Contraseña from CLIENTE";
                SqlCommand command = new SqlCommand(query, connection);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario cat = new Usuario();
                        cat.nombreusuario = reader["nombre_usuario"].ToString();
                        cat.contraseña = reader["Contraseña"].ToString();
                        lista.Add(cat);
                    }
                } 
                connection.Close();
            }
            return lista;
        }
    }
    
    
}