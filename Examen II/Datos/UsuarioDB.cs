using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;

namespace Datos
{
    public class UsuarioDB
    {
        string cadena = "server=localhost; user=root; database=examenii; password=Fersopoles51";

        public Usuario Autenticar(Login login)
        {
            Usuario user = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuario WHERE CodigoUsuario = @CodigoUsuario AND Password = @Password");

                using (MySqlConnection _Conexion = new MySqlConnection(cadena))
                {
                    _Conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _Conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.CodigoUsuario;
                        comando.Parameters.Add("@Password", MySqlDbType.VarChar, 50).Value = login.Contraseña;

                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            user = new Usuario();

                            user.CodigoUsuario = dr["CodigoUsuario"].ToString();
                            user.Nombre = dr["Nombre"].ToString();
                            user.Contraseña = dr["Password"].ToString();
                            user.Correo = dr["Correo"].ToString();
                            user.Rol = dr["Rol"].ToString();
                            user.FechaCreacion = (DateTime)(dr["FechaCreacion"]);
                            user.EstaActivo = Convert.ToBoolean(dr["EstadoActivo"]);

                        }
                    }
                }
            }
            catch (System.Exception ex)
            {

            }

            return user;
        }

        public DataTable DevolverUsuarios()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuario ");
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
