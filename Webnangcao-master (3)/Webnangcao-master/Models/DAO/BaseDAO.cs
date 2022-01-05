using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAO
{
    public class BaseModel : IDisposable
    {
        public MilanoShopDbContext context;
        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
        }
        public BaseModel()
        {
            context = new MilanoShopDbContext();
        }
    }
}
