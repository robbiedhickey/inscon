﻿using Enterprise.DALServices.DAL.Models;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Repositories.Interfaces
{
    public interface ILocationRepository : IBaseCrudRepository<Location>
    {
        IList<Location> GetBy(int organizationID);
        IList<Location> GetBy(int organizationID, int typeID);
    }
}