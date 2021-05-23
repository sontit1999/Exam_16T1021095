using Exam_16T1021095.DomainModels;
using Exam_16T1021095.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_16T1021095_DataLayers
{
    public class AccountDAL
    {
        public List<UsersAccount> getAllAccount()
        {

            var listACC = from u in UtilsDatabase.getDaTaBase().UserAccounts
                          select new UsersAccount(u.Username, u.Password);

            return listACC.ToList();
        }
    }
}
