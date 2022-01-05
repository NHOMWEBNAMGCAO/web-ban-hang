using Models.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models.DAO
{
    public class ProductCategoryDb : BaseModel
    {

   

        public List<ProductCategory> GetProductCategory(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
           };
            return context.Database.SqlQuery<ProductCategory>("PSP_ProductCategory_Select @id", param).ToList();
        }

        public ProductCategory GetProductCategoryID(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
           };
            return context.Database.SqlQuery<ProductCategory>("PSP_ProductCategory_Select @id", param).SingleOrDefault();
        }

        public int InsertAndUpdateProductCategory(ProductCategory cat)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",cat.ID),
                new SqlParameter("@Name",cat.Name),
                 new SqlParameter("@MetaTitle",cat.MetaTitle),
                  new SqlParameter("@ParentID",cat.ParentID),
                   new SqlParameter("@DisplayOrder",cat.DisplayOrder),
                    new SqlParameter("@SeoTitle",cat.SeoTitle),                
                             new SqlParameter("@CreatedDate",cat.CreatedDate),
                              new SqlParameter("@CreatedBy",cat.CreatedBy),
                               new SqlParameter("@ModifiedDate",cat.ModifiedDate),
                                new SqlParameter("@ModifiedBy",cat.ModifiedBy),
                                 new SqlParameter("@MetaKeywords",cat.MetaKeywords),
                                  new SqlParameter("@MetaDescriptions",cat.MetaDescriptions),
                                   new SqlParameter("@Status",cat.Status),
                                    new SqlParameter("ShowOnHome",cat.ShowOnHome),
                                  
                       
                 //...Them cho du thuonc tinsh
           };
            return context.Database.ExecuteSqlCommand("PSP_ProductCategory_InsertAndUpdate @id,@Name", param);
        }
        public int DeleteProductCategory(long id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
              
           };
            return context.Database.ExecuteSqlCommand("PSP_ProductCategory_Delete @id", param);
        }
    }
}
