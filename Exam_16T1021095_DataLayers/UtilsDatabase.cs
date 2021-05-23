using Exam_16T1021095_DataLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam_16T1021095.Web.Models
{
    public class UtilsDatabase
    {
        private static DataClasses1DataContext db = null;
        public static DataClasses1DataContext getDaTaBase()
        {
            if (db == null)
            {
                db = new DataClasses1DataContext();
            }
            return db;
        }
    }
}