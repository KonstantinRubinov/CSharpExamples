using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace JsonCreator
{
	[DataContract]
	public class SearchModel
	{
		private DateTime? _fromDate;
		private DateTime? _toDate;
		private string _company = "";
		private string _carType = "";
		private string _gear = "";
		private int _year = 0;
		private string _freeSearch = "";

		[DataMember]
		public DateTime? fromDate
		{
			get { return _fromDate; }
			set { _fromDate = value; }
		}

		[DataMember]
		public DateTime? toDate
		{
			get { return _toDate; }
			set { _toDate = value; }
		}

		[DataMember]
		public string company
		{
			get { return _company; }
			set { _company = value; }
		}

		[DataMember]
		public string carType
		{
			get { return _carType; }
			set { _carType = value; }
		}

		[DataMember]
		public string gear
		{
			get { return _gear; }
			set { _gear = value; }
		}

		[DataMember]
		public int year
		{
			get { return _year; }
			set { _year = value; }
		}

		[DataMember]
		public string freeSearch
		{
			get { return _freeSearch; }
			set { _freeSearch = value; }
		}

		public override string ToString()
		{
			return
				fromDate + " " +
				toDate + " " +
				company + " " +
				carType + " " +
				gear + " " +
				year + " " +
				freeSearch;
		}
	}
}
