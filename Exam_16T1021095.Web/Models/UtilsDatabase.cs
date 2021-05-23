using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam_16T1021095.Web.Models
{
    public class UtilsDatabase
    {
        private static DataBaseDataContext db = null;
        public static DataBaseDataContext getDaTaBase()
        {
            if (db == null)
            {
                db = new DataBaseDataContext();
            }
            return db;
        }
    }
}