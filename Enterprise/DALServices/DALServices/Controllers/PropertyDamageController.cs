using Enterprise.ApiServices.DALServices.Helpers;
using Enterprise.ApiServices.DALServices.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Enterprise.DAL.Core.Model;

namespace Enterprise.ApiServices.DALServices.Controllers
{
    public class PropertyDamageController : ApiController
    {
        private readonly IPropertyDamageRepository repository = new PropertyDamageRepository();
        private readonly ExceptionHelper exceptionHelper = new ExceptionHelper();
    }
}
