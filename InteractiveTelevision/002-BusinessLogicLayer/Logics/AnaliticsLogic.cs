﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveTelevision
{
	public class AnaliticsLogic : dbAccess
	{
		public AnaliticsLogic(string connectionString) : base(connectionString)
		{
		}
		public void InsertAnalitics(Analitics Item)
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

			cmdStr = "INSERT INTO Analitics (ANALITICS_ID, ANALITICS_NAME, ANALITICS_SUBJECT) VALUES (@ANALITICS_ID, @ANALITICS_NAME, @ANALITICS_SUBJECT)";
			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@ANALITICS_ID", Item.MY_ANALITICS_ID);
				command.Parameters.AddWithValue("@ANALITICS_NAME", Item.MY_ANALITICS_NAME);
				command.Parameters.AddWithValue("@ANALITICS_SUBJECT", Item.MY_ANALITICS_SUBJECT);
				base.ExecuteSimpleQuery(command);
			}
		}
		public Analitics[] GetAnaliticsData()
		{
			DataSet ds = new DataSet();
			ArrayList analitics = new ArrayList();

			string cmdStr = "SELECT * FROM [Programs], [Analitics] WHERE Programs.PROGRAM_ID=Analitics.ANALITICS_ID;";

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
				Analitics an = new Analitics(int.Parse(ms[0].ToString()), DateTime.Parse(ms[1].ToString()), ms[2].ToString(), ms[3].ToString(), int.Parse(ms[4].ToString()), int.Parse(ms[5].ToString()), int.Parse(ms[6].ToString()), ms[7].ToString(), ms[8].ToString());
				analitics.Add(an);
			}
			return (Analitics[])analitics.ToArray(typeof(Analitics));
		}
	}
}
