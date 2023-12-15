using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Comun.Cache;

namespace AccesoDatos
{
    public class UserDao : Conexion
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuarios where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.FirstName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Position = reader.GetString(5);
                            UserLoginCache.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Usuarios where LoginName= @user or Email =@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string userName = reader.GetString(3) + " " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);
                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                            subject: "Recuperación de contraseña",
                            body: "Hola " + userName + "tu password actual es "
                            + accountPassword + ". Se recomienda cambiar la" +
                            "contraseña cuando ingreses alsistema ",
                            recipientMail: new List<string> { userMail }
                            );
                        return "Hola " + userName + " verifica tu correo electrónico " +
                            " vinculado a esta cuenta y realiza el cambio de contraseña";
                    }
                    else
                    {
                        return "Lo sentimos!! :( usted no tiene una cuenta asociada al mail o al nombre del usuario";
                    }
                }
            }
        }
    }

}

