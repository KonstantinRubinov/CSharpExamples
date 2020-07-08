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
	public class LectionLogic : dbAccess
	{
		public LectionLogic(string connectionString) : base(connectionString)
		{
		}

		public void InsertLection(Lection Item)
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

			cmdStr = "INSERT INTO Lection (LECTION_ID, LECTION_NUMBER, LECTION_SUBJECT) VALUES (@LECTION_ID, @LECTION_NUMBER, @LECTION_SUBJECT)";
			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@LECTION_ID", Item.MY_LECTION_ID);
				command.Parameters.AddWithValue("@LECTION_NUMBER", Item.MY_LECTION_NUMBER);
				command.Parameters.AddWithValue("@LECTION_SUBJECT", Item.MY_LECTION_SUBJECT);
				base.ExecuteSimpleQuery(command);
			}
		}

		public Lection[] GetLectionData()
		{
			DataSet ds = new DataSet();
			ArrayList lection = new ArrayList();

			string cmdStr = "SELECT * FROM [Programs], [Lection] WHERE Programs.PROGRAM_ID=Lection.LECTION_ID;";

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
				Lection le = new Lection(int.Parse(ms[0].ToString()), DateTime.Parse(ms[1].ToString()), ms[2].ToString(), ms[3].ToString(), int.Parse(ms[4].ToString()), int.Parse(ms[5].ToString()), int.Parse(ms[6].ToString()), int.Parse(ms[7].ToString()), ms[8].ToString());
				lection.Add(le);
			}
			return (Lection[])lection.ToArray(typeof(Lection));
		}
	}
}
