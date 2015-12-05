using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoAngularJS.Data.Entities;

namespace TodoAngularJS.Data
{
    public interface IFourSquareRepository
    {
        IQueryable<BookmarkedPlace> GetBookmarkedPlaces(string userName);
        bool UserNameExists(string userName);
        int SavePlace(BookmarkedPlace bookmarkedPlace);
    }
}
