using BusinessObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer1
{
    public class UserDAL
    {
        private readonly SchoolEntities objSchoolEntities;
        public UserDAL()
        {
            objSchoolEntities = new SchoolEntities();
        }
        public AccountBO AddUser(UserBO objUserBo)
        {
            AccountBO objAccount = new AccountBO();
           CreatorUser creatorUser = new CreatorUser()
           {
               ID = objUserBo.ID,
               fName = objUserBo.fName,
               lName = (string)objUserBo.lName,
               pname = objUserBo.pname,
           };
           objSchoolEntities.CreatorUsers.Add(creatorUser);
           int returnValue = objSchoolEntities.SaveChanges();
            if(returnValue > 0)
            {
                objAccount.UserMsg = "Data Successfully Added..!!";
                objAccount.ID = returnValue; 
            }
            else
            {
                objAccount.UserMsg = "ERROR did not add..!!";
                objAccount.ID = returnValue;
            }
            return objAccount;
        }
        
    }
}
