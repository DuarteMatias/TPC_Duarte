using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class DocenteNegocio
    {
        public IList<Docente> listar()
        {
            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataReader lector;
            IList<Docente> lista = new List<Docente>();

            try
            {
                conexion.ConnectionString = "initial catalog= GESTION; data source = .; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select legajo,nombre,apellido,fnac,email,direccion,telefono,dni from docentes";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Docente aux = new Docente();
                    aux.Legajo = lector.GetInt32(0);
                    aux.Nombre = lector.GetString(1);
                    aux.Apellido = lector.GetString(2);
                    aux.FechaNac = lector.GetDateTime(3);
                    aux.Email = lector.GetString(4);
                    //aux.Direccion= 
                    //aux.Telefono = (int)lector.GetInt64(6);
                    aux.Dni = lector.GetString(7);


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
    }
}
