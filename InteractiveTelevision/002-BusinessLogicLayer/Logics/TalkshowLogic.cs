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
	public class TalkshowLogic : dbAccess
	{
		public TalkshowLogic(string connectionString) : base(connectionString)
		{
		}

		public void InsertTalkshow(Talkshow Item)
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

			cmdStr = "INSERT INTO Talkshow (TALKSHOW_ID, TALKSHOW_SUBJECT) VALUES (@TALKSHOW_ID, @TALKSHOW_SUBJECT)";
			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@TALKSHOW_ID", Item.MY_TALKSHOW_ID);
				command.Parameters.AddWithValue("@TALKSHOW_SUBJECT", Item.MY_TALKSHOW_SUBJECT);
				base.ExecuteSimpleQuery(command);
			}
		}

		public Talkshow[] GetTalkshowData()
		{
			DataSet ds = new DataSet();
			ArrayList Talk = new ArrayList();

			string cmdStr = "SELECT * FROM [Programs], [Talkshow] WHERE Programs.PROGRAM_ID=Talkshow.TALKSHOW_ID;";

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
				Talkshow ta = new Talkshow(int.Parse(ms[0].ToString()), DateTime.Parse(ms[1].ToString()), ms[2].ToString(), ms[3].ToString(), int.Parse(ms[4].ToString()), int.Parse(ms[5].ToString()), int.Parse(ms[6].ToString()), ms[7].ToString());
				Talk.Add(ta);
			}
			return (Talkshow[])Talk.ToArray(typeof(Talkshow));
		}
	}
}
