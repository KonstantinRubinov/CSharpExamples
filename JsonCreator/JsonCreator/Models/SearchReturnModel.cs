using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace JsonCreator
{
	[DataContract]
	public class SearchReturnModel
	{
		private List<FullCarDataModel> _fullCarsData;
		private int _fullCarsDataLenth;
		private int _fullCarsDataPage;

		[DataMember]
		public List<FullCarDataModel> fullCarsData
		{
			get { return _fullCarsData; }
			set { _fullCarsData = value; }
		}

		[DataMember]
		public int fullCarsDataLenth
		{
			get { return _fullCarsDataLenth; }
			set { _fullCarsDataLenth = value; }
		}

		[DataMember]
		public int fullCarsDataPage
		{
			get { return _fullCarsDataPage; }
			set { _fullCarsDataPage = value; }
		}

		public override string ToString()
		{
			return
				fullCarsDataLenth + " " +
				fullCarsDataPage;
		}
	}
}
