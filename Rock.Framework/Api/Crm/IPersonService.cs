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
	/// Represents a REST WCF service for People
	/// </summary>
	[ServiceContract]
    public partial interface IPersonService
    {
		/// <summary>
		/// Gets a Person object
		/// </summary>
		[OperationContract]
        Rock.DataTransferObjects.Crm.Person Get( string id );

		/// <summary>
		/// Updates a Person object
		/// </summary>
        [OperationContract]
        void UpdatePerson( string id, Rock.DataTransferObjects.Crm.Person Person );

		/// <summary>
		/// Creates a new Person object
		/// </summary>
        [OperationContract]
        void CreatePerson( Rock.DataTransferObjects.Crm.Person Person );

		/// <summary>
		/// Deletes a Person object
		/// </summary>
        [OperationContract]
        void DeletePerson( string id );
    }
}
