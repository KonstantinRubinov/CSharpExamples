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
	public class SportLogic : dbAccess
	{
		public SportLogic(string connectionString) : base(connectionString)
		{
		}

		public void InsertSport(Sport Item)
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

			cmdStr = "INSERT INTO Sport (SPORT_ID, SPORT_NUMBER, SPORT_TYPE) VALUES (@SPORT_ID, @SPORT_NUMBER, @SPORT_TYPE)";
			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@SPORT_ID", Item.MY_SPORT_ID);
				command.Parameters.AddWithValue("@SPORT_NUMBER", Item.MY_SPORT_NUMBER);
				command.Parameters.AddWithValue("@SPORT_TYPE", Item.MY_SPORT_TYPE);
				base.ExecuteSimpleQuery(command);
			}
		}

		public Sport[] GetSportData()
		{
			DataSet ds = new DataSet();
			ArrayList sport = new ArrayList();

			string cmdStr = "SELECT * FROM [Programs], [Sport] WHERE Programs.PROGRAM_ID=Sport.SPORT_ID;";

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
				Sport sp = new Sport(int.Parse(ms[0].ToString()), DateTime.Parse(ms[1].ToString()), ms[2].ToString(), ms[3].ToString(), int.Parse(ms[4].ToString()), int.Parse(ms[5].ToString()), int.Parse(ms[6].ToString()), int.Parse(ms[7].ToString()), ms[8].ToString());
				sport.Add(sp);
			}
			return (Sport[])sport.ToArray(typeof(Sport));
		}
	}
}
