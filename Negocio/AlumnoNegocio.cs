using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

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
                comando.CommandText = "select legajo,nombre,apellido,fnac,email,direccion,telefono,dni from alumnos";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Alumno aux = new Alumno();
                    aux.Legajo = lector.GetInt32(0);
                    aux.Nombre = lector.GetString(1);
                    aux.Apellido = lector.GetString(2);
                    aux.Fnac = lector.GetDateTime(3);
                    aux.Email = lector.GetString(4);
                    //aux.Direccion.Domicilio = lector.GetString(5);
                    //aux.Telefono = (int)lector.GetInt64(6);
                    aux.Dni = lector.GetInt32(7);
                    
                                      
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

        public void Insertar(string nombre, string apellido, DateTime fnac, string email, string direccion, Int64 telefono, Int32 dni)
        {
            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();


            conexion.Open();
            comando.CommandText="insert into Alumnos values('"+nombre+"','" + apellido+"','"+ fnac+"','" + email+"','" + direccion +"','" + telefono+"','" + dni+"')";
            comando.ExecuteNonQuery();
        }
    }
}
