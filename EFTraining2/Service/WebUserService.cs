using EFTraining2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTraining2.Service
{
    public static class WebUserService
    {
        public static List<User> GetAll()
        {
            WebUserContext context = new WebUserContext();
            List<User> users = context.Users.ToList();
            return users;
        }
        public static User GetById(int id)
        {
            WebUserContext context = new WebUserContext();
            return context.Users.Find(id);
        }
        public static void Add(User user)
        {
            WebUserContext context= new WebUserContext();
            context.Users.Add(user);
        }
    }
}
