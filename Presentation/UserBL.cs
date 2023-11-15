using BusinessObj;
using DataLayer1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class UserBL
    {
        public AccountBO AddUser(UserBO objUserBo)
        {
            return new UserDAL().AddUser(objUserBo);
        }
    }
}
