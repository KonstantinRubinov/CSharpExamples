using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWebApi
{
	static public class QueryStrings
	{
		static private string connectionString = "Data Source =.; Initial Catalog = MyExample; Integrated Security = True";

		static private string queryHeroesString = "SELECT * from Heroes";
		static private string queryHeroesByIdString = "SELECT * from Heroes where id={0}";
		static private string queryHeroesPost = "INSERT INTO Heroes (name) VALUES ('{0}')";
		static private string queryHeroesUpdate = "UPDATE Heroes SET name = '{1}' WHERE id = {0}";
		static private string queryHeroesDelete = "DELETE FROM Heroes WHERE id={0}";

		static private string queryLastId = "SELECT TOP (1) * FROM Heroes ORDER BY id DESC";
		static private string queryHeroesTopFour = "SELECT TOP (4) * FROM Heroes";




		static public string GetConnection()
		{
			return connectionString;
		}

		static public string GetAllData()
		{
			return queryHeroesString;
		}

		static public string GetDataById(int heroId)
		{
			string toReturn = string.Format(queryHeroesByIdString, heroId);
			return toReturn;
		}

		static public string PostHero(Hero hero)
		{
			string toReturn = string.Format(queryHeroesPost, hero.name);
			return toReturn;
		}

		static public string UpdateHero(int id, string name)
		{
			string toReturn = string.Format(queryHeroesUpdate, id, name);
			return toReturn;
		}

		static public string DeleteHero(int id)
		{
			string toReturn = string.Format(queryHeroesDelete, id);
			return toReturn;
		}

		static public string TopFourHeroes()
		{
			return queryHeroesTopFour;
		}


		static public string GetLastId()
		{
			return queryLastId;
		}
	}
}
