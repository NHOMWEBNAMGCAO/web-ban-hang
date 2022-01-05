using Models.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models.DAO
{
    public class ProductDb : BaseModel
    {
        //MilanoShopDbContext context ;

        //public ProductDb()
        //{
        //    context = new MilanoShopDbContext();
            
        //}

        public List<Product> GetProduct(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
           };
            return context.Database.SqlQuery<Product>("PSP_Product_Select @id", param).ToList();
        }

        public Product GetProductID(int id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
           };
            return context.Database.SqlQuery<Product>("PSP_Product_Select @id", param).SingleOrDefault();
        }

        public int InsertAndUpdateProduct(Product cat)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",cat.ID),
                new SqlParameter("@Name",cat.Name),
                 new SqlParameter("@Code",cat.Code),
                  new SqlParameter("@MetaTitle",cat.MetaTitle),
                   new SqlParameter("@Description",cat.Description),
                    new SqlParameter("@Image",cat.Image),
                     new SqlParameter("@MoreImages",cat.MoreImages),
                      new SqlParameter("@Price",cat.Price),
                       new SqlParameter("@PromotionPrice",cat.PromotionPrice),
                        new SqlParameter("@IncludedVAT",cat.IncludedVAT),
                         new SqlParameter("@Quantity",cat.Quantity),
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
                       
                 //...Them cho du thuonc tinsh
           };
            return context.Database.ExecuteSqlCommand("PSP_Product_InsertAndUpdate @id,@Name", param);
        }
        public int DeleteProduct(long id)
        {
            SqlParameter[] param = new SqlParameter[]{
               new SqlParameter("@id",id)
              
           };
            return context.Database.ExecuteSqlCommand("PSP_Product_Delete @id", param);
        }
    }
}
