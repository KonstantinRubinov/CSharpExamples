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
	public class VideoclipLogic : dbAccess
	{
		public VideoclipLogic(string connectionString) : base(connectionString)
		{
		}

		public void InsertVideoclip(Videoclip Item)
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

			cmdStr = "INSERT INTO Videoclip (VIDEOCLIP_ID, PERFORMER, MUSIC_TYPE) VALUES (@VIDEOCLIP_ID, @PERFORMER, @MUSIC_TYPE)";
			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@VIDEOCLIP_ID", Item.MY_VIDEOCLIP_ID);
				command.Parameters.AddWithValue("@PERFORMER", Item.MY_PERFORMER);
				command.Parameters.AddWithValue("@MUSIC_TYPE", Item.MY_MUSIC_TYPE);
				base.ExecuteSimpleQuery(command);
			}
		}

		public Videoclip[] GetVideoclipData()
		{
			DataSet ds = new DataSet();
			ArrayList videoclip = new ArrayList();

			string cmdStr = "SELECT * FROM [Programs], [Videoclip] WHERE Programs.PROGRAM_ID=Videoclip.VIDEOCLIP_ID;";

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
				Videoclip vi = new Videoclip(int.Parse(ms[0].ToString()), DateTime.Parse(ms[1].ToString()), ms[2].ToString(), ms[3].ToString(), int.Parse(ms[4].ToString()), int.Parse(ms[4].ToString()), int.Parse(ms[5].ToString()), ms[6].ToString(), ms[7].ToString());
				videoclip.Add(vi);
			}
			return (Videoclip[])videoclip.ToArray(typeof(Videoclip));
		}
	}
}
