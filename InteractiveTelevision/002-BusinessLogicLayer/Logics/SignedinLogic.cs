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
	public class SignedinLogic : dbAccess
	{
		public SignedinLogic(string connectionString) : base(connectionString)
		{
		}

		public void InsertSignedin(Signedin Item)
		{
			string cmdStr;
			cmdStr = "INSERT INTO Signedin (SIGNEDIN_ID, SIGNEDIN_PERMISSION, NAME, PASSWORD, FIRST_NAME, LAST_NAME, COUNTRY, BIRTHDATE, EMAIL) VALUES (@SIGNEDIN_ID, @SIGNEDIN_PERMISSION, @NAME, @PASSWORD, @FIRST_NAME, @LAST_NAME, @COUNTRY, @BIRTHDATE, @EMAIL)";
			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@SIGNEDIN_ID", Item.MY_SIGNEDIN_ID);
				command.Parameters.AddWithValue("@SIGNEDIN_PERMISSION", Item.MY_SIGNEDIN_PERMISSION);
				command.Parameters.AddWithValue("@NAME", Item.MY_NAME);
				command.Parameters.AddWithValue("@PASSWORD", Item.MY_PASSWORD);
				command.Parameters.AddWithValue("@FIRST_NAME", Item.MY_FIRST_NAME);
				command.Parameters.AddWithValue("@LAST_NAME", Item.MY_LAST_NAME);
				command.Parameters.AddWithValue("@COUNTRY", Item.MY_COUNTRY);
				command.Parameters.AddWithValue("@BIRTHDATE", Item.MY_BIRTHDATE);
				command.Parameters.AddWithValue("@EMAIL", Item.MY_EMAIL);

				base.ExecuteSimpleQuery(command);
			}
		}

		public Signedin[] GetSignedinMaxId()
		{
			DataSet ds = new DataSet();
			ArrayList personId = new ArrayList();

			string cmdStr = "SELECT MAX(SIGNEDIN_ID) FROM [Signedin];";

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
				Signedin prsId = new Signedin(int.Parse(ms[0].ToString()));
				personId.Add(prsId);
			}
			return (Signedin[])personId.ToArray(typeof(Signedin));
		}

		public Signedin[] GetSignedinData()
		{
			DataSet ds = new DataSet();
			ArrayList person = new ArrayList();

			string cmdStr = "SELECT * FROM [Signedin];";

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
				Signedin prs = new Signedin(int.Parse(ms[0].ToString()), int.Parse(ms[1].ToString()), ms[2].ToString(), ms[3].ToString(), ms[4].ToString(), ms[5].ToString(), ms[6].ToString(), DateTime.Parse(ms[7].ToString()), ms[8].ToString());
				person.Add(prs);
			}
			return (Signedin[])person.ToArray(typeof(Signedin));
		}

		public Signedin[] GetIdNameData()
		{
			DataSet ds = new DataSet();
			ArrayList personIdName = new ArrayList();

			string cmdStr = "SELECT [SIGNEDIN_ID], [NAME] FROM [Signedin];";

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
				Signedin prs = new Signedin(int.Parse(ms[0].ToString()), ms[1].ToString());
				personIdName.Add(prs);
			}
			return (Signedin[])personIdName.ToArray(typeof(Signedin));
		}

		public Signedin[] GetNamePassData(string na, string pa)
		{
			DataSet ds = new DataSet();
			ArrayList personNamePass = new ArrayList();

			string cmdStr = "Select * FROM [Signedin] where [NAME]=" + na + " and [PASSWORD]=" + pa + "";

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
				Signedin prs = new Signedin(int.Parse(ms[0].ToString()), ms[1].ToString(), ms[2].ToString());
				personNamePass.Add(prs);
			}
			return (Signedin[])personNamePass.ToArray(typeof(Signedin));
		}
	}
}