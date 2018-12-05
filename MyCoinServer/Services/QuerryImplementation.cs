using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MyCoinData;


namespace MyCoinServer.Services
{
    using MyCoinData.DAO;
    using MyCoinData.IData;
    using MyCoinData.Models;

    public class QuerryImplementation : IQuerryImplementation
    {
        public string ConnectUser(Querry querry)
        {
            UserDAO userDao = new UserDAO();
            try
            {
                var userActif = (User)querry.Data;
                var users = userDao.AllItems();
                var user = users.Where(
                    u => u.Username.Equals(userActif.Username) && u.Password.Equals(userActif.Password)).First();
                var response=new Response();
                user.State = true;
                response.Data = user;
                response.Entete = querry.Entete;
                return new UserDAO().Serialize(response);
            }
            catch (Exception e)
            {
                var response = new Response();
                response.Entete = querry.Entete;
                response.Data = e;
                return new UserDAO().Serialize(response);
            }
        }

        public string NewUser(Querry querry)
        {
            UserDAO userDao = new UserDAO();
            try
            {
                var userActif = (User)querry.Data;
                userActif.DateCreation= DateTime.Now;
                userDao.NewItem(userActif);
                var response = new Response();
                response.Data = userActif;
                response.Entete = querry.Entete;
                return new UserDAO().Serialize(response);
            }
            catch (Exception e)
            {
                var response = new Response();
                response.Entete = querry.Entete;
                response.Data = e;
                return new UserDAO().Serialize(response);
            }
        }
    }
}