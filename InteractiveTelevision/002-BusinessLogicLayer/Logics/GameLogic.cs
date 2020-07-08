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
	public class GameLogic : dbAccess
	{
		public GameLogic(string connectionString) : base(connectionString)
		{
		}

		public void InsertGame(Game Item)
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

			cmdStr = "INSERT INTO Game (GAME_ID, GAME_NUMBER, GAME_TYPE) VALUES (@GAME_ID, @GAME_NUMBER, @GAME_TYPE)";
			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@GAME_ID", Item.MY_GAME_ID);
				command.Parameters.AddWithValue("@GAME_NUMBER", Item.MY_GAME_NUMBER);
				command.Parameters.AddWithValue("@GAME_TYPE", Item.MY_GAME_TYPE);
				base.ExecuteSimpleQuery(command);
			}
		}

		public Game[] GetGameData()
		{
			DataSet ds = new DataSet();
			ArrayList game = new ArrayList();

			string cmdStr = "SELECT * FROM [Programs], [Game] WHERE Programs.PROGRAM_ID=Game.GAME_ID;";

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
				Game ga = new Game(int.Parse(ms[0].ToString()), DateTime.Parse(ms[1].ToString()), ms[2].ToString(), ms[3].ToString(), int.Parse(ms[4].ToString()), int.Parse(ms[5].ToString()), int.Parse(ms[6].ToString()), int.Parse(ms[7].ToString()), ms[8].ToString());
				game.Add(ga);
			}
			return (Game[])game.ToArray(typeof(Game));
		}
	}
}
