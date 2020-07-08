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
	public class MessageLogic : dbAccess
	{
		public MessageLogic(string connectionString) : base(connectionString)
		{
		}

		public void InsertMessage(Message Item)
		{
			string cmdStr = "INSERT INTO Message (MESSAGE_ID, FROM_ID, TO_ID, MESSAGE_CONTENT) VALUES (@MESSAGE_ID, @FROM_ID, @TO_ID, @MESSAGE_CONTENT)";
			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@MESSAGE_ID", Item.MY_MESSAGE_ID);
				command.Parameters.AddWithValue("@FROM_ID", Item.MY_FROM_ID);
				command.Parameters.AddWithValue("@TO_ID", Item.MY_TO_ID);
				command.Parameters.AddWithValue("@MESSAGE_CONTENT", Item.MY_MESSAGE_CONTENT);
				base.ExecuteSimpleQuery(command);
			}
		}

		public Message[] GetMessageMaxId()
		{
			DataSet ds = new DataSet();
			ArrayList messageID = new ArrayList();

			string cmdStr = "SELECT MAX(MESSAGE_ID) FROM [Message];";

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
				Message me = new Message(int.Parse(ms[0].ToString()));
				messageID.Add(me);
			}
			return (Message[])messageID.ToArray(typeof(Message));
		}

		public Message[] GetMessageData()
		{
			DataSet ds = new DataSet();
			ArrayList message = new ArrayList();

			string cmdStr = "SELECT * FROM [Message]";

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
				Message me = new Message(int.Parse(ms[0].ToString()), int.Parse(ms[1].ToString()), int.Parse(ms[2].ToString()), ms[3].ToString());
				message.Add(me);
			}
			return (Message[])message.ToArray(typeof(Message));
		}
	}
}
