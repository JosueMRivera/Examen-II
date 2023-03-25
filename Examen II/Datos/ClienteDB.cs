using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteDB
    {
        string cadena = "server=localhost; user=root; database=examenii; password=Fersopoles51";

        public Cliente DevolverClientesPorIdentidad(string identidad)
        {
            Cliente cliente = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM cliente WHERE Identidad = @Identidad ");
                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Identidad", MySqlDbType.VarChar, 25).Value = identidad;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            cliente = new Cliente();

                            cliente.Identidad = identidad;
                            cliente.Nombre = dr["Nombre"].ToString();
                            cliente.Telefono = dr["Telefono"].ToString();
                            cliente.Correo = dr["Correo"].ToString();
                            cliente.Direccion = dr["Direccion"].ToString();
                            cliente.EstaActivo = Convert.ToBoolean(dr["EstaActivo"]);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
            }

            return cliente;
        }

        public DataTable DevolverClientes()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM cliente ");
                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);
                    }
                }
            }
            catch (System.Exception ex)
            {
            }

            return dt;
        }

        public DataTable DevolverClientesPorNombre(string Nombre)
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM cliente WHERE Nombre LIKE '%" + Nombre + "%'");
                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);
                    }
                }
            }
            catch (System.Exception ex)
            {
            }

            return dt;
        }
    }
}
