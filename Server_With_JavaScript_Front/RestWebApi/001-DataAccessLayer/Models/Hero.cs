using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace RestWebApi
{
	public class Hero
	{
		public int id { get; set; }
		[Required]
		public string name { get; set; }

		public static Hero ToObject(SqlDataReader reader)
		{
			Hero hero = new Hero();
			hero.id = int.Parse(reader[0].ToString());
			hero.name = reader[1].ToString();
			return hero;
		}

	}
}
