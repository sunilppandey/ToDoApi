
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoAngularJS.Data;

namespace ToDoApi.Web.Controllers
{
    public class BaseApiController : ApiController
    {
        private IFourSquareRepository _repo;

        protected IFourSquareRepository TheRepository
        {
            get
            {
                _repo = new FourSquareRepository();
                return _repo;
            }
        }
    }
}
