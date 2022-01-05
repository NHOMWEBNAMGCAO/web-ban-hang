
using Models.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAO
{
    public class AccountDAO : BaseModel
    {

        public bool CheckLogin(ref string err, string UserName, string Password)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@UserName",UserName),
                 new SqlParameter("@Password",Password)
            };

                return context.Database.SqlQuery<bool>("Sp_Account_Login @UserName,@Password", param).SingleOrDefault();
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return false;
        }

        public User GetUserByUserName(string UserName, string Password)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@UserName",UserName),
                 new SqlParameter("@Password",Password)
            };

            return context.Database.SqlQuery<User>("SP_GetUserByUserName @UserName,@Password", param).SingleOrDefault();
        }
        public string UserName { set; get; }
        public string Password { set; get; }
        public string RememberMe { set; get; }





       
    }
}
