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

namespace Rock.Api.Cms
{
	/// <summary>
	/// Represents a REST WCF service for BlogPostComments
	/// </summary>
	[ServiceContract]
    public partial interface IBlogPostCommentService
    {
		/// <summary>
		/// Gets a BlogPostComment object
		/// </summary>
		[OperationContract]
        Rock.DataTransferObjects.Cms.BlogPostComment Get( string id );

		/// <summary>
		/// Updates a BlogPostComment object
		/// </summary>
        [OperationContract]
        void UpdateBlogPostComment( string id, Rock.DataTransferObjects.Cms.BlogPostComment BlogPostComment );

		/// <summary>
		/// Creates a new BlogPostComment object
		/// </summary>
        [OperationContract]
        void CreateBlogPostComment( Rock.DataTransferObjects.Cms.BlogPostComment BlogPostComment );

		/// <summary>
		/// Deletes a BlogPostComment object
		/// </summary>
        [OperationContract]
        void DeleteBlogPostComment( string id );
    }
}
