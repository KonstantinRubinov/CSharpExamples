using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
	public class AdvertisementLogic : dbAccess
	{
		public AdvertisementLogic(string connectionString) : base(connectionString)
		{
		}

		public void InsertAdvertisement(Advertisement Item)
		{
			string cmdStr = "INSERT INTO Programs (PROGRAM_ID, PROGRAM_DATE, PROGRAM_NAME, LINK, PART_NUMBER, VIEWERS) VALUES (@PROGRAM_ID, @PROGRAM_DATE, @PROGRAM_NAME, @LINK, @PART_NUMBER, @VIEWERS)";
			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@PROGRAM_ID", Item.MY_PROGRAM_ID);
				command.Parameters.AddWithValue("@PROGRAM_DATE", Item.MY_PROGRAM_DATE);
				command.Parameters.AddWithValue("@PROGRAM_NAME", Item.MY_PROGRAM_NAME);
				command.Parameters.AddWithValue("@LINK", Item.MY_LINK);
				command.Parameters.AddWithValue("@PART_NUMBER", Item.MY_PART_NUMBER);
				command.Parameters.AddWithValue("@PART_NUMBER", Item.MY_PART_NUMBER);
				command.Parameters.AddWithValue("@VIEWERS", Item.MY_VIEWERS);

				base.ExecuteSimpleQuery(command);
			}

			cmdStr = "INSERT INTO Advertisement (ADVERTISEMENT_ID, COMPANY_NAME, PRODUCT_NAME) VALUES (@ADVERTISEMENT_ID, @COMPANY_NAME, @PRODUCT_NAME)";
			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@ADVERTISEMENT_ID", Item.MY_ADVERTISEMENT_ID);
				command.Parameters.AddWithValue("@COMPANY_NAME", Item.MY_COMPANY_NAME);
				command.Parameters.AddWithValue("@PRODUCT_NAME", Item.MY_PRODUCT_NAME);
				base.ExecuteSimpleQuery(command);
			}
		}

		public Advertisement[] GetAdvertisementData()
		{
			DataSet ds = new DataSet();
			ArrayList advert = new ArrayList();

			string cmdStr = "SELECT * FROM [Programs], [Advertisement] WHERE Programs.PROGRAM_ID=Advertisement.ADVERTISEMENT_ID;";

			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				ds = GetMultipleQuery(command);
			}
			DataTable dt = new DataTable();
			try
			{
				dt = ds.Tables[0];
			}
			catch
			{
			}
			foreach (DataRow ms in dt.Rows)
			{
				Advertisement ad = new Advertisement(int.Parse(ms[0].ToString()), DateTime.Parse(ms[1].ToString()), ms[2].ToString(), ms[3].ToString(), int.Parse(ms[4].ToString()), int.Parse(ms[5].ToString()), int.Parse(ms[6].ToString()), ms[7].ToString(), ms[8].ToString());
				advert.Add(ad);
			}
			return (Advertisement[])advert.ToArray(typeof(Advertisement));
		}
	}
}
