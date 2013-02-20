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
    public class AssetController : ApiController
    {
        private readonly IAssetRepository _repository = new AssetRepository();
        private readonly ExceptionHelper _exceptionHelper = new ExceptionHelper();

        [HttpGet]
        public List<Asset> GetAllAssets()
        {
            return _repository.GetAllAssets();
        }

        [HttpGet]
        public Asset GetAssetById(Int32 id)
        {
            if (id < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The ID for the asset must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetAssetById(id);
        }

        [HttpGet]
        public List<Asset> GetAssetByOrganizationID(Int32 organizationID)
        {
            if (organizationID < 0)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The organizationID for the asset must not be negative.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.GetAssetByOrganizationID(organizationID);
        }

        [HttpDelete]
        public bool DeleteRecord(Asset asset)
        {
            if (asset == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The asset must not be null.",
                                                             "Null Value Not Allowed"));
            }

            return _repository.DeleteRecord(asset);
        }

        [HttpPost]
        public int SaveRecord(Asset asset)
        {
            if (asset == null)
            {
                throw new HttpResponseException(
                    _exceptionHelper.BuildHttpResponseMessage(HttpStatusCode.NotAcceptable,
                                                             "The asset must not be null.",
                                                             "Negative Value Not Allowed"));
            }

            return _repository.SaveRecord(asset);
        }
    }
}
