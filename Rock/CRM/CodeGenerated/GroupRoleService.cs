//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//

using System;
using System.Linq;

using Rock.Data;

namespace Rock.Crm
{
    /// <summary>
    /// GroupRole Service class
    /// </summary>
    public partial class GroupRoleService : Service<GroupRole, GroupRoleDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupRoleService"/> class
        /// </summary>
        public GroupRoleService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupRoleService"/> class
        /// </summary>
        public GroupRoleService(IRepository<GroupRole> repository) : base(repository)
        {
        }

        /// <summary>
        /// Creates a new model
        /// </summary>
        public override GroupRole CreateNew()
        {
            return new GroupRole();
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public override IQueryable<GroupRoleDto> QueryableDto( )
        {
            return QueryableDto( this.Queryable() );
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public IQueryable<GroupRoleDto> QueryableDto( IQueryable<GroupRole> items )
        {
            return items.Select( m => new GroupRoleDto()
                {
                    IsSystem = m.IsSystem,
                    GroupTypeId = m.GroupTypeId,
                    Name = m.Name,
                    Description = m.Description,
                    Order = m.Order,
                    MaxCount = m.MaxCount,
                    MinCount = m.MinCount,
                    Id = m.Id,
                    Guid = m.Guid,
                });
        }
    }
}
