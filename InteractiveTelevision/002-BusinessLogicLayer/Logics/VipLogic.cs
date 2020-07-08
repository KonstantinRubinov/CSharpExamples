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
	public class VipLogic : dbAccess
	{
		public VipLogic(string connectionString) : base(connectionString)
		{
		}

		public void InsertVip(Vip Item)
		{
			string cmdStr = "INSERT INTO Vip (VIP_ID, VIP_VALIDITY) VALUES (@VIP_ID, @VIP_VALIDITY)";
			using (OleDbCommand command = new OleDbCommand(cmdStr))
			{
				command.Parameters.AddWithValue("@VIP_ID", Item.MY_VIP_ID);
				command.Parameters.AddWithValue("@VIP_VALIDITY", Item.MY_VIP_VALIDITY);

				base.ExecuteSimpleQuery(command);
			}
		}

		public Vip[] GetVipData(int myID)
		{
			DataSet ds = new DataSet();
			ArrayList vip = new ArrayList();

			string cmdStr = "SELECT * FROM [Signedin], [Vip] WHERE " + myID + "=Vip.VIP_ID;";

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
				Vip vp = new Vip(int.Parse(ms[0].ToString()), int.Parse(ms[1].ToString()), ms[2].ToString(), ms[3].ToString(), ms[4].ToString(), ms[5].ToString(), ms[6].ToString(), DateTime.Parse(ms[7].ToString()), ms[8].ToString(), int.Parse(ms[9].ToString()), DateTime.Parse(ms[10].ToString()));
				vip.Add(vp);
			}
			return (Vip[])vip.ToArray(typeof(Vip));
		}
	}
}
