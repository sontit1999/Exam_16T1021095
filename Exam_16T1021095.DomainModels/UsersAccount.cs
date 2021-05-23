using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Exam_16T1021095.DomainModels
{
    public class UsersAccount
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public UsersAccount(string username,string pass)
        {
            this.UserName = username;
            this.Password = pass;
        }
    }
}
