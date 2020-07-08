using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersRest
{
	public class DataBase
	{
		static private SqlConnection connection = null;
		static private SqlCommand command = null;
		static private SqlDataReader reader = null;





		static public SqlConnection getConnection()
		{
			if (connection == null)
			{
				connection = new SqlConnection(ConnectionStrings.getConnection());
			}

			return connection;
		}


		static public SqlDataReader getReader(string sqlQuery)
		{
			command = new SqlCommand(sqlQuery, connection);
			try
			{
				reader = command.ExecuteReader();
			}
			catch (Exception ex)
			{
				if (reader != null)
					reader.Close();
				connection.Close();
				//Console.WriteLine(ex.Message);
			}
			return reader;
		}

		static public int ExecutePost(string sqlQuery)
		{
			int i = 0;
			command = new SqlCommand(sqlQuery, connection);
			try
			{
				i = command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				if (reader != null)
					reader.Close();
				connection.Close();
			}
			return i;
		}

		static public int ExecuteUpdate(string sqlQuery)
		{
			int i = 0;
			command = new SqlCommand(sqlQuery, connection);
			try
			{
				i = command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				if (reader != null)
					reader.Close();
				connection.Close();
			}
			return i;
		}
	}
}
