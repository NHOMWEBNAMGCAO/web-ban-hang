using Models.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAO
{
    public class MenuDb : BaseModel
    {


        public List<Menu> GetMenu(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
           };
            return context.Database.SqlQuery<Menu>("PSP_Menu_Select @id", param).ToList();
        }

        public Menu GetMenuByID(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
           };
            return context.Database.SqlQuery<Menu>("PSP_Menu_Select @id", param).SingleOrDefault();
        }

        public int InsertAndUpdateMenu(Menu cat)
        {
            SqlParameter[] param = new SqlParameter[]{
              new SqlParameter("@id",cat.ID),
               new SqlParameter("@Text",cat.Text),
                new SqlParameter("@Link",cat.Link),
                 new SqlParameter("@DisplayOrder",cat.DisplayOrder),
                  new SqlParameter("@Target",cat.Target),
                   new SqlParameter("@Status",cat.Status),
                    new SqlParameter("@TypeID",cat.TypeID),
                     
                     
           };
            return context.Database.ExecuteSqlCommand("PSP_Menu_InsertAndUpdate @id, @Text", param);
        }
        public int DeleteMenu(long id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
              
           };
            return context.Database.ExecuteSqlCommand("PSP_Menu_Delete @id", param);
        }
    }
}

