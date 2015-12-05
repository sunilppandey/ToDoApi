using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAngularJS.Data.Entities;
using TodoAngularJS.Data.Repositories;

namespace TodoAngularJS.Data.Extensions
{
    public static class BookmarkedPlaceExtensions
    {
        public static bool BookmarkedPlaceExists(this IEntityBaseRepository<BookmarkedPlace> _ctx, int placeId)
        {
            return _ctx.GetAll().Any(c => c.Id == placeId);
        }
    }
}
