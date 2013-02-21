using System;
using System.Collections.Generic;
using Enterprise.DAL.Core.Model;
using Enterprise.DAL.Core.Types;
using Enterprise.DAL.Framework.Data;

namespace Enterprise.DAL.Core.Service
{
    /// <summary>
    /// Class EntityService
    /// </summary>
    public class EntityService : ServiceBase<Entity>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityService"/> class.
        /// </summary>
        public EntityService()
        {
            IsCached = true;
            CacheMinutesToExpire = 60;
        }

        /// <summary>
        /// Builds the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>Entity.</returns>
        public static Entity Build(ITypeReader reader)
        {
            var record = new Entity
                {
                    EntityID = reader.GetInt16("EntityID"),
                    Name = reader.GetString("Name")
                };

            return record;
        }

        /// <summary>
        /// Gets all entities.
        /// </summary>
        /// <returns>List{Entity}.</returns>
        public List<Entity> GetAllEntities()
        {
            return QueryAll(SqlDatabase, Procedure.Entity_SelectAll, Build,
                            CacheMinutesToExpire, IsCached);
        }

        /// <summary>
        /// Gets the name of the entity by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>Entity.</returns>
        public Entity GetEntityByName(string name)
        {
            if (IsCached)
            {
                Predicate<Entity> h = h2 => h2.Name == name;
                return GetAllEntities().Find(h);
            }

            return Query(SqlDatabase, Procedure.Entity_SelectByName, Build, CacheMinutesToExpire,
                         IsCached, name);
        }

        /// <summary>
        /// Gets the entity by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>Entity.</returns>
        public Entity GetEntityById(Int16 id)
        {
            if (IsCached)
            {
                Predicate<Entity> h = h2 => h2.EntityID == id;
                return GetAllEntities().Find(h);
            }

            return Query(SqlDatabase, Procedure.Entity_SelectById, Build, CacheMinutesToExpire,
                         IsCached, id);
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        /// <exception cref="System.NotImplementedException">Delete is not allowed on this Table</exception>
        public void Delete()
        {
            throw new NotImplementedException("Delete is not allowed on this Table");
        }
    }
}
