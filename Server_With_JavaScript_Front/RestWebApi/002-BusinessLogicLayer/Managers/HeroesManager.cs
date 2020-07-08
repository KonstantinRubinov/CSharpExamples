using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RestWebApi
{
	public class HeroesManager: IHeroesRepository
	{
		static private SqlDataReader reader = null;

		public List<Hero> GetAllHeroes()
		{
			List<Hero> arrHero = new List<Hero>();
			DataBase.getConnection().Open();
			reader = DataBase.getReader(QueryStrings.GetAllData());

			try
			{
				while (reader.Read())
				{
					arrHero.Add(Hero.ToObject(reader));
				}
			}
			finally
			{
				reader.Close();
				DataBase.getConnection().Close();
			}
			return arrHero;
		}

		public Hero GetHeroById(int id)
		{
			if (id<0)
				throw new ArgumentOutOfRangeException();
			Hero hero = new Hero();
			DataBase.getConnection().Open();
			reader = DataBase.getReader(QueryStrings.GetDataById(id));
			try
			{
				while (reader.Read())
				{
					hero = Hero.ToObject(reader);
				}
			}
			finally
			{
				reader.Close();
				DataBase.getConnection().Close();
			}
			return hero;
		}

		public List<Hero> GetFourHeroes()
		{
			List<Hero> arrHero = new List<Hero>();
			DataBase.getConnection().Open();
			reader = DataBase.getReader(QueryStrings.TopFourHeroes());

			try
			{
				while (reader.Read())
				{
					arrHero.Add(Hero.ToObject(reader));
				}
			}
			finally
			{
				reader.Close();
				DataBase.getConnection().Close();
			}
			return arrHero;
		}


		public Hero PostHero(Hero value)
		{
			int i = -1;
			DataBase.getConnection().Open();
			i = DataBase.ExecutePost(QueryStrings.PostHero(value));
			DataBase.getConnection().Close();
			return GetHeroById(value.id);
		}

		public Hero UpdateHero(Hero value)
		{
			int i = -1;
			DataBase.getConnection().Open();
			i = DataBase.ExecutePost(QueryStrings.UpdateHero(value.id, value.name));
			DataBase.getConnection().Close();
			return GetHeroById(value.id);
		}

		public int DeleteHero(int id)
		{
			int i = 0;
			DataBase.getConnection().Open();
			i = DataBase.ExecuteUpdate(QueryStrings.DeleteHero(id));
			DataBase.getConnection().Close();
			return i;
		}
	}
}
