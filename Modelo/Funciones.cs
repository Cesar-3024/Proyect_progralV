using Proyecto_Programacios_lV_Grupo6.Controlador;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Programacios_lV_Grupo6.Modelo
{
    //Clase de referencia para poder ingresar los datos en la base de datos y agregar los atributos
    public class Funciones
    {
        private const int CommandTimeout = 120; // 120 segundos para ingreso de datos

        public static int AgregarPersona(Persona persona)
        {
            int retorno = 0;
            using (SqlConnection Conexion = BDGeneral.ObtenerConexion())
            {
                string query = "INSERT INTO persona (Nombre, Primer_Apellido, Segundo_Apellido, Celular, Correo_Electronico) " +
                               "VALUES (@Nombre, @PrimerApellido, @SegundoApellido, @Celular, @CorreoElectronico)";
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.AddWithValue("@Nombre", persona.Nombre);
                comando.Parameters.AddWithValue("@PrimerApellido", persona.Primer_Apellido);
                comando.Parameters.AddWithValue("@SegundoApellido", persona.Segundo_Apellido);
                comando.Parameters.AddWithValue("@Celular", persona.Celular);
                comando.Parameters.AddWithValue("@CorreoElectronico", persona.Correo_Electronico);
                comando.CommandTimeout = CommandTimeout;

                retorno = comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static List<Persona> MostrarBase()
        {
            List<Persona> lista = new List<Persona>();
            using (SqlConnection Conexion = BDGeneral.ObtenerConexion())
            {
                string query = "SELECT * FROM persona";
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.CommandTimeout = CommandTimeout;

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Persona persona = new Persona
                        {
                            id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Primer_Apellido = reader.GetString(2),
                            Segundo_Apellido = reader.GetString(3),
                            Celular = reader.GetString(4),
                            Correo_Electronico = reader.GetString(5)
                        };
                        lista.Add(persona);
                    }
                }
            }
            return lista;
        }

        public static int ModificarBD(Persona persona)
        {
            int result = 0;
            using (SqlConnection Conexion = BDGeneral.ObtenerConexion())
            {
                string query = "UPDATE persona SET nombre = @Nombre, Primer_Apellido = @PrimerApellido, Segundo_Apellido = @SegundoApellido, " +
                               "Celular = @Celular, Correo_Electronico = @CorreoElectronico WHERE id = @Id";
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.AddWithValue("@Nombre", persona.Nombre);
                comando.Parameters.AddWithValue("@PrimerApellido", persona.Primer_Apellido);
                comando.Parameters.AddWithValue("@SegundoApellido", persona.Segundo_Apellido);
                comando.Parameters.AddWithValue("@Celular", persona.Celular);
                comando.Parameters.AddWithValue("@CorreoElectronico", persona.Correo_Electronico);
                comando.Parameters.AddWithValue("@Id", persona.id);
                comando.CommandTimeout = CommandTimeout;

                result = comando.ExecuteNonQuery();
            }
            return result;
        }

        public static int EliminarPersona(int id)
        {
            int resultado = 0;
            using (SqlConnection Conexion = BDGeneral.ObtenerConexion())
            {
                string query = "DELETE FROM persona WHERE id = @Id";
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.AddWithValue("@Id", id);
                comando.CommandTimeout = CommandTimeout;

                resultado = comando.ExecuteNonQuery();
            }
            return resultado;
        }
    }
}
