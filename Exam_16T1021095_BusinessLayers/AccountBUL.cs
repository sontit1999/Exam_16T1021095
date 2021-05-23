using Exam_16T1021095.DomainModels;
using Exam_16T1021095_DataLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_16T1021095_BusinessLayers
{
    public class AccountBUL
    {
        AccountDAL accountDAL = new AccountDAL();
        public List<UsersAccount> getAllAccount()
        {
            return accountDAL.getAllAccount();
        }
    }
}
