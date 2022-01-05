using Models.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAO
{
    public class ContentDAO : BaseModel
    {
    

        public List<Content> GetContents(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
           };
            return context.Database.SqlQuery<Content>("PSP_Content_Select @id", param).ToList();
        }

        public Content GetContentByID(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
           };
            return context.Database.SqlQuery<Content>("PSP_Content_Select @id", param).SingleOrDefault();
        }

        public int InsertAndUpdateContent(Content cat)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",cat.ID),
                new SqlParameter("@Name",cat.Name),
                 new SqlParameter("@MetaTitle",cat.MetaTitle),
                  new SqlParameter("@Description",cat.Description),
                   new SqlParameter("@Image",cat.Image),
                    new SqlParameter("@CategoryID",cat.CategoryID),
                     new SqlParameter("@Detail",cat.Detail),
                      new SqlParameter("@Warranty",cat.Warranty),
                       new SqlParameter("@CreatedDate",cat.CreatedDate),
                        new SqlParameter("@CreatedBy",cat.CreatedBy),
                         new SqlParameter("@ModifiedDate",cat.ModifiedDate),
                          new SqlParameter("@ModifiedBy",cat.ModifiedBy),
                           new SqlParameter("@MetaKeywords",cat.MetaKeywords),
                            new SqlParameter("@MetaDescriptions",cat.MetaDescriptions),
                             new SqlParameter("@Status",cat.Status),
                              new SqlParameter("@TopHot",cat.TopHot),
                               new SqlParameter("@ViewCount",cat.ViewCount),
                                new SqlParameter("@Tags",cat.Tags),
                                 new SqlParameter("@Language",cat.Language),
                    
                 //...Them cho du thuonc tinsh
           };
            return context.Database.ExecuteSqlCommand("PSP_Content_InsertAndUpdate @id,@Name", param);
        }
        public int DeleteContent(long id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
              
           };
            return context.Database.ExecuteSqlCommand("PSP_Content_Delete @id", param);
        }
    }
}
