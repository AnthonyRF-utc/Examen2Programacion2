using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Exameen2Programacion2.Clases
{
    public class Equipos 
    {
        public int id { get; set; }
        public string tipoequipo { get; set; }
        public string modelo { get; set; }

        public Equipos(int Id, string TipoEquipo, string Modelo)
        {
            this.id = Id;
            this.tipoequipo = TipoEquipo;
            this.modelo = Modelo;
        }

        public Equipos() { }

        public static int INSERTAR_EQUIPOS(string tipoequipo, string modelo)
        {
            int retorno = 0;

            SqlConnection Conexion = new SqlConnection();
            try
            {
                using (Conexion = DBConexion.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("INSERTAR_EQUIPOS", Conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@TIPO_EQUIP", tipoequipo));
                    cmd.Parameters.Add(new SqlParameter("@MODELO", modelo));
                    


                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conexion.Close();
            }

            return retorno;

        }

        public static int BORRAR_EQUIPOS(int id)
        {
            int retorno = 0;

            SqlConnection Conexion = new SqlConnection();
            try
            {
                using (Conexion = DBConexion.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BORRAR_EQUIPOS", Conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID_EQUIP", id));


                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conexion.Close();
            }

            return retorno;

        }

        public static int ACTUALIZAR_EQUIP_ID(int id, string tipequip, string modelo)
        {
            int retorno = 0;

            SqlConnection Conexion = new SqlConnection();
            try
            {
                using (Conexion = DBConexion.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZAR_EQUIP_ID", Conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ID_EQUIP", id));
                    cmd.Parameters.Add(new SqlParameter("@TIPO_EQUIP", tipequip));
                    cmd.Parameters.Add(new SqlParameter("@MODELO", modelo));


                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conexion.Close();
            }

            return retorno;

        }
    }
}