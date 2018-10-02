using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Negocio
{
    public class AlumnoNegocio

    {
        public IList<Alumno> listar()
        {
            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataReader lector;
            IList<Alumno> lista = new List<Alumno>();
            try
            {
                conexion.ConnectionString = "initial catalog= GESTION; data source =.; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select legajo,nombre,apellido,fechanac,email,direccion,telefono,dni from alumnos";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Alumno aux = new Alumno();
                    aux.Legajo = lector.GetInt32(0);
                    aux.Nombre = lector.GetString(1);
                    aux.Apellido = lector.GetString(2);
                    aux.FechaNac = lector.GetDateTime(3);
                    //aux.Email = lector.GetString(4);
                    //aux.Direccion = lector.GetString(5);
                    //aux.Telefono = (int)lector.GetInt64(6);
                    //aux.Dni = lector.GetString(7);
                    
                                      
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void alta(Alumno nuevo)
        {
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "insert into ALUMNOS (Nombre,Apellido,Fnac)";
                consulta= consulta + "  values ('" + nuevo.Nombre + "','" + nuevo.Apellido + "','"+nuevo.FechaNac+ "')";

                conexion.setearConsulta(consulta);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.cerrarConexion();
            }


        }
    }
}
