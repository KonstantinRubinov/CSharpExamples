using System.Collections.Generic;

namespace RestWebApi
{
	public interface IHeroesRepository
	{
		List<Hero> GetAllHeroes();
		Hero GetHeroById(int id);
		List<Hero> GetFourHeroes();
		Hero PostHero(Hero value);
		Hero UpdateHero(Hero value);
		int DeleteHero(int id);
	}
}
