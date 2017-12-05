namespace PrivateDemo.SObjects
{
	using Apex.System;
	using ApexSharpApi.ApexApi;

	public class SearchActivity : SObject
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

		public string SearchTerm {set;get;}

		public DateTime QueryDate {set;get;}

		public int CountQueries {set;get;}

		public int CountUsers {set;get;}

		public double AvgNumResults {set;get;}

		public string KbChannel {set;get;}

		public string Period {set;get;}

		public double ClickRank {set;get;}

		public string QueryLanguage {set;get;}

		public string ClickedRecordName {set;get;}
	}
}