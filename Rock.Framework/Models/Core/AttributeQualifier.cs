//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the T4\Model.tt template.
//
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

using Rock.Models;

namespace Rock.Models.Core
{
    /// <summary>
    /// Attribute Qualifier POCO Entity.
    /// </summary>
    [Table( "coreAttributeQualifier" )]
    public partial class AttributeQualifier : Model<AttributeQualifier>, IAuditable
    {
		/// <summary>
		/// Gets or sets the System.
		/// </summary>
		/// <value>
		/// System.
		/// </value>
		[DataMember]
		public bool System { get; set; }
		
		/// <summary>
		/// Gets or sets the Attribute Id.
		/// </summary>
		/// <value>
		/// Attribute Id.
		/// </value>
		[DataMember]
		public int AttributeId { get; set; }
		
		/// <summary>
		/// Gets or sets the Key.
		/// </summary>
		/// <value>
		/// Key.
		/// </value>
		[MaxLength( 50 )]
		[DataMember]
		public string Key { get; set; }
		
		/// <summary>
		/// Gets or sets the Name.
		/// </summary>
		/// <value>
		/// Name.
		/// </value>
		[MaxLength( 100 )]
		[DataMember]
		public string Name { get; set; }
		
		/// <summary>
		/// Gets or sets the Value.
		/// </summary>
		/// <value>
		/// Value.
		/// </value>
		[DataMember]
		public string Value { get; set; }
		
		/// <summary>
		/// Gets or sets the Created Date Time.
		/// </summary>
		/// <value>
		/// Created Date Time.
		/// </value>
		[DataMember]
		public DateTime? CreatedDateTime { get; set; }
		
		/// <summary>
		/// Gets or sets the Modified Date Time.
		/// </summary>
		/// <value>
		/// Modified Date Time.
		/// </value>
		[DataMember]
		public DateTime? ModifiedDateTime { get; set; }
		
		/// <summary>
		/// Gets or sets the Created By Person Id.
		/// </summary>
		/// <value>
		/// Created By Person Id.
		/// </value>
		[DataMember]
		public int? CreatedByPersonId { get; set; }
		
		/// <summary>
		/// Gets or sets the Modified By Person Id.
		/// </summary>
		/// <value>
		/// Modified By Person Id.
		/// </value>
		[DataMember]
		public int? ModifiedByPersonId { get; set; }
		
		/// <summary>
        /// Gets a Data Transfer Object (lightweight) version of this object.
        /// </summary>
        /// <value>
        /// A <see cref="AttributeQualifierDTO"/> object.
        /// </value>
		public Rock.DataTransferObjects.Core.AttributeQualifier DataTransferObject
		{
			get 
			{ 
				Rock.DataTransferObjects.Core.AttributeQualifier dto = new Rock.DataTransferObjects.Core.AttributeQualifier();
				dto.Id = this.Id;
				dto.Guid = this.Guid;
				dto.System = this.System;
				dto.AttributeId = this.AttributeId;
				dto.Key = this.Key;
				dto.Name = this.Name;
				dto.Value = this.Value;
				dto.CreatedDateTime = this.CreatedDateTime;
				dto.ModifiedDateTime = this.ModifiedDateTime;
				dto.CreatedByPersonId = this.CreatedByPersonId;
				dto.ModifiedByPersonId = this.ModifiedByPersonId;
				return dto; 
			}
		}

        /// <summary>
        /// Gets the auth entity.
        /// </summary>
		[NotMapped]
		public override string AuthEntity { get { return "Core.AttributeQualifier"; } }
        
		/// <summary>
        /// Gets or sets the Attribute.
        /// </summary>
        /// <value>
        /// A <see cref="Attribute"/> object.
        /// </value>
		public virtual Attribute Attribute { get; set; }
        
		/// <summary>
        /// Gets or sets the Created By Person.
        /// </summary>
        /// <value>
        /// A <see cref="Crm.Person"/> object.
        /// </value>
		public virtual Crm.Person CreatedByPerson { get; set; }
        
		/// <summary>
        /// Gets or sets the Modified By Person.
        /// </summary>
        /// <value>
        /// A <see cref="Crm.Person"/> object.
        /// </value>
		public virtual Crm.Person ModifiedByPerson { get; set; }

    }
    /// <summary>
    /// Attribute Qualifier Configuration class.
    /// </summary>
    public partial class AttributeQualifierConfiguration : EntityTypeConfiguration<AttributeQualifier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeQualifierConfiguration"/> class.
        /// </summary>
        public AttributeQualifierConfiguration()
        {
			this.HasRequired( p => p.Attribute ).WithMany( p => p.AttributeQualifiers ).HasForeignKey( p => p.AttributeId );
			this.HasOptional( p => p.CreatedByPerson ).WithMany().HasForeignKey( p => p.CreatedByPersonId );
			this.HasOptional( p => p.ModifiedByPerson ).WithMany().HasForeignKey( p => p.ModifiedByPersonId );
		}
    }
}
