using Models.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAO
{
    public class FeedbackDb : BaseModel
    {


        public List<Feedback> GetFeedback(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
           };
            return context.Database.SqlQuery<Feedback>("PSP_Feedback_Select @id", param).ToList();
        }

        public Feedback GetFeedbackByID(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
           };
            return context.Database.SqlQuery<Feedback>("PSP_Feedback_Select @id", param).SingleOrDefault();
        }

        public int InsertAndUpdateFeedback(Feedback cat)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@ID",cat.ID),
                new SqlParameter("@Name",cat.Name),
                 new SqlParameter("@Phone",cat.Phone),
                  new SqlParameter("@Email",cat.Email),
                   new SqlParameter("@Address",cat.Address),
                    new SqlParameter("@ontent",cat.Content),
                     new SqlParameter("@CreatedDate",cat.CreatedDate),
                      new SqlParameter("@Status",cat.Status),
                    
                 //...Them cho du thuonc tinsh
           };
            return context.Database.ExecuteSqlCommand("PSP_Feedback_InsertAndUpdate @id,@Name", param);
        }
        public int DeleteFeedback(long id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
              
           };
            return context.Database.ExecuteSqlCommand("PSP_Feedback_Delete @id", param);
        }
    }
}

