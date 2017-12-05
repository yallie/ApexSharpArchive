namespace PrivateDemo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;

	public class UserProvisioningLog : SObject
	{
		public bool IsDeleted {set;get;}

		public string Name {set;get;}

		public DateTime CreatedDate {set;get;}

		public string CreatedById {set;get;}

		public User CreatedBy {set;get;}

		public DateTime LastModifiedDate {set;get;}

		public string LastModifiedById {set;get;}

		public User LastModifiedBy {set;get;}

		public DateTime SystemModstamp {set;get;}

		public string UserProvisioningRequestId {set;get;}

		public UserProvisioningRequest UserProvisioningRequest {set;get;}

		public string ExternalUserId {set;get;}

		public string ExternalUsername {set;get;}

		public string UserId {set;get;}

		public User User {set;get;}

		public string Status {set;get;}

		public string Details {set;get;}
	}
}