using ActionFilterDemo.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ActionFilterDemo.DataAccess.Managers
{
    public static class ReportsManager
    {
        public static List<Report> GetAll()
        {
            using(UsersEntities context = new UsersEntities())
            {
                return context.Reports.Include(x => x.User).OrderBy(x => x.Title).ToList();
            }
        }

        public static Report GetByID(int id)
        {
            using (UsersEntities context = new UsersEntities())
            {
                return context.Reports.Include(x=>x.User).First(x=>x.ReportID == id);
            }
        }
    }
}