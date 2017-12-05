namespace PrivateDemo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;

	public class Jay__c : SObject
	{
		public bool IsDeleted {set;get;}

		public string Name {set;get;}

		public string SetupOwnerId {set;get;}

		public Organization SetupOwner {set;get;}

		public DateTime CreatedDate {set;get;}

		public string CreatedById {set;get;}

		public User CreatedBy {set;get;}

		public DateTime LastModifiedDate {set;get;}

		public string LastModifiedById {set;get;}

		public User LastModifiedBy {set;get;}

		public DateTime SystemModstamp {set;get;}

		public string Name__c {set;get;}

		public double Cost__c {set;get;}
	}
}