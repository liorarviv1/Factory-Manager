using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationFactory.Models
{
    public class UserBL
    {
        private FactoryDBEntities db = new FactoryDBEntities();

        public List<User> GetAllUsers()
        {
            return db.User.ToList();
        }
        public User GetUserId(int id)
        {
            return db.User.Where(x=>x.ID== id).First();
        }
        public void AddUser(User user)
        {
            db.User.Add(user);
            db.SaveChanges();

        }
        public void UpdateUser(int id,User user)
        {
            User u=db.User.Where(x=>x.ID== id).First();
            //u.FullName = user.FullName;
            //u.UserName = user.UserName;
            //u.Password = user.Password;
            u.NumOfActions = user.NumOfActions;
            u.DailyActions = user.DailyActions;
            db.SaveChanges();
          
        }
        public void DeleteUser(int id)
        {
            User u = db.User.Where(x => x.ID == id).First();
            db.User.Remove(u);
            db.SaveChanges();

        }




        //public User CheckUser(string name,string pas)
        //{
        //    foreach (User us in db.User)
        //    {
        //        if(us.UserName==name&&us.Password==pas)
        //        {
        //            return us;
        //        }
        //        else
        //        {
        //            return null;   
        //        }
        //    }
        //}
    }
}