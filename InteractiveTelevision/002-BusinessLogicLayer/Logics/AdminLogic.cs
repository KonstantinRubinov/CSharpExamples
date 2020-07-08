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
	public class AdminLogic : dbAccess
	{
		public AdminLogic(string connectionString) : base(connectionString)
		{
		}

		public void InsertAdmin(Admin Item)
		{
			string cmdStr = "INSERT INTO Admin (ADMIN_ID) VALUES (@ADMIN_ID)";
			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@ADMIN_ID", Item.MY_ADMIN_ID);

				base.ExecuteSimpleQuery(command);
			}
		}

		public Admin[] GetAdminData(int myID)
		{
			DataSet ds = new DataSet();
			ArrayList admin = new ArrayList();

			string cmdStr = "SELECT * FROM [Signedin], [Admin] WHERE " + myID + "=Admin.ADMIN_ID;";

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
				Admin adm = new Admin(int.Parse(ms[0].ToString()), int.Parse(ms[1].ToString()), ms[2].ToString(), ms[3].ToString(), ms[4].ToString(), ms[5].ToString(), ms[6].ToString(), DateTime.Parse(ms[7].ToString()), ms[8].ToString(), int.Parse(ms[9].ToString()));
				admin.Add(adm);
			}
			return (Admin[])admin.ToArray(typeof(Admin));
		}
	}
}
