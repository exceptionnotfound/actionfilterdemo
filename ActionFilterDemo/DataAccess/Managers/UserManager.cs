using ActionFilterDemo.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActionFilterDemo.DataAccess.Managers
{
    public static class UserManager
    {
        public static List<User> GetAll()
        {
            using(UsersEntities context = new UsersEntities())
            {
                return context.Users.OrderBy(x => x.Name).ToList();
            }
        }

        public static User GetByID(int id)
        {
            using (UsersEntities context = new UsersEntities())
            {
                return context.Users.Find(id);
            }
        }
    }
}