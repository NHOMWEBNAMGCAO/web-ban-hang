using Models.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAO
{
    public class UserDb : BaseModel
    {
        

        public List<User> GetUser(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
           };
            return context.Database.SqlQuery<User>("PSP_User_Select @id", param).ToList();
        }

        public User GetUserByID(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
           };
            return context.Database.SqlQuery<User>("PSP_User_Select @id", param).SingleOrDefault();
        }

        public int InsertAndUpdateUser(User cat)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",cat.ID),
                new SqlParameter("@UserName",cat.UserName),
                 new SqlParameter("@Password",cat.Password),
                  new SqlParameter("@GroupID",cat.GroupID),
                   new SqlParameter("@Name",cat.Name),
                    new SqlParameter("@Address",cat.Address),
                     new SqlParameter("@Email",cat.Email),
                      new SqlParameter("@Phone",cat.Phone),
                       new SqlParameter("@ProvinceID",cat.ProvinceID),
                        new SqlParameter("@DistrictID",cat.DistrictID),
                         new SqlParameter("@CreatedDate",cat.CreatedDate),
                          new SqlParameter("@CreatedBy",cat.CreatedBy),
                           new SqlParameter("@ModifiedDate",cat.ModifiedDate),
                            new SqlParameter("@ModifiedBy",cat.ModifiedBy),
                             new SqlParameter("@Status",cat.Status),
                            
                    
                 //...Them cho du thuonc tinsh
           };
            return context.Database.ExecuteSqlCommand("PSP_User_InsertAndUpdate @id,@UserName", param);
        }
        public int DeleteUser(long id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
              
           };
            return context.Database.ExecuteSqlCommand("PSP_User_Delete @id", param);
        }
    }
}

