using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Data;

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
            Alumno aux;
            try
            {
                conexion.ConnectionString = "initial catalog= GESTION; data source =.; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select legajo,nombre,apellido,fechanac,email,direccion,telefono,dni,sexo from alumnos";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux= new Alumno();
                    aux.Legajo = lector.GetInt32(0); //Los numeros se corresponden con la posicion de las columnas en el SQL
                    aux.Nombre = lector.GetString(1);
                    aux.Apellido = lector.GetString(2);
                    aux.Dni = lector.GetString(7);
                    aux.FechaNac = lector.GetDateTime(3);
                    aux.Sexo = lector.GetString(8);
                    //aux.Direccion = lector.GetString(5);
                    //aux.Telefono = (int)lector.GetInt64(6);


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

        public IList<Alumno> listarBusquedaLegajo(int n)
        {
            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataReader lector;
            IList<Alumno> lista = new List<Alumno>();
            try
            {
                conexion.ConnectionString = "initial catalog= GESTION; data source =.; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select legajo,nombre,apellido,fechanac,email,direccion,telefono,dni,sexo from alumnos where legajo = '" + n + "'";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Alumno aux = new Alumno();
                    aux.Legajo = lector.GetInt32(0);
                    aux.Nombre = lector.GetString(1);
                    aux.Apellido = lector.GetString(2);
                    aux.Dni = lector.GetString(7);
                    aux.FechaNac = lector.GetDateTime(3);
                    aux.Email = lector.GetString(4);
                    aux.Sexo = lector.GetString(8);
                    //aux.Direccion = lector.GetString(5);
                    //aux.Telefono = (int)lector.GetInt64(6);


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

        public IList<Alumno> listarBusquedaNombre(string n)
        {
            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataReader lector;
            IList<Alumno> lista = new List<Alumno>();
            try
            {
                conexion.ConnectionString = "initial catalog= GESTION; data source =.; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select legajo,nombre,apellido,fechanac,email,direccion,telefono,dni,sexo from alumnos where nombre like '%" + n + "%'";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Alumno aux = new Alumno();
                    aux.Legajo = lector.GetInt32(0);
                    aux.Nombre = lector.GetString(1);
                    aux.Apellido = lector.GetString(2);
                    aux.Dni = lector.GetString(7);
                    aux.FechaNac = lector.GetDateTime(3);
                    aux.Email = lector.GetString(4);
                    aux.Sexo = lector.GetString(8);
                    //aux.Direccion = lector.GetString(5);
                    //aux.Telefono = (int)lector.GetInt64(6);


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
                consulta = "insert into ALUMNOS (Nombre,Apellido,FechaNac,email,dni,sexo)";
                consulta = consulta + "  values ('" + nuevo.Nombre + "','" + nuevo.Apellido + "','" + nuevo.FechaNac + "','" + nuevo.Email + "','" + nuevo.Dni + "','" + nuevo.Sexo + "')";

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

        public void baja(Alumno borrar)
        {

            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "delete from ALUMNOS where legajo = " + borrar.Legajo + " ";


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

        public void modificar(Alumno modificar)
        {


            SqlConnection conexion = new SqlConnection();

            SqlCommand comando = new SqlCommand();

            SqlDataReader lector;

            try
            {
                Alumno alum = new Alumno();

                conexion.ConnectionString = "initial catalog= GESTION; data source =.; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "update alumnos set Nombre = '" + alum.Nombre + "', Apellido ='" + alum.Apellido + "', email ='" + alum.Email + "',dni = '" + alum.Dni + "' where legajo = " + modificar.Legajo + " ";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
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

        public static long UltimoLegajo()
        {
            long ultimoLegajo = new long();

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "initial catalog= GESTION; data source =.; integrated security=sspi";
            SqlCommand command = new SqlCommand("Select Legajo from ALUMNOS ", conexion);
            SqlDataReader reader;

            try
            {

                conexion.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ultimoLegajo = reader.GetInt32(0);
                }
                return ultimoLegajo;
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
