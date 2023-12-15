using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

//Negocios
namespace SistemaVencejo
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(String user, string pass)
        {
            return userDao.Login(user, pass);
        }
        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }
    }
}
