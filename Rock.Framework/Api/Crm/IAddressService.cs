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
using System.ServiceModel;

namespace Rock.Api.Crm
{
	/// <summary>
	/// Represents a REST WCF service for Addresses
	/// </summary>
	[ServiceContract]
    public partial interface IAddressService
    {
		/// <summary>
		/// Gets a Address object
		/// </summary>
		[OperationContract]
        Rock.DataTransferObjects.Crm.Address Get( string id );

		/// <summary>
		/// Updates a Address object
		/// </summary>
        [OperationContract]
        void UpdateAddress( string id, Rock.DataTransferObjects.Crm.Address Address );

		/// <summary>
		/// Creates a new Address object
		/// </summary>
        [OperationContract]
        void CreateAddress( Rock.DataTransferObjects.Crm.Address Address );

		/// <summary>
		/// Deletes a Address object
		/// </summary>
        [OperationContract]
        void DeleteAddress( string id );
    }
}
