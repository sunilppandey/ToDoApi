using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAngularJS.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        FourSquareContext dbContext;

        public FourSquareContext Init()
        {
            return dbContext ?? (dbContext = new FourSquareContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
