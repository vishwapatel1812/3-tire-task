using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BussinessObject;
using DataAccess;

namespace Bussinesslogic
{
    public class UserBL
    {
        public int SaveUserregisrationBL(UserBO objUserBL)
        {
            try
            {
                UserDA objUserda = new UserDA();
                return objUserda.AddUserDetails(objUserBL);
            }
            catch
            {
                throw;
            }
        }
    }
}
