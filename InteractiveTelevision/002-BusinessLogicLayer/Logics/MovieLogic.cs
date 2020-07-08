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
	public class MovieLogic : dbAccess
	{
		public MovieLogic(string connectionString) : base(connectionString)
		{
		}

		public void InsertMovie(Movie Item)
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

			cmdStr = "INSERT INTO Movie (MOVIE_ID, MOVIE_GENRE) VALUES (@MOVIE_ID, @MOVIE_GENRE)";
			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@MOVIE_ID", Item.MY_MOVIE_ID);
				command.Parameters.AddWithValue("@MOVIE_GENRE", Item.MY_MOVIE_GENRE);
				base.ExecuteSimpleQuery(command);
			}
		}

		public Movie[] GetMovieData()
		{
			DataSet ds = new DataSet();
			ArrayList movie = new ArrayList();

			string cmdStr = "SELECT * FROM [Programs], [Movie] WHERE Programs.PROGRAM_ID=Movie.MOVIE_ID;";

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
				Movie mo = new Movie(int.Parse(ms[0].ToString()), DateTime.Parse(ms[1].ToString()), ms[2].ToString(), ms[3].ToString(), int.Parse(ms[4].ToString()), int.Parse(ms[5].ToString()), int.Parse(ms[7].ToString()), ms[7].ToString());
				movie.Add(mo);
			}
			return (Movie[])movie.ToArray(typeof(Movie));
		}
	}
}
