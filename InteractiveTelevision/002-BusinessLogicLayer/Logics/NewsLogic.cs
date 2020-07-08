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
	public class NewsLogic : dbAccess
	{
		public NewsLogic(string connectionString) : base(connectionString)
		{
		}

		public void InsertNews(News Item)
		{
			string cmdStr = "INSERT INTO News (NEWS_ID, NEWS_CONTENT) VALUES (@NEWS_ID, @NEWS_CONTENT)";
			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@NEWS_ID", Item.MY_NEWS_ID);
				command.Parameters.AddWithValue("@NEWS_CONTENT", Item.MY_NEWS_CONTENT);
				base.ExecuteSimpleQuery(command);
			}
		}

		public News[] GetNewsData()
		{
			DataSet ds = new DataSet();
			ArrayList news = new ArrayList();

			string cmdStr = "SELECT * FROM [News]";

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
				News ne = new News(int.Parse(ms[0].ToString()), ms[1].ToString());
				news.Add(ne);
			}
			return (News[])news.ToArray(typeof(News));
		}
	}
}
